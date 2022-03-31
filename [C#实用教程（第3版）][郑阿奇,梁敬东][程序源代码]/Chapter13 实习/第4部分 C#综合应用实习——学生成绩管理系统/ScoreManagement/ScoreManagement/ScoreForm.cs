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
    public partial class ScoreForm : Form
    {
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            string _sql = "select distinct ZY from XSB";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //读取专业名
                while (dr.Read())
                {
                    stuZY.Items.Add(dr[0]);
                }
                stuZY.SelectedIndex = 0;
                dr.Close();
                _sql = "select KCM from KCB";
                cmd = new SqlCommand(_sql, conn);
                dr = cmd.ExecuteReader();
                //读取课程名
                while (dr.Read())
                {
                    stuKCM.Items.Add(dr[0]);
                }
                dr.Close();
            }
            finally
            {
                conn.Close();
            }

        }

        private void stuZY_SelectedIndexChanged(object sender, EventArgs e)
        {
                string _sql = "select XH from XSB where ZY='" + stuZY.Text + "'";
    //清空现有的学号
    stuXH.Items.Clear();
    SqlConnection conn = new SqlConnection(connStr);
    SqlCommand cmd = new SqlCommand(_sql, conn);
    try
    {
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        //读取相应的学号
        while (dr.Read())

        {
            stuXH.Items.Add(dr[0]);
        }
        dr.Close();
        _sql = "select XSB.XH as '学号',XSB.XM as '姓名',KCB.KCM as '课程名',CJB.CJ as '成绩'," + "KCB.XF as '学分',KCB.XS as '学时',KCB.XQ as '开课学期'" + " from XSB,KCB,CJB"+ " where XSB.XH=CJB.XH and KCB.KCH=CJB.KCH and XSB.ZY='" + stuZY.Text + "'";
           SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
           DataSet ds = new DataSet();
           sda.Fill(ds);
           scoreDGV.DataSource = ds.Tables[0].DefaultView;
    }
    finally
    {
        conn.Close();
    }

        }

        private void stuXH_SelectedIndexChanged(object sender, EventArgs e)
        {
                string _sql = "select XSB.XH as '学号',XSB.XM as '姓名',KCB.KCM as '课程名',CJB.CJ as '成绩'," + "KCB.XF as '学分',KCB.XS as '学时',KCB.XQ as '开课学期'" + " from XSB,KCB,CJB"+ " where CJB.XH='" + stuXH.Text + "'and CJB.XH=XSB.XH and CJB.KCH= KCB.KCH";
        if (stuKCM.Text.Trim() != string.Empty)
        {
            _sql += " and KCB.KCM='" + stuKCM.Text + "'";
    }
    SqlConnection conn = new SqlConnection(connStr);
    SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
    DataSet ds = new DataSet();
    sda.Fill(ds);
    scoreDGV.DataSource = ds.Tables[0].DefaultView;

        }

        private void stuKCM_SelectedIndexChanged(object sender, EventArgs e)
        {
                string _sql = "select XSB.XH as '学号',XSB.XM as '姓名',KCB.KCM as '课程名',CJB.CJ as '成绩'," + "KCB.XF as '学分',KCB.XS as '学时',KCB.XQ as '开课学期'"+ " from XSB,KCB,CJB"+ " where KCB.KCM='" + stuKCM.Text + "'and CJB.XH=XSB.XH and CJB.KCH= KCB.KCH";
    if (stuXH.Text.Trim() != string.Empty)
    {
       _sql += " and XSB.XH='" + stuXH.Text + "'";
    }
    SqlConnection conn = new SqlConnection(connStr);
    SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
    DataSet ds = new DataSet();
    sda.Fill(ds);
    scoreDGV.DataSource = ds.Tables[0].DefaultView;

        }

        private void scoreDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //获得选中的记录行
            DataGridViewRow dgvRow = scoreDGV.Rows[e.RowIndex];
            //获得行单元格集合
            DataGridViewCellCollection dgvCC = dgvRow.Cells;
            //获得单元格数据
            stuXM.Text = dgvCC[1].Value.ToString();
            stuCJ.Text = dgvCC[3].Value.ToString();
            stuXF.Text = dgvCC[4].Value.ToString();
            stuKCM.SelectedItem = dgvCC[2].Value;

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string _sql = "select count(*) from CJB where CJB.XH='" + stuXH.Text + "' and 						CJB.KCH=(select KCH from KCB where KCM='" + stuKCM.Text + "')";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            //检查是否有此学生记录，有就修改，无则添加
            try
            {
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                //修改记录
                if (cnt == 1)
                {
                    _sql = "update CJB set CJB.CJ ='" + stuCJ.Text + "' where CJB.XH='" +
            stuXH.Text + "' and CJB.KCH=(select KCH from KCB where KCM='" + stuKCM.Text + "')";
                }
                //添加新记录
                else
                {
                    string _sql2 = "select KCH from KCB where KCM='" + stuKCM.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(_sql2, conn);
                    _sql = "insert into CJB values('" + stuXH.Text.Trim() + "'," + cmd2.ExecuteScalar() + "," + int.Parse(stuCJ.Text.Trim()) + ")";
                }
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();
                stuXH_SelectedIndexChanged(null, null);
                MessageBox.Show("更新成功！", "提示"
                                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("确定要删除记录吗？", "删除"
            , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel)
            {
                return;
            }
            string _sql = "delete from CJB where XH='" + stuXH.Text + "' and KCH=(select KCH from 										KCB where KCM='" + stuKCM.Text + "')";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                stuXH_SelectedIndexChanged(null, null);
                if (rows == 1)
                {
                    MessageBox.Show("删除成功！", "提示"
                                   , MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            finally
            {
                conn.Close();
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
