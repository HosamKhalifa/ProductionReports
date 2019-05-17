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
            this.userGC = new CoreLib.Grid.MyGridControl();
            this.userBS = new System.Windows.Forms.BindingSource(this.components);
            this.userXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.userGV = new CoreLib.Grid.MyGridView();
            this.colPrincipalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colChangeNextLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.generalTPage = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.overviewTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
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
            this.overviewTPage.Controls.Add(this.userGC);
            this.overviewTPage.Name = "overviewTPage";
            this.overviewTPage.Size = new System.Drawing.Size(576, 283);
            this.overviewTPage.Text = "Overview";
            // 
            // userGC
            // 
            this.userGC.DataSource = this.userBS;
            this.userGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGC.Location = new System.Drawing.Point(0, 0);
            this.userGC.MainView = this.userGV;
            this.userGC.Name = "userGC";
            this.userGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.userGC.Size = new System.Drawing.Size(576, 283);
            this.userGC.TabIndex = 0;
            this.userGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userGV});
            // 
            // userBS
            // 
            this.userBS.DataSource = this.userXPC;
            // 
            // userXPC
            // 
            this.userXPC.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew;
            this.userXPC.ObjectType = typeof(CoreModel.SecurityPrincipalUser);
            this.userXPC.Session = this.unitOfWork1;
            // 
            // userGV
            // 
            this.userGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrincipalId,
            this.colUserName,
            this.colEffectiveFrom,
            this.colEffectiveTo,
            this.gridColumn2,
            this.colPwd,
            this.colChangeNextLogin,
            this.colUserImage});
            this.userGV.EnableAutoFormat = true;
            this.userGV.EnableAutoSave = true;
            this.userGV.GridControl = this.userGC;
            this.userGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;
            this.userGV.Name = "userGV";
            this.userGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colPrincipalId
            // 
            this.colPrincipalId.FieldName = "PrincipalId";
            this.colPrincipalId.Name = "colPrincipalId";
            this.colPrincipalId.Visible = true;
            this.colPrincipalId.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colEffectiveFrom
            // 
            this.colEffectiveFrom.FieldName = "EffectiveFrom";
            this.colEffectiveFrom.Name = "colEffectiveFrom";
            this.colEffectiveFrom.Visible = true;
            this.colEffectiveFrom.VisibleIndex = 2;
            // 
            // colEffectiveTo
            // 
            this.colEffectiveTo.FieldName = "EffectiveTo";
            this.colEffectiveTo.Name = "colEffectiveTo";
            this.colEffectiveTo.Visible = true;
            this.colEffectiveTo.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Employee!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // colPwd
            // 
            this.colPwd.ColumnEdit = this.repositoryItemTextEdit1;
            this.colPwd.FieldName = "Pwd";
            this.colPwd.Name = "colPwd";
            this.colPwd.Visible = true;
            this.colPwd.VisibleIndex = 5;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.PasswordChar = '*';
            // 
            // colChangeNextLogin
            // 
            this.colChangeNextLogin.FieldName = "ChangeNextLogin";
            this.colChangeNextLogin.Name = "colChangeNextLogin";
            this.colChangeNextLogin.Visible = true;
            this.colChangeNextLogin.VisibleIndex = 6;
            // 
            // colUserImage
            // 
            this.colUserImage.FieldName = "UserImage";
            this.colUserImage.Name = "colUserImage";
            this.colUserImage.Visible = true;
            this.colUserImage.VisibleIndex = 7;
            // 
            // generalTPage
            // 
            this.generalTPage.Name = "generalTPage";
            this.generalTPage.Size = new System.Drawing.Size(576, 283);
            this.generalTPage.Text = "General";
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
            this.overviewTPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage overviewTPage;
        private DevExpress.XtraTab.XtraTabPage generalTPage;
        private DevExpress.Xpo.XPCollection userXPC;
        private CoreLib.Grid.MyGridControl userGC;
        private CoreLib.Grid.MyGridView userGV;
        private System.Windows.Forms.BindingSource userBS;
        private DevExpress.XtraGrid.Columns.GridColumn colPrincipalId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveTo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colPwd;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeNextLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colUserImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
