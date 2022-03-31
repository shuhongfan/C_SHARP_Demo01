namespace ScoreManagement
{
    partial class ScoreForm
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.stuXF = new System.Windows.Forms.TextBox();
            this.stuKCM = new System.Windows.Forms.ComboBox();
            this.stuCJ = new System.Windows.Forms.TextBox();
            this.stuXH = new System.Windows.Forms.ComboBox();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.stuZY = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生成绩录入";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.stuXF);
            this.groupBox1.Controls.Add(this.stuKCM);
            this.groupBox1.Controls.Add(this.stuCJ);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生成绩录入";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(333, 94);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 14;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(197, 94);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "删除";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(61, 94);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "更新";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // stuXF
            // 
            this.stuXF.Location = new System.Drawing.Point(353, 55);
            this.stuXF.Name = "stuXF";
            this.stuXF.Size = new System.Drawing.Size(87, 21);
            this.stuXF.TabIndex = 11;
            // 
            // stuKCM
            // 
            this.stuKCM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuKCM.FormattingEnabled = true;
            this.stuKCM.Location = new System.Drawing.Point(353, 29);
            this.stuKCM.Name = "stuKCM";
            this.stuKCM.Size = new System.Drawing.Size(87, 20);
            this.stuKCM.TabIndex = 10;
            this.stuKCM.SelectedIndexChanged += new System.EventHandler(this.stuKCM_SelectedIndexChanged);
            // 
            // stuCJ
            // 
            this.stuCJ.Location = new System.Drawing.Point(201, 55);
            this.stuCJ.Name = "stuCJ";
            this.stuCJ.Size = new System.Drawing.Size(87, 21);
            this.stuCJ.TabIndex = 9;
            // 
            // stuXH
            // 
            this.stuXH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuXH.FormattingEnabled = true;
            this.stuXH.Location = new System.Drawing.Point(201, 29);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(87, 20);
            this.stuXH.TabIndex = 8;
            this.stuXH.SelectedIndexChanged += new System.EventHandler(this.stuXH_SelectedIndexChanged);
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(61, 55);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(87, 21);
            this.stuXM.TabIndex = 7;
            // 
            // stuZY
            // 
            this.stuZY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuZY.FormattingEnabled = true;
            this.stuZY.Location = new System.Drawing.Point(61, 29);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(87, 20);
            this.stuZY.TabIndex = 6;
            this.stuZY.SelectedIndexChanged += new System.EventHandler(this.stuZY_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "学分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "课程名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "成绩";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "学号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "专业";
            // 
            // scoreDGV
            // 
            this.scoreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDGV.Location = new System.Drawing.Point(12, 173);
            this.scoreDGV.Name = "scoreDGV";
            this.scoreDGV.RowTemplate.Height = 23;
            this.scoreDGV.Size = new System.Drawing.Size(462, 185);
            this.scoreDGV.TabIndex = 2;
            this.scoreDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.scoreDGV_RowHeaderMouseClick);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 370);
            this.Controls.Add(this.scoreDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreForm";
            this.Text = "学生成绩录入";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stuCJ;
        private System.Windows.Forms.ComboBox stuXH;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.ComboBox stuZY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox stuXF;
        private System.Windows.Forms.ComboBox stuKCM;
        private System.Windows.Forms.DataGridView scoreDGV;
    }
}