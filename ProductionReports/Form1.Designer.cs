namespace ProductionReports
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.settingsNavPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.locationGC = new DevExpress.XtraGrid.GridControl();
            this.locationXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.locationList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.equipmentList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.equipmentXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.salesItemList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.salesItemXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.employeeList = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegreeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.POSAccountListLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.POSAccountListXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.locationGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLocationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.shiftXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShiftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.saveBI = new DevExpress.XtraBars.BarButtonItem();
            this.retrieveBI = new DevExpress.XtraBars.BarButtonItem();
            this.sIDBI = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEquipmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.productsXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.journalXUC1 = new ProductionReports.View.JournalXUC();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pivotJournalXUC1 = new ProductionReports.View.PivotJournalXUC();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.settingsNavPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesItemXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSAccountListLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSAccountListXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationGV)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.settingsNavPage);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 24);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage1,
            this.settingsNavPage});
            this.navigationPane1.RegularSize = new System.Drawing.Size(669, 324);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(669, 324);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationPane1_SelectedPageChanged);
            // 
            // settingsNavPage
            // 
            this.settingsNavPage.Caption = "Settings";
            this.settingsNavPage.Controls.Add(this.xtraTabControl1);
            this.settingsNavPage.Image = ((System.Drawing.Image)(resources.GetObject("settingsNavPage.Image")));
            this.settingsNavPage.Name = "settingsNavPage";
            this.settingsNavPage.Size = new System.Drawing.Size(590, 261);
            this.settingsNavPage.Enter += new System.EventHandler(this.settingsNavPage_Enter);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(590, 261);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.locationGC);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(585, 235);
            this.xtraTabPage1.Text = "Locations";
            // 
            // locationGC
            // 
            this.locationGC.DataSource = this.locationXPC;
            this.locationGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationGC.ExternalRepository = this.persistentRepository1;
            this.locationGC.Location = new System.Drawing.Point(0, 0);
            this.locationGC.MainView = this.locationGV;
            this.locationGC.Name = "locationGC";
            this.locationGC.Size = new System.Drawing.Size(585, 235);
            this.locationGC.TabIndex = 0;
            this.locationGC.UseEmbeddedNavigator = true;
            this.locationGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.locationGV});
            // 
            // locationXPC
            // 
            this.locationXPC.DeleteObjectOnRemove = true;
            this.locationXPC.DisplayableProperties = "This;LocationId;LocationName;POSAccountID";
            this.locationXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.Location);
            this.locationXPC.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.locationList,
            this.equipmentList,
            this.salesItemList,
            this.employeeList,
            this.POSAccountListLookUp});
            // 
            // locationList
            // 
            this.locationList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.locationList.DataSource = this.locationXPC;
            this.locationList.DisplayMember = "LocationName";
            this.locationList.Name = "locationList";
            this.locationList.ValueMember = "LocationId";
            // 
            // equipmentList
            // 
            this.equipmentList.AutoHeight = false;
            this.equipmentList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.equipmentList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EquipmentId", "Equipment Id", 86, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EquipmentName", "Equipment Name", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StartDate", "Start Date", 60, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EndDate", "End Date", 54, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Active", "Active", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FixedAccountId", "Fixed Account Id", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.equipmentList.DataSource = this.equipmentXPC;
            this.equipmentList.DisplayMember = "EquipmentName";
            this.equipmentList.Name = "equipmentList";
            this.equipmentList.ValueMember = "EquipmentId";
            // 
            // equipmentXPC
            // 
            this.equipmentXPC.DeleteObjectOnRemove = true;
            this.equipmentXPC.DisplayableProperties = "EquipmentId;EquipmentName;StartDate;EndDate;LocationId;Active;FixedAccountId";
            this.equipmentXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.Equipment);
            this.equipmentXPC.Session = this.unitOfWork1;
            // 
            // salesItemList
            // 
            this.salesItemList.AutoHeight = false;
            this.salesItemList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.salesItemList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountID", "Account ID", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.salesItemList.DataSource = this.salesItemXPC;
            this.salesItemList.DisplayMember = "Name";
            this.salesItemList.Name = "salesItemList";
            this.salesItemList.ValueMember = "AccountID";
            // 
            // salesItemXPC
            // 
            this.salesItemXPC.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.salesItemXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.SalesItem);
            this.salesItemXPC.Session = this.unitOfWork1;
            // 
            // employeeList
            // 
            this.employeeList.AutoHeight = false;
            this.employeeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.employeeList.DisplayMember = "Name";
            this.employeeList.KeyMember = "EmployeeAccountID";
            this.employeeList.Name = "employeeList";
            this.employeeList.ValueMember = "EmployeeAccountID";
            this.employeeList.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeAccountID,
            this.colEmployeeNumber,
            this.colName,
            this.colDeptName,
            this.colDegreeName,
            this.colCostName,
            this.colJobName});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemSearchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEmployeeNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colEmployeeAccountID
            // 
            this.colEmployeeAccountID.FieldName = "EmployeeAccountID";
            this.colEmployeeAccountID.Name = "colEmployeeAccountID";
            // 
            // colEmployeeNumber
            // 
            this.colEmployeeNumber.FieldName = "EmployeeNumber";
            this.colEmployeeNumber.Name = "colEmployeeNumber";
            this.colEmployeeNumber.Visible = true;
            this.colEmployeeNumber.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 137;
            // 
            // colDeptName
            // 
            this.colDeptName.FieldName = "DeptName";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.Visible = true;
            this.colDeptName.VisibleIndex = 2;
            // 
            // colDegreeName
            // 
            this.colDegreeName.FieldName = "DegreeName";
            this.colDegreeName.Name = "colDegreeName";
            this.colDegreeName.Visible = true;
            this.colDegreeName.VisibleIndex = 3;
            this.colDegreeName.Width = 112;
            // 
            // colCostName
            // 
            this.colCostName.FieldName = "CostName";
            this.colCostName.Name = "colCostName";
            this.colCostName.Visible = true;
            this.colCostName.VisibleIndex = 4;
            this.colCostName.Width = 114;
            // 
            // colJobName
            // 
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.Visible = true;
            this.colJobName.VisibleIndex = 5;
            this.colJobName.Width = 222;
            // 
            // POSAccountListLookUp
            // 
            this.POSAccountListLookUp.AutoHeight = false;
            this.POSAccountListLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.POSAccountListLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("POSAccountID", "POS Account ID", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.POSAccountListLookUp.DataSource = this.POSAccountListXPC;
            this.POSAccountListLookUp.DisplayMember = "LocationName";
            this.POSAccountListLookUp.KeyMember = "LocationID";
            this.POSAccountListLookUp.Name = "POSAccountListLookUp";
            this.POSAccountListLookUp.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.POSAccountListLookUp.ValueMember = "POSAccountID";
            // 
            // POSAccountListXPC
            // 
            this.POSAccountListXPC.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
            this.POSAccountListXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.LocationsTable);
            this.POSAccountListXPC.Session = this.unitOfWork1;
            // 
            // locationGV
            // 
            this.locationGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLocationId,
            this.colLocationName,
            this.colPOSAccountID});
            this.locationGV.GridControl = this.locationGC;
            this.locationGV.Name = "locationGV";
            this.locationGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.locationGV.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GV_InitNewRow);
            this.locationGV.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GV_ValidateRow);
            // 
            // colLocationId
            // 
            this.colLocationId.FieldName = "LocationId";
            this.colLocationId.Name = "colLocationId";
            this.colLocationId.Visible = true;
            this.colLocationId.VisibleIndex = 0;
            // 
            // colLocationName
            // 
            this.colLocationName.FieldName = "LocationName";
            this.colLocationName.Name = "colLocationName";
            this.colLocationName.Visible = true;
            this.colLocationName.VisibleIndex = 1;
            // 
            // colPOSAccountID
            // 
            this.colPOSAccountID.Caption = "Master Location";
            this.colPOSAccountID.ColumnEdit = this.POSAccountListLookUp;
            this.colPOSAccountID.FieldName = "POSAccountID";
            this.colPOSAccountID.Name = "colPOSAccountID";
            this.colPOSAccountID.Visible = true;
            this.colPOSAccountID.VisibleIndex = 2;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(585, 235);
            this.xtraTabPage2.Text = "Shifts";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.shiftXPC;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(585, 235);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // shiftXPC
            // 
            this.shiftXPC.DeleteObjectOnRemove = true;
            this.shiftXPC.DisplayableProperties = "ShiftId;ShiftName;TransJournals";
            this.shiftXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.Shift);
            this.shiftXPC.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShiftId,
            this.colShiftName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GV_InitNewRow);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GV_ValidateRow);
            // 
            // colShiftId
            // 
            this.colShiftId.FieldName = "ShiftId";
            this.colShiftId.Name = "colShiftId";
            this.colShiftId.Visible = true;
            this.colShiftId.VisibleIndex = 0;
            // 
            // colShiftName
            // 
            this.colShiftName.FieldName = "ShiftName";
            this.colShiftName.Name = "colShiftName";
            this.colShiftName.Visible = true;
            this.colShiftName.VisibleIndex = 1;
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
            this.saveBI,
            this.retrieveBI,
            this.sIDBI,
            this.skinBarSubItem1});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.retrieveBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.sIDBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.bar1.Text = "Tools";
            // 
            // saveBI
            // 
            this.saveBI.Caption = "Save";
            this.saveBI.Id = 0;
            this.saveBI.Name = "saveBI";
            this.saveBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBI_ItemClick);
            // 
            // retrieveBI
            // 
            this.retrieveBI.Caption = "Retrieve";
            this.retrieveBI.Id = 1;
            this.retrieveBI.Name = "retrieveBI";
            this.retrieveBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.retrieveBI_ItemClick);
            // 
            // sIDBI
            // 
            this.sIDBI.Caption = "SID";
            this.sIDBI.Enabled = false;
            this.sIDBI.Id = 2;
            this.sIDBI.Name = "sIDBI";
            this.sIDBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sIDBI_ItemClick);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skin selection";
            this.skinBarSubItem1.Id = 3;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
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
            this.barDockControlTop.Size = new System.Drawing.Size(669, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 348);
            this.barDockControlBottom.Size = new System.Drawing.Size(669, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 324);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(669, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 324);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(585, 235);
            this.xtraTabPage3.Text = "Equipment";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.equipmentXPC;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.ExternalRepository = this.persistentRepository1;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(585, 235);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEquipmentId,
            this.colEquipmentName,
            this.colStartDate,
            this.colEndDate,
            this.colLocationId2,
            this.colActive,
            this.colFixedAccountId});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView2.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GV_InitNewRow);
            this.gridView2.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GV_ValidateRow);
            // 
            // colEquipmentId
            // 
            this.colEquipmentId.FieldName = "EquipmentId";
            this.colEquipmentId.Name = "colEquipmentId";
            this.colEquipmentId.Visible = true;
            this.colEquipmentId.VisibleIndex = 0;
            // 
            // colEquipmentName
            // 
            this.colEquipmentName.FieldName = "EquipmentName";
            this.colEquipmentName.Name = "colEquipmentName";
            this.colEquipmentName.Visible = true;
            this.colEquipmentName.VisibleIndex = 1;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 3;
            // 
            // colLocationId2
            // 
            this.colLocationId2.Caption = "Location";
            this.colLocationId2.ColumnEdit = this.locationList;
            this.colLocationId2.FieldName = "LocationId";
            this.colLocationId2.Name = "colLocationId2";
            this.colLocationId2.Visible = true;
            this.colLocationId2.VisibleIndex = 6;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            // 
            // colFixedAccountId
            // 
            this.colFixedAccountId.FieldName = "FixedAccountId";
            this.colFixedAccountId.Name = "colFixedAccountId";
            this.colFixedAccountId.Visible = true;
            this.colFixedAccountId.VisibleIndex = 5;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.gridControl3);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(585, 235);
            this.xtraTabPage4.Text = "Products";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.productsXPC;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.ExternalRepository = this.persistentRepository1;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.MenuManager = this.barManager1;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(585, 235);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.UseEmbeddedNavigator = true;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // productsXPC
            // 
            this.productsXPC.DeleteObjectOnRemove = true;
            this.productsXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.EquipmentProducts);
            this.productsXPC.Session = this.unitOfWork1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colProductName,
            this.colSalesAccountID,
            this.gridColumn1});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView3.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSalesAccountID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView3.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GV_InitNewRow);
            this.gridView3.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GV_ValidateRow);
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ProductName";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 2;
            this.colProductName.Width = 232;
            // 
            // colSalesAccountID
            // 
            this.colSalesAccountID.ColumnEdit = this.salesItemList;
            this.colSalesAccountID.FieldName = "SalesAccountID";
            this.colSalesAccountID.Name = "colSalesAccountID";
            this.colSalesAccountID.Visible = true;
            this.colSalesAccountID.VisibleIndex = 1;
            this.colSalesAccountID.Width = 246;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "SalesAccountID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Journal";
            this.navigationPage2.Controls.Add(this.xtraTabControl2);
            this.navigationPage2.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.Image")));
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.PageText = "Daily trans";
            this.navigationPage2.Size = new System.Drawing.Size(625, 261);
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage5;
            this.xtraTabControl2.Size = new System.Drawing.Size(625, 261);
            this.xtraTabControl2.TabIndex = 1;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage5});
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.journalXUC1);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(620, 235);
            this.xtraTabPage5.Text = "Daily trans";
            // 
            // journalXUC1
            // 
            this.journalXUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalXUC1.Location = new System.Drawing.Point(0, 0);
            this.journalXUC1.Name = "journalXUC1";
            this.journalXUC1.Size = new System.Drawing.Size(620, 235);
            this.journalXUC1.TabIndex = 0;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Report";
            this.navigationPage1.Controls.Add(this.pivotJournalXUC1);
            this.navigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.Image")));
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(625, 261);
            // 
            // pivotJournalXUC1
            // 
            this.pivotJournalXUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotJournalXUC1.Location = new System.Drawing.Point(0, 0);
            this.pivotJournalXUC1.Name = "pivotJournalXUC1";
            this.pivotJournalXUC1.Size = new System.Drawing.Size(625, 261);
            this.pivotJournalXUC1.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 370);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Production reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.settingsNavPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesItemXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSAccountListLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSAccountListXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationGV)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage settingsNavPage;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl locationGC;
        private DevExpress.XtraGrid.Views.Grid.GridView locationGV;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem saveBI;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem retrieveBI;
        private DevExpress.Xpo.XPCollection locationXPC;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationId;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection shiftXPC;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftId;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftName;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.Xpo.XPCollection equipmentXPC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationId2;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit locationList;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.Xpo.XPCollection productsXPC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesAccountID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit equipmentList;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit salesItemList;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit employeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn colDegreeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCostName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobName;
        private DevExpress.Xpo.XPCollection salesItemXPC;
        private View.JournalXUC journalXUC1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private View.PivotJournalXUC pivotJournalXUC1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit POSAccountListLookUp;
        private DevExpress.Xpo.XPCollection POSAccountListXPC;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraBars.BarButtonItem sIDBI;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

