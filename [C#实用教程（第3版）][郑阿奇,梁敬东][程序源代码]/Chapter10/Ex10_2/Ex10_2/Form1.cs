using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLoad;
using Student;
using MySql.Data.MySqlClient;

namespace Ex10_2
{
    public partial class Form1 : Form
    {
        Student.Student student;
        MySqlConnection con;
        List<string> cbx_xh;
        List<string> cbx_kcm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoad.DataLoad dl = new DataLoad.DataLoad();
            con = dl.initializeData();
            cbx_xh = dl.getCbx_xh();
            foreach(string xh in cbx_xh) { comboBox_xh.Items.Add(xh); }
            cbx_kcm = dl.getCbx_kcm();
            for(int i = 0; i < cbx_kcm.Count; i++) { comboBox_kcm.Items.Add(cbx_kcm[i]); }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                student =new Student.Student(con);
                if (comboBox_xh.Text == "") return;
                student.getStubyXh(comboBox_xh.Text);
                textBox_xm.Text = student.getXm();
                radioButton_male.Checked = student.getXb() ? true : false;
                radioButton_female.Checked = student.getXb() ? false : true;
                textBox_csrq.Text = student.getCsrq().ToString("yyyy-MM-dd");
                textBox_zy.Text = student.getZy();
                textBox_xf.Text = student.getXf().ToString();
                richTextBox_bz.Text = student.getBz();
                dataGridView_kccj.DataSource = student.getKccj().Tables["KCJ"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("检索失败！错误信息为：\r\n" + ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (student == null) student = new Student.Student(con);
                if (comboBox_xh.Text == "" || comboBox_kcm.Text == "" || textBox_cj.Text == "") return;
                student.insertStuCj(comboBox_xh.Text, comboBox_kcm.Text, int.Parse(textBox_cj.Text));
                dataGridView_kccj.DataSource = student.getKccj().Tables["KCJ"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("录入失败！错误信息为：\r\n" + ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
