using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using System.IO;
using DevExpress.Xpo;
using CoreModel;

namespace CoreModelWin.AppLists
{
    public partial class PersistentRepositoryXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public PersistentRepositoryXUC()
        {
            InitializeComponent();
            appListStore = new List<AppListInfo>();
            
            MarkersIconsComboBox.PopulateMarkerImageComboBox(symbolRIImageComboBox);
           


        }

        #region InnerClasses
        
        public class AppListInfo //Class holding infos about app list object 
        {
            public AppListInfo() 
            {
                IsORMDataUsed = false;
                
                ActiveColumnLinks = new List<DevExpress.XtraGrid.Columns.GridColumn>();
                listBindingSource = new BindingSource();
                
            }

            #region Members
            BindingSource listBindingSource;
            private RepositoryItemLookUpEditBase repositoryItem;
            XPBaseCollection dataMemberXPCollection;

            #endregion

            #region Properties
            public bool IsORMDataUsed { get; set; }
            
            public XPBaseCollection DataMemberXPCollection
            {
                get { return dataMemberXPCollection; }
                set {
                       dataMemberXPCollection = value;
                       ListBindingSource.DataSource = dataMemberXPCollection;
                    }
            }
            public SqlConnection Conn { get; set; }
            public RepositoryItemLookUpEditBase RepositoryItem 
            { 
                get { return repositoryItem; } 
                set 
                { 
                    repositoryItem = value;
                    AddButtonsToList(repositoryItem);
                } 
            }
            public DataTable DataMember { get; set; }
            public SqlDataAdapter DataAdapter { get; set; }
            
            public Type ClassType { get; set; }
            public TableBase.TableEnum AppListName { get; set; }
            public List<DevExpress.XtraGrid.Columns.GridColumn> ActiveColumnLinks { get; set; }
            public BindingSource ListBindingSource { set { listBindingSource = value; } get { return listBindingSource; } }
            public object LayoutObject { get; set; }
            public string DisplayMember { get { return RepositoryItem.DisplayMember; } set { RepositoryItem.DisplayMember = value; } }
            public string ValueMember { get { return RepositoryItem.ValueMember; } set { RepositoryItem.ValueMember = value; } }

            public SqlParameterCollection SqlParms { get { return DataAdapter.SelectCommand.Parameters; } }
            #endregion

            #region Methods

         
            
            private int  RetrieveRowsFromDB() 
            {
                int rowsCount;

                if (IsORMDataUsed)
                {
                    DataMemberXPCollection.LoadingEnabled = true;
                    DataMemberXPCollection.Load();
                    rowsCount=DataMemberXPCollection.Count;
                }
                else
                {
                    DataAdapter.Fill(DataMember.DataSet, DataMember.TableName);
                    rowsCount = DataMember.Rows.Count;
                }

                return rowsCount;
            }
            
            public  int  RetrieveRows(bool EnforceFromDB) 
            {
                
                int rowsCount;
                //Check if this list using XPCollection 
                if (IsORMDataUsed)
                {
                    if (EnforceFromDB)
                    {
                        rowsCount = RetrieveRowsFromDB();
                    }
                    else
                    {
                        if (DataMemberXPCollection.Count == 0)
                        {
                            RetrieveRowsFromDB();
                        }
                        rowsCount = DataMemberXPCollection.Count;//listBindingSource.Count;
                    }
                    listBindingSource.DataSource = this.DataMemberXPCollection;
                    RepositoryItem.DataSource = listBindingSource;
                    rowsCount = this.DataMemberXPCollection.Count;

                }
                else
                {
                    listBindingSource.DataSource = DataMember;
                    RepositoryItem.DataSource = listBindingSource;
                    rowsCount = DataMember.Rows.Count;
                    if (EnforceFromDB)
                    {
                        rowsCount = RetrieveRowsFromDB();
                    }
                    else
                    {
                        if (rowsCount <= 0)
                        {
                            //Try to get rows from Database
                            RetrieveRowsFromDB();
                        }

                    }
                }

                return rowsCount;
                
            }

            public void LinkListToColumn(DevExpress.XtraGrid.Columns.GridColumn col) 
            {
                col.ColumnEdit = RepositoryItem;
                ActiveColumnLinks.Add(col);
                RetrieveRows(false); //Tell AppList to get its rows if it the first use
            }
            public void LinkListToColumn(DevExpress.XtraTreeList.Columns.TreeListColumn col)
            {
                col.ColumnEdit = RepositoryItem;
                RetrieveRows(false); //Tell AppList to get its rows if it the first use

            }
            public void LinkListToColumn(DevExpress.XtraBars.BarEditItem col)
            {
                col.Edit = RepositoryItem;
                RetrieveRows(false); //Tell AppList to get its rows if it the first use

            }

