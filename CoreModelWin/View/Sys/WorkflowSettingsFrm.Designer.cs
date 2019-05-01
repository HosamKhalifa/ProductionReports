namespace CoreModelWin.View.Sys
{
    partial class WorkflowSettingsFrm
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
            this.workflowXPage = new DevExpress.XtraTab.XtraTabPage();
            this.wflowRoutesXPAG = new DevExpress.XtraTab.XtraTabPage();
            this.workflowStepsXPC = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workflowStepsXPC)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.workflowXPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(725, 400);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.workflowXPage,
            this.wflowRoutesXPAG});
            // 
            // workflowXPage
            // 
            this.workflowXPage.Name = "workflowXPage";
            this.workflowXPage.Size = new System.Drawing.Size(719, 372);
            this.workflowXPage.Text = "Workflow ";
            // 
            // wflowRoutesXPAG
            // 
            this.wflowRoutesXPAG.Name = "wflowRoutesXPAG";
            this.wflowRoutesXPAG.Size = new System.Drawing.Size(719, 372);
            this.wflowRoutesXPAG.Text = "Workfow Routes";
            // 
            // workflowStepsXPC
            // 
            this.workflowStepsXPC.Session = this.unitOfWork1;
            // 
            // WorkflowSettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(725, 400);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "WorkflowSettingsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workflowStepsXPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage workflowXPage;
        private DevExpress.XtraTab.XtraTabPage wflowRoutesXPAG;
        private DevExpress.Xpo.XPCollection workflowStepsXPC;
    }
}
