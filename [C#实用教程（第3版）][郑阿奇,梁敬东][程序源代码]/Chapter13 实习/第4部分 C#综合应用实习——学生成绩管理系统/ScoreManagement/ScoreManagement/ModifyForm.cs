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
    public partial class ModifyForm : Form
    {
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            string _sql = "select XH as '学号',XM as '姓名',ZY as '专业',XB as '性别',"+ "CSRQ as '出生日期',ZXF as '总学分',BZ as '备注' from XSB";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            StuDGV.DataSource = ds.Tables[0].DefaultView;
        }

        private void StuDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //获得选中的记录行
            DataGridViewRow dgvRow = StuDGV.Rows[e.RowIndex];
            //获得行单元格集合
            DataGridViewCellCollection dgvCC = dgvRow.Cells;
            //获得单元格数据
            stuXH.Text = dgvCC[0].Value.ToString();
            stuXM.Text = dgvCC[1].Value.ToString();
            stuZY.Text = dgvCC[2].Value.ToString();
            if (dgvCC[3].Value.ToString() == "男")
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }
            stuCS.Text = Convert.ToDateTime(dgvCC[4].Value).ToShortDateString();
            stuZXF.Text = dgvCC[5].Value.ToString();
            stuBZ.Text = dgvCC[6].Value.ToString();
        }

        private void stuUpdate_Click(object sender, EventArgs e)
        {
            string _sql = "select count(*) from XSB where XH='" + stuXH.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            // 检查是否有此学生记录，有就修改，无则添加
            try
            {
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                string sex = male.Checked ? "男" : "女";
                // 修改记录
                if (cnt == 1)
                {
                    _sql = "update XSB set XM ='" + stuXM.Text + "',XB='" + sex + "',CSRQ='"
        + stuCS.Text + "',ZY='" + stuZY.Text + "',ZXF=" + int.Parse(stuZXF.Text) + ",BZ='" + stuBZ.Text + "'where XH='" + stuXH.Text + "'";
                }
                // 添加新记录
                else
                {
                    _sql = "insert into XSB values('" + stuXH.Text + "','" + stuXM.Text + "','" + sex + "','" + stuCS.Text + "','" + stuZY.Text + "'," + int.Parse(stuZXF.Text) + ",'" + stuBZ.Text + "')";
                }
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();
                ModifyForm_Load(null, null);
            }
            finally
            {

                conn.Close();
            }

        }

        private void stuDelete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("确定要删除记录吗？", "删除"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel)
            {
                return;
            }
            string _sql = "delete from XSB where XH='" + stuXH.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                ModifyForm_Load(null, null);
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
    }
}
