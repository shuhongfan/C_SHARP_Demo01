using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex9_3
{
    public partial class SelfDetail : Form
    {
        internal DataSet mDataSet;
        public SelfDetail()
        {
            InitializeComponent();
        }

        private void ButtonStateControl()
        {
            btnFirst.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnLast.Enabled = true;
            if (this.BindingContext[mDataSet, "SelfInfo"].Position == 0)
            {
                btnPrev.Enabled = false;
                btnFirst.Enabled = false;
            }
            if (this.BindingContext[mDataSet, "SelfInfo"].Position == (this.BindingContext[mDataSet, "SelfInfo"].Count - 1))
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
        }

        private void SelfDetail_Load(object sender, EventArgs e)
        {
            ButtonStateControl();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[mDataSet, "SelfInfo"].Position = 0;
            ButtonStateControl();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.BindingContext[mDataSet, "SelfInfo"].Position += 1;
            ButtonStateControl();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.BindingContext[mDataSet, "SelfInfo"].Position -= 1;
            ButtonStateControl();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[mDataSet, "SelfInfo"].Position = this.BindingContext[mDataSet, "SelfInfo"].Count - 1;
            ButtonStateControl();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
