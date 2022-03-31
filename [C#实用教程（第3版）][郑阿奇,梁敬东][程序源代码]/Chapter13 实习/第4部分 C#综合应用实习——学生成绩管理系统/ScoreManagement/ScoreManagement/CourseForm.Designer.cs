namespace ScoreManagement
{
    partial class CourseForm
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
            this.stuKCDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stuKCDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // stuKCDGV
            // 
            this.stuKCDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuKCDGV.Location = new System.Drawing.Point(12, 12);
            this.stuKCDGV.Name = "stuKCDGV";
            this.stuKCDGV.RowTemplate.Height = 23;
            this.stuKCDGV.Size = new System.Drawing.Size(380, 127);
            this.stuKCDGV.TabIndex = 0;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 151);
            this.Controls.Add(this.stuKCDGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseForm";
            this.Text = "学生选课信息";
            ((System.ComponentModel.ISupportInitialize)(this.stuKCDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView stuKCDGV;

    }
}