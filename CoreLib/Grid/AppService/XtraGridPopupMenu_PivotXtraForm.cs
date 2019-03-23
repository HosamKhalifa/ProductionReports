using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using CoreLib.SharedExt;

namespace CoreLib.Grid.AppService
{
    public partial class XtraGridPopupMenu_PivotXtraForm : MyForm
    {
        public XtraGridPopupMenu_PivotXtraForm(MyGridView sourceGridView)
        {
            InitializeComponent();
            this.sourceGridView = sourceGridView;
            chartConfigurationBarXUC1.InitPanel(pivotGridControl1,chartControl1);
            sourceGridView.ColumnFilterChanged += sourceGridView_ColumnFilterChanged;

           

            tableBindingSource.DataSource = sourceGridView.DataSource;
            tableBindingSource.ResetBindings(true);
            
            //Build monthes list 
            monthNamesListBindingSource.DataSource = BuildMonthNames();
            

            InitNewReport(sourceGridView);
            //AddXtraDateFields(tableBindingSource); We will using Split Date Field
            
            pivotGridControl1.RefreshData();
            

            //Apply filter to dataSource 
            string filter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(sourceGridView.ActiveFilterCriteria);
            pivotGridControl1.Prefilter.Criteria = sourceGridView.ActiveFilterCriteria;


            gridInfo = (XtraGridViewInfo)sourceGridView.Tag;
            string instanceUQNameSuffix = gridInfo != null && gridInfo.GridViewDBKey != null ? gridInfo.GridViewDBKey.ToString() : "";
            pivotGridControl1.Name += instanceUQNameSuffix;


        }

        public XtraGridPopupMenu_PivotXtraForm()
        {
            InitializeComponent();
           


        }



        #region Members
     
        //DataTable reportSourceTable;
        DevExpress.XtraGrid.Views.Grid.GridView sourceGridView;
        XtraGridViewInfo gridInfo;
        XtraGridViewInfo pivotInfo;
    
        #endregion

        #region Properties

        #endregion

        #region Methods

        private void InitNewReport(DevExpress.XtraGrid.Views.Grid.GridView sourceGridView) 
        {
            pivotGridControl1.Fields.Clear();
            foreach (DevExpress.XtraGrid.Columns.GridColumn c in sourceGridView.Columns)
            {
                DevExpress.XtraPivotGrid.PivotGridField newField = new DevExpress.XtraPivotGrid.PivotGridField(c.FieldName, DevExpress.XtraPivotGrid.PivotArea.FilterArea);
                newField.Name                       = "field" + c.FieldName;
                newField.Caption                    = c.Caption;
                newField.CellFormat.Format          = c.DisplayFormat.Format;
                newField.ValueFormat.Format         = c.DisplayFormat.Format;
                newField.TotalValueFormat.Format    = c.DisplayFormat.Format;
                pivotGridControl1.Fields.Add(newField);

            }
            

        }

