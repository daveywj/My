namespace WindowsFormStudy
{
    partial class FrmMain
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
            this.buttonFileToDB = new System.Windows.Forms.Button();
            this.buttonDBToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFileToDB
            // 
            this.buttonFileToDB.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFileToDB.Location = new System.Drawing.Point(12, 126);
            this.buttonFileToDB.Name = "buttonFileToDB";
            this.buttonFileToDB.Size = new System.Drawing.Size(162, 41);
            this.buttonFileToDB.TabIndex = 0;
            this.buttonFileToDB.Text = "保存到数据库&B";
            this.buttonFileToDB.UseVisualStyleBackColor = true;
            this.buttonFileToDB.Click += new System.EventHandler(this.buttonFileToDB_Click);
            // 
            // buttonDBToFile
            // 
            this.buttonDBToFile.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDBToFile.Location = new System.Drawing.Point(12, 184);
            this.buttonDBToFile.Name = "buttonDBToFile";
            this.buttonDBToFile.Size = new System.Drawing.Size(162, 41);
            this.buttonDBToFile.TabIndex = 0;
            this.buttonDBToFile.Text = "从数据库读表&C";
            this.buttonDBToFile.UseVisualStyleBackColor = true;
            this.buttonDBToFile.Click += new System.EventHandler(this.buttonDBToFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 277);
            this.Controls.Add(this.buttonDBToFile);
            this.Controls.Add(this.buttonFileToDB);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFileToDB;
        private System.Windows.Forms.Button buttonDBToFile;
    }
}

