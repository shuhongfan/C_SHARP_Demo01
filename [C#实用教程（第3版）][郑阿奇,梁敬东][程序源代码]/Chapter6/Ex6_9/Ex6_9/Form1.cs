﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Ex6_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InvokeFun()
        {
            if (trackBar1.Value < 100)
            {
                trackBar1.Value = trackBar1.Value + 1;
                button1.Text = trackBar1.Value.ToString();
            }
            if (trackBar1.Value == 100)
            {
                MessageBox.Show("到达终点");
                trackBar1.Value = 0;
                button1.Text = trackBar1.Value.ToString();
            }
        }
        private void ThreadFun()
        {
            MethodInvoker mi = new MethodInvoker(this.InvokeFun);
            for (int i = 0; i < 100; i++)
            {
                this.BeginInvoke(mi);			//让主线程去访问自己创建的控件
                Thread.Sleep(100);			//在新的线程上执行耗时操作
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thdProcess = new Thread(new ThreadStart(ThreadFun));
            thdProcess.Start();

        }

    }
}