        public void AddXtraDateFields(DataTable dTable, DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl,bool withFieldPrefix) 
        {
            
            //Add month value integer 
            DevExpress.XtraPivotGrid.PivotGridField dateField;
            List<DataColumn> colList = new List<DataColumn>();
            foreach (DataColumn c in dTable.Columns)
            {
                colList.Add(c);
            }

            foreach (DataColumn col in colList)
            {
                if (col.DataType == Type.GetType("System.DateTime"))
                {
                    #region OldCode
                    //Add MonthValue 
                    //DataColumn monthValue = dTable.Columns.Add(col.ColumnName + "_MonthValue", Type.GetType("System.Int32"));
                    //DataColumn monthDisplay = dTable.Columns.Add(col.ColumnName + "_MonthDisplay", Type.GetType("System.String"));

                    //monthDisplay.Caption = col.Caption + "_Month";

                    //foreach (DataRow dr in dTable.Rows)
                    //{
                    //    DateTime dVal = (DateTime)dr[col.ColumnName];
                    //    string format = "yyyy-MMM";
                    //    dr[monthValue.ColumnName] = (dVal.Year * 100) + dVal.Month;
                    //    dr[monthDisplay] = dVal.Date.ToString(format);

                    //}
                    #endregion
                    //Adding xtra fields for each date field Month
                    
                    if (withFieldPrefix)
                    {
                        dateField = pivotGridControl.Fields.GetFieldByName("field" + col.ColumnName);
                    }
                    else
                    {
                        dateField = pivotGridControl.Fields.GetFieldByName(col.ColumnName);
                    }


                    DevExpress.XtraPivotGrid.PivotGridField newField = new DevExpress.XtraPivotGrid.PivotGridField();
                    newField.FieldName = dateField.FieldName + "_Month";
                    if (dateField.Caption == string.Empty)
                    {
                        newField.Caption = dateField.FieldName + "_Month";
                    }
                    else
                    {
                        newField.Caption = dateField.Caption + "_Month";
                    }

                    //newField.CellFormat.Format = c.DisplayFormat.Format;
                    //string exp = string.Format("(  GetYear([{0}])*100  ) + GetMonth([{1}])",dateField.FieldName,dateField.FieldName);
                    string exp = string.Format("(  GetYear([{0}])) + '-' + GetMonth([{1}]) + '-01' ", dateField.FieldName, dateField.FieldName);
                    
                    newField.UnboundExpression = exp;
                    newField.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
                    newField.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    newField.ValueFormat.FormatString    = "yyyy-MMM";
                    newField.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                    pivotGridControl.Fields.Add(newField);
                    
                    //Adding xtra fields for each date field Year

                    newField = new DevExpress.XtraPivotGrid.PivotGridField();
                    newField.FieldName = dateField.FieldName + "_Year";
                    if (dateField.Caption == string.Empty)
                    {
                        newField.Caption = dateField.FieldName + "_Year";
                    }
                    else
                    {
                        newField.Caption = dateField.Caption + "_Year";
                    }

                    exp = string.Format("(  GetYear([{0}])) + '-01-01' ", dateField.FieldName);

                    newField.UnboundExpression = exp;
                    newField.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
                    newField.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    newField.ValueFormat.FormatString = "yyyy";
                    newField.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                    pivotGridControl.Fields.Add(newField);


                }
            }

            
        }

        public void AddXtraDateFields(BindingSource bindingSrce)
        {
            if (bindingSrce.DataSource is DataSet)
            {
                DataSet ds = (DataSet)bindingSrce.DataSource;
                AddXtraDateFields(ds.Tables[bindingSrce.DataMember],pivotGridControl1,true);
            }
            else if(bindingSrce.DataSource is BindingSource)
            {
                BindingSource src = (BindingSource)bindingSrce.DataSource;
                AddXtraDateFields(src);
            }

        }

        private XtraGridColumnInfoDS.MonthNamesListDataTable BuildMonthNames(DateTime fromDate, DateTime toDate) 
        {
            fromDate = fromDate.AddMonths(-1);
            toDate = toDate.AddMonths(1);
            int monthKey ;
            string monthName;
            XtraGridColumnInfoDS.MonthNamesListDataTable dTable= new XtraGridColumnInfoDS.MonthNamesListDataTable();
            do
            {
                monthKey = ( fromDate.Year * 100 ) + fromDate.Month;
                monthName = fromDate.Date.ToString("yyyy-MMM");
                dTable.AddMonthNamesListRow(monthKey,monthName);
                fromDate = fromDate.AddMonths(1);

            } while (toDate >= fromDate);
            return dTable;
        }

        private XtraGridColumnInfoDS.MonthNamesListDataTable BuildMonthNames()
        {
            DateTime fromDate, toDate;
            fromDate = DateTime.Today;//(DateTime)GlobalMethods.SQLSelectScalar("SELECT MIN(P.StartDate) FROM FinancialPeriodTable P");
            toDate = DateTime.Today;// (DateTime)GlobalMethods.SQLSelectScalar("SELECT MAX(P.EndDate) FROM FinancialPeriodTable P");
            return BuildMonthNames(fromDate, toDate);
        }

