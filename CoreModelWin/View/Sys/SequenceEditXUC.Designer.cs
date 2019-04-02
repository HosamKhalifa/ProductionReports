namespace CoreModelWin.View.Sys
{
    partial class SequenceEditXUC
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
            this.myGridControl1 = new CoreLib.Grid.MyGridControl();
            this.xpCollectionExt1 = new CoreLib.Xpo.XPCollectionExt();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.myGridView1 = new CoreLib.Grid.MyGridView();
            this.colLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequMask = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequRecycle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWFStatusCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.xpCollectionExt1;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(658, 483);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.UseEmbeddedNavigator = true;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // xpCollectionExt1
            // 
            this.xpCollectionExt1.ObjectType = typeof(CoreModel.Sequence);
            this.xpCollectionExt1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.gridColumn1,
            this.gridColumn2,
            this.colSequName,
            this.colSequMask,
            this.colSequType,
            this.colSequLength,
            this.colStartDate,
            this.colEndDate,
            this.colSequRecycle,
            this.colWFStatusCreation});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colLineId
            // 
            this.colLineId.FieldName = "LineId";
            this.colLineId.Name = "colLineId";
            this.colLineId.Visible = true;
            this.colLineId.VisibleIndex = 0;
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
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "TableId!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "TableId!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // colSequName
            // 
            this.colSequName.FieldName = "SequName";
            this.colSequName.Name = "colSequName";
            this.colSequName.Visible = true;
            this.colSequName.VisibleIndex = 7;
            // 
            // colSequMask
            // 
            this.colSequMask.FieldName = "SequMask";
            this.colSequMask.Name = "colSequMask";
            this.colSequMask.Visible = true;
            this.colSequMask.VisibleIndex = 8;
            // 
            // colSequType
            // 
            this.colSequType.FieldName = "SequType";
            this.colSequType.Name = "colSequType";
            this.colSequType.Visible = true;
            this.colSequType.VisibleIndex = 9;
            // 
            // colSequLength
            // 
            this.colSequLength.FieldName = "SequLength";
            this.colSequLength.Name = "colSequLength";
            this.colSequLength.Visible = true;
            this.colSequLength.VisibleIndex = 10;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 11;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 12;
            // 
            // colSequRecycle
            // 
            this.colSequRecycle.FieldName = "SequRecycle";
            this.colSequRecycle.Name = "colSequRecycle";
            this.colSequRecycle.Visible = true;
            this.colSequRecycle.VisibleIndex = 13;
            // 
            // colWFStatusCreation
            // 
            this.colWFStatusCreation.FieldName = "WFStatusCreation";
            this.colWFStatusCreation.Name = "colWFStatusCreation";
            this.colWFStatusCreation.Visible = true;
            this.colWFStatusCreation.VisibleIndex = 14;
            // 
            // SequenceEditXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "SequenceEditXUC";
            this.Size = new System.Drawing.Size(658, 483);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CoreLib.Grid.MyGridControl myGridControl1;
        private CoreLib.Grid.MyGridView myGridView1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private CoreLib.Xpo.XPCollectionExt xpCollectionExt1;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colSequName;
        private DevExpress.XtraGrid.Columns.GridColumn colSequMask;
        private DevExpress.XtraGrid.Columns.GridColumn colSequType;
        private DevExpress.XtraGrid.Columns.GridColumn colSequLength;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSequRecycle;
        private DevExpress.XtraGrid.Columns.GridColumn colWFStatusCreation;
    }
}
