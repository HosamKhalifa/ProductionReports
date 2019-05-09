namespace CoreModelWin.View.Sys
{
    partial class SecurityPrincipalUserFrm
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
            this.components = new System.ComponentModel.Container();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.overviewTPage = new DevExpress.XtraTab.XtraTabPage();
            this.generalTPage = new DevExpress.XtraTab.XtraTabPage();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.overviewTPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(582, 311);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.overviewTPage,
            this.generalTPage});
            // 
            // overviewTPage
            // 
            this.overviewTPage.Name = "overviewTPage";
            this.overviewTPage.Size = new System.Drawing.Size(576, 283);
            this.overviewTPage.Text = "Overview";
            // 
            // generalTPage
            // 
            this.generalTPage.Name = "generalTPage";
            this.generalTPage.Size = new System.Drawing.Size(576, 283);
            this.generalTPage.Text = "General";
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(CoreModel.SecurityPrincipalUser);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // SecurityPrincipalUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "SecurityPrincipalUserFrm";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage overviewTPage;
        private DevExpress.XtraTab.XtraTabPage generalTPage;
        private DevExpress.Xpo.XPCollection xpCollection1;
    }
}
