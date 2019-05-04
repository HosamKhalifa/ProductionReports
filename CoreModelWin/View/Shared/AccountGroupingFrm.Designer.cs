namespace CoreModelWin.View.Shared
{
    partial class AccountGroupingFrm
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
            this.accountGroupingXUC1 = new CoreModelWin.View.Shared.AccountGroupingXUC();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountGroupingXUC1
            // 
            this.accountGroupingXUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountGroupingXUC1.Location = new System.Drawing.Point(0, 0);
            this.accountGroupingXUC1.Name = "accountGroupingXUC1";
            this.accountGroupingXUC1.Size = new System.Drawing.Size(582, 311);
            this.accountGroupingXUC1.TabIndex = 0;
            // 
            // AccountGroupingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.accountGroupingXUC1);
            this.Name = "AccountGroupingFrm";
            this.Text = "Grouping";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountGroupingXUC accountGroupingXUC1;
    }
}