            public void LinkListToColumn(DevExpress.XtraEditors.TreeListLookUpEdit col, string treeFilterString ="") 
            {
                try
                {

                    DevExpress.XtraTreeList.TreeList MyList = (DevExpress.XtraTreeList.TreeList)this.LayoutObject;
                    MyList.DataSource = this.ListBindingSource;
                    col.Properties.DataSource       = this.ListBindingSource;
                    col.Properties.DisplayMember    = this.DisplayMember;
                    col.Properties.ValueMember      = this.ValueMember;
                    RetrieveRows(false);
                    col.Properties.TreeList.ForceInitialize();
                    CopySettings(MyList, col.Properties.TreeList);
                    if (treeFilterString != "")
                    {
                        col.Properties.TreeList.AddFilter(treeFilterString);
                    }
                
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(GlobalMethods.FormateExceptionMessage(ex));
                }

            }
            public void LinkListToColumn(DevExpress.XtraEditors.LookUpEdit col)
            {
                try
                {

                    RepositoryItemLookUpEdit MyList = (RepositoryItemLookUpEdit)this.LayoutObject;
                    //MyList.Columns.Assign(col.Properties.Columns);
                    col.Properties.Columns.Assign(MyList.Columns);
                    col.Properties.DataSource       = this.ListBindingSource;
                    col.Properties.DisplayMember    = this.DisplayMember;
                    col.Properties.ValueMember      = this.ValueMember;
                    RetrieveRows(false);


                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(GlobalMethods.FormateExceptionMessage(ex));
                }

            }
            public void LinkListToColumn(DevExpress.XtraEditors.SearchLookUpEdit col, string gridFilterString = "") 
            {
                try
                {

                    DevExpress.XtraGrid.Views.Grid.GridView MyList = (DevExpress.XtraGrid.Views.Grid.GridView)this.LayoutObject;

                    col.Properties.DataSource       = this.ListBindingSource;
                    col.Properties.DisplayMember    = this.DisplayMember ;
                    col.Properties.ValueMember      = this.ValueMember;
                    
                    RetrieveRows(false);
                    col.Properties.View.GridControl.ForceInitialize();
                    CopySettings(MyList, col.Properties.View);
                    if (gridFilterString != "")
                    {
                        col.Properties.View.ActiveFilterString = gridFilterString;
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(GlobalMethods.FormateExceptionMessage(ex));
                }
            }

            public void CopySettings(DevExpress.XtraGrid.Views.Grid.GridView sourceGV, DevExpress.XtraGrid.Views.Grid.GridView targetGV) 
            {
                targetGV.GridControl.ForceInitialize();
                targetGV.OptionsView.ColumnAutoWidth = sourceGV.OptionsView.ColumnAutoWidth;
                targetGV.OptionsView.ShowAutoFilterRow = sourceGV.OptionsView.ShowAutoFilterRow;
                targetGV.OptionsView.ShowFooter = sourceGV.OptionsView.ShowFooter;
                targetGV.OptionsView.ShowGroupPanel = sourceGV.OptionsView.ShowGroupPanel;
                targetGV.OptionsView.EnableAppearanceEvenRow = sourceGV.OptionsView.EnableAppearanceEvenRow;
                targetGV.OptionsView.EnableAppearanceOddRow= sourceGV.OptionsView.EnableAppearanceOddRow;
                targetGV.OptionsView.ShowFilterPanelMode= sourceGV.OptionsView.ShowFilterPanelMode;
                targetGV.OptionsView.ShowGroupedColumns= sourceGV.OptionsView.ShowGroupedColumns;

                    
                targetGV.Columns.Clear();//reset all columns

                foreach (DevExpress.XtraGrid.Columns.GridColumn col in sourceGV.Columns)
                {
                    DevExpress.XtraGrid.Columns.GridColumn colToken = targetGV.Columns.AddField(col.FieldName);
                    colToken.Caption = col.GetCaption();
                    colToken.FieldNameSortGroup = col.FieldNameSortGroup;
                    colToken.SortIndex = col.SortIndex;
                    colToken.SortMode = col.SortMode;
                    colToken.SortOrder = col.SortOrder;
                    colToken.Visible = col.Visible;
                    colToken.VisibleIndex = col.VisibleIndex;
                    colToken.Width = col.Width;
                    colToken.UnboundExpression = col.UnboundExpression;
                    colToken.UnboundType = col.UnboundType;


                }


            }
            public void CopySettings(DevExpress.XtraTreeList.TreeList sourceTL, DevExpress.XtraTreeList.TreeList targetTL)
            {
                targetTL.ForceInitialize();
                targetTL.OptionsView.AutoWidth                  = sourceTL.OptionsView.AutoWidth;
                targetTL.OptionsView.ShowAutoFilterRow          = sourceTL.OptionsView.ShowAutoFilterRow;
                targetTL.OptionsView.ExpandButtonCentered       = sourceTL.OptionsView.ExpandButtonCentered;
                targetTL.OptionsView.FocusRectStyle             = sourceTL.OptionsView.FocusRectStyle;
                targetTL.OptionsView.EnableAppearanceEvenRow    = sourceTL.OptionsView.EnableAppearanceEvenRow;
                targetTL.OptionsView.EnableAppearanceOddRow     = sourceTL.OptionsView.EnableAppearanceOddRow;
                targetTL.OptionsView.ShowFilterPanelMode        = sourceTL.OptionsView.ShowFilterPanelMode;
                targetTL.OptionsView.HeaderFilterButtonShowMode = sourceTL.OptionsView.HeaderFilterButtonShowMode;
                targetTL.OptionsView.ShowBands                  = sourceTL.OptionsView.ShowBands;
                targetTL.OptionsView.ShowButtons                = sourceTL.OptionsView.ShowButtons;
                targetTL.OptionsView.ShowColumns                = sourceTL.OptionsView.ShowColumns;
                targetTL.OptionsView.ShowHorzLines              = sourceTL.OptionsView.ShowHorzLines;
                targetTL.OptionsView.ShowIndicator              = sourceTL.OptionsView.ShowIndicator;
                targetTL.OptionsView.ShowPreview                = sourceTL.OptionsView.ShowPreview;
                targetTL.OptionsView.ShowRoot                   = sourceTL.OptionsView.ShowRoot;
                targetTL.OptionsView.ShowRowFooterSummary       = sourceTL.OptionsView.ShowRowFooterSummary;
                targetTL.OptionsView.ShowSummaryFooter          = sourceTL.OptionsView.ShowSummaryFooter;
                targetTL.OptionsView.ShowVertLines              = sourceTL.OptionsView.ShowVertLines;
                
                targetTL.KeyFieldName           = sourceTL.KeyFieldName;
                targetTL.ParentFieldName        = sourceTL.ParentFieldName;
                targetTL.ActiveFilterString     = sourceTL.ActiveFilterString;
                targetTL.DataSource = sourceTL.DataSource;
                targetTL.DataMember= sourceTL.DataMember;
                targetTL.FixedLineWidth= sourceTL.FixedLineWidth;

                targetTL.Columns.Clear();//reset all columns

                foreach (DevExpress.XtraTreeList.Columns.TreeListColumn col in sourceTL.Columns)
                {
                    DevExpress.XtraTreeList.Columns.TreeListColumn colToken = targetTL.Columns.AddField(col.FieldName);
                    colToken.Caption = col.GetCaption();
                    colToken.SortIndex = col.SortIndex;
                    colToken.SortMode = col.SortMode;
                    colToken.SortOrder = col.SortOrder;
                    colToken.Visible = col.Visible;
                    colToken.VisibleIndex = col.VisibleIndex;
                    colToken.Width = col.Width;
                    colToken.UnboundExpression = col.UnboundExpression;
                    colToken.UnboundType = col.UnboundType;


                }

            }
            public void CopySettings(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit sourceLookUp, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit targetLookUp) 
            {
                //DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection 
                targetLookUp.Columns.Clear();
                targetLookUp.Columns.Assign(sourceLookUp.Columns);
            }
            public void CopySettings(DevExpress.XtraEditors.LookUpEdit sourceLookUp, DevExpress.XtraEditors.LookUpEdit targetLookUp)
            {
                //DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection 
                targetLookUp.Properties.Columns.Clear();
                targetLookUp.Properties.Columns.Assign(sourceLookUp.Properties.Columns);
                
            }

            public  void AddButtonsToList(RepositoryItemLookUpEditBase listObj) 
            {
                AddButtonsToList(listObj.Buttons);
                listObj.ButtonClick +=listObj_ButtonClick;                                
                // 
            }
            private void AddButtonsToList(DevExpress.XtraEditors.Controls.EditorButtonCollection listButtons) 
            {
                foreach (DevExpress.XtraEditors.Controls.EditorButton b in listButtons)
                {
                    if (b.Caption.ToLower() == "Refresh".ToLower())
                    {
                        return;
                    }
                }

                DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
                System.Drawing.Image refreshIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/actions/refresh_16x16.png");
                DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
                DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
                DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
                toolTipTitleItem1.Appearance.Image = refreshIcon;
                toolTipTitleItem1.Appearance.Options.UseImage = true;
                toolTipTitleItem1.Image = refreshIcon;
                toolTipTitleItem1.Text = "Refresh list from database";
                toolTipItem1.LeftIndent = 6;
                toolTipItem1.Text = "Press this button only when you want to retrieve new inserted rows from database " +
                    "";
                superToolTip1.Items.Add(toolTipTitleItem1);
                superToolTip1.Items.Add(toolTipItem1);
                DevExpress.XtraEditors.Controls.EditorButton refreshButton = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Refresh", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, refreshIcon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, superToolTip1, true);

                listButtons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { refreshButton/*,new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)*/});

                // 
            }
            public  void AddButtonsToList(LookUpEditBase listObj) 
            {
                AddButtonsToList(listObj.Properties.Buttons);
                listObj.Properties.ButtonClick += listObj_ButtonClick;
                // 
            }
            #endregion

