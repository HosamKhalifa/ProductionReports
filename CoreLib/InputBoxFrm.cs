using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreLib
{
    public partial class InputBoxFrm : CoreLib.MyForm
    {
        public InputBoxFrm(Args _args):base(_args)
        {
            InitializeComponent();
            InitObj(_args);
            InitEvents();


        }

        private void InitEvents()
        {
            okSimpleButton.Click += (s, e) => 
            {

                parmBS.EndEdit();
                parmBS.ResetCurrentItem();
                var dataRow = ((DataRowView)parmBS.Current).Row;
                foreach (var item in fList)
                {
                    var val = dataRow[$"{item.Name}"];
                    item.InputValue = val;
                }
                this.DialogResult = DialogResult.OK;
                Close();

            };

        }

        List<InputBoxInfo> fList;
        private void InitObj(Args _args)
        {
            DataTable parmTable = dataTable1;
            if (_args.ParmObject == null) return;
            fList = (List<InputBoxInfo>)_args.ParmObject;
            foreach (var item in fList)
            {
                DataColumn col = new DataColumn(item.Name, item.DataType)
                { Caption = item.Caption };
                parmTable.Columns.Add(col);
            }
          
            parmVGC.OptionsBehavior.AutoFocusNewRecord = true;

            parmBS.ResetBindings(true);
            parmBS.AddNew();


        }
    }
}
