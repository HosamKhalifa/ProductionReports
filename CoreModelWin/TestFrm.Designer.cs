namespace CoreModelWin
{
    partial class TestFrm
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
            this.countryGC = new CoreLib.Grid.MyGridControl();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.countryGV = new CoreLib.Grid.MyGridView();
            this.colLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.provinceGC = new CoreLib.Grid.MyGridControl();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinceGV = new CoreLib.Grid.MyGridView();
            this.colLineId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvinceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvinceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityGC = new CoreLib.Grid.MyGridControl();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityGV = new CoreLib.Grid.MyGridView();
            this.colLineId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryGC
            // 
            this.countryGC.DataSource = this.countryBindingSource;
            this.countryGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countryGC.Location = new System.Drawing.Point(0, 0);
            this.countryGC.MainView = this.countryGV;
            this.countryGC.Name = "countryGC";
            this.countryGC.Size = new System.Drawing.Size(727, 392);
            this.countryGC.TabIndex = 0;
            this.countryGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.countryGV});
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = this.xpCollection1;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(CoreModel.Country);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // countryGV
            // 
            this.countryGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.gridColumn1,
            this.gridColumn2,
            this.colCountryCode,
            this.colCountryName});
            this.countryGV.EnableAutoFormat = true;
            this.countryGV.EnableAutoSave = true;
            this.countryGV.GridControl = this.countryGC;
            this.countryGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.SimpleEdit;
            this.countryGV.Name = "countryGV";
            this.countryGV.UnitOfWorkXpo = this.unitOfWork1;
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
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.Visible = true;
            this.colCountryCode.VisibleIndex = 7;
            // 
            // colCountryName
            // 
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 8;
            // 
            // provinceGC
            // 
            this.provinceGC.DataSource = this.provincesBindingSource;
            this.provinceGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.provinceGC.Location = new System.Drawing.Point(0, 0);
            this.provinceGC.MainView = this.provinceGV;
            this.provinceGC.Name = "provinceGC";
            this.provinceGC.Size = new System.Drawing.Size(727, 392);
            this.provinceGC.TabIndex = 0;
            this.provinceGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.provinceGV});
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataMember = "Provinces";
            this.provincesBindingSource.DataSource = this.countryBindingSource;
            // 
            // provinceGV
            // 
            this.provinceGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId1,
            this.colCreatedBy1,
            this.colCreatedAt1,
            this.colModifiedBy1,
            this.colModifiedAt1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.colProvinceCode,
            this.colProvinceName});
            this.provinceGV.EnableAutoFormat = true;
            this.provinceGV.EnableAutoSave = true;
            this.provinceGV.GridControl = this.provinceGC;
            this.provinceGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.SimpleEdit;
            this.provinceGV.Name = "provinceGV";
            this.provinceGV.UnitOfWorkXpo = this.unitOfWork1;
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
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "TableId!";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "TableId!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "ProvinceCountry!";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "ProvinceCountry!Key";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 8;
            // 
            // colProvinceCode
            // 
            this.colProvinceCode.FieldName = "ProvinceCode";
            this.colProvinceCode.Name = "colProvinceCode";
            this.colProvinceCode.Visible = true;
            this.colProvinceCode.VisibleIndex = 9;
            // 
            // colProvinceName
            // 
            this.colProvinceName.FieldName = "ProvinceName";
            this.colProvinceName.Name = "colProvinceName";
            this.colProvinceName.Visible = true;
            this.colProvinceName.VisibleIndex = 10;
            // 
            // cityGC
            // 
            this.cityGC.DataSource = this.citiesBindingSource;
            this.cityGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityGC.Location = new System.Drawing.Point(0, 0);
            this.cityGC.MainView = this.cityGV;
            this.cityGC.Name = "cityGC";
            this.cityGC.Size = new System.Drawing.Size(727, 392);
            this.cityGC.TabIndex = 0;
            this.cityGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cityGV});
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.provincesBindingSource;
            // 
            // cityGV
            // 
            this.cityGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId2,
            this.colCreatedBy2,
            this.colCreatedAt2,
            this.colModifiedBy2,
            this.colModifiedAt2,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.colCityCode,
            this.colCityName});
            this.cityGV.EnableAutoFormat = true;
            this.cityGV.EnableAutoSave = true;
            this.cityGV.GridControl = this.cityGC;
            this.cityGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.SimpleEdit;
            this.cityGV.Name = "cityGV";
            this.cityGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colLineId2
            // 
            this.colLineId2.FieldName = "LineId";
            this.colLineId2.Name = "colLineId2";
            this.colLineId2.Visible = true;
            this.colLineId2.VisibleIndex = 0;
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
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "TableId!";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "TableId!Key";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "Province!";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "Province!Key";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            // 
            // colCityCode
            // 
            this.colCityCode.FieldName = "CityCode";
            this.colCityCode.Name = "colCityCode";
            this.colCityCode.Visible = true;
            this.colCityCode.VisibleIndex = 9;
            // 
            // colCityName
            // 
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 10;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(785, 402);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.countryGC);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(727, 392);
            this.xtraTabPage1.Text = "Country";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.provinceGC);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(727, 392);
            this.xtraTabPage2.Text = "Province";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.cityGC);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(727, 392);
            this.xtraTabPage3.Text = "City";
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(785, 402);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "TestFrm";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CoreLib.Grid.MyGridControl countryGC;
        private CoreLib.Grid.MyGridView countryGV;
        private CoreLib.Grid.MyGridControl provinceGC;
        private CoreLib.Grid.MyGridView provinceGV;
        private CoreLib.Grid.MyGridControl cityGC;
        private CoreLib.Grid.MyGridView cityGV;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinceCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinceName;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId2;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy2;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt2;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy2;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colCityCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCityName;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
    }
}
