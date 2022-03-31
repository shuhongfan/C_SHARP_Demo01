using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex7_12
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point pStart, pEnd;     	// 定义画图的起始终点
        int ChoiceGraph;        	// 所选择图形枚举
        int penWidth;           	// 画笔宽度
        enum mySelected
        {
            Pencil,          	// 铅笔
            Line,            	// 直线
            Ellipse,         	// 空心椭圆
            FillEllipse,       	// 填充椭圆
            Rec,             	// 空心矩形
            FillRec,         	// 填充矩形
            Eraser          	// 橡皮擦
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.pictureBox1.CreateGraphics();
            ChoiceGraph = (int)mySelected.Pencil;    		// 默认选择为铅笔工具
            penWidth = 3;          	 			// 初始化画笔宽度
            btnControl.BackColor = btnBlack.BackColor;  	// 默认黑色笔

        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnFillRec_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnLine1_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度

        }

        private void btnLine2_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度

        }

        private void btnLine3_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度

        }

        private void btnLine4_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度

        }

        private void btnLine5_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }

        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }

        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }

        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }

        }

        private void Change_Point()
        {
            Point pTemp = new Point();			// 定义临时点
            if (pStart.X < pEnd.X)
            {
                if (pStart.Y > pEnd.Y)
                {
                    pTemp.Y = pStart.Y;
                    pStart.Y = pEnd.Y;
                    pEnd.Y = pTemp.Y;
                }
            }
            if (pStart.X > pEnd.X)
            {
                if (pStart.Y < pEnd.Y)
                {
                    pTemp.X = pStart.X;
                    pStart.X = pEnd.X;
                    pEnd.X = pTemp.X;
                }
                if (pStart.Y > pEnd.Y)
                {
                    pTemp = pStart;
                    pStart = pEnd;
                    pEnd = pTemp;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)	// 如果单击鼠标左键，则将当前点坐标赋给起始点
            {
                pStart.X = e.X;
                pStart.Y = e.Y;
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "X:" + e.X.ToString() + ",Y:" + e.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                switch (ChoiceGraph)
                {
                    case (int)mySelected.Pencil:       	 	// 选择的是铅笔
                        Pen pen1 = new Pen(btnControl.BackColor, penWidth);
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen1, pStart, pEnd);
                        pStart = pEnd;      				// 将已经绘制的终点作为下一次绘制的起点
                        break;
                    case (int)mySelected.Eraser:
                        Pen pen2 = new Pen(Color.White, penWidth);   	// 定义白色画笔作为擦除效果
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen2, pStart, pEnd);
                        pStart = pEnd;   				// 将已经绘制的终点作为下一次绘制的起点
                        break;
                    default:
                        break;
                }
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)         	// 如果用户按下的是鼠标左键，记录终点坐标
    {
        pEnd.X = e.X;
        pEnd.Y = e.Y;
        switch (ChoiceGraph)
        {
            case (int)mySelected.Line:       	// 如果选择的是直线
                Pen pen1 = new Pen(btnControl.BackColor, penWidth);
                g.DrawLine(pen1, pStart, pEnd);
                break;
            case (int)mySelected.Ellipse:     	// 如果选择的是空心椭圆
                Change_Point();
                Pen pen2 = new Pen(btnControl.BackColor, penWidth);
                g.DrawEllipse(pen2, pStart.X, pStart.Y, pEnd.X-pStart.X, pEnd.Y-pStart.Y);
                break;
            case (int)mySelected.FillEllipse:		// 如果选择的是实心椭圆
                Change_Point();
                SolidBrush myBrush1 = new SolidBrush(btnControl.BackColor);
                Rectangle rec1 = new Rectangle(pStart.X, pStart.Y, pEnd.X-pStart.X, pEnd.Y - pStart.Y);
                g.FillEllipse(myBrush1, rec1);

                break;
            case (int)mySelected.Rec:			// 如果选择的是矩形
                Change_Point();
                Pen pen3 = new Pen(btnControl.BackColor, penWidth);
                g.DrawRectangle(pen3, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.Y - pStart.Y);
                break;
            case (int)mySelected.FillRec:		// 如果选择的是实心矩形
                Change_Point();
                SolidBrush myBrush2 = new SolidBrush(btnControl.BackColor);
                Rectangle rec2 = new Rectangle(pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.Y - pStart.Y);
                g.FillRectangle(myBrush2, rec2);
                break;
            default:
                break;
        }
    }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();			// 刷新
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();					// 关闭
        }

    }
}
