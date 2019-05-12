namespace CoreModelWin.View.Shared
{
    partial class AccountBase
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
            this.mainTabC = new DevExpress.XtraTab.XtraTabControl();
            this.overviewTabG = new DevExpress.XtraTab.XtraTabPage();
            this.accountBaseGC = new CoreLib.Grid.MyGridControl();
            this.accountBaseBS = new System.Windows.Forms.BindingSource(this.components);
            this.accountBaseXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.accountBaseGV = new CoreLib.Grid.MyGridView();
            this.colWorkflowStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefNo1_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.generalTabG = new DevExpress.XtraTab.XtraTabPage();
            this.accountBaseLineXUC2 = new CoreModelWin.View.Sales.AccountBaseLineXUC();
            this.accountBaseXUC1 = new CoreModelWin.View.Shared.AccountBaseXUC();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabC)).BeginInit();
            this.mainTabC.SuspendLayout();
            this.overviewTabG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGV)).BeginInit();
            this.generalTabG.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabC
            // 
            this.mainTabC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabC.Location = new System.Drawing.Point(444, 176);
            this.mainTabC.Name = "mainTabC";
            this.mainTabC.SelectedTabPage = this.overviewTabG;
            this.mainTabC.Size = new System.Drawing.Size(352, 249);
            this.mainTabC.TabIndex = 0;
            this.mainTabC.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.overviewTabG,
            this.generalTabG});
            this.mainTabC.Visible = false;
            // 
            // overviewTabG
            // 
            this.overviewTabG.Controls.Add(this.accountBaseGC);
            this.overviewTabG.Name = "overviewTabG";
            this.overviewTabG.Size = new System.Drawing.Size(346, 221);
            this.overviewTabG.Text = "Overview";
            // 
            // accountBaseGC
            // 
            this.accountBaseGC.DataSource = this.accountBaseBS;
            this.accountBaseGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountBaseGC.Location = new System.Drawing.Point(0, 0);
            this.accountBaseGC.MainView = this.accountBaseGV;
            this.accountBaseGC.Name = "accountBaseGC";
            this.accountBaseGC.Size = new System.Drawing.Size(346, 221);
            this.accountBaseGC.TabIndex = 0;
            this.accountBaseGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accountBaseGV});
            // 
            // accountBaseBS
            // 
            this.accountBaseBS.DataSource = this.accountBaseXPC;
            // 
            // accountBaseXPC
            // 
            this.accountBaseXPC.LoadingEnabled = false;
            this.accountBaseXPC.ObjectType = typeof(CoreModel.Account);
            this.accountBaseXPC.Session = this.unitOfWork1;
            // 
            // accountBaseGV
            // 
            this.accountBaseGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWorkflowStatus,
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colDisplayNumber,
            this.colName,
            this.colDescription,
            this.colActive,
            this.colRefNo1_Name,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.colReferenceNumber,
            this.gridColumn11,
            this.gridColumn12});
            this.accountBaseGV.CustomizationFormBounds = new System.Drawing.Rectangle(630, 389, 216, 183);
            this.accountBaseGV.EnableAutoFormat = false;
            this.accountBaseGV.EnableAutoSave = true;
            this.accountBaseGV.GridControl = this.accountBaseGC;
            this.accountBaseGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.SimpleEdit;
            this.accountBaseGV.Name = "accountBaseGV";
            this.accountBaseGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.accountBaseGV.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Cached;
            this.accountBaseGV.OptionsEditForm.EditFormColumnCount = 2;
            this.accountBaseGV.OptionsMenu.ShowConditionalFormattingItem = true;
            this.accountBaseGV.OptionsView.ColumnAutoWidth = false;
            this.accountBaseGV.OptionsView.EnableAppearanceEvenRow = true;
            this.accountBaseGV.OptionsView.ShowAutoFilterRow = true;
            this.accountBaseGV.OptionsView.ShowFooter = true;
            this.accountBaseGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colWorkflowStatus
            // 
            this.colWorkflowStatus.Caption = "Status";
            this.colWorkflowStatus.FieldName = "WorkflowStatus";
            this.colWorkflowStatus.Name = "colWorkflowStatus";
            this.colWorkflowStatus.Visible = true;
            this.colWorkflowStatus.VisibleIndex = 0;
            // 
            // colLineId
            // 
            this.colLineId.FieldName = "LineId";
            this.colLineId.Name = "colLineId";
            this.colLineId.OptionsColumn.AllowEdit = false;
            this.colLineId.OptionsColumn.ReadOnly = true;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowEdit = false;
            this.colCreatedBy.OptionsColumn.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.OptionsColumn.AllowEdit = false;
            this.colCreatedAt.OptionsColumn.ReadOnly = true;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.OptionsColumn.AllowEdit = false;
            this.colModifiedBy.OptionsColumn.ReadOnly = true;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.OptionsColumn.AllowEdit = false;
            this.colModifiedAt.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "TableId!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "TableId!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "DimensionHeader!";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "DimensionHeader!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            // 
            // colDisplayNumber
            // 
            this.colDisplayNumber.FieldName = "DisplayNumber";
            this.colDisplayNumber.Name = "colDisplayNumber";
            this.colDisplayNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DisplayNumber", "{0}")});
            this.colDisplayNumber.Visible = true;
            this.colDisplayNumber.VisibleIndex = 1;
            this.colDisplayNumber.Width = 88;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 166;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 130;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 43;
            // 
            // colRefNo1_Name
            // 
            this.colRefNo1_Name.Caption = "Ref 1 name";
            this.colRefNo1_Name.FieldName = "ReferenceNumber1.RefNo1Name";
            this.colRefNo1_Name.Name = "colRefNo1_Name";
            this.colRefNo1_Name.OptionsColumn.AllowEdit = false;
            this.colRefNo1_Name.OptionsColumn.ReadOnly = true;
            this.colRefNo1_Name.Visible = true;
            this.colRefNo1_Name.VisibleIndex = 7;
            this.colRefNo1_Name.Width = 109;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "ReferenceNumber1!Key";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 111;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ref 2 name";
            this.gridColumn7.FieldName = "ReferenceNumber2.RefNo1Name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 109;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "ReferenceNumber2!Key";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Primary group";
            this.gridColumn9.FieldName = "GroupId.GroupName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 111;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "GroupId!Key";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.FieldName = "ReferenceNumber";
            this.colReferenceNumber.Name = "colReferenceNumber";
            this.colReferenceNumber.Visible = true;
            this.colReferenceNumber.VisibleIndex = 2;
            this.colReferenceNumber.Width = 102;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "PrimaryAddress!";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            this.gridColumn11.Width = 103;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "PrimaryAddress!Key";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 10;
            // 
            // generalTabG
            // 
            this.generalTabG.Controls.Add(this.accountBaseLineXUC2);
            this.generalTabG.Name = "generalTabG";
            this.generalTabG.Size = new System.Drawing.Size(346, 221);
            this.generalTabG.Text = "General";
            // 
            // accountBaseLineXUC2
            // 
            this.accountBaseLineXUC2.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountBaseLineXUC2.Location = new System.Drawing.Point(0, 0);
            this.accountBaseLineXUC2.Name = "accountBaseLineXUC2";
            this.accountBaseLineXUC2.Size = new System.Drawing.Size(346, 460);
            this.accountBaseLineXUC2.TabIndex = 0;
            // 
            // accountBaseXUC1
            // 
            this.accountBaseXUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountBaseXUC1.Location = new System.Drawing.Point(12, 12);
            this.accountBaseXUC1.Name = "accountBaseXUC1";
            this.accountBaseXUC1.Size = new System.Drawing.Size(862, 413);
            this.accountBaseXUC1.TabIndex = 1;
            // 
            // AccountBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(886, 437);
            this.Controls.Add(this.accountBaseXUC1);
            this.Controls.Add(this.mainTabC);
            this.Name = "AccountBase";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabC)).EndInit();
            this.mainTabC.ResumeLayout(false);
            this.overviewTabG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGV)).EndInit();
            this.generalTabG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage overviewTabG;
        public DevExpress.XtraTab.XtraTabControl mainTabC;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNo1_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        public CoreLib.Grid.MyGridControl accountBaseGC;
        public CoreLib.Grid.MyGridView accountBaseGV;
        public DevExpress.Xpo.XPCollection accountBaseXPC;
        private System.Windows.Forms.BindingSource accountBaseBS;
        
        private DevExpress.XtraTab.XtraTabPage generalTabG;
        private Sales.AccountBaseLineXUC accountBaseLineXUC2;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkflowStatus;
        private AccountBaseXUC accountBaseXUC1;
    }
}