            #region EventHandlers

            private void listObj_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
            {
                if (e.Button.Caption.ToLower() == "Refresh".ToLower())
                {
                    if (XtraMessageBox.Show("Do you want to retrieve rows from database.", "Refresh list from database", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        RetrieveRows(true);
                    }

                }
            }

            #endregion

        }
        
        #endregion

        #region Members
       
        public enum AppNonListEnum
        {           
            /*Generic*/ MarkerSymbolImageList, ActiveByteCheckEdit, CalculatorColumn, DateColumn, DateTimeColumn 
        }

        public enum AppListEnum
        {
            /*Mis*/     CurrencyList, LocationsList, FinancialYearList, FinancialPeriodList, JournalList, JournalPermittedList, DocumentTypeList, AccountTypeList,
            /*Mis*/     JournalClassName,AccountTableReference_One, AccountTableReference_Two, AccountTableReference_Three,
            /*GL*/      FinAccountSimpleList,FinAccountTreeList,BankListForGL,BankListForTreasuery, BankingTypeList,
            /*Cost*/    CostAccountList,CostAccountTreeList,POSAccountList,
            /*HR*/      EmployeeSimpleList,BankListForPayroll,
            /*Sales*/   CustomerList,CustomerGroupList,SalesItemsList,SalesItemsGroupTreeList,
            /*Fixed*/   FixedAssetTypeList, FixedAssetCategoryList, FixedAssetCategoryTreeList, FixedAssetGeoLocationTreeList,
            /*LG*/      LG_DocumentTypeList, LG_CustomerVendorAccountList, LG_StatusList, LG_BankList,
            /*Inventory*/ InventoryStoreList
            
        }
        
