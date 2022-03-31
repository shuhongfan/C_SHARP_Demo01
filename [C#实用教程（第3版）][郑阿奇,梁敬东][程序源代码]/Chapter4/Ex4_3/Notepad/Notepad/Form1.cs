using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmTxt : Form
    {
        public frmTxt()
        {
            InitializeComponent();
        }

        private void 撤销UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 删除LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int m = textBox1.SelectionStart;
            int Ln = 0;
            int Col = 0;
            for (int i = m - 1; i >= 0; i--)
            {
                if (str[i] == '\n')
                {
                    Ln++;
                }
                if (Ln < 1)
                {
                    Col++;
                }
            }
            Ln = Ln + 1;
            Col = Col + 1;
            toolStripStatusLabel1.Text = "行:" + Ln.ToString() + "," + "列:" + Col.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void 打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }
    }
}
