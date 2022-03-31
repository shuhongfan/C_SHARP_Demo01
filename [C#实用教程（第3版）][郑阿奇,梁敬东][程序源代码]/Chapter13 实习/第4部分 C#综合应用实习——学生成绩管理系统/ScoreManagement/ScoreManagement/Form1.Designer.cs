namespace ScoreManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息IToolStripMenuItem,
            this.学生成绩SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息IToolStripMenuItem
            // 
            this.学生信息IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询QToolStripMenuItem,
            this.修改MToolStripMenuItem});
            this.学生信息IToolStripMenuItem.Name = "学生信息IToolStripMenuItem";
            this.学生信息IToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.学生信息IToolStripMenuItem.Text = "学生信息(&I)";
            // 
            // 查询QToolStripMenuItem
            // 
            this.查询QToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询QToolStripMenuItem.Image")));
            this.查询QToolStripMenuItem.Name = "查询QToolStripMenuItem";
            this.查询QToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.查询QToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.查询QToolStripMenuItem.Text = "查询(&Q)";
            this.查询QToolStripMenuItem.Click += new System.EventHandler(this.查询QToolStripMenuItem_Click);
            // 
            // 修改MToolStripMenuItem
            // 
            this.修改MToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改MToolStripMenuItem.Image")));
            this.修改MToolStripMenuItem.Name = "修改MToolStripMenuItem";
            this.修改MToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.修改MToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.修改MToolStripMenuItem.Text = "修改(&M)";
            this.修改MToolStripMenuItem.Click += new System.EventHandler(this.修改MToolStripMenuItem_Click);
            // 
            // 学生成绩SToolStripMenuItem
            // 
            this.学生成绩SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.录入UToolStripMenuItem});
            this.学生成绩SToolStripMenuItem.Name = "学生成绩SToolStripMenuItem";
            this.学生成绩SToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.学生成绩SToolStripMenuItem.Text = "学生成绩(&S)";
            // 
            // 录入UToolStripMenuItem
            // 
            this.录入UToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("录入UToolStripMenuItem.Image")));
            this.录入UToolStripMenuItem.Name = "录入UToolStripMenuItem";
            this.录入UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.录入UToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.录入UToolStripMenuItem.Text = "录入(&U)";
            this.录入UToolStripMenuItem.Click += new System.EventHandler(this.录入UToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "查询学生信息";
            this.toolStripButton1.Click += new System.EventHandler(this.查询QToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "修改学生信息";
            this.toolStripButton2.Click += new System.EventHandler(this.修改MToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "录入学生成绩";
            this.toolStripButton3.Click += new System.EventHandler(this.录入UToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 224);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "学生成绩管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入UToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

