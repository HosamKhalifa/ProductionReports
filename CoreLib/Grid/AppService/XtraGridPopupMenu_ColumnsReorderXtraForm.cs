using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreLib.Grid.AppService
{
    public partial class XtraGridPopupMenu_ColumnsReorderXtraForm : MyForm
    {
        public XtraGridPopupMenu_ColumnsReorderXtraForm(MyGridView gridView)
        {

            InitializeComponent();
            view = gridView;
            ReadColumnsData(view);
            ReadViewOptions(view);

            hiddenGridViewColumnsBindingSource.Filter = string.Format("IsVisible = {0} ", false);
            visibleGridViewColumnsBindingSource.Filter = string.Format("IsVisible = {0} ", true);


            
        }


        #region Members
        MyGridView view;

        #endregion

        #region Properties


        #endregion

        #region Methods
        private void ReadColumnsData(DevExpress.XtraGrid.Views.Grid.GridView v) 
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn c in v.Columns)
            {
                bool isExp = false;
                string caption;
                if (c.UnboundType != DevExpress.Data.UnboundColumnType.Bound)
	            {
                    isExp = false;
	            }
                if (c.Caption == string.Empty)
                    caption = c.FieldName;
                else
                    caption = c.Caption;

                xtraGridColumnInfoDS.GridViewColumns.AddGridViewColumnsRow(c.Name, c.FieldName, caption, c.UnboundType.ToString(), c.UnboundExpression,c.SortOrder.ToString(),c.VisibleIndex,isExp,c.Visible);
            }
        }

        private void ReadViewOptions(DevExpress.XtraGrid.Views.Grid.GridView v) 
        {
            allowOnlyOneMasterRowExpandedCheckEdit.Checked =  v.OptionsDetail.AllowOnlyOneMasterRowExpanded;
            autoZoomDetailCheckEdit.Checked = v.OptionsDetail.AutoZoomDetail;
            showGroupSummaryEditorItemCheckEdit.Checked = v.OptionsMenu.ShowGroupSummaryEditorItem;
            printSelectedRowsOnlyCheckEdit.Checked =  v.OptionsPrint.PrintSelectedRowsOnly;
            allowCellMergeCheckEdit.Checked = v.OptionsView.AllowCellMerge;
            enableAppearanceEvenRowCheckEdit.Checked = v.OptionsView.EnableAppearanceEvenRow;
            showGroupedColumnsCheckEdit.Checked = v.OptionsView.ShowGroupedColumns;

            if (v.OptionsSelection.MultiSelect     && 
                v.OptionsSelection.MultiSelectMode == DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect)
            {
                multiSelectCheckEdit.Checked = true;
            }
            else
            {
                multiSelectCheckEdit.Checked = false;
            }

        }

        private void WriteColumnsData(XtraGridColumnInfoDS.GridViewColumnsDataTable columnsTable) 
        {
            view.BeginUpdate();
            
            foreach (XtraGridColumnInfoDS.GridViewColumnsRow dr in columnsTable.Rows)
            {
                DevExpress.XtraGrid.Columns.GridColumn c =
                view.Columns.ColumnByFieldName(dr.FieldName);

                c.Visible = dr.IsVisible;
                c.Caption = dr.Caption;
                c.SortOrder = TransliateSortOrderEnum(dr.SortOrder);
                if (dr.IsVisible)
                {
                    c.VisibleIndex = dr.VisibleIndex;
                }
                else
                {
                    c.VisibleIndex = -1;
                }
                



            }

            view.EndUpdate();
            
        }

        private void WriteViewOptions(DevExpress.XtraGrid.Views.Grid.GridView v)
        {
            v.OptionsDetail.AllowOnlyOneMasterRowExpanded = allowOnlyOneMasterRowExpandedCheckEdit.Checked;
            v.OptionsDetail.AutoZoomDetail = autoZoomDetailCheckEdit.Checked;
            v.OptionsMenu.ShowGroupSummaryEditorItem = showGroupSummaryEditorItemCheckEdit.Checked;
            v.OptionsPrint.PrintSelectedRowsOnly = printSelectedRowsOnlyCheckEdit.Checked;
            v.OptionsView.AllowCellMerge = allowCellMergeCheckEdit.Checked;
            v.OptionsView.EnableAppearanceEvenRow = enableAppearanceEvenRowCheckEdit.Checked;
            v.OptionsView.ShowGroupedColumns = showGroupedColumnsCheckEdit.Checked;

            v.OptionsSelection.MultiSelect = multiSelectCheckEdit.Checked;
            if (v.OptionsSelection.MultiSelect)
            {
                v.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            }
            else
            {
                v.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            }
        }


        private int GetLastVisibleIndex(FormWindowState maxOrMin) 
        {
            int minInddex = int.MaxValue;
            int maxIndex  = int.MinValue;
            int returnValue=0;
            foreach (XtraGridColumnInfoDS.GridViewColumnsRow dr in xtraGridColumnInfoDS.GridViewColumns.Rows)
            {
                
                minInddex = Math.Min(minInddex, dr.VisibleIndex);
                maxIndex  = Math.Max(maxIndex , dr.VisibleIndex);
            }
            switch (maxOrMin)
            {
                case FormWindowState.Maximized:
                    returnValue = maxIndex;
                    break;
                case FormWindowState.Minimized:
                    returnValue = minInddex;
                    break;
            }
            return returnValue;

            
        }

        private void ShowHideRows(int[] rowHandles,bool isVisible) 
        {
            //foreach (int rowHandle in rowHandles)
            //{
            //    XtraGridColumnInfoDS.GridViewColumnsRow dr =
            //   (XtraGridColumnInfoDS.GridViewColumnsRow)hiddenGridView.GetDataRow(rowHandle);
            //    dr.IsVisible = isVisible;
            //}
            if (isVisible == true)
            {
                for (int i = rowHandles.Length -1 ; i >= 0; i--)
                {
                    XtraGridColumnInfoDS.GridViewColumnsRow dr =
                 (XtraGridColumnInfoDS.GridViewColumnsRow)hiddenGridView.GetDataRow(rowHandles[i]);
                    dr.IsVisible = isVisible;
                    dr.VisibleIndex = GetLastVisibleIndex(FormWindowState.Maximized) + 1;
                }
            }
            else
            {
                for (int i = rowHandles.Length -1; i >= 0; i--)
                {
                    XtraGridColumnInfoDS.GridViewColumnsRow dr =
                 (XtraGridColumnInfoDS.GridViewColumnsRow)visibleGridView.GetDataRow(rowHandles[i]);
                    dr.IsVisible = isVisible;
                }
            }
           

            hiddenGridViewColumnsBindingSource.EndEdit();

        }

        private void MoveUpDown(string direction) 
        {
            int incrementValue = 0;
            int focusedRowHandle = visibleGridView.FocusedRowHandle;
            int replacmentRowHandle=0;
            switch (direction.ToUpper())
            {
                case "UP":
                    if (!(visibleGridView.IsFirstRow))
	                {
                        incrementValue = -1;
                        replacmentRowHandle = focusedRowHandle - 1;
	                }
                    
                    break;
                case "DOWN":
                    if (!(visibleGridView.IsLastRow))
	                {
                        incrementValue = 1;
                        replacmentRowHandle = focusedRowHandle + 1;
	                }

                    break;
            }

           
            XtraGridColumnInfoDS.GridViewColumnsRow visibleDR = (XtraGridColumnInfoDS.GridViewColumnsRow)visibleGridView.GetDataRow(focusedRowHandle);
            XtraGridColumnInfoDS.GridViewColumnsRow replacmentDR = (XtraGridColumnInfoDS.GridViewColumnsRow)visibleGridView.GetDataRow(replacmentRowHandle);
            
            visibleDR.VisibleIndex += incrementValue;
            replacmentDR.VisibleIndex += (-1 * incrementValue);


        }

        private DevExpress.Data.ColumnSortOrder TransliateSortOrderEnum(string sortOrder) 
        {
            DevExpress.Data.ColumnSortOrder v = DevExpress.Data.ColumnSortOrder.None;
            switch (sortOrder)
            {
                case "Ascending":
                        
                        v = DevExpress.Data.ColumnSortOrder.Ascending;
                    
                        break;
                case "Descending":

                        v = DevExpress.Data.ColumnSortOrder.Descending;

                    break;

                case "None":

                    v = DevExpress.Data.ColumnSortOrder.None;
                    
                    break;
                default:
                    break;
            }

            return v;
        }

        #endregion

        #region EventHandlers

        private void hiddenGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks > 1)
            {
                showColumnSimpleButton.PerformClick();
            }
        }

        private void cancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hideAllSimpleButton_Click(object sender, EventArgs e)
        {
            visibleGridView.SelectAll();
            ShowHideRows(visibleGridView.GetSelectedRows(), false);
        }

        private void showAllSimpleButton_Click(object sender, EventArgs e)
        {
            hiddenGridView.SelectAll();
            ShowHideRows(hiddenGridView.GetSelectedRows(), true);
        }

        private void hideColumnSimpleButton_Click(object sender, EventArgs e)
        {
            ShowHideRows(visibleGridView.GetSelectedRows(), false);
        }

        private void showColumnSimpleButton_Click(object sender, EventArgs e)
        {
            ShowHideRows(hiddenGridView.GetSelectedRows(),true);

        }

        #endregion

        private void okSimpleButton_Click(object sender, EventArgs e)
        {

            visibleGridViewColumnsBindingSource.EndEdit();
            hiddenGridViewColumnsBindingSource.EndEdit();

            WriteColumnsData(xtraGridColumnInfoDS.GridViewColumns);
            WriteViewOptions(view);
            Close();


        }

        private void visibleGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            if (e.Clicks > 1 )
            {
                hideColumnSimpleButton.PerformClick();
            }

        }

        private void upSimpleButton_Click(object sender, EventArgs e)
        {

            MoveUpDown("Up");


        }

        private void downSimpleButton_Click(object sender, EventArgs e)
        {
            MoveUpDown("Down");
        }



    }
}
