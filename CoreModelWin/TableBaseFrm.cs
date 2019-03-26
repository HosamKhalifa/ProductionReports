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
    public partial class TableBaseFrm : CoreLib.MyForm
    {
        public TableBaseFrm()
        {
            InitializeComponent();
            InitGridView();
            InitTableRows();
        }

        private void InitGridView()
        {
            myGridView1.Columns.ColumnByFieldName("TableId").OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            myGridView1.Columns.ColumnByFieldName("TableName").OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            myGridView1.Columns.ColumnByFieldName("TableDBName").OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;

            myGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            myGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;

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
