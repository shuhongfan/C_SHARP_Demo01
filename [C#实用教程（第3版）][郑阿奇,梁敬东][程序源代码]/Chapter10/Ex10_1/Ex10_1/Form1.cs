using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//

namespace Ex10_1
{
    public partial class Form1 : Form
    {
        Student student;
        MySqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoad dl = new DataLoad();
            con = dl.initializeData(comboBox_xh, comboBox_kcm);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                student = new Student(con);
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
                if (student == null) student = new Student(con);
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
