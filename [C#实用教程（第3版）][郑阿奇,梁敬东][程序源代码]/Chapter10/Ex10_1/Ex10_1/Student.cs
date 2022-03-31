using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//
using MySql.Data.MySqlClient;//

namespace Ex10_1
{
    class Student
    {
        private string xh;
        private string xm;
        private bool xb;
        private DateTime csrq;
        private string zy;
        private int xf;
        private string bz;
        private DataSet kccj;
        private MySqlConnection mycon;

        //构造方法
        public Student(MySqlConnection con)
        {
            xh = "";
            xm = "";
            xb = false;
            csrq = DateTime.Now;
            zy = "";
            xf = 0;
            bz = "";
            kccj = new DataSet();
            mycon = con;
        }

        //方法：实现由学号查询学生信息
        public void getStubyXh(string xh)
        {
            string sql = "select * from XSB where XH = '" + xh + "'";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            mda.Fill(ds, "STU");
            if (ds.Tables["STU"].Rows.Count != 1) return;
            xh = ds.Tables["STU"].Rows[0]["XH"].ToString();
            xm = ds.Tables["STU"].Rows[0]["XM"].ToString();
            xb = (ds.Tables["STU"].Rows[0]["XB"].ToString() == "男") ? true : false;
            csrq = DateTime.Parse(ds.Tables["STU"].Rows[0]["CSRQ"].ToString());
            zy = ds.Tables["STU"].Rows[0]["ZY"].ToString();
            xf = int.Parse(ds.Tables["STU"].Rows[0]["ZXF"].ToString());
            bz = ds.Tables["STU"].Rows[0]["BZ"].ToString();
            sql = "select KCM As 已修课程, CJ As 成绩 from KCB join CJB on KCB.KCH = CJB.KCH where XH = '" + xh + "'";
            mda = new MySqlDataAdapter(sql, mycon);
            mda.Fill(kccj, "KCJ");
        }

        //方法：实现录入学生成绩
        public void insertStuCj(string xh, string kcm, int cj)
        {
            //先由课程名查到对应的课程号
            string sql = "select KCH from KCB where KCM = '" + kcm + "'";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            mda.Fill(ds, "KCH");
            if (ds.Tables["KCH"].Rows.Count != 1) return;
            //再向数据库中插入对应学生该门课的成绩记录
            sql = "insert into CJB values('" + xh + "', '" + ds.Tables["KCH"].Rows[0]["KCH"].ToString() + "', " + cj + ")";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.ExecuteNonQuery();
            //查询当前最新的已修课程成绩记录,用于刷新
            sql = "select KCM As 已修课程, CJ As 成绩 from KCB join CJB on KCB.KCH = CJB.KCH where XH = '" + xh + "'";
            mda = new MySqlDataAdapter(sql, mycon);
            kccj.Tables.Clear();    //清除旧数据
            mda.Fill(kccj, "KCJ");  //载入新数据
        }

        //get方法：提供给外部程序获取本类的各个属性值
        public string getXh() { return xh; }
        public string getXm() { return xm; }
        public bool getXb() { return xb; }
        public DateTime getCsrq() { return csrq; }
        public string getZy() { return zy; }
        public int getXf() { return xf; }
        public string getBz() { return bz; }
        public DataSet getKccj() { return kccj; }
    }
}
