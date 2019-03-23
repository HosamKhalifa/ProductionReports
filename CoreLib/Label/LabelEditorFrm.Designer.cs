namespace CoreLib.Label
{
    partial class LabelEditorFrm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.labelsMyGV = new CoreLib.Grid.MyGridView();
            this.colLabelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelEdt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLang_en = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLang_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLang_fr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLabelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.myGridControl1 = new CoreLib.Grid.MyGridControl();
            this.xpCollectionExt1 = new CoreLib.Xpo.XPCollectionExt();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.objectMyGV = new CoreLib.Grid.MyGridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssemblyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.syuncBtn = new DevExpress.XtraEditors.SimpleButton();
            this.buildClassListBtn = new DevExpress.XtraEditors.SimpleButton();
            this.buildMembersBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.labelsMyGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelEdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectMyGV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsMyGV
            // 
            this.labelsMyGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLabelId,
            this.colLang_en,
            this.colLang_ar,
            this.colLang_fr,
            this.colLabelType,
            this.gridColumn1,
            this.gridColumn2,
            this.colFieldName});
            this.labelsMyGV.GridControl = this.myGridControl1;
            this.labelsMyGV.Name = "labelsMyGV";
            this.labelsMyGV.OptionsEditForm.EditFormColumnCount = 2;
            this.labelsMyGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colLabelId
            // 
            this.colLabelId.ColumnEdit = this.LabelEdt;
            this.colLabelId.FieldName = "LabelId";
            this.colLabelId.Name = "colLabelId";
            this.colLabelId.Visible = true;
            this.colLabelId.VisibleIndex = 0;
            this.colLabelId.Width = 92;
            // 
            // LabelEdt
            // 
            this.LabelEdt.AutoHeight = false;
            this.LabelEdt.Mask.EditMask = "@\\d{6}";
            this.LabelEdt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.LabelEdt.Name = "LabelEdt";
            // 
            // colLang_en
            // 
            this.colLang_en.FieldName = "Lang_en";
            this.colLang_en.Name = "colLang_en";
            this.colLang_en.OptionsEditForm.VisibleIndex = 30;
            this.colLang_en.Visible = true;
            this.colLang_en.VisibleIndex = 3;
            this.colLang_en.Width = 188;
            // 
            // colLang_ar
            // 
            this.colLang_ar.FieldName = "Lang_ar";
            this.colLang_ar.Name = "colLang_ar";
            this.colLang_ar.OptionsEditForm.VisibleIndex = 40;
            this.colLang_ar.Visible = true;
            this.colLang_ar.VisibleIndex = 4;
            this.colLang_ar.Width = 220;
            // 
            // colLang_fr
            // 
            this.colLang_fr.FieldName = "Lang_fr";
            this.colLang_fr.Name = "colLang_fr";
            this.colLang_fr.OptionsEditForm.VisibleIndex = 50;
            this.colLang_fr.Visible = true;
            this.colLang_fr.VisibleIndex = 5;
            this.colLang_fr.Width = 233;
            // 
            // colLabelType
            // 
            this.colLabelType.FieldName = "LabelType";
            this.colLabelType.Name = "colLabelType";
            this.colLabelType.Visible = true;
            this.colLabelType.VisibleIndex = 2;
            this.colLabelType.Width = 92;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ObjectName!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 132;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ObjectName!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 183;
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "FieldName";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 1;
            this.colFieldName.Width = 117;
            // 
            // myGridControl1
            // 
            this.myGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myGridControl1.DataSource = this.xpCollectionExt1;
            gridLevelNode1.LevelTemplate = this.labelsMyGV;
            gridLevelNode1.RelationName = "ObjectLabels";
            this.myGridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.myGridControl1.Location = new System.Drawing.Point(12, 35);
            this.myGridControl1.MainView = this.objectMyGV;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LabelEdt});
            this.myGridControl1.Size = new System.Drawing.Size(823, 372);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.UseEmbeddedNavigator = true;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.objectMyGV,
            this.labelsMyGV});
            // 
            // xpCollectionExt1
            // 
            this.xpCollectionExt1.ObjectType = typeof(CoreLib.Label.UIObjectBase);
            this.xpCollectionExt1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // objectMyGV
            // 
            this.objectMyGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colObjectName,
            this.colAssemblyName});
            this.objectMyGV.GridControl = this.myGridControl1;
            this.objectMyGV.Name = "objectMyGV";
            this.objectMyGV.OptionsDetail.AllowExpandEmptyDetails = true;
            this.objectMyGV.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.objectMyGV.OptionsSelection.MultiSelect = true;
            this.objectMyGV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.objectMyGV.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.objectMyGV.OptionsView.ColumnAutoWidth = false;
            this.objectMyGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 1;
            // 
            // colObjectName
            // 
            this.colObjectName.FieldName = "ObjectName";
            this.colObjectName.Name = "colObjectName";
            this.colObjectName.Visible = true;
            this.colObjectName.VisibleIndex = 2;
            this.colObjectName.Width = 442;
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.FieldName = "AssemblyName";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Visible = true;
            this.colAssemblyName.VisibleIndex = 3;
            this.colAssemblyName.Width = 197;
            // 
            // syuncBtn
            // 
            this.syuncBtn.Location = new System.Drawing.Point(174, 6);
            this.syuncBtn.Name = "syuncBtn";
            this.syuncBtn.Size = new System.Drawing.Size(75, 23);
            this.syuncBtn.TabIndex = 1;
            this.syuncBtn.Text = "Syncronize";
            this.syuncBtn.Click += new System.EventHandler(this.syuncBtn_Click);
            // 
            // buildClassListBtn
            // 
            this.buildClassListBtn.Location = new System.Drawing.Point(12, 6);
            this.buildClassListBtn.Name = "buildClassListBtn";
            this.buildClassListBtn.Size = new System.Drawing.Size(75, 23);
            this.buildClassListBtn.TabIndex = 2;
            this.buildClassListBtn.Text = "BuildClassList";
            this.buildClassListBtn.Click += new System.EventHandler(this.buildClassListBtn_Click);
            // 
            // buildMembersBtn
            // 
            this.buildMembersBtn.Location = new System.Drawing.Point(93, 6);
            this.buildMembersBtn.Name = "buildMembersBtn";
            this.buildMembersBtn.Size = new System.Drawing.Size(75, 23);
            this.buildMembersBtn.TabIndex = 3;
            this.buildMembersBtn.Text = "Build members";
            this.buildMembersBtn.Click += new System.EventHandler(this.buildMembersBtn_Click);
            // 
            // LabelEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(847, 419);
            this.Controls.Add(this.buildMembersBtn);
            this.Controls.Add(this.buildClassListBtn);
            this.Controls.Add(this.syuncBtn);
            this.Controls.Add(this.myGridControl1);
            this.Name = "LabelEditorFrm";
            this.Text = "Label Editor";
            ((System.ComponentModel.ISupportInitialize)(this.labelsMyGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelEdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectMyGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Grid.MyGridControl myGridControl1;
        private Grid.MyGridView objectMyGV;
        private Xpo.XPCollectionExt xpCollectionExt1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraEditors.SimpleButton syuncBtn;
        private Grid.MyGridView labelsMyGV;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colObjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colAssemblyName;
        private DevExpress.XtraGrid.Columns.GridColumn colLabelId;
        private DevExpress.XtraGrid.Columns.GridColumn colLang_en;
        private DevExpress.XtraGrid.Columns.GridColumn colLang_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colLang_fr;
        private DevExpress.XtraGrid.Columns.GridColumn colLabelType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton buildClassListBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit LabelEdt;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraEditors.SimpleButton buildMembersBtn;
    }
}
