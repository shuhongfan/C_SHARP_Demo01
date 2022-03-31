namespace Ex8_5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStreamWrite = new System.Windows.Forms.Button();
            this.btnStreamRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(1, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(413, 227);
            this.textBox1.TabIndex = 0;
            // 
            // btnStreamWrite
            // 
            this.btnStreamWrite.Location = new System.Drawing.Point(48, 232);
            this.btnStreamWrite.Name = "btnStreamWrite";
            this.btnStreamWrite.Size = new System.Drawing.Size(75, 23);
            this.btnStreamWrite.TabIndex = 1;
            this.btnStreamWrite.Text = "文本保存";
            this.btnStreamWrite.UseVisualStyleBackColor = true;
            this.btnStreamWrite.Click += new System.EventHandler(this.btnStreamWrite_Click);
            // 
            // btnStreamRead
            // 
            this.btnStreamRead.Location = new System.Drawing.Point(129, 232);
            this.btnStreamRead.Name = "btnStreamRead";
            this.btnStreamRead.Size = new System.Drawing.Size(75, 23);
            this.btnStreamRead.TabIndex = 2;
            this.btnStreamRead.Text = "文本读取";
            this.btnStreamRead.UseVisualStyleBackColor = true;
            this.btnStreamRead.Click += new System.EventHandler(this.btnStreamRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(210, 232);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 3;
            this.btnBinaryWrite.Text = "二进制保存";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(291, 232);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 4;
            this.btnBinaryRead.Text = "二进制读取";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 267);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnStreamRead);
            this.Controls.Add(this.btnStreamWrite);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "读写文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStreamWrite;
        private System.Windows.Forms.Button btnStreamRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
    }
}

