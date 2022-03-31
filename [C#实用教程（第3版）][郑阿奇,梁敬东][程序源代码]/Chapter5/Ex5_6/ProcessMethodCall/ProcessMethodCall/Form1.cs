﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcessMethodCall
{
    public partial class Form1 : Form
    {           
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox2.Text = "运行中……";
                groupBox2.Refresh();
                textBox1.Clear();
                textBox1.Refresh();
                this.writeTextBox1();    //调用方法writeTextBox1()向文本区①写入文字
                groupBox2.Text = "任务1";
                textBox3.Focus();
                textBox3.SelectAll();
            }
            if (checkBox2.Checked == true)
            {
                groupBox2.Refresh();
                groupBox3.Text = "运行中……";
                groupBox3.Refresh();
                textBox2.Clear();
                textBox2.Refresh();
                this.writeTextBox2();    //调用方法writeTextBox2()向文本区②写入文字
                groupBox3.Text = "任务2";
                textBox3.Focus();
                textBox3.SelectAll();
            }
        }

        //写文本区①的方法
        private void writeTextBox1()
        {
            string strdata = textBox3.Text;
            for (int i = 0; i < strdata.Length; i++)
            {
                textBox1.AppendText(strdata[i] + "\r");
                //间歇延时
                DateTime now = DateTime.Now;
                while (now.AddSeconds(1) > DateTime.Now) { }
            }
        }

        //写文本区②的方法
        private void writeTextBox2()
        {
            string strdata = textBox3.Text;
            for (int i = 0; i < strdata.Length; i++)
            {
                textBox2.AppendText(strdata[i] + "\r");
                //间歇延时
                DateTime now = DateTime.Now;
                while (now.AddSeconds(1) > DateTime.Now) { }
            }
        }
    }
}
