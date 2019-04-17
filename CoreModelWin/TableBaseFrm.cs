using CoreModel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoreLib.SharedExt;
namespace CoreModelWin
{
    public partial class TableBaseFrm : CoreLib.MyForm,CoreLib.IEditableForm
    {
        public TableBaseFrm()
        {
            InitializeComponent();
            InitGridView();
            InitTableRows();
        }

        public void AddRecord()
        {
            myGridView1.AddNewRow();
        }

        public void DeleteRecord()
        {
            if(myGridView1.SelectedRowsCount > 0)
            {
                myGridView1.DeleteSelectedRows();
            }
            else
            {
                myGridView1.DeleteRow(myGridView1.FocusedRowHandle);
            }
        }

        public void EditRecord()
        {
            myGridView1.ShowEditorByKey(new KeyEventArgs(Keys.F2));
        }

        public void SaveChanges()
        {
            unitOfWork1.CommitChanges();
        }

        private void InitGridView()
        {
            //myGridView1.Columns.ColumnByFieldName("TableId").OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            //myGridView1.Columns.ColumnByFieldName("TableName").OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            //myGridView1.Columns.ColumnByFieldName("TableDBName").OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;

            myGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            myGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            AppLists.AppListInfo lst = new AppLists.AppListInfo(unitOfWork1);
            lst.LinkLookupsToGrid(myGridView1, xpCollectionExt1);
        }

        private void InitTableRows()
        {
            try
            {
                TableBase.TableBaseRowsBuilder(unitOfWork1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
            
        }
    }
}
