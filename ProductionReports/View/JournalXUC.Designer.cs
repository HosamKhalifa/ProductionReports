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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalXUC));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
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
            this.journalXPC = new DevExpress.Xpo.XPCollection();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository();
            this.shiftList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.shiftXPC = new DevExpress.Xpo.XPCollection();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaultsHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDecription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(615, 403);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // journalXPC
            // 
            this.journalXPC.DisplayableProperties = "JournalId;ShiftId;TransDate;WorkingHours;FaultsHours;Decription;TransJournalEmplo" +
    "yeesCollection;TransJournalLines";
            this.journalXPC.LoadingEnabled = false;
            this.journalXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.TransJournal);
            this.journalXPC.Session = this.unitOfWork1;
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
            this.shiftList});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalId,
            this.colShiftId,
            this.colTransDate,
            this.colWorkingHours,
            this.colFaultsHours,
            this.colDecription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
    }
}
