namespace ProductionReports.View.Task
{
    partial class TaskMastersXUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskMastersXUC));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.CategortPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.taskCatGC = new CoreLib.Grid.MyGridControl();
            this.categoryXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.taskCatGV = new CoreLib.Grid.MyGridView();
            this.colLineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.projectPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.projectGC = new CoreLib.Grid.MyGridControl();
            this.projectXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.projectGV = new CoreLib.Grid.MyGridView();
            this.colLineID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.trackerGC = new CoreLib.Grid.MyGridControl();
            this.trackerXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.filterValues = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.categoryLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.trackerGV = new CoreLib.Grid.MyGridView();
            this.colLineID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrackerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilterValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.CategortPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskCatGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskCatGV)).BeginInit();
            this.projectPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectGV)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackerGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.CategortPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(652, 242);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.projectPage3,
            this.CategortPage1,
            this.xtraTabPage2});
            // 
            // CategortPage1
            // 
            this.CategortPage1.Controls.Add(this.taskCatGC);
            this.CategortPage1.Name = "CategortPage1";
            this.CategortPage1.Size = new System.Drawing.Size(647, 216);
            this.CategortPage1.Text = "Category";
            // 
            // taskCatGC
            // 
            this.taskCatGC.DataSource = this.categoryXPC;
            this.taskCatGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskCatGC.Location = new System.Drawing.Point(0, 0);
            this.taskCatGC.MainView = this.taskCatGV;
            this.taskCatGC.Name = "taskCatGC";
            this.taskCatGC.Size = new System.Drawing.Size(647, 216);
            this.taskCatGC.TabIndex = 0;
            this.taskCatGC.UseEmbeddedNavigator = true;
            this.taskCatGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.taskCatGV});
            // 
            // categoryXPC
            // 
            this.categoryXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.ArticalCategory);
            this.categoryXPC.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // taskCatGV
            // 
            this.taskCatGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineID,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.colCategoryName});
            this.taskCatGV.GridControl = this.taskCatGC;
            this.taskCatGV.Name = "taskCatGV";
            // 
            // colLineID
            // 
            this.colLineID.FieldName = "LineID";
            this.colLineID.Name = "colLineID";
            this.colLineID.Visible = true;
            this.colLineID.VisibleIndex = 0;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 1;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 2;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.Visible = true;
            this.colModifiedBy.VisibleIndex = 3;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.Visible = true;
            this.colModifiedAt.VisibleIndex = 4;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 5;
            // 
            // projectPage3
            // 
            this.projectPage3.Controls.Add(this.projectGC);
            this.projectPage3.Name = "projectPage3";
            this.projectPage3.Size = new System.Drawing.Size(647, 216);
            this.projectPage3.Text = "Projects";
            // 
            // projectGC
            // 
            this.projectGC.DataSource = this.projectXPC;
            this.projectGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectGC.ExternalRepository = this.persistentRepository1;
            this.projectGC.Location = new System.Drawing.Point(0, 0);
            this.projectGC.MainView = this.projectGV;
            this.projectGC.Name = "projectGC";
            this.projectGC.Size = new System.Drawing.Size(647, 216);
            this.projectGC.TabIndex = 0;
            this.projectGC.UseEmbeddedNavigator = true;
            this.projectGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.projectGV});
            // 
            // projectXPC
            // 
            this.projectXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.Project);
            this.projectXPC.Session = this.unitOfWork1;
            // 
            // projectGV
            // 
            this.projectGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineID2,
            this.colCreatedBy2,
            this.colCreatedAt2,
            this.colModifiedBy2,
            this.colModifiedAt2,
            this.gridColumn1,
            this.gridColumn2,
            this.colProjectDescription,
            this.colStartDate,
            this.colEndDate});
            this.projectGV.GridControl = this.projectGC;
            this.projectGV.Name = "projectGV";
            this.projectGV.OptionsView.ShowFooter = true;
            // 
            // colLineID2
            // 
            this.colLineID2.FieldName = "LineID";
            this.colLineID2.Name = "colLineID2";
            this.colLineID2.Visible = true;
            this.colLineID2.VisibleIndex = 0;
            // 
            // colCreatedBy2
            // 
            this.colCreatedBy2.FieldName = "CreatedBy";
            this.colCreatedBy2.Name = "colCreatedBy2";
            this.colCreatedBy2.Visible = true;
            this.colCreatedBy2.VisibleIndex = 1;
            // 
            // colCreatedAt2
            // 
            this.colCreatedAt2.FieldName = "CreatedAt";
            this.colCreatedAt2.Name = "colCreatedAt2";
            this.colCreatedAt2.Visible = true;
            this.colCreatedAt2.VisibleIndex = 2;
            // 
            // colModifiedBy2
            // 
            this.colModifiedBy2.FieldName = "ModifiedBy";
            this.colModifiedBy2.Name = "colModifiedBy2";
            this.colModifiedBy2.Visible = true;
            this.colModifiedBy2.VisibleIndex = 3;
            // 
            // colModifiedAt2
            // 
            this.colModifiedAt2.FieldName = "ModifiedAt";
            this.colModifiedAt2.Name = "colModifiedAt2";
            this.colModifiedAt2.Visible = true;
            this.colModifiedAt2.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "CategoryID.CategoryName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.ColumnEdit = this.categoryLookup;
            this.gridColumn2.FieldName = "CategoryID!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // colProjectDescription
            // 
            this.colProjectDescription.FieldName = "ProjectDescription";
            this.colProjectDescription.Name = "colProjectDescription";
            this.colProjectDescription.Visible = true;
            this.colProjectDescription.VisibleIndex = 7;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 8;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 9;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.trackerGC);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(647, 216);
            this.xtraTabPage2.Text = "Tracker";
            // 
            // trackerGC
            // 
            this.trackerGC.DataSource = this.trackerXPC;
            this.trackerGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackerGC.ExternalRepository = this.persistentRepository1;
            this.trackerGC.Location = new System.Drawing.Point(0, 0);
            this.trackerGC.MainView = this.trackerGV;
            this.trackerGC.Name = "trackerGC";
            this.trackerGC.Size = new System.Drawing.Size(647, 216);
            this.trackerGC.TabIndex = 0;
            this.trackerGC.UseEmbeddedNavigator = true;
            this.trackerGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.trackerGV});
            // 
            // trackerXPC
            // 
            this.trackerXPC.ObjectType = typeof(ProductionReports.ModelXpo.OmarERP.Tracker);
            this.trackerXPC.Session = this.unitOfWork1;
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.filterValues,
            this.categoryLookup});
            // 
            // filterValues
            // 
            this.filterValues.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filterValues.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task status", "STATUS", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Priority", "PRIORITY", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task tracker", "TASK_TRACKER", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task Activity", "TASK_ACTIVITY", 3)});
            this.filterValues.LargeImages = this.imageCollection1;
            this.filterValues.Name = "filterValues";
            this.filterValues.SmallImages = this.imageCollection1;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("checkbox_16x16.png", "office2013/content/checkbox_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/content/checkbox_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "checkbox_16x16.png");
            this.imageCollection1.InsertGalleryImage("gaugestylehalfcircular_16x16.png", "office2013/gauges/gaugestylehalfcircular_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/gauges/gaugestylehalfcircular_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "gaugestylehalfcircular_16x16.png");
            this.imageCollection1.InsertGalleryImage("forcetesting_16x16.png", "office2013/programming/forcetesting_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/programming/forcetesting_16x16.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "forcetesting_16x16.png");
            this.imageCollection1.InsertGalleryImage("newtablestyle_16x16.png", "images/actions/newtablestyle_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/newtablestyle_16x16.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "newtablestyle_16x16.png");
            // 
            // categoryLookup
            // 
            this.categoryLookup.AutoHeight = false;
            this.categoryLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LineID", "Line ID", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.categoryLookup.DataSource = this.categoryXPC;
            this.categoryLookup.DisplayMember = "CategoryName";
            this.categoryLookup.KeyMember = "LineID";
            this.categoryLookup.Name = "categoryLookup";
            this.categoryLookup.ValueMember = "LineID";
            // 
            // trackerGV
            // 
            this.trackerGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineID1,
            this.colCreatedBy1,
            this.colCreatedAt1,
            this.colModifiedBy1,
            this.colModifiedAt1,
            this.colTrackerName,
            this.colFilterValue,
            this.colRemark});
            this.trackerGV.GridControl = this.trackerGC;
            this.trackerGV.Name = "trackerGV";
            // 
            // colLineID1
            // 
            this.colLineID1.FieldName = "LineID";
            this.colLineID1.Name = "colLineID1";
            this.colLineID1.Visible = true;
            this.colLineID1.VisibleIndex = 0;
            // 
            // colCreatedBy1
            // 
            this.colCreatedBy1.FieldName = "CreatedBy";
            this.colCreatedBy1.Name = "colCreatedBy1";
            this.colCreatedBy1.Visible = true;
            this.colCreatedBy1.VisibleIndex = 1;
            // 
            // colCreatedAt1
            // 
            this.colCreatedAt1.FieldName = "CreatedAt";
            this.colCreatedAt1.Name = "colCreatedAt1";
            this.colCreatedAt1.Visible = true;
            this.colCreatedAt1.VisibleIndex = 2;
            // 
            // colModifiedBy1
            // 
            this.colModifiedBy1.FieldName = "ModifiedBy";
            this.colModifiedBy1.Name = "colModifiedBy1";
            this.colModifiedBy1.Visible = true;
            this.colModifiedBy1.VisibleIndex = 3;
            // 
            // colModifiedAt1
            // 
            this.colModifiedAt1.FieldName = "ModifiedAt";
            this.colModifiedAt1.Name = "colModifiedAt1";
            this.colModifiedAt1.Visible = true;
            this.colModifiedAt1.VisibleIndex = 4;
            // 
            // colTrackerName
            // 
            this.colTrackerName.FieldName = "TrackerName";
            this.colTrackerName.Name = "colTrackerName";
            this.colTrackerName.Visible = true;
            this.colTrackerName.VisibleIndex = 5;
            // 
            // colFilterValue
            // 
            this.colFilterValue.ColumnEdit = this.filterValues;
            this.colFilterValue.FieldName = "FilterValue";
            this.colFilterValue.Name = "colFilterValue";
            this.colFilterValue.Visible = true;
            this.colFilterValue.VisibleIndex = 6;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 7;
            // 
            // TaskMastersXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "TaskMastersXUC";
            this.Size = new System.Drawing.Size(652, 242);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.CategortPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskCatGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskCatGV)).EndInit();
            this.projectPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectGV)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackerGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage CategortPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private CoreLib.Grid.MyGridControl taskCatGC;
        private CoreLib.Grid.MyGridView taskCatGV;
        private DevExpress.Xpo.XPCollection categoryXPC;
        private DevExpress.XtraGrid.Columns.GridColumn colLineID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.Xpo.XPCollection trackerXPC;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private CoreLib.Grid.MyGridControl trackerGC;
        private CoreLib.Grid.MyGridView trackerGV;
        private DevExpress.XtraGrid.Columns.GridColumn colLineID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrackerName;
        private DevExpress.XtraGrid.Columns.GridColumn colFilterValue;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox filterValues;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraTab.XtraTabPage projectPage3;
        private CoreLib.Grid.MyGridControl projectGC;
        private CoreLib.Grid.MyGridView projectGV;
        private DevExpress.Xpo.XPCollection projectXPC;
        private DevExpress.XtraGrid.Columns.GridColumn colLineID2;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy2;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt2;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy2;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit categoryLookup;
    }
}
