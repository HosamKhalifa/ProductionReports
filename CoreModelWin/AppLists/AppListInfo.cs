using CoreModel;
using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.SharedExt;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using CoreLib.Label;
using DevExpress.Data.Filtering;
using System.Drawing;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraGrid.Views.Grid;

namespace CoreModelWin.AppLists
{
    public class AppListInfo //Class holding infos about app list object 
    {
        public AppListInfo(Session session)
        {

            this.AppListSession = session;
            ActiveColumnLinks = new List<DevExpress.XtraGrid.Columns.GridColumn>();
            

        }

        #region Members
        private RepositoryItemLookUpEditBase repositoryItem;
        XPBaseCollection dataMemberXPCollection;

        #endregion

        #region Properties
        

        public XPBaseCollection DataMemberXPCollection
        {
            get { return dataMemberXPCollection; }
            set
            {
                dataMemberXPCollection = value;
            }
        }
        public Session AppListSession { get; set; }
        public RepositoryItemLookUpEditBase RepositoryItem
        {
            get { return repositoryItem; }
            set
            {
                repositoryItem = value;
                AddButtonsToList(repositoryItem);
            }
        }
        public Type ClassType { get; set; }
        public TableBase.TableEnum AppListName { get; set; }
        public List<DevExpress.XtraGrid.Columns.GridColumn> ActiveColumnLinks { get; set; }
        
        public object LayoutObject { get; set; }
        public string DisplayMember { get; set; }
        public string ValueMember { get;set; }
        
        #endregion

        #region Methods



        private int RetrieveRowsFromDB()
        {
            int rowsCount;
           
            DataMemberXPCollection.LoadingEnabled = true;
            DataMemberXPCollection.Load();
            rowsCount = DataMemberXPCollection.Count;

            return rowsCount;
        }

        public int RetrieveRows(bool EnforceFromDB)
        {

            int rowsCount;
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
            //RepositoryItem.DataSource = this.DataMemberXPCollection;
            rowsCount = this.DataMemberXPCollection.Count;
            return rowsCount;
        }

