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
            this.userTPage = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
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
            this.userGroupsGC = new CoreLib.Grid.MyGridControl();
            this.userGroupsBS = new System.Windows.Forms.BindingSource(this.components);
            this.userGroupsGV = new CoreLib.Grid.MyGridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupTPage = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupGC = new CoreLib.Grid.MyGridControl();
            this.groupBS = new System.Windows.Forms.BindingSource(this.components);
            this.groupXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.groupGV = new CoreLib.Grid.MyGridView();
            this.colPrincipalId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveFrom1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveTo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupUsersGC = new CoreLib.Grid.MyGridControl();
            this.groupUsersBS = new System.Windows.Forms.BindingSource(this.components);
            this.groupUsersGV = new CoreLib.Grid.MyGridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.userTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsGV)).BeginInit();
            this.groupTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.userTPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(853, 417);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.userTPage,
            this.groupTPage});
            // 
            // userTPage
            // 
            this.userTPage.Controls.Add(this.splitContainerControl1);
            this.userTPage.Name = "userTPage";
            this.userTPage.Size = new System.Drawing.Size(847, 389);
            this.userTPage.Text = "Users";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.userGC);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.userGroupsGC);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(847, 389);
            this.splitContainerControl1.SplitterPosition = 218;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.userGC.Size = new System.Drawing.Size(624, 389);
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
            // userGroupsGC
            // 
            this.userGroupsGC.DataSource = this.userGroupsBS;
            this.userGroupsGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGroupsGC.Location = new System.Drawing.Point(0, 0);
            this.userGroupsGC.MainView = this.userGroupsGV;
            this.userGroupsGC.Name = "userGroupsGC";
            this.userGroupsGC.Size = new System.Drawing.Size(218, 389);
            this.userGroupsGC.TabIndex = 0;
            this.userGroupsGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userGroupsGV});
            // 
            // userGroupsBS
            // 
            this.userGroupsBS.DataMember = "Members";
            this.userGroupsBS.DataSource = this.userBS;
            // 
            // userGroupsGV
            // 
            this.userGroupsGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.userGroupsGV.EnableAutoFormat = false;
            this.userGroupsGV.EnableAutoSave = true;
            this.userGroupsGV.GridControl = this.userGroupsGC;
            this.userGroupsGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.SimpleEdit;
            this.userGroupsGV.Name = "userGroupsGV";
            this.userGroupsGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.userGroupsGV.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Cached;
            this.userGroupsGV.OptionsEditForm.EditFormColumnCount = 2;
            this.userGroupsGV.OptionsView.ColumnAutoWidth = false;
            this.userGroupsGV.OptionsView.EnableAppearanceOddRow = true;
            this.userGroupsGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.userGroupsGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "OU name";
            this.gridColumn6.FieldName = "RoleOU.UserName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 226;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "OU";
            this.gridColumn7.FieldName = "RoleOU!Key";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 122;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "User.UserName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "User";
            this.gridColumn9.FieldName = "User!Key";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            // 
            // groupTPage
            // 
            this.groupTPage.Controls.Add(this.splitContainerControl2);
            this.groupTPage.Name = "groupTPage";
            this.groupTPage.Size = new System.Drawing.Size(847, 389);
            this.groupTPage.Text = "Groups";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupGC);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupUsersGC);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(847, 389);
            this.splitContainerControl2.SplitterPosition = 270;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupGC
            // 
            this.groupGC.DataSource = this.groupBS;
            this.groupGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGC.Location = new System.Drawing.Point(0, 0);
            this.groupGC.MainView = this.groupGV;
            this.groupGC.Name = "groupGC";
            this.groupGC.Size = new System.Drawing.Size(572, 389);
            this.groupGC.TabIndex = 0;
            this.groupGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.groupGV});
            // 
            // groupBS
            // 
            this.groupBS.DataSource = this.groupXPC;
            // 
            // groupXPC
            // 
            this.groupXPC.ObjectType = typeof(CoreModel.SecurityPrincipalRoleOU);
            this.groupXPC.Session = this.unitOfWork1;
            // 
            // groupGV
            // 
            this.groupGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrincipalId1,
            this.colUserName1,
            this.colEffectiveFrom1,
            this.colEffectiveTo1,
            this.colRoleType});
            this.groupGV.EnableAutoFormat = true;
            this.groupGV.EnableAutoSave = true;
            this.groupGV.GridControl = this.groupGC;
            this.groupGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;
            this.groupGV.Name = "groupGV";
            this.groupGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colPrincipalId1
            // 
            this.colPrincipalId1.FieldName = "PrincipalId";
            this.colPrincipalId1.Name = "colPrincipalId1";
            this.colPrincipalId1.Visible = true;
            this.colPrincipalId1.VisibleIndex = 0;
            // 
            // colUserName1
            // 
            this.colUserName1.FieldName = "UserName";
            this.colUserName1.Name = "colUserName1";
            this.colUserName1.Visible = true;
            this.colUserName1.VisibleIndex = 1;
            // 
            // colEffectiveFrom1
            // 
            this.colEffectiveFrom1.FieldName = "EffectiveFrom";
            this.colEffectiveFrom1.Name = "colEffectiveFrom1";
            this.colEffectiveFrom1.Visible = true;
            this.colEffectiveFrom1.VisibleIndex = 2;
            // 
            // colEffectiveTo1
            // 
            this.colEffectiveTo1.FieldName = "EffectiveTo";
            this.colEffectiveTo1.Name = "colEffectiveTo1";
            this.colEffectiveTo1.Visible = true;
            this.colEffectiveTo1.VisibleIndex = 3;
            // 
            // colRoleType
            // 
            this.colRoleType.FieldName = "RoleType";
            this.colRoleType.Name = "colRoleType";
            this.colRoleType.Visible = true;
            this.colRoleType.VisibleIndex = 4;
            // 
            // groupUsersGC
            // 
            this.groupUsersGC.DataSource = this.groupUsersBS;
            this.groupUsersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupUsersGC.Location = new System.Drawing.Point(0, 0);
            this.groupUsersGC.MainView = this.groupUsersGV;
            this.groupUsersGC.Name = "groupUsersGC";
            this.groupUsersGC.Size = new System.Drawing.Size(270, 389);
            this.groupUsersGC.TabIndex = 0;
            this.groupUsersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.groupUsersGV});
            // 
            // groupUsersBS
            // 
            this.groupUsersBS.DataMember = "Members";
            this.groupUsersBS.DataSource = this.groupBS;
            // 
            // groupUsersGV
            // 
            this.groupUsersGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn13});
            this.groupUsersGV.EnableAutoFormat = false;
            this.groupUsersGV.EnableAutoSave = true;
            this.groupUsersGV.GridControl = this.groupUsersGC;
            this.groupUsersGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.SimpleEdit;
            this.groupUsersGV.Name = "groupUsersGV";
            this.groupUsersGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.groupUsersGV.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Cached;
            this.groupUsersGV.OptionsEditForm.EditFormColumnCount = 2;
            this.groupUsersGV.OptionsView.ColumnAutoWidth = false;
            this.groupUsersGV.OptionsView.EnableAppearanceOddRow = true;
            this.groupUsersGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn12, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.groupUsersGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "OU name";
            this.gridColumn10.FieldName = "RoleOU.UserName";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "User name";
            this.gridColumn12.FieldName = "User.UserName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 78;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "User";
            this.gridColumn13.FieldName = "User!Key";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 233;
            // 
            // SecurityPrincipalUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(853, 417);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "SecurityPrincipalUserFrm";
            this.Text = "Security principals";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.userTPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsGV)).EndInit();
            this.groupTPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage userTPage;
        private DevExpress.XtraTab.XtraTabPage groupTPage;
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
        private DevExpress.Xpo.XPCollection groupXPC;
        private System.Windows.Forms.BindingSource groupBS;
        private CoreLib.Grid.MyGridControl groupGC;
        private CoreLib.Grid.MyGridView groupGV;
        private DevExpress.XtraGrid.Columns.GridColumn colPrincipalId1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName1;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveFrom1;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveTo1;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleType;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private CoreLib.Grid.MyGridControl userGroupsGC;
        private System.Windows.Forms.BindingSource userGroupsBS;
        private CoreLib.Grid.MyGridView userGroupsGV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private CoreLib.Grid.MyGridControl groupUsersGC;
        private System.Windows.Forms.BindingSource groupUsersBS;
        private CoreLib.Grid.MyGridView groupUsersGV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
    }
}
