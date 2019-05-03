namespace CoreModelWin
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
            DevExpress.Utils.Animation.PushTransition pushTransition2 = new DevExpress.Utils.Animation.PushTransition();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.SystemSetupNavGrp = new DevExpress.XtraNavBar.NavBarGroup();
            this.fiscalCalenderLink = new DevExpress.XtraNavBar.NavBarItem();
            this.fiscalCalenderYearLink = new DevExpress.XtraNavBar.NavBarItem();
            this.fieldsSettingsLink = new DevExpress.XtraNavBar.NavBarItem();
            this.uILabelLink = new DevExpress.XtraNavBar.NavBarItem();
            this.tableBaseLink = new DevExpress.XtraNavBar.NavBarItem();
            this.sequenceLink = new DevExpress.XtraNavBar.NavBarItem();
            this.currencyCodeLink = new DevExpress.XtraNavBar.NavBarItem();
            this.currencySetupLink = new DevExpress.XtraNavBar.NavBarItem();
            this.testLink = new DevExpress.XtraNavBar.NavBarItem();
            this.gLNavGrp = new DevExpress.XtraNavBar.NavBarGroup();
            this.cOALink = new DevExpress.XtraNavBar.NavBarItem();
            this.mainAccountsTypeLink = new DevExpress.XtraNavBar.NavBarItem();
            this.mainAccountsLink = new DevExpress.XtraNavBar.NavBarItem();
            this.aPNavGrp = new DevExpress.XtraNavBar.NavBarGroup();
            this.aRNabGrp = new DevExpress.XtraNavBar.NavBarGroup();
            this.customerLink = new DevExpress.XtraNavBar.NavBarItem();
            this.orgNavGrp = new DevExpress.XtraNavBar.NavBarGroup();
            this.countryLink = new DevExpress.XtraNavBar.NavBarItem();
            this.cityLink = new DevExpress.XtraNavBar.NavBarItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.retrieveBI = new DevExpress.XtraBars.BarButtonItem();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.delBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.printBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.langBI = new DevExpress.XtraBars.BarEditItem();
            this.langRIImageCombo = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.approveBI = new DevExpress.XtraBars.BarButtonItem();
            this.approvePopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.statusBarTxt = new DevExpress.XtraBars.BarStaticItem();
            this.effectiveDateBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.testBI = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            this.sharedImageCollection1 = new DevExpress.Utils.SharedImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langRIImageCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvePopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1.ImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.SystemSetupNavGrp;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.SystemSetupNavGrp,
            this.gLNavGrp,
            this.aPNavGrp,
            this.aRNabGrp,
            this.orgNavGrp});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.tableBaseLink,
            this.uILabelLink,
            this.fieldsSettingsLink,
            this.sequenceLink,
            this.currencySetupLink,
            this.currencyCodeLink,
            this.fiscalCalenderLink,
            this.fiscalCalenderYearLink,
            this.cOALink,
            this.mainAccountsTypeLink,
            this.mainAccountsLink,
            this.customerLink,
            this.countryLink,
            this.cityLink,
            this.testLink});
            this.navBarControl1.Location = new System.Drawing.Point(0, 51);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 203;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(203, 367);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // SystemSetupNavGrp
            // 
            this.SystemSetupNavGrp.Caption = "System setup";
            this.SystemSetupNavGrp.Expanded = true;
            this.SystemSetupNavGrp.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.fiscalCalenderLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.fiscalCalenderYearLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.fieldsSettingsLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.uILabelLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.tableBaseLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.sequenceLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.currencyCodeLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.currencySetupLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.testLink)});
            this.SystemSetupNavGrp.Name = "SystemSetupNavGrp";
            this.SystemSetupNavGrp.SmallImage = ((System.Drawing.Image)(resources.GetObject("SystemSetupNavGrp.SmallImage")));
            // 
            // fiscalCalenderLink
            // 
            this.fiscalCalenderLink.Caption = "Fiscal calender";
            this.fiscalCalenderLink.LargeImage = ((System.Drawing.Image)(resources.GetObject("fiscalCalenderLink.LargeImage")));
            this.fiscalCalenderLink.Name = "fiscalCalenderLink";
            this.fiscalCalenderLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("fiscalCalenderLink.SmallImage")));
            // 
            // fiscalCalenderYearLink
            // 
            this.fiscalCalenderYearLink.Caption = "Fiscal calender year";
            this.fiscalCalenderYearLink.Name = "fiscalCalenderYearLink";
            this.fiscalCalenderYearLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("fiscalCalenderYearLink.SmallImage")));
            // 
            // fieldsSettingsLink
            // 
            this.fieldsSettingsLink.Caption = "Fields settings";
            this.fieldsSettingsLink.Name = "fieldsSettingsLink";
            this.fieldsSettingsLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("fieldsSettingsLink.SmallImage")));
            // 
            // uILabelLink
            // 
            this.uILabelLink.Caption = "UI Labels";
            this.uILabelLink.Name = "uILabelLink";
            this.uILabelLink.SmallImage = global::CoreModelWin.Properties.Resources.language_16x16;
            // 
            // tableBaseLink
            // 
            this.tableBaseLink.Caption = "Table info";
            this.tableBaseLink.Name = "tableBaseLink";
            this.tableBaseLink.SmallImage = global::CoreModelWin.Properties.Resources.grid_16x16;
            // 
            // sequenceLink
            // 
            this.sequenceLink.Caption = "Sequences";
            this.sequenceLink.Name = "sequenceLink";
            this.sequenceLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("sequenceLink.SmallImage")));
            // 
            // currencyCodeLink
            // 
            this.currencyCodeLink.Caption = "Currency code";
            this.currencyCodeLink.Name = "currencyCodeLink";
            this.currencyCodeLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("currencyCodeLink.SmallImage")));
            // 
            // currencySetupLink
            // 
            this.currencySetupLink.Caption = "Currency setup";
            this.currencySetupLink.Name = "currencySetupLink";
            this.currencySetupLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("currencySetupLink.SmallImage")));
            // 
            // testLink
            // 
            this.testLink.Caption = "Test";
            this.testLink.Name = "testLink";
            // 
            // gLNavGrp
            // 
            this.gLNavGrp.Caption = "General Ledger";
            this.gLNavGrp.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.cOALink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainAccountsTypeLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainAccountsLink)});
            this.gLNavGrp.Name = "gLNavGrp";
            this.gLNavGrp.SmallImage = ((System.Drawing.Image)(resources.GetObject("gLNavGrp.SmallImage")));
            // 
            // cOALink
            // 
            this.cOALink.Caption = "Chart of accounts";
            this.cOALink.Name = "cOALink";
            this.cOALink.SmallImage = ((System.Drawing.Image)(resources.GetObject("cOALink.SmallImage")));
            // 
            // mainAccountsTypeLink
            // 
            this.mainAccountsTypeLink.Caption = "Main accounts type";
            this.mainAccountsTypeLink.Name = "mainAccountsTypeLink";
            this.mainAccountsTypeLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainAccountsTypeLink.SmallImage")));
            // 
            // mainAccountsLink
            // 
            this.mainAccountsLink.Caption = "Main accounts";
            this.mainAccountsLink.Name = "mainAccountsLink";
            this.mainAccountsLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainAccountsLink.SmallImage")));
            // 
            // aPNavGrp
            // 
            this.aPNavGrp.Caption = "Accounts payable";
            this.aPNavGrp.Name = "aPNavGrp";
            this.aPNavGrp.SmallImage = ((System.Drawing.Image)(resources.GetObject("aPNavGrp.SmallImage")));
            // 
            // aRNabGrp
            // 
            this.aRNabGrp.Caption = "Accounts receivable";
            this.aRNabGrp.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.customerLink)});
            this.aRNabGrp.Name = "aRNabGrp";
            this.aRNabGrp.SmallImage = ((System.Drawing.Image)(resources.GetObject("aRNabGrp.SmallImage")));
            // 
            // customerLink
            // 
            this.customerLink.Caption = "Customer";
            this.customerLink.Name = "customerLink";
            this.customerLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("customerLink.SmallImage")));
            // 
            // orgNavGrp
            // 
            this.orgNavGrp.Caption = "Organization";
            this.orgNavGrp.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.countryLink),
            new DevExpress.XtraNavBar.NavBarItemLink(this.cityLink)});
            this.orgNavGrp.Name = "orgNavGrp";
            this.orgNavGrp.SmallImage = ((System.Drawing.Image)(resources.GetObject("orgNavGrp.SmallImage")));
            // 
            // countryLink
            // 
            this.countryLink.Caption = "Country";
            this.countryLink.Name = "countryLink";
            this.countryLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("countryLink.SmallImage")));
            // 
            // cityLink
            // 
            this.cityLink.Caption = "City";
            this.cityLink.Name = "cityLink";
            this.cityLink.SmallImage = ((System.Drawing.Image)(resources.GetObject("cityLink.SmallImage")));
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.statusBarTxt,
            this.skinBarSubItem1,
            this.testBI,
            this.retrieveBI,
            this.saveBarButtonItem,
            this.addBarButtonItem,
            this.delBarButtonItem,
            this.printBarButtonItem,
            this.barButtonItem1,
            this.langBI,
            this.barEditItem1,
            this.effectiveDateBarStaticItem,
            this.approveBI,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 19;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.langRIImageCombo,
            this.repositoryItemImageComboBox1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.retrieveBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.delBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.printBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.langBI),
            new DevExpress.XtraBars.LinkPersistInfo(this.approveBI)});
            this.bar1.Text = "Tools";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skin";
            this.skinBarSubItem1.Id = 1;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            this.skinBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // retrieveBI
            // 
            this.retrieveBI.Caption = "Retrieve";
            this.retrieveBI.Glyph = ((System.Drawing.Image)(resources.GetObject("retrieveBI.Glyph")));
            this.retrieveBI.Id = 4;
            this.retrieveBI.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("retrieveBI.LargeGlyph")));
            this.retrieveBI.Name = "retrieveBI";
            this.retrieveBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // saveBarButtonItem
            // 
            this.saveBarButtonItem.Caption = "Save";
            this.saveBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.Glyph")));
            this.saveBarButtonItem.Id = 6;
            this.saveBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("saveBarButtonItem.LargeGlyph")));
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "Add";
            this.addBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("addBarButtonItem.Glyph")));
            this.addBarButtonItem.Id = 7;
            this.addBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBarButtonItem.LargeGlyph")));
            this.addBarButtonItem.Name = "addBarButtonItem";
            // 
            // delBarButtonItem
            // 
            this.delBarButtonItem.Caption = "Delete";
            this.delBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("delBarButtonItem.Glyph")));
            this.delBarButtonItem.Id = 8;
            this.delBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("delBarButtonItem.LargeGlyph")));
            this.delBarButtonItem.Name = "delBarButtonItem";
            // 
            // printBarButtonItem
            // 
            this.printBarButtonItem.Caption = "Print";
            this.printBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("printBarButtonItem.Glyph")));
            this.printBarButtonItem.Id = 9;
            this.printBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printBarButtonItem.LargeGlyph")));
            this.printBarButtonItem.Name = "printBarButtonItem";
            // 
            // langBI
            // 
            this.langBI.Caption = "Lang";
            this.langBI.Edit = this.langRIImageCombo;
            this.langBI.Id = 11;
            this.langBI.Name = "langBI";
            this.langBI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // langRIImageCombo
            // 
            this.langRIImageCombo.AutoHeight = false;
            this.langRIImageCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.langRIImageCombo.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("EN", "en", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("AR", "ar", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("FR", "fr", -1)});
            this.langRIImageCombo.Name = "langRIImageCombo";
            // 
            // approveBI
            // 
            this.approveBI.ActAsDropDown = true;
            this.approveBI.AllowDrawArrow = false;
            this.approveBI.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.approveBI.Caption = "Action";
            this.approveBI.DropDownControl = this.approvePopupMenu;
            this.approveBI.Id = 14;
            this.approveBI.Name = "approveBI";
            // 
            // approvePopupMenu
            // 
            this.approvePopupMenu.Manager = this.barManager1;
            this.approvePopupMenu.MenuCaption = "Workflow steps";
            this.approvePopupMenu.Name = "approvePopupMenu";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Make it ready";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Approve";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Reopen";
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.statusBarTxt),
            new DevExpress.XtraBars.LinkPersistInfo(this.effectiveDateBarStaticItem, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // statusBarTxt
            // 
            this.statusBarTxt.Caption = "Ok";
            this.statusBarTxt.Id = 0;
            this.statusBarTxt.Name = "statusBarTxt";
            this.statusBarTxt.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // effectiveDateBarStaticItem
            // 
            this.effectiveDateBarStaticItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.effectiveDateBarStaticItem.Id = 13;
            this.effectiveDateBarStaticItem.Name = "effectiveDateBarStaticItem";
            this.effectiveDateBarStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(772, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 418);
            this.barDockControlBottom.Size = new System.Drawing.Size(772, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 367);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(772, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 367);
            // 
            // testBI
            // 
            this.testBI.Caption = "Test";
            this.testBI.Id = 3;
            this.testBI.Name = "testBI";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.langRIImageCombo;
            this.barEditItem1.Id = 12;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition2;
            // 
            // sharedImageCollection1
            // 
            // 
            // 
            // 
            this.sharedImageCollection1.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("sharedImageCollection1.ImageSource.ImageStream")));
            this.sharedImageCollection1.ParentControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 445);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langRIImageCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvePopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup SystemSetupNavGrp;
        private DevExpress.XtraNavBar.NavBarItem tableBaseLink;
        private DevExpress.XtraNavBar.NavBarItem uILabelLink;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem statusBarTxt;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarButtonItem testBI;
        private DevExpress.XtraNavBar.NavBarItem fieldsSettingsLink;
        private DevExpress.XtraBars.BarButtonItem retrieveBI;
        private DevExpress.XtraNavBar.NavBarItem sequenceLink;
        private DevExpress.XtraNavBar.NavBarItem currencySetupLink;
        private DevExpress.XtraNavBar.NavBarItem currencyCodeLink;
        private DevExpress.XtraNavBar.NavBarItem fiscalCalenderLink;
        private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem addBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem delBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem printBarButtonItem;
        private DevExpress.XtraBars.BarEditItem langBI;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox langRIImageCombo;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.SharedImageCollection sharedImageCollection1;
        private DevExpress.XtraNavBar.NavBarItem fiscalCalenderYearLink;
        private DevExpress.XtraNavBar.NavBarGroup gLNavGrp;
        private DevExpress.XtraNavBar.NavBarItem cOALink;
        private DevExpress.XtraNavBar.NavBarGroup aPNavGrp;
        private DevExpress.XtraNavBar.NavBarGroup aRNabGrp;
        private DevExpress.XtraNavBar.NavBarItem mainAccountsTypeLink;
        private DevExpress.XtraNavBar.NavBarItem mainAccountsLink;
        private DevExpress.XtraNavBar.NavBarItem customerLink;
        private DevExpress.XtraNavBar.NavBarGroup orgNavGrp;
        private DevExpress.XtraNavBar.NavBarItem countryLink;
        private DevExpress.XtraNavBar.NavBarItem cityLink;
        private DevExpress.XtraNavBar.NavBarItem testLink;
        private DevExpress.XtraBars.BarStaticItem effectiveDateBarStaticItem;
        private DevExpress.XtraBars.BarButtonItem approveBI;
        private DevExpress.XtraBars.PopupMenu approvePopupMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}

