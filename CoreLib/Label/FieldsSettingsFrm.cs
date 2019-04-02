using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreLib.Label
{
    public partial class FieldsSettingsFrm : CoreLib.MyForm
    {
        public FieldsSettingsFrm()
        {
            InitializeComponent();
            InitObj();
        }

        private void InitObj()
        {

            myGridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Default;
            myGridView1.OptionsView.ColumnAutoWidth = true;
            myGridView1.FocusedRowChanged += (s, e) => 
            {
                if (e.FocusedRowHandle < 0) return;
                var objName = (UIObjectBase)myGridView1.GetRow(e.FocusedRowHandle);
                string filter = $"[ObjectName!Key] = {objName.Oid} ";
                xpCollectionExt2.CriteriaString =filter;
            };
            myGridView2.FocusedRowChanged += (s, e) => 
            {
                if (e.FocusedRowHandle < 0) return;
                var label = (UILabel)myGridView2.GetRow(e.FocusedRowHandle);
                string filter = $"[UILabel!Key] = '{label.LabelId}'";
                xpCollectionExt3.CriteriaString = filter;
            };
        }
    }
}
