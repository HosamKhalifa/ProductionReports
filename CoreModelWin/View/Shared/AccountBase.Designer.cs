namespace CoreModelWin.View.Shared
{
    partial class AccountBase
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
            this.mainTabC = new DevExpress.XtraTab.XtraTabControl();
            this.overviewTabG = new DevExpress.XtraTab.XtraTabPage();
            this.accountBaseGC = new CoreLib.Grid.MyGridControl();
            this.accountBaseXPC = new DevExpress.Xpo.XPCollection(this.components);
            this.accountBaseGV = new CoreLib.Grid.MyGridView();
            this.colLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefNo1_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.generalTabG = new DevExpress.XtraTab.XtraTabPage();
            this.accountBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressGC = new CoreLib.Grid.MyGridControl();
            this.addressGV = new CoreLib.Grid.MyGridView();
            this.accountAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLineId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedAt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPrimary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReportHint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxFileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommercialRegistry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabC)).BeginInit();
            this.mainTabC.SuspendLayout();
            this.overviewTabG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseXPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGV)).BeginInit();
            this.generalTabG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountAddressesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabC
            // 
            this.mainTabC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabC.Location = new System.Drawing.Point(0, 12);
            this.mainTabC.Name = "mainTabC";
            this.mainTabC.SelectedTabPage = this.overviewTabG;
            this.mainTabC.Size = new System.Drawing.Size(796, 413);
            this.mainTabC.TabIndex = 0;
            this.mainTabC.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.overviewTabG,
            this.generalTabG});
            // 
            // overviewTabG
            // 
            this.overviewTabG.Controls.Add(this.accountBaseGC);
            this.overviewTabG.Name = "overviewTabG";
            this.overviewTabG.Size = new System.Drawing.Size(794, 380);
            this.overviewTabG.Text = "Overview";
            // 
            // accountBaseGC
            // 
            this.accountBaseGC.DataSource = this.accountBaseBindingSource;
            this.accountBaseGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountBaseGC.Location = new System.Drawing.Point(0, 0);
            this.accountBaseGC.MainView = this.accountBaseGV;
            this.accountBaseGC.Name = "accountBaseGC";
            this.accountBaseGC.Size = new System.Drawing.Size(794, 380);
            this.accountBaseGC.TabIndex = 0;
            this.accountBaseGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accountBaseGV});
            // 
            // accountBaseXPC
            // 
            this.accountBaseXPC.LoadingEnabled = false;
            this.accountBaseXPC.ObjectType = typeof(CoreModel.Account);
            this.accountBaseXPC.Session = this.unitOfWork1;
            // 
            // accountBaseGV
            // 
            this.accountBaseGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId,
            this.colCreatedBy,
            this.colCreatedAt,
            this.colModifiedBy,
            this.colModifiedAt,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colDisplayNumber,
            this.colName,
            this.colDescription,
            this.colActive,
            this.colRefNo1_Name,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.colReferenceNumber,
            this.gridColumn11,
            this.gridColumn12});
            this.accountBaseGV.EnableAutoFormat = false;
            this.accountBaseGV.EnableAutoSave = false;
            this.accountBaseGV.GridControl = this.accountBaseGC;
            this.accountBaseGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;
            this.accountBaseGV.Name = "accountBaseGV";
            this.accountBaseGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.accountBaseGV.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Cached;
            this.accountBaseGV.OptionsEditForm.EditFormColumnCount = 2;
            this.accountBaseGV.OptionsView.ColumnAutoWidth = false;
            this.accountBaseGV.OptionsView.EnableAppearanceEvenRow = true;
            this.accountBaseGV.OptionsView.ShowAutoFilterRow = true;
            this.accountBaseGV.OptionsView.ShowFooter = true;
            this.accountBaseGV.UnitOfWorkXpo = this.unitOfWork1;
            // 
            // colLineId
            // 
            this.colLineId.FieldName = "LineId";
            this.colLineId.Name = "colLineId";
            this.colLineId.OptionsColumn.AllowEdit = false;
            this.colLineId.OptionsColumn.ReadOnly = true;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowEdit = false;
            this.colCreatedBy.OptionsColumn.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.OptionsColumn.AllowEdit = false;
            this.colCreatedAt.OptionsColumn.ReadOnly = true;
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            this.colModifiedBy.OptionsColumn.AllowEdit = false;
            this.colModifiedBy.OptionsColumn.ReadOnly = true;
            // 
            // colModifiedAt
            // 
            this.colModifiedAt.FieldName = "ModifiedAt";
            this.colModifiedAt.Name = "colModifiedAt";
            this.colModifiedAt.OptionsColumn.AllowEdit = false;
            this.colModifiedAt.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "TableId!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "TableId!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "DimensionHeader!";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "DimensionHeader!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            // 
            // colDisplayNumber
            // 
            this.colDisplayNumber.FieldName = "DisplayNumber";
            this.colDisplayNumber.Name = "colDisplayNumber";
            this.colDisplayNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DisplayNumber", "{0}")});
            this.colDisplayNumber.Visible = true;
            this.colDisplayNumber.VisibleIndex = 0;
            this.colDisplayNumber.Width = 88;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 166;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 130;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            this.colActive.Width = 43;
            // 
            // colRefNo1_Name
            // 
            this.colRefNo1_Name.Caption = "Ref 1 name";
            this.colRefNo1_Name.FieldName = "ReferenceNumber1.RefNo1Name";
            this.colRefNo1_Name.Name = "colRefNo1_Name";
            this.colRefNo1_Name.OptionsColumn.AllowEdit = false;
            this.colRefNo1_Name.OptionsColumn.ReadOnly = true;
            this.colRefNo1_Name.Visible = true;
            this.colRefNo1_Name.VisibleIndex = 6;
            this.colRefNo1_Name.Width = 109;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "ReferenceNumber1!Key";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 111;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ref 2 name";
            this.gridColumn7.FieldName = "ReferenceNumber2.RefNo1Name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 109;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "ReferenceNumber2!Key";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Primary group";
            this.gridColumn9.FieldName = "GroupId.GroupName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 111;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "GroupId!Key";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.FieldName = "ReferenceNumber";
            this.colReferenceNumber.Name = "colReferenceNumber";
            this.colReferenceNumber.Visible = true;
            this.colReferenceNumber.VisibleIndex = 1;
            this.colReferenceNumber.Width = 102;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "PrimaryAddress!";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 8;
            this.gridColumn11.Width = 103;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "PrimaryAddress!Key";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 9;
            // 
            // generalTabG
            // 
            this.generalTabG.Controls.Add(this.addressGC);
            this.generalTabG.Name = "generalTabG";
            this.generalTabG.Size = new System.Drawing.Size(794, 380);
            this.generalTabG.Text = "General";
            // 
            // accountBaseBindingSource
            // 
            this.accountBaseBindingSource.DataSource = this.accountBaseXPC;
            // 
            // addressGC
            // 
            this.addressGC.DataSource = this.accountAddressesBindingSource;
            this.addressGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressGC.Location = new System.Drawing.Point(0, 0);
            this.addressGC.MainView = this.addressGV;
            this.addressGC.Name = "addressGC";
            this.addressGC.Size = new System.Drawing.Size(794, 380);
            this.addressGC.TabIndex = 0;
            this.addressGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.addressGV});
            // 
            // addressGV
            // 
            this.addressGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLineId1,
            this.colCreatedBy1,
            this.colCreatedAt1,
            this.colModifiedBy1,
            this.colModifiedAt1,
            this.gridColumn5,
            this.gridColumn13,
            this.colRowNumber,
            this.gridColumn14,
            this.gridColumn15,
            this.colIsPrimary,
            this.colAddressDetails,
            this.colContact,
            this.colReportHint,
            this.colTelephone,
            this.colMobile,
            this.colFax,
            this.colEmail,
            this.colCountry,
            this.colCity,
            this.colTaxFileNumber,
            this.colTaxCardNumber,
            this.colCommercialRegistry,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19});
            this.addressGV.EnableAutoFormat = true;
            this.addressGV.EnableAutoSave = true;
            this.addressGV.GridControl = this.addressGC;
            this.addressGV.GridViewEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;
            this.addressGV.Name = "addressGV";
            this.addressGV.UnitOfWorkXpo = null;
            // 
            // accountAddressesBindingSource
            // 
            this.accountAddressesBindingSource.DataMember = "AccountAddresses";
            this.accountAddressesBindingSource.DataSource = this.accountBaseBindingSource;
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
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "TableId!";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "TableId!Key";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            // 
            // colRowNumber
            // 
            this.colRowNumber.FieldName = "RowNumber";
            this.colRowNumber.Name = "colRowNumber";
            this.colRowNumber.Visible = true;
            this.colRowNumber.VisibleIndex = 7;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "Account!";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "Account!Key";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 9;
            // 
            // colIsPrimary
            // 
            this.colIsPrimary.FieldName = "IsPrimary";
            this.colIsPrimary.Name = "colIsPrimary";
            this.colIsPrimary.Visible = true;
            this.colIsPrimary.VisibleIndex = 10;
            // 
            // colAddressDetails
            // 
            this.colAddressDetails.FieldName = "AddressDetails";
            this.colAddressDetails.Name = "colAddressDetails";
            this.colAddressDetails.Visible = true;
            this.colAddressDetails.VisibleIndex = 11;
            // 
            // colContact
            // 
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 12;
            // 
            // colReportHint
            // 
            this.colReportHint.FieldName = "ReportHint";
            this.colReportHint.Name = "colReportHint";
            this.colReportHint.Visible = true;
            this.colReportHint.VisibleIndex = 13;
            // 
            // colTelephone
            // 
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 14;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 15;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 16;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 17;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 18;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 19;
            // 
            // colTaxFileNumber
            // 
            this.colTaxFileNumber.FieldName = "TaxFileNumber";
            this.colTaxFileNumber.Name = "colTaxFileNumber";
            this.colTaxFileNumber.Visible = true;
            this.colTaxFileNumber.VisibleIndex = 20;
            // 
            // colTaxCardNumber
            // 
            this.colTaxCardNumber.FieldName = "TaxCardNumber";
            this.colTaxCardNumber.Name = "colTaxCardNumber";
            this.colTaxCardNumber.Visible = true;
            this.colTaxCardNumber.VisibleIndex = 21;
            // 
            // colCommercialRegistry
            // 
            this.colCommercialRegistry.FieldName = "CommercialRegistry";
            this.colCommercialRegistry.Name = "colCommercialRegistry";
            this.colCommercialRegistry.Visible = true;
            this.colCommercialRegistry.VisibleIndex = 22;
            // 
            // gridColumn16
            // 
            this.gridColumn16.FieldName = "TaxAgency!";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 23;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "TaxAgency!Key";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 24;
            // 
            // gridColumn18
            // 
            this.gridColumn18.FieldName = "TaxGroup!";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 25;
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "TaxGroup!Key";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 26;
            // 
            // AccountBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(886, 437);
            this.Controls.Add(this.mainTabC);
            this.Name = "AccountBase";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabC)).EndInit();
            this.mainTabC.ResumeLayout(false);
            this.overviewTabG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseXPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseGV)).EndInit();
            this.generalTabG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountAddressesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage overviewTabG;
        private DevExpress.XtraTab.XtraTabPage generalTabG;
        public DevExpress.XtraTab.XtraTabControl mainTabC;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNo1_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        public CoreLib.Grid.MyGridControl accountBaseGC;
        public CoreLib.Grid.MyGridView accountBaseGV;
        public DevExpress.Xpo.XPCollection accountBaseXPC;
        private System.Windows.Forms.BindingSource accountBaseBindingSource;
        private CoreLib.Grid.MyGridControl addressGC;
        private System.Windows.Forms.BindingSource accountAddressesBindingSource;
        private CoreLib.Grid.MyGridView addressGV;
        private DevExpress.XtraGrid.Columns.GridColumn colLineId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedAt1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn colRowNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPrimary;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colReportHint;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxFileNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCommercialRegistry;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
    }
}
