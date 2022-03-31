namespace Test4_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Bookname = new System.Windows.Forms.TextBox();
            this.comboBox_Publishing = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.listBox_Book = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Publishing);
            this.groupBox1.Controls.Add(this.textBox_Bookname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择出版社";
            // 
            // textBox_Bookname
            // 
            this.textBox_Bookname.Location = new System.Drawing.Point(24, 37);
            this.textBox_Bookname.Name = "textBox_Bookname";
            this.textBox_Bookname.Size = new System.Drawing.Size(121, 21);
            this.textBox_Bookname.TabIndex = 2;
            // 
            // comboBox_Publishing
            // 
            this.comboBox_Publishing.FormattingEnabled = true;
            this.comboBox_Publishing.Items.AddRange(new object[] {
            "清华大学出版社",
            "电子工业出版社",
            "中国铁道出版社",
            "机械工业出版社",
            "人民邮电出版社",
            "中国电力出版社"});
            this.comboBox_Publishing.Location = new System.Drawing.Point(24, 94);
            this.comboBox_Publishing.Name = "comboBox_Publishing";
            this.comboBox_Publishing.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Publishing.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_Remove);
            this.groupBox2.Controls.Add(this.Button_Add);
            this.groupBox2.Location = new System.Drawing.Point(186, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(26, 42);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 0;
            this.Button_Add.Text = "添加>>";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.Location = new System.Drawing.Point(26, 71);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(75, 23);
            this.Button_Remove.TabIndex = 1;
            this.Button_Remove.Text = "移出<<";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // listBox_Book
            // 
            this.listBox_Book.FormattingEnabled = true;
            this.listBox_Book.ItemHeight = 12;
            this.listBox_Book.Location = new System.Drawing.Point(318, 12);
            this.listBox_Book.Name = "listBox_Book";
            this.listBox_Book.Size = new System.Drawing.Size(239, 136);
            this.listBox_Book.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 175);
            this.Controls.Add(this.listBox_Book);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Publishing;
        private System.Windows.Forms.TextBox textBox_Bookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.ListBox listBox_Book;
    }
}

