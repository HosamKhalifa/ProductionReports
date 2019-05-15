namespace CoreModelWin.AppLists
{
    partial class AppListPredefined
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppListPredefined));
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SharedPR = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.accountGroupTreeList = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colGroupNum = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colGroupName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAccountType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.accountRef1TreeList = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colRefNo1Num = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRefNo1Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAccountType1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.accountRef2TreeList = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.repositoryItemTreeListLookUpEdit2TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colRefNo2Num = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRefNo1Name1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAccountType2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.workflowImgList = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRef1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRef2TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit2TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflowImgList)).BeginInit();
            this.SuspendLayout();
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(CoreModel.AccountRef2);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.xpCollection1;
            // 
            // SharedPR
            // 
            this.SharedPR.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.accountGroupTreeList,
            this.accountRef1TreeList,
            this.accountRef2TreeList});
            // 
            // accountGroupTreeList
            // 
            this.accountGroupTreeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountGroupTreeList.DataSource = this.bindingSource1;
            this.accountGroupTreeList.DisplayMember = "GroupName";
            this.accountGroupTreeList.KeyMember = "LineId";
            this.accountGroupTreeList.Name = "accountGroupTreeList";
            this.accountGroupTreeList.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            this.accountGroupTreeList.ValueMember = "LineId";
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colGroupNum,
            this.colGroupName,
            this.colAccountType});
            this.repositoryItemTreeListLookUpEdit1TreeList.DataSource = this.bindingSource1;
            this.repositoryItemTreeListLookUpEdit1TreeList.KeyFieldName = "LineId";
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.AutoWidth = false;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.EnableAppearanceOddRow = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.ParentFieldName = "ParentLine!Key";
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colGroupNum
            // 
            this.colGroupNum.FieldName = "GroupNum";
            this.colGroupNum.Name = "colGroupNum";
            this.colGroupNum.Visible = true;
            this.colGroupNum.VisibleIndex = 0;
            this.colGroupNum.Width = 201;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            this.colGroupName.Width = 866;
            // 
            // colAccountType
            // 
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.Width = 24;
            // 
            // accountRef1TreeList
            // 
            this.accountRef1TreeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountRef1TreeList.DataSource = this.bindingSource1;
            this.accountRef1TreeList.DisplayMember = "RefNo1Name";
            this.accountRef1TreeList.KeyMember = "LineId";
            this.accountRef1TreeList.Name = "accountRef1TreeList";
            this.accountRef1TreeList.TreeList = this.treeList1;
            this.accountRef1TreeList.ValueMember = "LineId";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colRefNo1Num,
            this.colRefNo1Name,
            this.colAccountType1});
            this.treeList1.DataSource = this.bindingSource1;
            this.treeList1.KeyFieldName = "LineId";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsView.AutoWidth = false;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowAutoFilterRow = true;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.ParentFieldName = "ParentLine!Key";
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
            // 
            // colRefNo1Num
            // 
            this.colRefNo1Num.FieldName = "RefNo1Num";
            this.colRefNo1Num.Name = "colRefNo1Num";
            this.colRefNo1Num.Visible = true;
            this.colRefNo1Num.VisibleIndex = 0;
            this.colRefNo1Num.Width = 117;
            // 
            // colRefNo1Name
            // 
            this.colRefNo1Name.FieldName = "RefNo1Name";
            this.colRefNo1Name.Name = "colRefNo1Name";
            this.colRefNo1Name.Visible = true;
            this.colRefNo1Name.VisibleIndex = 1;
            this.colRefNo1Name.Width = 329;
            // 
            // colAccountType1
            // 
            this.colAccountType1.FieldName = "AccountType";
            this.colAccountType1.Name = "colAccountType1";
            this.colAccountType1.Width = 24;
            // 
            // accountRef2TreeList
            // 
            this.accountRef2TreeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountRef2TreeList.DataSource = this.bindingSource1;
            this.accountRef2TreeList.DisplayMember = "RefNo1Name";
            this.accountRef2TreeList.KeyMember = "LineId";
            this.accountRef2TreeList.Name = "accountRef2TreeList";
            this.accountRef2TreeList.TreeList = this.repositoryItemTreeListLookUpEdit2TreeList;
            this.accountRef2TreeList.ValueMember = "LineId";
            // 
            // repositoryItemTreeListLookUpEdit2TreeList
            // 
            this.repositoryItemTreeListLookUpEdit2TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colRefNo2Num,
            this.colRefNo1Name1,
            this.colAccountType2});
            this.repositoryItemTreeListLookUpEdit2TreeList.DataSource = this.bindingSource1;
            this.repositoryItemTreeListLookUpEdit2TreeList.KeyFieldName = "LineId";
            this.repositoryItemTreeListLookUpEdit2TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit2TreeList.Name = "repositoryItemTreeListLookUpEdit2TreeList";
            this.repositoryItemTreeListLookUpEdit2TreeList.OptionsBehavior.EnableFiltering = true;
            this.repositoryItemTreeListLookUpEdit2TreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.repositoryItemTreeListLookUpEdit2TreeList.OptionsView.AutoWidth = false;
            this.repositoryItemTreeListLookUpEdit2TreeList.OptionsView.EnableAppearanceOddRow = true;
            this.repositoryItemTreeListLookUpEdit2TreeList.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemTreeListLookUpEdit2TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit2TreeList.ParentFieldName = "ParentLine!Key";
            this.repositoryItemTreeListLookUpEdit2TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit2TreeList.TabIndex = 0;
            // 
            // colRefNo2Num
            // 
            this.colRefNo2Num.FieldName = "RefNo2Num";
            this.colRefNo2Num.Name = "colRefNo2Num";
            this.colRefNo2Num.Visible = true;
            this.colRefNo2Num.VisibleIndex = 0;
            this.colRefNo2Num.Width = 109;
            // 
            // colRefNo1Name1
            // 
            this.colRefNo1Name1.FieldName = "RefNo1Name";
            this.colRefNo1Name1.Name = "colRefNo1Name1";
            this.colRefNo1Name1.Visible = true;
            this.colRefNo1Name1.VisibleIndex = 1;
            this.colRefNo1Name1.Width = 319;
            // 
            // colAccountType2
            // 
            this.colAccountType2.FieldName = "AccountType";
            this.colAccountType2.Name = "colAccountType2";
            // 
            // workflowImgList
            // 
            this.workflowImgList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("workflowImgList.ImageStream")));
            this.workflowImgList.InsertGalleryImage("editname_16x16.png", "images/actions/editname_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_16x16.png"), 0);
            this.workflowImgList.Images.SetKeyName(0, "editname_16x16.png");
            this.workflowImgList.InsertGalleryImage("bofileattachment_16x16.png", "images/business%20objects/bofileattachment_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bofileattachment_16x16.png"), 1);
            this.workflowImgList.Images.SetKeyName(1, "bofileattachment_16x16.png");
            this.workflowImgList.InsertGalleryImage("previouscomment_16x16.png", "images/comments/previouscomment_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/comments/previouscomment_16x16.png"), 2);
            this.workflowImgList.Images.SetKeyName(2, "previouscomment_16x16.png");
            this.workflowImgList.InsertGalleryImage("checkbox_16x16.png", "images/content/checkbox_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/checkbox_16x16.png"), 3);
            this.workflowImgList.Images.SetKeyName(3, "checkbox_16x16.png");
            this.workflowImgList.InsertGalleryImage("record_16x16.png", "images/arrows/record_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/record_16x16.png"), 4);
            this.workflowImgList.Images.SetKeyName(4, "record_16x16.png");
            this.workflowImgList.InsertGalleryImage("cancel_16x16.png", "office2013/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_16x16.png"), 5);
            this.workflowImgList.Images.SetKeyName(5, "cancel_16x16.png");
            // 
            // AppListPredefined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AppListPredefined";
            this.Size = new System.Drawing.Size(420, 239);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRef1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRef2TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit2TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflowImgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.Repository.PersistentRepository SharedPR;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit accountGroupTreeList;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGroupNum;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGroupName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAccountType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit accountRef1TreeList;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit accountRef2TreeList;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit2TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo1Num;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo1Name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAccountType1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo2Num;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRefNo1Name1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAccountType2;
        private DevExpress.Utils.ImageCollection workflowImgList;
    }
}