        private List<AppListInfo> appListStore;
        SqlConnection Sqlca;
        Session session1;
      
        #endregion

        #region Properties
        public List<AppListInfo> AppListStore{get;set;}

        public Session XPOSession
        {
            get { return session1; }
        }

        #endregion

        #region Methods
      
        public void ShowInMemoryDataTablesInfo() 
        {
            string msg = "";
           
            foreach (AppListInfo item in AppListStore)
            {
                string name;
                if (item.IsORMDataUsed)
                {
                    name = string.Format("{0}.{1} = {2} Rows", item.DataMemberXPCollection.GetObjectClassInfo().ClassType.ToString(), " ", item.DataMemberXPCollection.Count);
                }
                else
                {
                    name = string.Format("{0}.{1} = {2} Rows", item.DataMember.DataSet, item.DataMember.TableName, item.DataMember.Rows.Count);
                }

                    msg += name + Environment.NewLine;
             
            }
            XtraMessageBox.Show(msg);
        }
        public  void InitObj(SqlConnection conn) 
        {
            this.Sqlca = conn;
            session1 = new Session() { Connection = conn,AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists};
            session1.Connect();

            AppListStore = new List<AppListInfo>();
            FXAppList_InitObj(conn);
            HRAppList_InitObj(conn);
            MISAppList_InitObj(conn);
            CTAppList_InitObj(conn);
            GLAppList_InitObj(conn);
            LGAppList_InitObj(conn);
            IVAppList_InitObj(conn);
            

        }
        public  AppListInfo GetAppList(TableBase.TableEnum listName) 
        {
            AppListInfo lst = AppListStore.Find(x => x.AppListName == listName);
            return lst;

        }
        public  AppListInfo LinkListToColumn(TableBase.TableEnum listName, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            AppListInfo l = AppListStore.Find(x => x.AppListName == listName);
            l.LinkListToColumn(col);
            return l;
        }
        public  AppListInfo LinkListToColumn(TableBase.TableEnum listName, DevExpress.XtraTreeList.Columns.TreeListColumn col)
        {
            AppListInfo l = AppListStore.Find(x => x.AppListName == listName);
            l.LinkListToColumn(col);
            return l;
        }
        public  void        LinkListToColumn(AppNonListEnum listName, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            #region OldCost
            //switch (listName)
            //{
            //    case AppNonListEnum.MarkerSymbolImageList:
            //        col.ColumnEdit = symbolRIImageComboBox;
            //        break;
            //    case AppNonListEnum.ActiveByteCheckEdit:
            //        col.ColumnEdit = activeRICheckEdit;
            //        break;
            //    case AppNonListEnum.CalculatorColumn:
            //        col.ColumnEdit = calcRICalcEdit;
            //        break;
            //    case AppNonListEnum.DateColumn:
            //        col.ColumnEdit = dateRIDateEdit;
            //        break;
            //    case AppNonListEnum.DateTimeColumn:
            //        col.ColumnEdit = dateTimeRIDateEdit;
            //        break;

            //    default:
            //        break;
            //}
            #endregion

            col.ColumnEdit = FindList(listName);
            

        }
        public  void        LinkListToColumn(AppNonListEnum listName, DevExpress.XtraTreeList.Columns.TreeListColumn col)
        {
           
            col.ColumnEdit = FindList(listName);

        }
        public  AppListInfo LinkListToColumn(TableBase.TableEnum listName, DevExpress.XtraBars.BarEditItem col)
        {
            AppListInfo l = AppListStore.Find(x => x.AppListName == listName);
            l.LinkListToColumn(col);
            return l;
        }
        public  void        LinkListToColumn(AppNonListEnum listName, DevExpress.XtraBars.BarEditItem col)
        {
            col.Edit = FindList(listName);
        }


