using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ScoreManagement
{
    public partial class SearchForm : Form
    {
        //保存查询字符串
        private string sql = "";
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            string _sql = "select XH as '学号',XM as '姓名',ZY as '专业',XB as '性别',"+"CSRQ as '出生日期',ZXF as '总学分',BZ as '备注' from XSB";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            StuDGV.DataSource = ds.Tables[0].DefaultView;
            stuZY.SelectedIndex = 0;

        }

        private void MakeSqlStr()
        {
            //清空上次的查询字符串
            sql = "";
            if (stuXH.Text.Trim() != string.Empty)
            {
                sql = " and XH like '%" + stuXH.Text.Trim() + "%'";
            }
            if (stuXM.Text.Trim() != string.Empty)
            {
                sql += " and XM like '%" + stuXM.Text.Trim() + "%'";
            }
            if (stuZY.Text != "所有专业")
            {
                sql += " and ZY='" + stuZY.Text + "'";
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            //获取查询字符串
            MakeSqlStr();
            string _sql = "select XH as '学号',XM as '姓名',ZY as '专业',XB as '性别',"+ "CSRQ as '出生日期',ZXF as '总学分',BZ as '备注' from XSB where 1=1"+ sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            StuDGV.DataSource = ds.Tables[0].DefaultView;
        }

        private void StuDGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string _sql = "select XSB.XM as '姓名',KCB.KCM as '课程',CJB.CJ as '成绩', KCB.XF as '学分' from XSB,KCB,CJB" + " where XSB.XH=CJB.XH and KCB.KCH=CJB.KCH" + " and XSB.XH ='"+ StuDGV.Rows[e.RowIndex].Cells[0].Value + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            CourseForm courseFrm = new CourseForm();
            courseFrm.stuKCDGV.DataSource = ds.Tables[0].DefaultView;
            courseFrm.ShowDialog();
        }

    }
}
