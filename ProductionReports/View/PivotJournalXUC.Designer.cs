namespace ProductionReports.View
{
    partial class PivotJournalXUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotJournalXUC));
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldRecId1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLocationId1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLocationName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShiftId1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShiftName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldEquipmentName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductId1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldItemName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJournalId1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTransDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWorkingHours1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFaultsHours1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDescription1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLineDescription1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.fromBI = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.toBI = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.retrieveBI = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rptDS = new ProductionReports.View.RptDS();
            this.pRD_TransJournalLinesViewTableAdapter = new ProductionReports.View.RptDSTableAdapters.PRD_TransJournalLinesViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDS)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.bindingSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldRecId1,
            this.fieldLocationId1,
            this.fieldLocationName1,
            this.fieldShiftId1,
            this.fieldShiftName1,
            this.fieldEquipmentName1,
            this.fieldProductId1,
            this.fieldItemName1,
            this.fieldJournalId1,
            this.fieldTransDate1,
            this.fieldWorkingHours1,
            this.fieldFaultsHours1,
            this.fieldDescription1,
            this.fieldQuantity1,
            this.fieldLineDescription1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 28);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(545, 364);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldRecId1
            // 
            this.fieldRecId1.AreaIndex = 0;
            this.fieldRecId1.FieldName = "RecId";
            this.fieldRecId1.Name = "fieldRecId1";
            // 
            // fieldLocationId1
            // 
            this.fieldLocationId1.AreaIndex = 1;
            this.fieldLocationId1.FieldName = "LocationId";
            this.fieldLocationId1.Name = "fieldLocationId1";
            // 
            // fieldLocationName1
            // 
            this.fieldLocationName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldLocationName1.AreaIndex = 0;
            this.fieldLocationName1.FieldName = "LocationName";
            this.fieldLocationName1.Name = "fieldLocationName1";
            this.fieldLocationName1.Width = 72;
            // 
            // fieldShiftId1
            // 
            this.fieldShiftId1.AreaIndex = 9;
            this.fieldShiftId1.FieldName = "ShiftId";
            this.fieldShiftId1.Name = "fieldShiftId1";
            // 
            // fieldShiftName1
            // 
            this.fieldShiftName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShiftName1.AreaIndex = 0;
            this.fieldShiftName1.FieldName = "ShiftName";
            this.fieldShiftName1.Name = "fieldShiftName1";
            // 
            // fieldEquipmentName1
            // 
            this.fieldEquipmentName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldEquipmentName1.AreaIndex = 1;
            this.fieldEquipmentName1.FieldName = "EquipmentName";
            this.fieldEquipmentName1.Name = "fieldEquipmentName1";
            // 
            // fieldProductId1
            // 
            this.fieldProductId1.AreaIndex = 2;
            this.fieldProductId1.FieldName = "ProductId";
            this.fieldProductId1.Name = "fieldProductId1";
            // 
            // fieldItemName1
            // 
            this.fieldItemName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldItemName1.AreaIndex = 2;
            this.fieldItemName1.FieldName = "ItemName";
            this.fieldItemName1.Name = "fieldItemName1";
            // 
            // fieldJournalId1
            // 
            this.fieldJournalId1.AreaIndex = 3;
            this.fieldJournalId1.FieldName = "JournalId";
            this.fieldJournalId1.Name = "fieldJournalId1";
            // 
            // fieldTransDate1
            // 
            this.fieldTransDate1.AreaIndex = 4;
            this.fieldTransDate1.FieldName = "TransDate";
            this.fieldTransDate1.Name = "fieldTransDate1";
            // 
            // fieldWorkingHours1
            // 
            this.fieldWorkingHours1.AreaIndex = 5;
            this.fieldWorkingHours1.FieldName = "WorkingHours";
            this.fieldWorkingHours1.Name = "fieldWorkingHours1";
            // 
            // fieldFaultsHours1
            // 
            this.fieldFaultsHours1.AreaIndex = 6;
            this.fieldFaultsHours1.FieldName = "FaultsHours";
            this.fieldFaultsHours1.Name = "fieldFaultsHours1";
            // 
            // fieldDescription1
            // 
            this.fieldDescription1.AreaIndex = 7;
            this.fieldDescription1.FieldName = "Description";
            this.fieldDescription1.Name = "fieldDescription1";
            // 
            // fieldQuantity1
            // 
            this.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity1.AreaIndex = 0;
            this.fieldQuantity1.FieldName = "Quantity";
            this.fieldQuantity1.Name = "fieldQuantity1";
            this.fieldQuantity1.ValueFormat.FormatString = "#.##";
            this.fieldQuantity1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldLineDescription1
            // 
            this.fieldLineDescription1.AreaIndex = 8;
            this.fieldLineDescription1.FieldName = "LineDescription";
            this.fieldLineDescription1.Name = "fieldLineDescription1";
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.fromBI,
            this.toBI,
            this.retrieveBI});
            this.barManager1.MaxItemId = 3;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.fromBI, "", false, true, true, 110),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.toBI, "", false, true, true, 106),
            new DevExpress.XtraBars.LinkPersistInfo(this.retrieveBI)});
            this.bar1.Text = "Tools";
            // 
            // fromBI
            // 
            this.fromBI.Caption = "From:";
            this.fromBI.Edit = this.repositoryItemDateEdit1;
            this.fromBI.Id = 0;
            this.fromBI.Name = "fromBI";
            this.fromBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // toBI
            // 
            this.toBI.Caption = "To:";
            this.toBI.Edit = this.repositoryItemDateEdit2;
            this.toBI.Id = 1;
            this.toBI.Name = "toBI";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // retrieveBI
            // 
            this.retrieveBI.Caption = "Retrieve";
            this.retrieveBI.Glyph = ((System.Drawing.Image)(resources.GetObject("retrieveBI.Glyph")));
            this.retrieveBI.Id = 2;
            this.retrieveBI.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("retrieveBI.LargeGlyph")));
            this.retrieveBI.Name = "retrieveBI";
            this.retrieveBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.retrieveBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.retrieveBI_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(545, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 392);
            this.barDockControlBottom.Size = new System.Drawing.Size(545, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 364);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(545, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 364);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "PRD_TransJournalLinesView";
            this.bindingSource1.DataSource = this.rptDS;
            // 
            // rptDS
            // 
            this.rptDS.DataSetName = "RptDS";
            this.rptDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRD_TransJournalLinesViewTableAdapter
            // 
            this.pRD_TransJournalLinesViewTableAdapter.ClearBeforeFill = true;
            // 
            // PivotJournalXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PivotJournalXUC";
            this.Size = new System.Drawing.Size(545, 414);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem fromBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem toBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem retrieveBI;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRecId1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLocationId1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLocationName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShiftId1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShiftName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldEquipmentName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductId1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldItemName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJournalId1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTransDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWorkingHours1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFaultsHours1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDescription1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLineDescription1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RptDS rptDS;
        private RptDSTableAdapters.PRD_TransJournalLinesViewTableAdapter pRD_TransJournalLinesViewTableAdapter;
    }
}
