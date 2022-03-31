namespace ScoreManagement
{
    partial class ModifyForm
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
            this.stuZXF = new System.Windows.Forms.TextBox();
            this.stuZY = new System.Windows.Forms.TextBox();
            this.stuCS = new System.Windows.Forms.TextBox();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.stuXH = new System.Windows.Forms.TextBox();
            this.stuBZ = new System.Windows.Forms.TextBox();
            this.stuCancel = new System.Windows.Forms.Button();
            this.stuDelete = new System.Windows.Forms.Button();
            this.stuUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StuDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生信息修改";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stuZXF);
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.stuCS);
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.stuBZ);
            this.groupBox1.Controls.Add(this.stuCancel);
            this.groupBox1.Controls.Add(this.stuDelete);
            this.groupBox1.Controls.Add(this.stuUpdate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // stuZXF
            // 
            this.stuZXF.Location = new System.Drawing.Point(253, 80);
            this.stuZXF.Name = "stuZXF";
            this.stuZXF.Size = new System.Drawing.Size(93, 21);
            this.stuZXF.TabIndex = 19;
            // 
            // stuZY
            // 
            this.stuZY.Location = new System.Drawing.Point(253, 51);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(93, 21);
            this.stuZY.TabIndex = 18;
            // 
            // stuCS
            // 
            this.stuCS.Location = new System.Drawing.Point(253, 24);
            this.stuCS.Name = "stuCS";
            this.stuCS.Size = new System.Drawing.Size(93, 21);
            this.stuCS.TabIndex = 17;
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(70, 51);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(93, 21);
            this.stuXM.TabIndex = 16;
            // 
            // stuXH
            // 
            this.stuXH.Location = new System.Drawing.Point(70, 24);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(93, 21);
            this.stuXH.TabIndex = 15;
            // 
            // stuBZ
            // 
            this.stuBZ.Location = new System.Drawing.Point(405, 24);
            this.stuBZ.Multiline = true;
            this.stuBZ.Name = "stuBZ";
            this.stuBZ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stuBZ.Size = new System.Drawing.Size(117, 77);
            this.stuBZ.TabIndex = 14;
            // 
            // stuCancel
            // 
            this.stuCancel.Location = new System.Drawing.Point(447, 112);
            this.stuCancel.Name = "stuCancel";
            this.stuCancel.Size = new System.Drawing.Size(75, 23);
            this.stuCancel.TabIndex = 13;
            this.stuCancel.Text = "取消";
            this.stuCancel.UseVisualStyleBackColor = true;
            // 
            // stuDelete
            // 
            this.stuDelete.Location = new System.Drawing.Point(304, 112);
            this.stuDelete.Name = "stuDelete";
            this.stuDelete.Size = new System.Drawing.Size(75, 23);
            this.stuDelete.TabIndex = 12;
            this.stuDelete.Text = "删除";
            this.stuDelete.UseVisualStyleBackColor = true;
            this.stuDelete.Click += new System.EventHandler(this.stuDelete_Click);
            // 
            // stuUpdate
            // 
            this.stuUpdate.Location = new System.Drawing.Point(190, 112);
            this.stuUpdate.Name = "stuUpdate";
            this.stuUpdate.Size = new System.Drawing.Size(75, 23);
            this.stuUpdate.TabIndex = 11;
            this.stuUpdate.Text = "更新";
            this.stuUpdate.UseVisualStyleBackColor = true;
            this.stuUpdate.Click += new System.EventHandler(this.stuUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "备注";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "总学分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "专业";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "出生日期*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "注意：加*为必填字段";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(128, 81);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(35, 16);
            this.female.TabIndex = 5;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(70, 81);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(35, 16);
            this.male.TabIndex = 4;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号*";
            // 
            // StuDGV
            // 
            this.StuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuDGV.Location = new System.Drawing.Point(12, 189);
            this.StuDGV.Name = "StuDGV";
            this.StuDGV.RowTemplate.Height = 23;
            this.StuDGV.Size = new System.Drawing.Size(553, 125);
            this.StuDGV.TabIndex = 0;
            this.StuDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StuDGV_RowHeaderMouseClick);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StuDGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyForm";
            this.Text = "学生信息修改";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stuZXF;
        private System.Windows.Forms.TextBox stuZY;
        private System.Windows.Forms.TextBox stuCS;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.TextBox stuXH;
        private System.Windows.Forms.TextBox stuBZ;
        private System.Windows.Forms.Button stuCancel;
        private System.Windows.Forms.Button stuDelete;
        private System.Windows.Forms.Button stuUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StuDGV;
    }
}