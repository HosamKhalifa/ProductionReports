namespace CoreModelWin.View.Sys
{
    partial class CurrencySetupFrm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromToKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLineId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyFromToKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollection2 = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(744, 542);
            this.splitContainerControl1.SplitterPosition = 293;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(293, 542);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.gridColumn1,
            this.gridColumn2,
            this.colFromCurrencyCode,
            this.colToCurrencyCode,
            this.colFromToKey,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // colFromCurrencyCode
            // 
            this.colFromCurrencyCode.FieldName = "FromCurrencyCode";
            this.colFromCurrencyCode.Name = "colFromCurrencyCode";
            this.colFromCurrencyCode.Visible = true;
            this.colFromCurrencyCode.VisibleIndex = 7;
            // 
            // colToCurrencyCode
            // 
            this.colToCurrencyCode.FieldName = "ToCurrencyCode";
            this.colToCurrencyCode.Name = "colToCurrencyCode";
            this.colToCurrencyCode.Visible = true;
            this.colToCurrencyCode.VisibleIndex = 8;
            // 
            // colFromToKey
            // 
            this.colFromToKey.FieldName = "FromToKey";
            this.colFromToKey.Name = "colFromToKey";
            this.colFromToKey.Visible = true;
            this.colFromToKey.VisibleIndex = 9;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "TableId.TableName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 10;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.xpCollection2;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(445, 542);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId1,
            this.colCreatedBy1,
            this.colCreatedAt1,
            this.colModifiedBy1,
            this.colModifiedAt1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.colValidFrom,
            this.colValidTo,
            this.colCurrencyFromToKey});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colLineId1
            // 
            this.colLineId1.FieldName = "LineId";
            this.colLineId1.Name = "colLineId1";
            this.colLineId1.Visible = true;
            this.colLineId1.VisibleIndex = 0;
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
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "TableId!";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "TableId!Key";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "CurrencyPair!";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "CurrencyPair!Key";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            // 
            // colValidFrom
            // 
            this.colValidFrom.FieldName = "ValidFrom";
            this.colValidFrom.Name = "colValidFrom";
            this.colValidFrom.Visible = true;
            this.colValidFrom.VisibleIndex = 9;
            // 
            // colValidTo
            // 
            this.colValidTo.FieldName = "ValidTo";
            this.colValidTo.Name = "colValidTo";
            this.colValidTo.Visible = true;
            this.colValidTo.VisibleIndex = 10;
            // 
            // colCurrencyFromToKey
            // 
            this.colCurrencyFromToKey.FieldName = "CurrencyFromToKey";
            this.colCurrencyFromToKey.Name = "colCurrencyFromToKey";
            this.colCurrencyFromToKey.Visible = true;
            this.colCurrencyFromToKey.VisibleIndex = 11;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(CoreModel.CurrencyPair);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // xpCollection2
            // 
            this.xpCollection2.ObjectType = typeof(CoreModel.CurrencyPairExchangeRate);
            this.xpCollection2.Session = this.unitOfWork1;
            // 
            // CurrencySetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(744, 542);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "CurrencySetupFrm";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colFromCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colToCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFromToKey;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colValidFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colValidTo;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyFromToKey;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.XPCollection xpCollection2;
    }
}
