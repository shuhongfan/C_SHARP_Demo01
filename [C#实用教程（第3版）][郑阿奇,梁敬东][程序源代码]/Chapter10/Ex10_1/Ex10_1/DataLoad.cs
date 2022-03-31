using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//
using MySql.Data.MySqlClient;//

namespace Ex10_1
{
    class DataLoad
    {
        private static string strcon = @"server=localhost;User Id=root;password=njnu123456;database=XSCJDB;Character Set=utf8";
        private MySqlConnection sqlcon = new MySqlConnection(strcon);

        public MySqlConnection initializeData(ComboBox cbx_xh, ComboBox cbx_kcm)
        {
            try
            {
                sqlcon.Open();
                string sql = "SELECT DISTINCT XH FROM XSB";
                MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
                MySqlDataReader mdr = cmd.ExecuteReader();
                //读取并加载学号
                while (mdr.Read()) { cbx_xh.Items.Add(mdr[0]); }
                mdr.Close();
                sql = "SELECT DISTINCT KCM FROM KCB";
                cmd = new MySqlCommand(sql, sqlcon);
                mdr = cmd.ExecuteReader();
                //读取并加载课程
                while (mdr.Read()) { cbx_kcm.Items.Add(mdr[0]); }
                mdr.Close();
                return sqlcon;
            }
            catch (Exception e)
            {
                MessageBox.Show("初始化失败！错误信息为：\r\n" + e.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