        public void LinkListToColumn(DevExpress.XtraGrid.Columns.GridColumn col,Type tableType, string gridFilterString = "")
        {
            XPClassInfo classInfo = AppListSession.GetClassInfo(tableType);
            DataMemberXPCollection = new XPCollection(AppListSession, classInfo);

            var lookupGrd = new RepositoryItemSearchLookUpEdit(); 
            var lookupGrdView=new GridView();
            lookupGrd.BeginInit();
            lookupGrdView.BeginInit();
            SetupGridView(lookupGrdView, DataMemberXPCollection);
            lookupGrd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            lookupGrd.Name = "lookupGrd";
            lookupGrd.View = lookupGrdView;

            //SetupGridView()
            col.ColumnEdit = lookupGrd;
            
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

        public void LinkListToColumn(DevExpress.XtraEditors.TreeListLookUpEdit col, string treeFilterString = "")
        {
            try
            {

                DevExpress.XtraTreeList.TreeList MyList = (DevExpress.XtraTreeList.TreeList)this.LayoutObject;
                MyList.DataSource = this.DataMemberXPCollection;
                col.Properties.DataSource = this.DataMemberXPCollection;
                col.Properties.DisplayMember = this.DisplayMember;
                col.Properties.ValueMember = this.ValueMember;
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
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }

        }
        public void LinkListToColumn(DevExpress.XtraEditors.LookUpEdit col)
        {
            try
            {

                RepositoryItemLookUpEdit MyList = (RepositoryItemLookUpEdit)this.LayoutObject;
                //MyList.Columns.Assign(col.Properties.Columns);
                col.Properties.Columns.Assign(MyList.Columns);
                col.Properties.DataSource = DataMemberXPCollection;
                col.Properties.DisplayMember = this.DisplayMember;
                col.Properties.ValueMember = this.ValueMember;
                RetrieveRows(false);


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }

        }
        public void LinkListToColumn(DevExpress.XtraEditors.SearchLookUpEdit col,Type tableType, string gridFilterString = "")
        {
            try
            {
                XPClassInfo classInfo = AppListSession.GetClassInfo(tableType);
                DataMemberXPCollection = new XPCollection(AppListSession,classInfo);

                col.Properties.DataSource = this.DataMemberXPCollection;
               

                RetrieveRows(false);
                col.Properties.View.GridControl.ForceInitialize();

                SetupGridView(col.Properties.View, DataMemberXPCollection );
                col.Properties.ValueMember = ValueMember;
                col.Properties.DisplayMember = DisplayMember;
                if (gridFilterString != "")
                {
                    col.Properties.View.ActiveFilterString = gridFilterString;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }


        public void SetupGridView(DevExpress.XtraGrid.Views.Grid.GridView targetGV, XPBaseCollection _listXPC)
        {
            //DevExpress.XtraGrid.Views.Grid.GridView targetGV = col.Properties.View;
            targetGV.GridControl?.ForceInitialize();
            targetGV.Columns.Clear();
            targetGV.OptionsView.ColumnAutoWidth = false;
            targetGV.OptionsView.ShowAutoFilterRow = true;
            targetGV.OptionsView.ShowFooter = true;
            targetGV.OptionsView.ShowGroupPanel = false;
            targetGV.OptionsView.EnableAppearanceOddRow = true;
            targetGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            var classInfo = _listXPC.GetObjectClassInfo();
            var objName = AppListSession.FindObject<UIObjectBase>(CriteriaOperator.Parse("[ObjectName] = ? ", classInfo.FullName));
            var labels = objName.ObjectLabels.Where(x => x.LookupMember != CoreLib.MyEnums.AutoLookUp.None);
            foreach (var item in labels)
            {
                string filedName = item.FieldName.Substring(item.FieldName.LastIndexOf('.') + 1);
                string caption = item.ChooseValueForCurrentLang();
                var grdCol = targetGV.Columns.AddVisible(filedName, caption);
                //Calc estimated width according to LookUp char width
                Size columnSize = TextRenderer.MeasureText("".PadLeft(item.LookupMemberCharWidth,'A'), targetGV.Appearance.HeaderPanel.Font);
                grdCol.Width = columnSize.Width;
                if (item.LookupMember == CoreLib.MyEnums.AutoLookUp.ValueMemberVisiable ||
                    item.LookupMember == CoreLib.MyEnums.AutoLookUp.ValueMemberHidden)
                {
                    ValueMember = filedName;
                    
                }
                if(item.LookupMember == CoreLib.MyEnums.AutoLookUp.DisplayMember1)
                {
                    DisplayMember = filedName;
                }
                
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
            targetGV.OptionsView.EnableAppearanceOddRow = sourceGV.OptionsView.EnableAppearanceOddRow;
            targetGV.OptionsView.ShowFilterPanelMode = sourceGV.OptionsView.ShowFilterPanelMode;
            targetGV.OptionsView.ShowGroupedColumns = sourceGV.OptionsView.ShowGroupedColumns;


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
            targetTL.OptionsView.AutoWidth = sourceTL.OptionsView.AutoWidth;
            targetTL.OptionsView.ShowAutoFilterRow = sourceTL.OptionsView.ShowAutoFilterRow;
            targetTL.OptionsView.ExpandButtonCentered = sourceTL.OptionsView.ExpandButtonCentered;
            targetTL.OptionsView.FocusRectStyle = sourceTL.OptionsView.FocusRectStyle;
            targetTL.OptionsView.EnableAppearanceEvenRow = sourceTL.OptionsView.EnableAppearanceEvenRow;
            targetTL.OptionsView.EnableAppearanceOddRow = sourceTL.OptionsView.EnableAppearanceOddRow;
            targetTL.OptionsView.ShowFilterPanelMode = sourceTL.OptionsView.ShowFilterPanelMode;
            targetTL.OptionsView.HeaderFilterButtonShowMode = sourceTL.OptionsView.HeaderFilterButtonShowMode;
            targetTL.OptionsView.ShowBandsMode = sourceTL.OptionsView.ShowBandsMode;
            targetTL.OptionsView.ShowButtons = sourceTL.OptionsView.ShowButtons;
            targetTL.OptionsView.ShowColumns = sourceTL.OptionsView.ShowColumns;
            targetTL.OptionsView.ShowHorzLines = sourceTL.OptionsView.ShowHorzLines;
            targetTL.OptionsView.ShowIndicator = sourceTL.OptionsView.ShowIndicator;
            targetTL.OptionsView.ShowPreview = sourceTL.OptionsView.ShowPreview;
            targetTL.OptionsView.ShowRoot = sourceTL.OptionsView.ShowRoot;
            targetTL.OptionsView.ShowRowFooterSummary = sourceTL.OptionsView.ShowRowFooterSummary;
            targetTL.OptionsView.ShowSummaryFooter = sourceTL.OptionsView.ShowSummaryFooter;
            targetTL.OptionsView.ShowVertLines = sourceTL.OptionsView.ShowVertLines;

            targetTL.KeyFieldName = sourceTL.KeyFieldName;
            targetTL.ParentFieldName = sourceTL.ParentFieldName;
            targetTL.ActiveFilterString = sourceTL.ActiveFilterString;
            targetTL.DataSource = sourceTL.DataSource;
            targetTL.DataMember = sourceTL.DataMember;
            targetTL.FixedLineWidth = sourceTL.FixedLineWidth;

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

        public void AddButtonsToList(RepositoryItemLookUpEditBase listObj)
        {
            AddButtonsToList(listObj.Buttons);
            listObj.ButtonClick += listObj_ButtonClick;
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
        public void AddButtonsToList(LookUpEditBase listObj)
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

}
