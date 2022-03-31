namespace ScoreManagement
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stuXH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stuZY = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.StuDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生信息查询";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StuDGV);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号：";
            // 
            // stuXH
            // 
            this.stuXH.Location = new System.Drawing.Point(69, 23);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(60, 21);
            this.stuXH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(192, 23);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(60, 21);
            this.stuXM.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "专业：";
            // 
            // stuZY
            // 
            this.stuZY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuZY.FormattingEnabled = true;
            this.stuZY.Items.AddRange(new object[] {
            "所有专业",
            "计算机",
            "通信工程"});
            this.stuZY.Location = new System.Drawing.Point(314, 23);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(60, 20);
            this.stuZY.TabIndex = 5;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(390, 21);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "查询";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // StuDGV
            // 
            this.StuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuDGV.Location = new System.Drawing.Point(24, 50);
            this.StuDGV.Name = "StuDGV";
            this.StuDGV.RowTemplate.Height = 23;
            this.StuDGV.Size = new System.Drawing.Size(441, 141);
            this.StuDGV.TabIndex = 7;
            this.StuDGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StuDGV_RowHeaderMouseDoubleClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 257);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "学生信息查询";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView StuDGV;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ComboBox stuZY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stuXH;
        private System.Windows.Forms.Label label2;
    }
}