        public AppListInfo LinkListToColumn(TableBase.TableEnum listName, DevExpress.XtraEditors.TreeListLookUpEdit col)
        {
            AppListInfo l = AppListStore.Find(x => x.AppListName == listName);
            l.LinkListToColumn(col);
            l.AddButtonsToList(col);
            return l;
        }
        public AppListInfo LinkListToColumn(TableBase.TableEnum listName, DevExpress.XtraEditors.LookUpEdit col)
        {
            AppListInfo l = AppListStore.Find(x => x.AppListName == listName);
            l.LinkListToColumn(col);
            l.AddButtonsToList(col);
            return l;
        }
        public AppListInfo LinkListToColumn(TableBase.TableEnum listName, DevExpress.XtraEditors.SearchLookUpEdit col)
        {
            AppListInfo l = AppListStore.Find(x => x.AppListName == listName);
            l.LinkListToColumn(col);
            l.AddButtonsToList(col);
            return l;
        }
        

        private RepositoryItem FindList(AppNonListEnum listName) 
        {
            switch (listName)
            {
                case AppNonListEnum.MarkerSymbolImageList:
                    return symbolRIImageComboBox;
                    break;
                case AppNonListEnum.ActiveByteCheckEdit:
                    return activeRICheckEdit;
                    break;
                case AppNonListEnum.CalculatorColumn:
                    return calcRICalcEdit;
                    break;
                case AppNonListEnum.DateColumn:
                    return  dateRIDateEdit;
                    break;
                case AppNonListEnum.DateTimeColumn:
                    return dateTimeRIDateEdit;
                    break;
                default:
                    return null;
                    break;
            }
        }
        
