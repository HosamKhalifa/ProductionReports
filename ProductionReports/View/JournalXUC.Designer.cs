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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalXUC));
            this.productListSLookup = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.productListXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.journalXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.shiftList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.shiftXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.equipmentList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.equipmentXPC = new DevExpress.Xpo.XPCollection(this.components);
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.journalGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shiftRILookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaultsHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.journalPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.journalLinesPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.journalLinesXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.journalLinesGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productListSLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftRILookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.journalPage1.SuspendLayout();
            this.journalLinesPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLinesXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLinesGV)).BeginInit();
            this.SuspendLayout();
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
            this.colItemName});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemSearchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colItemName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 323;
            // 
            // journalXPC
            // 
            this.journalXPC.DeleteObjectOnRemove = true;
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
            this.productListSLookup,
            this.equipmentList});
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
            // equipmentList
            // 
            this.equipmentList.AutoHeight = false;
            this.equipmentList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.equipmentList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EquipmentId", "Equipment Id", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EquipmentName", "Equipment Name", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.equipmentList.DataSource = this.equipmentXPC;
            this.equipmentList.DisplayMember = "EquipmentName";
            this.equipmentList.KeyMember = "EquipmentId";
            this.equipmentList.Name = "equipmentList";
            this.equipmentList.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.equipmentList.ValueMember = "EquipmentId";
            // 
            // equipmentXPC
            // 
            this.equipmentXPC.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.equipmentXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.Equipment);
            this.equipmentXPC.Session = this.unitOfWork1;
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.journalXPC;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.ExternalRepository = this.persistentRepository1;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.journalGV;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.shiftRILookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(613, 370);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.journalGV});
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
            this.journalGV.OptionsView.ColumnAutoWidth = false;
            this.journalGV.OptionsView.EnableAppearanceEvenRow = true;
            this.journalGV.OptionsView.ShowAutoFilterRow = true;
            this.journalGV.OptionsView.ShowFooter = true;
            this.journalGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTransDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.journalGV.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.journalGV_InitNewRow);
            this.journalGV.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GV_ValidateRow);
            // 
            // colJournalId
            // 
            this.colJournalId.FieldName = "JournalId";
            this.colJournalId.Name = "colJournalId";
            this.colJournalId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "JournalId", "{0}")});
            this.colJournalId.Visible = true;
            this.colJournalId.VisibleIndex = 0;
            // 
            // colShiftId
            // 
            this.colShiftId.Caption = "Shift";
            this.colShiftId.ColumnEdit = this.shiftRILookUpEdit;
            this.colShiftId.FieldName = "ShiftId!Key";
            this.colShiftId.Name = "colShiftId";
            this.colShiftId.Visible = true;
            this.colShiftId.VisibleIndex = 5;
            // 
            // shiftRILookUpEdit
            // 
            this.shiftRILookUpEdit.AutoHeight = false;
            this.shiftRILookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shiftRILookUpEdit.DataSource = this.shiftXPC;
            this.shiftRILookUpEdit.DisplayMember = "ShiftName";
            this.shiftRILookUpEdit.KeyMember = "ShiftId";
            this.shiftRILookUpEdit.Name = "shiftRILookUpEdit";
            this.shiftRILookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.shiftRILookUpEdit.ValueMember = "ShiftId";
            // 
            // colTransDate
            // 
            this.colTransDate.FieldName = "TransDate";
            this.colTransDate.Name = "colTransDate";
            this.colTransDate.Visible = true;
            this.colTransDate.VisibleIndex = 1;
            this.colTransDate.Width = 96;
            // 
            // colWorkingHours
            // 
            this.colWorkingHours.FieldName = "WorkingHours";
            this.colWorkingHours.Name = "colWorkingHours";
            this.colWorkingHours.Visible = true;
            this.colWorkingHours.VisibleIndex = 2;
            // 
            // colFaultsHours
            // 
            this.colFaultsHours.FieldName = "FaultsHours";
            this.colFaultsHours.Name = "colFaultsHours";
            this.colFaultsHours.Visible = true;
            this.colFaultsHours.VisibleIndex = 3;
            // 
            // colDecription
            // 
            this.colDecription.FieldName = "Decription";
            this.colDecription.Name = "colDecription";
            this.colDecription.Visible = true;
            this.colDecription.VisibleIndex = 4;
            this.colDecription.Width = 261;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 28);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.journalPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(615, 403);
            this.xtraTabControl1.TabIndex = 15;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.journalPage1,
            this.journalLinesPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // journalPage1
            // 
            this.journalPage1.Controls.Add(this.gridControl1);
            this.journalPage1.Name = "journalPage1";
            this.journalPage1.Size = new System.Drawing.Size(613, 370);
            this.journalPage1.Text = "Journal";
            // 
            // journalLinesPage2
            // 
            this.journalLinesPage2.Controls.Add(this.gridControl2);
            this.journalLinesPage2.Name = "journalLinesPage2";
            this.journalLinesPage2.Size = new System.Drawing.Size(613, 370);
            this.journalLinesPage2.Text = "Lines";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.journalLinesXPC;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.ExternalRepository = this.persistentRepository1;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.journalLinesGV;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(613, 370);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.journalLinesGV});
            // 
            // journalLinesXPC
            // 
            this.journalLinesXPC.DeleteObjectOnRemove = true;
            this.journalLinesXPC.LoadingEnabled = false;
            this.journalLinesXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.TransJournalLine);
            this.journalLinesXPC.Session = this.unitOfWork1;
            // 
            // journalLinesGV
            // 
            this.journalLinesGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecId,
            this.gridColumn1,
            this.gridColumn4,
            this.colQuantity,
            this.colLineDescription});
            this.journalLinesGV.GridControl = this.gridControl2;
            this.journalLinesGV.Name = "journalLinesGV";
            this.journalLinesGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.journalLinesGV.OptionsView.ColumnAutoWidth = false;
            this.journalLinesGV.OptionsView.EnableAppearanceOddRow = true;
            this.journalLinesGV.OptionsView.ShowAutoFilterRow = true;
            this.journalLinesGV.OptionsView.ShowFooter = true;
            this.journalLinesGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRecId, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.journalLinesGV.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.journalGV_InitNewRow);
            this.journalLinesGV.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GV_ValidateRow);
            // 
            // colRecId
            // 
            this.colRecId.FieldName = "RecId";
            this.colRecId.Name = "colRecId";
            this.colRecId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colRecId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RecId", "{0}")});
            this.colRecId.Visible = true;
            this.colRecId.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Equipment";
            this.gridColumn1.ColumnEdit = this.equipmentList;
            this.gridColumn1.FieldName = "EquipmentId!Key";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsEditForm.VisibleIndex = 2;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 170;
            // 
            // gridColumn4
            // 
            this.gridColumn4.ColumnEdit = this.productListSLookup;
            this.gridColumn4.FieldName = "ProductId!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsEditForm.VisibleIndex = 3;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 287;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsEditForm.VisibleIndex = 1;
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "SUM={0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colLineDescription
            // 
            this.colLineDescription.FieldName = "LineDescription";
            this.colLineDescription.Name = "colLineDescription";
            this.colLineDescription.OptionsEditForm.VisibleIndex = 4;
            this.colLineDescription.Visible = true;
            this.colLineDescription.VisibleIndex = 4;
            this.colLineDescription.Width = 349;
            // 
            // JournalXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "JournalXUC";
            this.Size = new System.Drawing.Size(615, 431);
            ((System.ComponentModel.ISupportInitialize)(this.productListSLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftRILookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.journalPage1.ResumeLayout(false);
            this.journalLinesPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLinesXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalLinesGV)).EndInit();
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
        private DevExpress.Xpo.XPCollection journalXPC;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraBars.BarEditItem fromBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem toBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem retrieveBI;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit shiftList;
        private DevExpress.Xpo.XPCollection shiftXPC;
        private DevExpress.Xpo.XPCollection productListXPC;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit productListSLookup;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage journalLinesPage2;
        private DevExpress.XtraTab.XtraTabPage journalPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView journalGV;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingHours;
        private DevExpress.XtraGrid.Columns.GridColumn colFaultsHours;
        private DevExpress.XtraGrid.Columns.GridColumn colDecription;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.Xpo.XPCollection journalLinesXPC;
        private DevExpress.XtraGrid.Views.Grid.GridView journalLinesGV;
        private DevExpress.XtraGrid.Columns.GridColumn colRecId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colLineDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit shiftRILookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.Xpo.XPCollection equipmentXPC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit equipmentList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
