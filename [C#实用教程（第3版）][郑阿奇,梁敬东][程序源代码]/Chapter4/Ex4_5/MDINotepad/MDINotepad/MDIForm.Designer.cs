namespace MDINotepad
{
    partial class MDIForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.层叠CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部关闭LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem,
            this.窗口WToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.窗口WToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 窗口WToolStripMenuItem
            // 
            this.窗口WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.垂直平铺VToolStripMenuItem,
            this.层叠CToolStripMenuItem,
            this.水平平铺HToolStripMenuItem,
            this.全部关闭LToolStripMenuItem});
            this.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem";
            this.窗口WToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.窗口WToolStripMenuItem.Text = "窗口(&W)";
            // 
            // 垂直平铺VToolStripMenuItem
            // 
            this.垂直平铺VToolStripMenuItem.Name = "垂直平铺VToolStripMenuItem";
            this.垂直平铺VToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.垂直平铺VToolStripMenuItem.Text = "垂直平铺(&V)";
            this.垂直平铺VToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺VToolStripMenuItem_Click);
            // 
            // 层叠CToolStripMenuItem
            // 
            this.层叠CToolStripMenuItem.Name = "层叠CToolStripMenuItem";
            this.层叠CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.层叠CToolStripMenuItem.Text = "层叠(&C)";
            this.层叠CToolStripMenuItem.Click += new System.EventHandler(this.层叠CToolStripMenuItem_Click);
            // 
            // 水平平铺HToolStripMenuItem
            // 
            this.水平平铺HToolStripMenuItem.Name = "水平平铺HToolStripMenuItem";
            this.水平平铺HToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.水平平铺HToolStripMenuItem.Text = "水平平铺(&H)";
            this.水平平铺HToolStripMenuItem.Click += new System.EventHandler(this.水平平铺HToolStripMenuItem_Click);
            // 
            // 全部关闭LToolStripMenuItem
            // 
            this.全部关闭LToolStripMenuItem.Name = "全部关闭LToolStripMenuItem";
            this.全部关闭LToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.全部关闭LToolStripMenuItem.Text = "全部关闭(&L)";
            this.全部关闭LToolStripMenuItem.Click += new System.EventHandler(this.全部关闭LToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 266);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIForm";
            this.Text = "多文档记事本";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 层叠CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部关闭LToolStripMenuItem;
    }
}

