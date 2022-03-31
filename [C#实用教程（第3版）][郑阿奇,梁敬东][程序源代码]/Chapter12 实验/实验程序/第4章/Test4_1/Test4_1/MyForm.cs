using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_Hong_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_Hong.Checked == true)
                this.BackColor = Color.Red;
        }

        private void radioButton_lv_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_lv.Checked == true)
                this.BackColor = Color.Green;
        }

        private void radioButton_lan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_lan.Checked == true)
                this.BackColor = Color.Blue;
        }

        private void checkBox_hong_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_hong.Checked == true)
                this.YourColor.Text = YourColor.Text + checkBox_hong.Text + "、";
        }

        private void checkBox_lv_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_lv.Checked == true)
                this.YourColor.Text = YourColor.Text + checkBox_lv.Text + "、";
        }

        private void checkBox_lan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_lan.Checked)
                YourColor.Text = YourColor.Text + checkBox_lan.Text + "、";
        }

        private void checkBox_cheng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cheng.Checked)
                YourColor.Text = YourColor.Text + checkBox_cheng.Text + "、";
        }

        private void checkBox＿huang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox＿huang.Checked)
                YourColor.Text = YourColor.Text + checkBox＿huang.Text + "、";
        }

        private void checkBox_zi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_zi.Checked)
                YourColor.Text = YourColor.Text + checkBox_zi.Text + "、";
        }
    }
}
