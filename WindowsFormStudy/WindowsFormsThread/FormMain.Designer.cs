namespace WindowsFormsThread
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnQuire = new System.Windows.Forms.Button();
            this.LblMark = new System.Windows.Forms.Label();
            this.btn_Chancel = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnQuire
            // 
            this.BtnQuire.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuire.Location = new System.Drawing.Point(32, 170);
            this.BtnQuire.Name = "BtnQuire";
            this.BtnQuire.Size = new System.Drawing.Size(95, 41);
            this.BtnQuire.TabIndex = 0;
            this.BtnQuire.Text = "查询&X";
            this.BtnQuire.UseVisualStyleBackColor = true;
            this.BtnQuire.Click += new System.EventHandler(this.BtnQuire_Click);
            // 
            // LblMark
            // 
            this.LblMark.AutoSize = true;
            this.LblMark.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblMark.Location = new System.Drawing.Point(27, 68);
            this.LblMark.Name = "LblMark";
            this.LblMark.Size = new System.Drawing.Size(100, 29);
            this.LblMark.TabIndex = 1;
            this.LblMark.Text = "主窗体";
            // 
            // btn_Chancel
            // 
            this.btn_Chancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Chancel.Location = new System.Drawing.Point(155, 170);
            this.btn_Chancel.Name = "btn_Chancel";
            this.btn_Chancel.Size = new System.Drawing.Size(95, 41);
            this.btn_Chancel.TabIndex = 0;
            this.btn_Chancel.Text = "退出&C";
            this.btn_Chancel.UseVisualStyleBackColor = true;
            this.btn_Chancel.Click += new System.EventHandler(this.btn_Chancel_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult1.Location = new System.Drawing.Point(32, 116);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(0, 19);
            this.lblResult1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 277);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.LblMark);
            this.Controls.Add(this.btn_Chancel);
            this.Controls.Add(this.BtnQuire);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnQuire;
        private System.Windows.Forms.Label LblMark;
        private System.Windows.Forms.Button btn_Chancel;
        private System.Windows.Forms.Label lblResult1;
    }
}

