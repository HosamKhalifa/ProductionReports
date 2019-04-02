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
            this.colTableType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDimensionPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssemblyName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colTableType,
            this.colDimensionPrefix,
            this.colLastIndex,
            this.colSequId,
            this.colClassName,
            this.colAssemblyName});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.myGridView1.OptionsView.ColumnAutoWidth = false;
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
            this.colTableDBName.VisibleIndex = 1;
            // 
            // colTableName
            // 
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 2;
            // 
            // colTableDescription
            // 
            this.colTableDescription.FieldName = "TableDescription";
            this.colTableDescription.Name = "colTableDescription";
            this.colTableDescription.Visible = true;
            this.colTableDescription.VisibleIndex = 3;
            // 
            // colTableType
            // 
            this.colTableType.FieldName = "TableType";
            this.colTableType.Name = "colTableType";
            this.colTableType.Visible = true;
            this.colTableType.VisibleIndex = 4;
            // 
            // colDimensionPrefix
            // 
            this.colDimensionPrefix.FieldName = "DimensionPrefix";
            this.colDimensionPrefix.Name = "colDimensionPrefix";
            this.colDimensionPrefix.Visible = true;
            this.colDimensionPrefix.VisibleIndex = 5;
            // 
            // colLastIndex
            // 
            this.colLastIndex.FieldName = "LastIndex";
            this.colLastIndex.Name = "colLastIndex";
            this.colLastIndex.Visible = true;
            this.colLastIndex.VisibleIndex = 6;
            // 
            // colSequId
            // 
            this.colSequId.FieldName = "SequId";
            this.colSequId.Name = "colSequId";
            this.colSequId.Visible = true;
            this.colSequId.VisibleIndex = 7;
            // 
            // colClassName
            // 
            this.colClassName.FieldName = "ClassName";
            this.colClassName.Name = "colClassName";
            this.colClassName.Visible = true;
            this.colClassName.VisibleIndex = 8;
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.FieldName = "AssemblyName";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Visible = true;
            this.colAssemblyName.VisibleIndex = 9;
            // 
            // TableBaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.myGridControl1);
            this.Name = "TableBaseFrm";
            this.Text = "Table base";
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
        private DevExpress.XtraGrid.Columns.GridColumn colTableType;
        private DevExpress.XtraGrid.Columns.GridColumn colDimensionPrefix;
        private DevExpress.XtraGrid.Columns.GridColumn colLastIndex;
        private DevExpress.XtraGrid.Columns.GridColumn colSequId;
        private DevExpress.XtraGrid.Columns.GridColumn colClassName;
        private DevExpress.XtraGrid.Columns.GridColumn colAssemblyName;
    }
}
