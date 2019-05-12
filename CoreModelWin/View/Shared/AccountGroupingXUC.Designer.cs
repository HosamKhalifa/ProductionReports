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
            this.ref1DataNavigator = new DevExpress.XtraEditors.DataNavigator();
            this.ref1BS = new System.Windows.Forms.BindingSource(this.components);
            this.ref1XPC = new DevExpress.Xpo.XPCollection(this.components);
            this.ref1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colRefNo1Num = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRefNo1Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAccountType1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRefNo1ParentLine = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RefNo1Lookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLineId_ref1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ref2TPage = new DevExpress.XtraTab.XtraTabPage();
            this.ref2DataNavigator = new DevExpress.XtraEditors.DataNavigator();
            this.ref2BS = new System.Windows.Forms.BindingSource(this.components);
            this.ref2XPC = new DevExpress.Xpo.XPCollection(this.components);
            this.ref2TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colRefNo2Num = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRefNo1Name1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAccountType2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRefNo2ParentLine = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.RefNo2ParentLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLineId_ref2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.accountTypeImageCombo = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.grpTPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentLookUp)).BeginInit();
            this.ref1TPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ref1BS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref1XPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefNo1Lookup)).BeginInit();
            this.ref2TPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ref2BS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref2XPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref2TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefNo2ParentLookup)).BeginInit();
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 29);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.grpTPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(708, 365);
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
            this.grpTPage.Size = new System.Drawing.Size(702, 337);
            this.grpTPage.Text = "Primary group";
            // 
            // grpDataNavigator
            // 
            this.grpDataNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataNavigator.DataSource = this.grpBS;
            this.grpDataNavigator.Location = new System.Drawing.Point(3, 310);
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
            this.grpTreeList.Size = new System.Drawing.Size(702, 310);
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
            this.ref1TPage.Controls.Add(this.ref1DataNavigator);
            this.ref1TPage.Controls.Add(this.ref1TreeList);
            this.ref1TPage.Name = "ref1TPage";
            this.ref1TPage.Size = new System.Drawing.Size(702, 337);
            this.ref1TPage.Text = "Reference one";
            // 
            // ref1DataNavigator
            // 
            this.ref1DataNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ref1DataNavigator.DataSource = this.ref1BS;
            this.ref1DataNavigator.Location = new System.Drawing.Point(3, 310);
            this.ref1DataNavigator.Name = "ref1DataNavigator";
            this.ref1DataNavigator.Size = new System.Drawing.Size(160, 24);
            this.ref1DataNavigator.TabIndex = 4;
            this.ref1DataNavigator.Text = "Group";
            // 
            // ref1BS
            // 
            this.ref1BS.DataSource = this.ref1XPC;
            // 
            // ref1XPC
            // 
            this.ref1XPC.LoadingEnabled = false;
            this.ref1XPC.ObjectType = typeof(CoreModel.AccountRef1);
            this.ref1XPC.Session = this.unitOfWork1;
            // 
            // ref1TreeList
            // 
            this.ref1TreeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ref1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colRefNo1Num,
            this.colRefNo1Name,
            this.colAccountType1,
            this.colRefNo1ParentLine,
            this.colLineId_ref1});
            this.ref1TreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ref1TreeList.DataSource = this.ref1BS;
            this.ref1TreeList.KeyFieldName = "LineId";
            this.ref1TreeList.Location = new System.Drawing.Point(0, 0);
            this.ref1TreeList.Name = "ref1TreeList";
            this.ref1TreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.ref1TreeList.OptionsView.AutoWidth = false;
            this.ref1TreeList.OptionsView.ShowAutoFilterRow = true;
            this.ref1TreeList.ParentFieldName = "ParentLine!Key";
            this.ref1TreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RefNo1Lookup});
            this.ref1TreeList.Size = new System.Drawing.Size(702, 310);
            this.ref1TreeList.TabIndex = 0;
            // 
            // colRefNo1Num
            // 
            this.colRefNo1Num.Caption = "Num";
            this.colRefNo1Num.FieldName = "RefNo1Num";
            this.colRefNo1Num.Name = "colRefNo1Num";
            this.colRefNo1Num.Visible = true;
            this.colRefNo1Num.VisibleIndex = 0;
            this.colRefNo1Num.Width = 68;
            // 
            // colRefNo1Name
            // 
            this.colRefNo1Name.Caption = "Name";
            this.colRefNo1Name.FieldName = "RefNo1Name";
            this.colRefNo1Name.Name = "colRefNo1Name";
            this.colRefNo1Name.Visible = true;
            this.colRefNo1Name.VisibleIndex = 1;
            this.colRefNo1Name.Width = 207;
            // 
            // colAccountType1
            // 
            this.colAccountType1.FieldName = "AccountType";
            this.colAccountType1.Name = "colAccountType1";
            this.colAccountType1.OptionsColumn.AllowEdit = false;
            this.colAccountType1.OptionsColumn.ReadOnly = true;
            this.colAccountType1.Width = 192;
            // 
            // colRefNo1ParentLine
            // 
            this.colRefNo1ParentLine.Caption = "Parent";
            this.colRefNo1ParentLine.ColumnEdit = this.RefNo1Lookup;
            this.colRefNo1ParentLine.FieldName = "ParentLine!Key";
            this.colRefNo1ParentLine.Name = "colRefNo1ParentLine";
            this.colRefNo1ParentLine.Visible = true;
            this.colRefNo1ParentLine.VisibleIndex = 2;
            this.colRefNo1ParentLine.Width = 410;
            // 
            // RefNo1Lookup
            // 
            this.RefNo1Lookup.AutoHeight = false;
            this.RefNo1Lookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RefNo1Lookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo1Num", "Ref No1Num", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo1Name", "Ref No1Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.RefNo1Lookup.DataSource = this.ref1BS;
            this.RefNo1Lookup.DisplayMember = "RefNo1Name";
            this.RefNo1Lookup.KeyMember = "LineId";
            this.RefNo1Lookup.Name = "RefNo1Lookup";
            this.RefNo1Lookup.ValueMember = "LineId";
            // 
            // colLineId_ref1
            // 
            this.colLineId_ref1.Caption = "LineId";
            this.colLineId_ref1.FieldName = "LineId";
            this.colLineId_ref1.Name = "colLineId_ref1";
            this.colLineId_ref1.OptionsColumn.AllowEdit = false;
            this.colLineId_ref1.OptionsColumn.ReadOnly = true;
            // 
            // ref2TPage
            // 
            this.ref2TPage.Controls.Add(this.ref2DataNavigator);
            this.ref2TPage.Controls.Add(this.ref2TreeList);
            this.ref2TPage.Name = "ref2TPage";
            this.ref2TPage.Size = new System.Drawing.Size(702, 337);
            this.ref2TPage.Text = "Reference two";
            // 
            // ref2DataNavigator
            // 
            this.ref2DataNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ref2DataNavigator.DataSource = this.ref2BS;
            this.ref2DataNavigator.Location = new System.Drawing.Point(3, 310);
            this.ref2DataNavigator.Name = "ref2DataNavigator";
            this.ref2DataNavigator.Size = new System.Drawing.Size(160, 24);
            this.ref2DataNavigator.TabIndex = 5;
            this.ref2DataNavigator.Text = "Group";
            // 
            // ref2BS
            // 
            this.ref2BS.DataSource = this.ref2XPC;
            // 
            // ref2XPC
            // 
            this.ref2XPC.LoadingEnabled = false;
            this.ref2XPC.ObjectType = typeof(CoreModel.AccountRef2);
            this.ref2XPC.Session = this.unitOfWork1;
            // 
            // ref2TreeList
            // 
            this.ref2TreeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ref2TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colRefNo2Num,
            this.colRefNo1Name1,
            this.colAccountType2,
            this.colRefNo2ParentLine,
            this.colLineId_ref2});
            this.ref2TreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ref2TreeList.DataSource = this.ref2BS;
            this.ref2TreeList.KeyFieldName = "LineId";
            this.ref2TreeList.Location = new System.Drawing.Point(0, 0);
            this.ref2TreeList.Name = "ref2TreeList";
            this.ref2TreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.ref2TreeList.OptionsView.AutoWidth = false;
            this.ref2TreeList.OptionsView.ShowAutoFilterRow = true;
            this.ref2TreeList.ParentFieldName = "ParentLine!Key";
            this.ref2TreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RefNo2ParentLookup});
            this.ref2TreeList.Size = new System.Drawing.Size(702, 310);
            this.ref2TreeList.TabIndex = 0;
            // 
            // colRefNo2Num
            // 
            this.colRefNo2Num.Caption = "Num";
            this.colRefNo2Num.FieldName = "RefNo2Num";
            this.colRefNo2Num.Name = "colRefNo2Num";
            this.colRefNo2Num.Visible = true;
            this.colRefNo2Num.VisibleIndex = 0;
            this.colRefNo2Num.Width = 73;
            // 
            // colRefNo1Name1
            // 
            this.colRefNo1Name1.Caption = "Name";
            this.colRefNo1Name1.FieldName = "RefNo1Name";
            this.colRefNo1Name1.Name = "colRefNo1Name1";
            this.colRefNo1Name1.Visible = true;
            this.colRefNo1Name1.VisibleIndex = 1;
            this.colRefNo1Name1.Width = 220;
            // 
            // colAccountType2
            // 
            this.colAccountType2.FieldName = "AccountType";
            this.colAccountType2.Name = "colAccountType2";
            this.colAccountType2.OptionsColumn.AllowEdit = false;
            this.colAccountType2.OptionsColumn.ReadOnly = true;
            this.colAccountType2.Width = 27;
            // 
            // colRefNo2ParentLine
            // 
            this.colRefNo2ParentLine.Caption = "Parent";
            this.colRefNo2ParentLine.ColumnEdit = this.RefNo2ParentLookup;
            this.colRefNo2ParentLine.FieldName = "ParentLine!Key";
            this.colRefNo2ParentLine.Name = "colRefNo2ParentLine";
            this.colRefNo2ParentLine.Visible = true;
            this.colRefNo2ParentLine.VisibleIndex = 2;
            this.colRefNo2ParentLine.Width = 251;
            // 
            // RefNo2ParentLookup
            // 
            this.RefNo2ParentLookup.AutoHeight = false;
            this.RefNo2ParentLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RefNo2ParentLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo2Num", "Ref No2Num", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo1Name", "Ref No1Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.RefNo2ParentLookup.DataSource = this.ref2BS;
            this.RefNo2ParentLookup.DisplayMember = "RefNo1Name";
            this.RefNo2ParentLookup.KeyMember = "LineId";
            this.RefNo2ParentLookup.Name = "RefNo2ParentLookup";
            this.RefNo2ParentLookup.ValueMember = "LineId";
            // 
            // colLineId_ref2
            // 
            this.colLineId_ref2.Caption = "treeListColumn1";
            this.colLineId_ref2.FieldName = "LineId";
            this.colLineId_ref2.Name = "colLineId_ref2";
            this.colLineId_ref2.OptionsColumn.AllowEdit = false;
            this.colLineId_ref2.OptionsColumn.ReadOnly = true;
            // 
            // accountTypeImageCombo
            // 
            this.accountTypeImageCombo.Location = new System.Drawing.Point(13, 3);
            this.accountTypeImageCombo.Name = "accountTypeImageCombo";
            this.accountTypeImageCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountTypeImageCombo.Size = new System.Drawing.Size(219, 20);
            this.accountTypeImageCombo.TabIndex = 6;
            // 
            // AccountGroupingXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.accountTypeImageCombo);
            this.Name = "AccountGroupingXUC";
            this.Size = new System.Drawing.Size(732, 414);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMyXUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.grpTPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentLookUp)).EndInit();
            this.ref1TPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ref1BS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref1XPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefNo1Lookup)).EndInit();
            this.ref2TPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ref2BS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref2XPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref2TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefNo2ParentLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeImageCombo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.XPCollection grpXPC;
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
        private DevExpress.XtraTreeList.TreeList ref1TreeList;
        private DevExpress.XtraTreeList.TreeList ref2TreeList;
        private DevExpress.Xpo.XPCollection ref1XPC;
        private DevExpress.Xpo.XPCollection ref2XPC;
        private System.Windows.Forms.BindingSource ref1BS;
        private System.Windows.Forms.BindingSource ref2BS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo1Num;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo1Name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAccountType1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo1ParentLine;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RefNo1Lookup;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo2Num;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo1Name1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAccountType2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo2ParentLine;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RefNo2ParentLookup;
        private DevExpress.XtraEditors.DataNavigator ref1DataNavigator;
        private DevExpress.XtraEditors.DataNavigator ref2DataNavigator;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLineId_ref1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLineId_ref2;
    }
}
