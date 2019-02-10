namespace ProductionReports
{
    partial class LoginXtraForm
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
            this.loginXUC1 = new ProductionReports.LoginXUC();
            this.SuspendLayout();
            // 
            // loginXUC1
            // 
            this.loginXUC1.Location = new System.Drawing.Point(-4, 0);
            this.loginXUC1.Name = "loginXUC1";
            this.loginXUC1.Size = new System.Drawing.Size(234, 96);
            this.loginXUC1.TabIndex = 0;
            // 
            // LoginXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 88);
            this.Controls.Add(this.loginXUC1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginXUC loginXUC1;
    }
}