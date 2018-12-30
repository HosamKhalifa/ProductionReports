namespace ProductionReports.View
{
    partial class JournalXUC
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalXUC));
            this.journalLinesGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productListSLookup = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.productListXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.journalXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.shiftList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.shiftXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.journalGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaultsHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.fromBI = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.toBI = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.retrieveBI = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.journalLinesGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListSLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // journalLinesGV
            // 
            this.journalLinesGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5,
            this.colQuantity,
            this.colLineDescription});
            this.journalLinesGV.GridControl = this.gridControl1;
            this.journalLinesGV.Name = "journalLinesGV";
            this.journalLinesGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.journalLinesGV.OptionsView.ColumnAutoWidth = false;
            this.journalLinesGV.OptionsView.EnableAppearanceOddRow = true;
            this.journalLinesGV.OptionsView.ShowAutoFilterRow = true;
            this.journalLinesGV.OptionsView.ShowFooter = true;
            this.journalLinesGV.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.journalGV_InitNewRow);
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            this.colRecId.OptionsColumn.AllowEdit = false;
            this.colRecId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colRecId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RecId", "{0}")});
            this.colRecId.Visible = true;
            this.colRecId.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "JournalId!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Width = 102;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "JournalId!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Width = 125;
            // 
            // gridColumn4
            // 
            this.gridColumn4.ColumnEdit = this.productListSLookup;
            this.gridColumn4.FieldName = "ProductId!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // productListSLookup
            // 
            this.productListSLookup.AutoHeight = false;
            this.productListSLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productListSLookup.DataSource = this.productListXPC;
            this.productListSLookup.DisplayMember = "ItemName";
            this.productListSLookup.KeyMember = "ProductId";
            this.productListSLookup.Name = "productListSLookup";
            this.productListSLookup.ValueMember = "ProductId";
            this.productListSLookup.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // productListXPC
            // 
            this.productListXPC.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.productListXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.ProductList);
            this.productListXPC.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colEquipmentName,
            this.colItemName,
            this.colLocationName,
            this.colStartDate,
            this.colEndDate});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemSearchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLocationName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEquipmentName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            // 
            // colEquipmentName
            // 
            this.colEquipmentName.FieldName = "EquipmentName";
            this.colEquipmentName.Name = "colEquipmentName";
            this.colEquipmentName.Visible = true;
            this.colEquipmentName.VisibleIndex = 2;
            this.colEquipmentName.Width = 144;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 3;
            this.colItemName.Width = 190;
            // 
            // colLocationName
            // 
            this.colLocationName.FieldName = "LocationName";
            this.colLocationName.Name = "colLocationName";
            this.colLocationName.Visible = true;
            this.colLocationName.VisibleIndex = 1;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 4;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Equipment";
            this.gridColumn3.FieldName = "ProductId.EquipmentName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 118;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Location";
            this.gridColumn5.FieldName = "ProductId.LocationName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "SUM={0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            // 
            // colLineDescription
            // 
            this.colLineDescription.FieldName = "LineDescription";
            this.colLineDescription.Name = "colLineDescription";
            this.colLineDescription.Visible = true;
            this.colLineDescription.VisibleIndex = 4;
            this.colLineDescription.Width = 318;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.journalXPC;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.ExternalRepository = this.persistentRepository1;
            gridLevelNode1.LevelTemplate = this.journalLinesGV;
            gridLevelNode2.RelationName = "ProductId";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "TransJournalLines";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.journalGV;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(615, 403);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.journalGV,
            this.journalLinesGV});
            // 
            // journalXPC
            // 
            this.journalXPC.DisplayableProperties = "JournalId;ShiftId;TransDate;WorkingHours;FaultsHours;Decription;TransJournalEmplo" +
    "yeesCollection;TransJournalLines";
            this.journalXPC.LoadingEnabled = false;
            this.journalXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.TransJournal);
            this.journalXPC.Session = this.unitOfWork1;
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.shiftList,
            this.productListSLookup});
            // 
            // shiftList
            // 
            this.shiftList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shiftList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftId", "Shift Id", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftName", "Shift Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.shiftList.DataSource = this.shiftXPC;
            this.shiftList.DisplayMember = "ShiftName";
            this.shiftList.KeyMember = "ShiftId";
            this.shiftList.Name = "shiftList";
            this.shiftList.ValueMember = "ShiftId";
            // 
            // shiftXPC
            // 
            this.shiftXPC.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.shiftXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.Shift);
            this.shiftXPC.Session = this.unitOfWork1;
            // 
            // journalGV
            // 
            this.journalGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalId,
            this.colShiftId,
            this.colTransDate,
            this.colWorkingHours,
            this.colFaultsHours,
            this.colDecription});
            this.journalGV.GridControl = this.gridControl1;
            this.journalGV.Name = "journalGV";
            this.journalGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.journalGV.OptionsDetail.AllowExpandEmptyDetails = true;
            this.journalGV.OptionsView.ColumnAutoWidth = false;
            this.journalGV.OptionsView.EnableAppearanceEvenRow = true;
            this.journalGV.OptionsView.ShowAutoFilterRow = true;
            this.journalGV.OptionsView.ShowFooter = true;
            this.journalGV.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.journalGV_InitNewRow);
            // 
            // colJournalId
            // 
            this.colJournalId.FieldName = "JournalId";
            this.colJournalId.Name = "colJournalId";
            this.colJournalId.Visible = true;
            this.colJournalId.VisibleIndex = 0;
            // 
            // colShiftId
            // 
            this.colShiftId.ColumnEdit = this.shiftList;
            this.colShiftId.FieldName = "ShiftId";
            this.colShiftId.Name = "colShiftId";
            this.colShiftId.Visible = true;
            this.colShiftId.VisibleIndex = 1;
            // 
            // colTransDate
            // 
            this.colTransDate.FieldName = "TransDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 2;
            // 
            // colWorkingHours
            // 
            this.colWorkingHours.FieldName = "WorkingHours";
            this.colWorkingHours.Name = "colWorkingHours";
            this.colWorkingHours.Visible = true;
            this.colWorkingHours.VisibleIndex = 3;
            // 
            // colFaultsHours
            // 
            this.colFaultsHours.FieldName = "FaultsHours";
            this.colFaultsHours.Name = "colFaultsHours";
            this.colFaultsHours.Visible = true;
            this.colFaultsHours.VisibleIndex = 4;
            // 
            // colDecription
            // 
            this.colDecription.FieldName = "Decription";
            this.colDecription.Name = "colDecription";
            this.colDecription.Visible = true;
            this.colDecription.VisibleIndex = 5;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
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
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.fromBI, "", false, true, true, 99),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.toBI, "", false, true, true, 100),
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
            this.toBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(615, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 431);
            this.barDockControlBottom.Size = new System.Drawing.Size(615, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(615, 28);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 403);
            // 
            // JournalXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "JournalXUC";
            this.Size = new System.Drawing.Size(615, 431);
            ((System.ComponentModel.ISupportInitialize)(this.journalLinesGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListSLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Xpo.XPCollection journalXPC;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Views.Grid.GridView journalGV;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalId;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingHours;
        private DevExpress.XtraGrid.Columns.GridColumn colFaultsHours;
        private DevExpress.XtraGrid.Columns.GridColumn colDecription;
        private DevExpress.XtraBars.BarEditItem fromBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem toBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem retrieveBI;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit shiftList;
        private DevExpress.Xpo.XPCollection shiftXPC;
        private DevExpress.XtraGrid.Views.Grid.GridView journalLinesGV;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colLineDescription;
        private DevExpress.Xpo.XPCollection productListXPC;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit productListSLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
