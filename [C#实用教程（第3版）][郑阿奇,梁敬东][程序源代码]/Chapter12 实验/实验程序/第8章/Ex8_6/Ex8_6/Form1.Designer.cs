namespace Ex8_6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maiMenu = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSep = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.目录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDir = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelDir = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miList = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvDir = new System.Windows.Forms.TreeView();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maiMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maiMenu
            // 
            this.maiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.目录DToolStripMenuItem,
            this.视图VToolStripMenuItem});
            this.maiMenu.Location = new System.Drawing.Point(0, 0);
            this.maiMenu.Name = "maiMenu";
            this.maiMenu.Size = new System.Drawing.Size(649, 24);
            this.maiMenu.TabIndex = 0;
            this.maiMenu.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewFile,
            this.miOpenFile,
            this.miDelFile,
            this.miSep,
            this.miExit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // miNewFile
            // 
            this.miNewFile.Name = "miNewFile";
            this.miNewFile.Size = new System.Drawing.Size(114, 22);
            this.miNewFile.Text = "新建(&N)";
            // 
            // miOpenFile
            // 
            this.miOpenFile.Name = "miOpenFile";
            this.miOpenFile.Size = new System.Drawing.Size(114, 22);
            this.miOpenFile.Text = "打开(&O)";
            // 
            // miDelFile
            // 
            this.miDelFile.Name = "miDelFile";
            this.miDelFile.Size = new System.Drawing.Size(114, 22);
            this.miDelFile.Text = "删除(&D)";
            // 
            // miSep
            // 
            this.miSep.Name = "miSep";
            this.miSep.Size = new System.Drawing.Size(111, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(114, 22);
            this.miExit.Text = "退出(&X)";
            // 
            // 目录DToolStripMenuItem
            // 
            this.目录DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewDir,
            this.miDelDir});
            this.目录DToolStripMenuItem.Name = "目录DToolStripMenuItem";
            this.目录DToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.目录DToolStripMenuItem.Text = "目录(&D)";
            // 
            // miNewDir
            // 
            this.miNewDir.Name = "miNewDir";
            this.miNewDir.Size = new System.Drawing.Size(113, 22);
            this.miNewDir.Text = "新建(&N)";
            // 
            // miDelDir
            // 
            this.miDelDir.Name = "miDelDir";
            this.miDelDir.Size = new System.Drawing.Size(113, 22);
            this.miDelDir.Text = "删除(&D)";
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLargeIcon,
            this.miSmallIcon,
            this.miList,
            this.miDetail});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // miLargeIcon
            // 
            this.miLargeIcon.Name = "miLargeIcon";
            this.miLargeIcon.Size = new System.Drawing.Size(137, 22);
            this.miLargeIcon.Text = "大图标(&L)";
            // 
            // miSmallIcon
            // 
            this.miSmallIcon.Name = "miSmallIcon";
            this.miSmallIcon.Size = new System.Drawing.Size(137, 22);
            this.miSmallIcon.Text = "小图标(&S)";
            // 
            // miList
            // 
            this.miList.Name = "miList";
            this.miList.Size = new System.Drawing.Size(137, 22);
            this.miList.Text = "列表(&L)";
            // 
            // miDetail
            // 
            this.miDetail.Name = "miDetail";
            this.miDetail.Size = new System.Drawing.Size(152, 22);
            this.miDetail.Text = "详细资料(&D)";
            this.miDetail.Click += new System.EventHandler(this.miDetail_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPath});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "路径:";
            // 
            // txtPath
            // 
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(500, 25);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "drive.ico");
            this.imageList1.Images.SetKeyName(1, "folder_closed.ico");
            this.imageList1.Images.SetKeyName(2, "folder_open.ico");
            this.imageList1.Images.SetKeyName(3, "doc.ico");
            this.imageList1.Images.SetKeyName(4, "docx.ico");
            this.imageList1.Images.SetKeyName(5, "txt.ico");
            this.imageList1.Images.SetKeyName(6, "rar.ico");
            this.imageList1.Images.SetKeyName(7, "htm.ico");
            this.imageList1.Images.SetKeyName(8, "ini.ico");
            this.imageList1.Images.SetKeyName(9, "dll.ico");
            this.imageList1.Images.SetKeyName(10, "bat.ico");
            this.imageList1.Images.SetKeyName(11, "exe.ico");
            this.imageList1.Images.SetKeyName(12, "jpg.ico");
            this.imageList1.Images.SetKeyName(13, "gif.ico");
            this.imageList1.Images.SetKeyName(14, "unknow.ico");
            // 
            // tvDir
            // 
            this.tvDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDir.ImageIndex = 0;
            this.tvDir.ImageList = this.imageList1;
            this.tvDir.Location = new System.Drawing.Point(0, 49);
            this.tvDir.Name = "tvDir";
            this.tvDir.SelectedImageIndex = 0;
            this.tvDir.Size = new System.Drawing.Size(165, 345);
            this.tvDir.TabIndex = 2;
            this.tvDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDir_AfterSelect);
            this.tvDir.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDir_NodeMouseDoubleClick);
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSize,
            this.chType,
            this.chTime});
            this.lvFiles.LargeImageList = this.imageList1;
            this.lvFiles.Location = new System.Drawing.Point(166, 49);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(483, 345);
            this.lvFiles.TabIndex = 3;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 395);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.tvDir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.maiMenu);
            this.MainMenuStrip = this.maiMenu;
            this.Name = "Form1";
            this.Text = "资源管理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.maiMenu.ResumeLayout(false);
            this.maiMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip maiMenu;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewFile;
        private System.Windows.Forms.ToolStripMenuItem miOpenFile;
        private System.Windows.Forms.ToolStripMenuItem miDelFile;
        private System.Windows.Forms.ToolStripSeparator miSep;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem 目录DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewDir;
        private System.Windows.Forms.ToolStripMenuItem miDelDir;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem miSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem miList;
        private System.Windows.Forms.ToolStripMenuItem miDetail;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvDir;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chTime;
    }
}

