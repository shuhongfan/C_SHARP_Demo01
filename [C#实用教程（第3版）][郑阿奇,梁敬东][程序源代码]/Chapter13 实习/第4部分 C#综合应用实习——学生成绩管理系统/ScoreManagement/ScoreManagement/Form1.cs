using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 查询QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建学生信息查询窗体
            SearchForm searchfrm = new SearchForm();
            searchfrm.ShowDialog();
        }

        private void 修改MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建学生信息修改窗体
            ModifyForm modifyfrm = new ModifyForm();
            modifyfrm.ShowDialog();
        }

        private void 录入UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建学生成绩录入窗体
            ScoreForm scorefrm = new ScoreForm();
            scorefrm.ShowDialog();
        }
    }
}
