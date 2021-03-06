using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ex9_2
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtAllStu.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql = "SELECT * FROM XSB";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAllStu.Text += reader[0].ToString() + reader[1].ToString()
    + reader[2].ToString() + reader[3].ToString() + reader[4].ToString() + reader[5].ToString() + "\r\n";
                    }
                }
                reader.Close();
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                string stuID = txtStuID.Text.Trim();
                string stuName = txtName.Text.Trim();
                string stuXB;
                if (RbtnMale.Checked)
                {
                    stuXB = "男";
                }
                else
                {
                    stuXB = "女";
                }
                string stuBirthday = dateTimePicker1.Value.ToShortDateString().Split(' ')[0];
                string stuMajor = txtMajor.Text.Trim();
                string stuCredit = txtCredit.Text.Trim();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO XSB(XH,XM,XB,CSRQ,ZY,ZXF) VALUES('" + stuID + "','" + stuName + "','" + stuXB + "','" + stuBirthday + "','" + stuMajor + "','" + stuCredit + "')";
                command.CommandType = CommandType.Text;
                command.Connection = sqlcon;
                sqlcon.Open();
                if (command.ExecuteNonQuery() == 1)

                {
                    MessageBox.Show("插入成功！", "消息", MessageBoxButtons.OK);
                    btnSearch_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }

        }
    }
}