        private void AddXtraDateFeildsManually(DevExpress.XtraPivotGrid.PivotGridField datePVF, bool withFieldPrefix) 
        {
            //Adding xtra fields for each date field Month
            DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl = datePVF.PivotGrid;
            DevExpress.XtraPivotGrid.PivotGridField newField = new DevExpress.XtraPivotGrid.PivotGridField();
            newField.FieldName = datePVF.FieldName + "_Month";
            if (datePVF.Caption == string.Empty)
            {
                newField.Caption = datePVF.FieldName + "_Month";
            }
            else
            {
                newField.Caption = datePVF.Caption + "_Month";
            }

            //newField.CellFormat.Format = c.DisplayFormat.Format;
            //string exp = string.Format("(  GetYear([{0}])*100  ) + GetMonth([{1}])",datePVF.FieldName,datePVF.FieldName);
            string exp = string.Format("(  GetYear([{0}])) + '-' + GetMonth([{1}]) + '-01' ", datePVF.FieldName, datePVF.FieldName);

            newField.UnboundExpression = exp;
            newField.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            newField.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            newField.ValueFormat.FormatString = "yyyy-MMM";
            newField.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            pivotGridControl.Fields.Add(newField);

            //Adding xtra fields for each date field Year

            newField = new DevExpress.XtraPivotGrid.PivotGridField();
            newField.FieldName = datePVF.FieldName + "_Year";
            if (datePVF.Caption == string.Empty)
            {
                newField.Caption = datePVF.FieldName + "_Year";
            }
            else
            {
                newField.Caption = datePVF.Caption + "_Year";
            }

            exp = string.Format("(  GetYear([{0}])) + '-01-01' ", datePVF.FieldName);

            newField.UnboundExpression = exp;
            newField.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            newField.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            newField.ValueFormat.FormatString = "yyyy";
            newField.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            pivotGridControl.Fields.Add(newField);

            //Adding xtra fields for each date field Month Only

            newField = new DevExpress.XtraPivotGrid.PivotGridField();
            newField.FieldName = datePVF.FieldName + "_MonthOnly";
            if (datePVF.Caption == string.Empty)
            {
                newField.Caption = datePVF.FieldName + "_MonthOnly";
            }
            else
            {
                newField.Caption = datePVF.Caption + "_MonthOnly";
            }
            exp = string.Format("(  GetMonth([{0}])) ", datePVF.FieldName);

            newField.UnboundExpression = exp;
            newField.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            //newField.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //newField.ValueFormat.FormatString = "MMM";
            newField.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            pivotGridControl.Fields.Add(newField);

            

        }

        #endregion

        #region EventHandlers

        private void changeSummeryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (DevExpress.XtraPivotGrid.PivotGridField pvf in pivotGridControl1.Fields)
            {
               
                pvf.Options.AllowRunTimeSummaryChange = true;
                pvf.Options.ShowSummaryTypeName = true;

                
            }
        }

        private void XtraGridPopupMenu_PivotXtraForm_Shown(object sender, EventArgs e)
        {
            pivotInfo = new XtraGridViewInfo(pivotGridControl1);
            pivotInfo.RestoreLayoutFromDefaultXML();
        }

        private void filterSourceGridBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                sourceGridView.ShowFilterEditor(sourceGridView.Columns[0]);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());

            }

        }

        void sourceGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            try
            {
                if (sourceGridView.ActiveFilterCriteria != null)
                {
                    pivotGridControl1.Prefilter.Criteria = sourceGridView.ActiveFilterCriteria;
                }
                else
                {
                    pivotGridControl1.Prefilter.Clear();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }


        }

        #endregion

        private void pivotGridControl1_PopupMenuShowing(object sender, DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs e)
        {
            try
            {
                if (e.Area == DevExpress.XtraPivotGrid.PivotArea.FilterArea && e.Field != null)
                {
                    if (e.Field.DataType == Type.GetType("System.DateTime"))
                    {
                        if (!e.Field.IsUnboundExpression)
                        {
                            Image splitFieldIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/format/columns_16x16.png");
                            DevExpress.Utils.Menu.DXMenuItem mn = new DevExpress.Utils.Menu.DXMenuItem("Split date");
                            mn.Image = splitFieldIcon;
                            mn.Tag = e.Field;
                            mn.Click+=mn_Click;
                            e.Menu.Items.Add(mn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }

        void mn_Click(object sender, EventArgs e)
        {
             DevExpress.Utils.Menu.DXMenuItem mn = ( DevExpress.Utils.Menu.DXMenuItem)sender;
             DevExpress.XtraPivotGrid.PivotGridField clickedField = (DevExpress.XtraPivotGrid.PivotGridField)mn.Tag;
             AddXtraDateFeildsManually(clickedField, true);

        }

        private void setupColumnsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.Fields.UpdateAreaIndexes();
            pivotGridControl1.FieldsCustomization();
        }



    }
}
