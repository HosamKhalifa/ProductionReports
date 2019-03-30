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

            myGridView1.OptionsView.ColumnAutoWidth = true;
            myGridView1.FocusedRowChanged += (s, e) => 
            {
                if (e.FocusedRowHandle < 0) return;
                var objName = (UIObjectBase)myGridView1.GetRow(e.FocusedRowHandle);
                string filter = $"[ObjectName!Key] = {objName.Oid} AND [LabelType] = {(int)MyEnums.UILabelType.FieldCaption}";
                xpCollectionExt2.CriteriaString =filter;
            };
        }
    }
}