        private void FXAppList_InitObj(Session conn) 
        {
            #region OldCodeUsingDataSet
            //.FixedAssetCategoryTreeList
            //FX_AppListDSTableAdapters.FixedAssetCategoryListTableAdapter fixedAssetCategoryListTableAdapter = new FX_AppListDSTableAdapters.FixedAssetCategoryListTableAdapter(){Connection = conn};
            //fixedAssetCategoryListTableAdapter.GetData(); //for load SelectCommand to Adapter
            //AppListInfo l = new AppListInfo() { AppListName = AppListEnum.FixedAssetCategoryTreeList, Conn = conn, RepositoryItem = fXACategoryRITreeListLookUpEdit, DataMember = fX_AppListDS.FixedAssetCategoryList, DataAdapter = fixedAssetCategoryListTableAdapter.Adapter };
            //l.LayoutObject = fXACategoryRITreeListLookUpEdit.TreeList;
            //AppListStore.Add(l);

            //.FixedAssetGeoLocationList 
            //FX_AppListDSTableAdapters.FixedAssetGeoLocationListTableAdapter fixedAssetGeoLocationListTableAdapter = new FX_AppListDSTableAdapters.FixedAssetGeoLocationListTableAdapter() { Connection = conn};
            //fixedAssetGeoLocationListTableAdapter.GetData();
            //l = new AppListInfo() { AppListName = AppListEnum.FixedAssetGeoLocationTreeList, Conn = conn, RepositoryItem = geoLocationRITreeListLookUpEdit, DataMember = fX_AppListDS.FixedAssetGeoLocationList, DataAdapter = fixedAssetGeoLocationListTableAdapter.Adapter };
            //l.LayoutObject = geoLocationRITreeListLookUpEdit.TreeList;
            //AppListStore.Add(l);

            ////FixedAssetTypeList 
            //FX_AppListDSTableAdapters.FixedAssetTypeListTableAdapter fixedAssetTypeListTableAdapter = new FX_AppListDSTableAdapters.FixedAssetTypeListTableAdapter() { Connection = conn };
            //fixedAssetTypeListTableAdapter.GetData();
            //l = new AppListInfo() { AppListName = AppListEnum.FixedAssetTypeList, Conn = conn, RepositoryItem = fixedAssetTypeRILookUpEdit, DataMember = fX_AppListDS.FixedAssetTypeList, DataAdapter = fixedAssetTypeListTableAdapter.Adapter };
            //l.LayoutObject = fixedAssetTypeRILookUpEdit;
            //AppListStore.Add(l);
            #endregion
            
            //AppLists.OmarERP.FXCategoryList
            XPCollection FXCatXPC = new XPCollection(session1, typeof(OmarERP.FXCategoryList), false) ;
            AppListInfo l = new AppListInfo() { AppListName = AppListEnum.FixedAssetCategoryTreeList, RepositoryItem = fXACategoryRITreeListLookUpEdit, DataMemberXPCollection = FXCatXPC, IsORMDataUsed = true };
            l.LayoutObject = fXACategoryRITreeListLookUpEdit.TreeList;
            AppListStore.Add(l);
            
            //OmarERP.FXGeolocationList
            XPCollection FXGeoXPC = new XPCollection(session1, typeof(OmarERP.FXGeolocationList), false);
            l = new AppListInfo() { AppListName = AppListEnum.FixedAssetGeoLocationTreeList, RepositoryItem = geoLocationRITreeListLookUpEdit, DataMemberXPCollection = FXGeoXPC, IsORMDataUsed = true };
            l.LayoutObject = geoLocationRITreeListLookUpEdit.TreeList;
            AppListStore.Add(l);
            
            //OmarERP.FXTypeList
            XPCollection FXTypeXPC = new XPCollection(session1, typeof(OmarERP.FXTypeList), false);
            l = new AppListInfo() { AppListName = AppListEnum.FixedAssetTypeList, RepositoryItem = fixedAssetTypeRILookUpEdit, DataMemberXPCollection = FXTypeXPC, IsORMDataUsed = true };
            l.LayoutObject = fixedAssetTypeRILookUpEdit;
            AppListStore.Add(l);
            

        }
        private void HRAppList_InitObj(SqlConnection conn) 
        {
            //.EmployeeSimpleList 
            HR_AppListDSTableAdapters.EmployeeFullDataViewListTableAdapter employeeFullDataViewListTableAdapter = new HR_AppListDSTableAdapters.EmployeeFullDataViewListTableAdapter(){ Connection = conn };
            employeeFullDataViewListTableAdapter.GetData(); //for load SelectCommand to Adapter
            AppListInfo l = new AppListInfo() { AppListName = AppListEnum.EmployeeSimpleList, Conn = conn, RepositoryItem = empsRISearchLookUpEdit, DataMember = hR_AppListDS.EmployeeFullDataViewList, DataAdapter = employeeFullDataViewListTableAdapter.Adapter };
            l.LayoutObject = empsRISearchLookUpEdit.View;
            AppListStore.Add(l);




        }
        private void MISAppList_InitObj(SqlConnection conn)
        {
            //.CurrencyList
            SYS_AppListDSTableAdapters.CurrencyEntityViewListTableAdapter currencyEntityViewListTableAdapter = new SYS_AppListDSTableAdapters.CurrencyEntityViewListTableAdapter() { Connection = conn };
            currencyEntityViewListTableAdapter.GetData(); //for load SelectCommand to Adapter
            AppListInfo l = new AppListInfo() { AppListName = AppListEnum.CurrencyList, Conn = conn, RepositoryItem = currencyRILookUpEdit, DataMember = sYS_AppListDS.CurrencyEntityViewList, DataAdapter = currencyEntityViewListTableAdapter.Adapter };
            l.LayoutObject = currencyRILookUpEdit;
            AppListStore.Add(l);

            //DocumentType
            SYS_AppListDSTableAdapters.DocumentTypeTableListTableAdapter documentTypeTableListTableAdapter = new SYS_AppListDSTableAdapters.DocumentTypeTableListTableAdapter() { Connection = conn };
            documentTypeTableListTableAdapter.GetData();
            l = new AppListInfo() { AppListName = AppListEnum.DocumentTypeList, Conn = conn, RepositoryItem = documentTypeRILookUpEdit, DataMember = sYS_AppListDS.DocumentTypeTableList, DataAdapter = documentTypeTableListTableAdapter.Adapter };
            l.LayoutObject = documentTypeRILookUpEdit;
            AppListStore.Add(l);

            SYS_AppListDSTableAdapters.FinancialPeriodListTableAdapter financialPeriodListTableAdapter = new SYS_AppListDSTableAdapters.FinancialPeriodListTableAdapter() { Connection = conn };
            financialPeriodListTableAdapter.GetData();
            l = new AppListInfo() { AppListName = AppListEnum.FinancialPeriodList, Conn = conn, RepositoryItem = finPeriodListRISearchLookUpEdit, DataMember = sYS_AppListDS.FinancialPeriodList, DataAdapter = financialPeriodListTableAdapter.Adapter };
            l.LayoutObject = finPeriodListRISearchLookUpEdit.View;
            AppListStore.Add(l);

            //JournalList 
            SYS_AppListDSTableAdapters.JournalEntityViewListTableAdapter journalEntityViewListTableAdapter = new SYS_AppListDSTableAdapters.JournalEntityViewListTableAdapter() { Connection = conn };
            journalEntityViewListTableAdapter.GetData();
            l = new AppListInfo() { AppListName = AppListEnum.JournalList, Conn = conn, RepositoryItem = journalListRILookUpEdit, DataMember = sYS_AppListDS.JournalEntityViewList, DataAdapter = journalEntityViewListTableAdapter.Adapter };
            l.LayoutObject = journalListRILookUpEdit;
            AppListStore.Add(l);

            //JournalClass 
            //OmarERP.JournalCalssName
            
            XPCollection JournalClassXPC = new XPCollection(session1, typeof(OmarERP.JournalCalssName), false);
            l = new AppListInfo() { AppListName = AppListEnum.JournalClassName, RepositoryItem = journalClassLookupEdit, DataMemberXPCollection = JournalClassXPC, IsORMDataUsed = true };
            l.LayoutObject = journalClassLookupEdit;
            AppListStore.Add(l);

            //JournalPermittedList
            SYS_AppListDSTableAdapters.F_ERPSys_PrincipalsJournalTableAdapter f_ERPSys_PrincipalsJournalTableAdapter = new SYS_AppListDSTableAdapters.F_ERPSys_PrincipalsJournalTableAdapter(){Connection = conn};
            f_ERPSys_PrincipalsJournalTableAdapter.GetData();
            RepositoryItemLookUpEdit journalListRILookUpEditMirror2 = new RepositoryItemLookUpEdit();
            l.CopySettings(journalListRILookUpEdit,journalListRILookUpEditMirror2);
            l = new AppListInfo() { AppListName = AppListEnum.JournalPermittedList, Conn = conn, RepositoryItem = journalListRILookUpEditMirror2, DataMember = sYS_AppListDS.F_ERPSys_PrincipalsJournal, DataAdapter = f_ERPSys_PrincipalsJournalTableAdapter.Adapter };
            l.LayoutObject = journalListRILookUpEditMirror2;
            AppListStore.Add(l);




        }
        private void CTAppList_InitObj(SqlConnection conn) 
        {
            //.CostAccountList
            //CT_AppListDSTableAdapters.CostAccountEntityViewListTableAdapter costAccountEntityViewListTableAdapter = new CT_AppListDSTableAdapters.CostAccountEntityViewListTableAdapter() { Connection = conn };
            //costAccountEntityViewListTableAdapter.GetData(); //for load SelectCommand to Adapter
            //AppListInfo l = new AppListInfo() { AppListName = AppListEnum.CostAccountList, Conn = conn, RepositoryItem = costList, DataMember = cT_AppListDS.CostAccountEntityViewList, DataAdapter = costAccountEntityViewListTableAdapter.Adapter };
            //l.LayoutObject = costList.View;
            //AppListStore.Add(l);

            //.POSAccountList
            //CT_AppListDSTableAdapters.POSAccountListTableAdapter pOSAccountListTableAdapter = new CT_AppListDSTableAdapters.POSAccountListTableAdapter() { Connection = conn };
            //pOSAccountListTableAdapter.GetData();
            //l = new AppListInfo() { AppListName = AppListEnum.POSAccountList, Conn = conn, RepositoryItem = pOSAccountList, DataMember = cT_AppListDS.POSAccountList, DataAdapter = pOSAccountListTableAdapter.Adapter };
            //l.LayoutObject = pOSAccountList.View;
            //AppListStore.Add(l);

            //AppLists.OmarERP.CostAccountList
            XPCollection<AppLists.OmarERP.CostAccountList> CostXPC = new XPCollection<OmarERP.CostAccountList>(this.session1, false);
            AppListInfo l = new AppListInfo() { AppListName = AppListEnum.CostAccountList, RepositoryItem = costList ,DataMemberXPCollection = CostXPC,IsORMDataUsed=true};
            l.LayoutObject = costList.View;
            AppListStore.Add(l);

            //AppLists.OmarERP.POSAccountList
            XPCollection POSXPC = new XPCollection(session1, typeof(OmarERP.POSAccountList), false) {Sorting=new SortingCollection { new SortProperty("Name",DevExpress.Xpo.DB.SortingDirection.Ascending)} } ;
            l = new AppListInfo() { AppListName = AppListEnum.POSAccountList, RepositoryItem = pOSAccountList, DataMemberXPCollection = POSXPC, IsORMDataUsed = true };
            l.LayoutObject = pOSAccountList.View;
            AppListStore.Add(l);


        }
        private void GLAppList_InitObj(SqlConnection conn) 
        {
            //OmarERP.AccountTypeList
            XPCollection ActTypeXPC = new XPCollection(session1, typeof(MainAccountType), false);
            AppListInfo l = new AppListInfo() { AppListName = TableBase.TableEnum.MainAccountType, RepositoryItem = accountTypeRILookUpEdit, DataMemberXPCollection = ActTypeXPC, IsORMDataUsed = true };
            accountTypeRILookUpEdit.DisplayMember = "DisplayName";
            accountTypeRILookUpEdit.ValueMember = "AccountType";
            l.LayoutObject = accountTypeRILookUpEdit;
            AppListStore.Add(l);

            //OmarERP.BankList For GL Bank Acccount
            XPCollection BankListXPC = new XPCollection(session1, typeof(OmarERP.BankList), true) { Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("BankGroup = 'B' ") };
            l = new AppListInfo() { AppListName = AppListEnum.BankListForGL, RepositoryItem = bankAccountRISearchLookUpEdit, DataMemberXPCollection = BankListXPC, IsORMDataUsed = true };
            bankAccountRISearchLookUpEdit.DisplayMember = "Name";
            bankAccountRISearchLookUpEdit.ValueMember = "AccountID";
            l.LayoutObject = bankAccountRISearchLookUpEdit.View;
            AppListStore.Add(l);

            //OmarERP.BankList for Treasuery for AP
            XPCollection TreasueryListXPC = new XPCollection(session1, typeof(OmarERP.BankList), true) { Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("BankGroup = 'C' ")};
            l = new AppListInfo() {AppListName = AppListEnum.BankListForTreasuery,RepositoryItem=bankAccountRISearchLookUpEdit,DataMemberXPCollection=TreasueryListXPC,IsORMDataUsed=true };
            bankAccountRISearchLookUpEdit.DisplayMember = "Name";
            bankAccountRISearchLookUpEdit.ValueMember = "AccountID";
            l.LayoutObject = bankAccountRISearchLookUpEdit.View;
            AppListStore.Add(l);
            
        }
        private void LGAppList_InitObj(SqlConnection conn)
        {
            //.LG_CustomerVendorAccountList
            LG_AppListDSTableAdapters.LG_CustomerVendorAccountListTableAdapter lG_CustomerVendorAccountListTableAdapter = new LG_AppListDSTableAdapters.LG_CustomerVendorAccountListTableAdapter(){ Connection = conn };
            lG_CustomerVendorAccountListTableAdapter.GetData(0); //for load SelectCommand to Adapter
            AppListInfo l = new AppListInfo() { AppListName = AppListEnum.LG_CustomerVendorAccountList, Conn = conn, RepositoryItem = LG_CustVendListRISearchLookUpEdit, DataMember = lG_AppListDS.LG_CustomerVendorAccountList, DataAdapter = lG_CustomerVendorAccountListTableAdapter.Adapter };
            l.LayoutObject = LG_CustVendListRISearchLookUpEdit.View;
            AppListStore.Add(l);

            //.LG_BankList
            LG_AppListDSTableAdapters.LetterOfGuranateeBankListTableAdapter LG_BankListTableAdapter = new LG_AppListDSTableAdapters.LetterOfGuranateeBankListTableAdapter() { Connection = conn };
            LG_BankListTableAdapter.GetData(Convert.ToByte(1));
            l = new AppListInfo() {AppListName = AppListEnum.LG_BankList,Conn = conn,RepositoryItem = LG_BankListRISearchLookUpEdit,DataMember = lG_AppListDS.LetterOfGuranateeBankList,DataAdapter = LG_BankListTableAdapter.Adapter };
            l.LayoutObject = LG_BankListRISearchLookUpEdit.View;
            AppListStore.Add(l);

            //. LG_StatusList
            LG_AppListDSTableAdapters.LetterOfGuaranteeStatusListTableAdapter lG_StatusListTableAdapter = new LG_AppListDSTableAdapters.LetterOfGuaranteeStatusListTableAdapter() { Connection = conn };
            lG_StatusListTableAdapter.GetData();
            l = new AppListInfo() { AppListName = AppListEnum.LG_StatusList,Conn = conn,RepositoryItem=LG_StatusListRILookUpEdit,DataMember = lG_AppListDS.LetterOfGuaranteeStatusList,DataAdapter = lG_StatusListTableAdapter.Adapter};
            l.LayoutObject = LG_StatusListRILookUpEdit;
            AppListStore.Add(l);

            //.LG_DocumentType
            LG_AppListDSTableAdapters.LGDocumentTypeListTableAdapter lG_DocumentTypeListTableAdapter = new LG_AppListDSTableAdapters.LGDocumentTypeListTableAdapter() { Connection = conn };
            lG_DocumentTypeListTableAdapter.GetData();
            l = new AppListInfo() { AppListName = AppListEnum.LG_DocumentTypeList,Conn=conn,RepositoryItem=LG_DocumentTypeListRILookUpEdit,DataMember = lG_AppListDS.LGDocumentTypeList,DataAdapter=lG_DocumentTypeListTableAdapter.Adapter};
            l.LayoutObject = LG_DocumentTypeListRILookUpEdit;
            AppListStore.Add(l);

        }
        private void IVAppList_InitObj(SqlConnection conn)
        {
            //OmarERP.InventoryStoreList
            XPCollection InvStoreXPC = new XPCollection(session1, typeof(OmarERP.InventoryStore), false);
            AppListInfo l = new AppListInfo() { AppListName = AppListEnum.InventoryStoreList, RepositoryItem = inventoryStoreRILookUpEdit, DataMemberXPCollection = InvStoreXPC, IsORMDataUsed = true };
            
            l.LayoutObject = inventoryStoreRILookUpEdit;
            AppListStore.Add(l);

        }

        

        #endregion

        #region EventHandlers

        #endregion


    }
}
