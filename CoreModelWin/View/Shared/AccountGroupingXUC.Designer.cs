namespace CoreModelWin.View.Shared
{
    partial class AccountGroupingXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountGroupingXUC));
            this.grpXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.grpTPage = new DevExpress.XtraTab.XtraTabPage();
            this.grpDataNavigator = new DevExpress.XtraEditors.DataNavigator();
            this.grpBS = new System.Windows.Forms.BindingSource(this.components);
            this.grpTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colLineId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreatedBy = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreatedAt = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModifiedBy = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModifiedAt = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colGroupNum = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colGroupName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAccountType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentLine = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.parentLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ref1TPage = new DevExpress.XtraTab.XtraTabPage();
            this.ref2TPage = new DevExpress.XtraTab.XtraTabPage();
            this.accountTypeImageCombo = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.grpTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeImageCombo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollectionMyXUC
            // 
            this.imageCollectionMyXUC.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionMyXUC.ImageStream")));
            // 
            // grpXPC
            // 
            this.grpXPC.LoadingEnabled = false;
            this.grpXPC.ObjectType = typeof(CoreModel.AccountGroup);
            this.grpXPC.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 29);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.grpTPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(450, 249);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.grpTPage,
            this.ref1TPage,
            this.ref2TPage});
            // 
            // grpTPage
            // 
            this.grpTPage.Controls.Add(this.grpDataNavigator);
            this.grpTPage.Controls.Add(this.grpTreeList);
            this.grpTPage.Name = "grpTPage";
            this.grpTPage.Size = new System.Drawing.Size(444, 221);
            this.grpTPage.Text = "Primary group";
            // 
            // grpDataNavigator
            // 
            this.grpDataNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataNavigator.DataSource = this.grpBS;
            this.grpDataNavigator.Location = new System.Drawing.Point(3, 194);
            this.grpDataNavigator.Name = "grpDataNavigator";
            this.grpDataNavigator.Size = new System.Drawing.Size(160, 24);
            this.grpDataNavigator.TabIndex = 3;
            this.grpDataNavigator.Text = "Group";
            // 
            // grpBS
            // 
            this.grpBS.DataSource = this.grpXPC;
            // 
            // grpTreeList
            // 
            this.grpTreeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.treeListColumn2,
            this.colGroupNum,
            this.colGroupName,
            this.colAccountType,
            this.colParentLine});
            this.grpTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpTreeList.CustomizationFormBounds = new System.Drawing.Rectangle(954, 438, 216, 200);
            this.grpTreeList.DataSource = this.grpBS;
            this.grpTreeList.KeyFieldName = "LineId";
            this.grpTreeList.Location = new System.Drawing.Point(0, 0);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.grpTreeList.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.grpTreeList.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.grpTreeList.OptionsClipboard.ShowProgress = DevExpress.Export.ProgressMode.Always;
            this.grpTreeList.OptionsMenu.ShowConditionalFormattingItem = true;
            this.grpTreeList.OptionsView.AutoWidth = false;
            this.grpTreeList.OptionsView.ShowAutoFilterRow = true;
            this.grpTreeList.ParentFieldName = "ParentLine!Key";
            this.grpTreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.parentLookUp});
            this.grpTreeList.RootValue = null;
            this.grpTreeList.Size = new System.Drawing.Size(444, 194);
            this.grpTreeList.TabIndex = 0;
            // 
            // colLineId
            // 
            this.colLineId.FieldName = "LineId";
            this.colLineId.Name = "colLineId";
            this.colLineId.OptionsColumn.AllowEdit = false;
            this.colLineId.OptionsColumn.ReadOnly = true;
            this.colLineId.Width = 25;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowEdit = false;
            this.colCreatedBy.OptionsColumn.ReadOnly = true;
            this.colCreatedBy.Width = 25;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.OptionsColumn.AllowEdit = false;
            this.colCreatedAt.OptionsColumn.ReadOnly = true;
            this.colCreatedAt.Width = 25;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.OptionsColumn.AllowEdit = false;
            this.colModifiedBy.OptionsColumn.ReadOnly = true;
            this.colModifiedBy.Width = 25;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.OptionsColumn.AllowEdit = false;
            this.colModifiedAt.OptionsColumn.ReadOnly = true;
            this.colModifiedAt.Width = 25;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.FieldName = "ParentLine!Key";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.ReadOnly = true;
            this.treeListColumn2.Width = 87;
            // 
            // colGroupNum
            // 
            this.colGroupNum.FieldName = "GroupNum";
            this.colGroupNum.Name = "colGroupNum";
            this.colGroupNum.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colGroupNum.Visible = true;
            this.colGroupNum.VisibleIndex = 0;
            this.colGroupNum.Width = 94;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            this.colGroupName.Width = 278;
            // 
            // colAccountType
            // 
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.OptionsColumn.ReadOnly = true;
            this.colAccountType.Width = 298;
            // 
            // colParentLine
            // 
            this.colParentLine.Caption = "Parent group";
            this.colParentLine.ColumnEdit = this.parentLookUp;
            this.colParentLine.FieldName = "ParentLine!Key";
            this.colParentLine.Name = "colParentLine";
            this.colParentLine.Visible = true;
            this.colParentLine.VisibleIndex = 2;
            this.colParentLine.Width = 204;
            // 
            // parentLookUp
            // 
            this.parentLookUp.AutoHeight = false;
            this.parentLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parentLookUp.CascadingMember = "AccountType";
            this.parentLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupNum", "Group Num", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupName", "Group Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.parentLookUp.DataSource = this.grpXPC;
            this.parentLookUp.DisplayMember = "GroupName";
            this.parentLookUp.KeyMember = "LineId";
            this.parentLookUp.Name = "parentLookUp";
            this.parentLookUp.ValueMember = "LineId";
            // 
            // ref1TPage
            // 
            this.ref1TPage.Name = "ref1TPage";
            this.ref1TPage.Size = new System.Drawing.Size(444, 221);
            this.ref1TPage.Text = "Reference one";
            // 
            // ref2TPage
            // 
            this.ref2TPage.Name = "ref2TPage";
            this.ref2TPage.Size = new System.Drawing.Size(444, 221);
            this.ref2TPage.Text = "Reference two";
            // 
            // accountTypeImageCombo
            // 
            this.accountTypeImageCombo.Location = new System.Drawing.Point(98, 3);
            this.accountTypeImageCombo.Name = "accountTypeImageCombo";
            this.accountTypeImageCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountTypeImageCombo.Size = new System.Drawing.Size(134, 20);
            this.accountTypeImageCombo.TabIndex = 6;
            // 
            // AccountGroupingXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.accountTypeImageCombo);
            this.Name = "AccountGroupingXUC";
            this.Size = new System.Drawing.Size(474, 298);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.grpTPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeImageCombo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.XPCollection grpXPC;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage ref1TPage;
        private DevExpress.XtraTab.XtraTabPage grpTPage;
        private DevExpress.XtraTab.XtraTabPage ref2TPage;
        private DevExpress.XtraEditors.ImageComboBoxEdit accountTypeImageCombo;
        private System.Windows.Forms.BindingSource grpBS;
        private DevExpress.XtraTreeList.TreeList grpTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLineId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreatedBy;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreatedAt;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModifiedBy;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModifiedAt;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGroupNum;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGroupName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAccountType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentLine;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit parentLookUp;
        private DevExpress.XtraEditors.DataNavigator grpDataNavigator;
    }
}
