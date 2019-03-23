namespace CoreModelWin
{
    partial class TableBaseFrm
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
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.xpCollectionExt1 = new CoreLib.Xpo.XPCollectionExt();
            this.myGridControl1 = new CoreLib.Grid.MyGridControl();
            this.myGridView1 = new CoreLib.Grid.MyGridView();
            this.colTableId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableDBName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTABLE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenerateKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // xpCollectionExt1
            // 
            this.xpCollectionExt1.ObjectType = typeof(CoreModel.TableBase);
            this.xpCollectionExt1.Session = this.unitOfWork1;
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.xpCollectionExt1;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(582, 311);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.UseEmbeddedNavigator = true;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTableId,
            this.colTableDBName,
            this.colTableName,
            this.colTableDescription,
            this.colTABLE_TYPE,
            this.colLastIndex,
            this.colGenerateKey,
            this.colSequId});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
            this.myGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTableId, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.myGridView1.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colTableId
            // 
            this.colTableId.FieldName = "TableId";
            this.colTableId.Name = "colTableId";
            this.colTableId.Visible = true;
            this.colTableId.VisibleIndex = 0;
            // 
            // colTableDBName
            // 
            this.colTableDBName.FieldName = "TableDBName";
            this.colTableDBName.Name = "colTableDBName";
            this.colTableDBName.Visible = true;
            this.colTableDBName.VisibleIndex = 2;
            this.colTableDBName.Width = 141;
            // 
            // colTableName
            // 
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 1;
            this.colTableName.Width = 145;
            // 
            // colTableDescription
            // 
            this.colTableDescription.FieldName = "TableDescription";
            this.colTableDescription.Name = "colTableDescription";
            this.colTableDescription.Visible = true;
            this.colTableDescription.VisibleIndex = 3;
            this.colTableDescription.Width = 169;
            // 
            // colTABLE_TYPE
            // 
            this.colTABLE_TYPE.FieldName = "TABLE_TYPE";
            this.colTABLE_TYPE.Name = "colTABLE_TYPE";
            this.colTABLE_TYPE.Visible = true;
            this.colTABLE_TYPE.VisibleIndex = 4;
            this.colTABLE_TYPE.Width = 107;
            // 
            // colLastIndex
            // 
            this.colLastIndex.FieldName = "LastIndex";
            this.colLastIndex.Name = "colLastIndex";
            this.colLastIndex.Visible = true;
            this.colLastIndex.VisibleIndex = 5;
            // 
            // colGenerateKey
            // 
            this.colGenerateKey.FieldName = "GenerateKey";
            this.colGenerateKey.Name = "colGenerateKey";
            this.colGenerateKey.Visible = true;
            this.colGenerateKey.VisibleIndex = 6;
            this.colGenerateKey.Width = 94;
            // 
            // colSequId
            // 
            this.colSequId.FieldName = "SequId";
            this.colSequId.Name = "colSequId";
            this.colSequId.Visible = true;
            this.colSequId.VisibleIndex = 7;
            this.colSequId.Width = 109;
            // 
            // TableBaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.myGridControl1);
            this.Name = "TableBaseFrm";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private CoreLib.Xpo.XPCollectionExt xpCollectionExt1;
        private CoreLib.Grid.MyGridControl myGridControl1;
        private CoreLib.Grid.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTableId;
        private DevExpress.XtraGrid.Columns.GridColumn colTableDBName;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.Columns.GridColumn colTableDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTABLE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colLastIndex;
        private DevExpress.XtraGrid.Columns.GridColumn colGenerateKey;
        private DevExpress.XtraGrid.Columns.GridColumn colSequId;
    }
}
