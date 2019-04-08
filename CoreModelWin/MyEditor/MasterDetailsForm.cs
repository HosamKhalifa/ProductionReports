using CoreLib.Xpo;
using CoreLib;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoreLib.SharedExt;
using DevExpress.XtraEditors;

namespace CoreModelWin.MyEditor
{
    public partial class MasterDetailsForm : MyForm
    {
        public MasterDetailsForm()
        {
            InitializeComponent();
        }
        public class FormParms
        {
            public Type MasterClass { get; set; }
            public Type Details { get; set; }
            public string MasterKeyName { get; set; }
            public string DetailsKeyName { get; set; }
            public bool IsKeyValueNumeric{ get; set; }
        }
        public MasterDetailsForm(FormParms _args)
        {
            InitializeComponent();
            this.args = _args;
            InitObj();
           
            InitEvents();
        }
        FormParms args;
        object masterKeyValue;
        XPCollection masterXPC;
       
        XPCollection detailsXPC;

        public object XtarMessageBox { get; private set; }

        private void InitEvents()
        {
            masterGV.FocusedRowChanged += (s, e) =>
            {
                try
                {
                    if (e.FocusedRowHandle < 0) return;
                    var objName = (XPLiteObject)masterGV.GetRow(e.FocusedRowHandle);
                    masterKeyValue = objName.GetMemberValue(args.MasterKeyName);
                    string filter = $"[{args.DetailsKeyName}] =  ";
                    if (args.IsKeyValueNumeric)
                    {
                        filter += $"{masterKeyValue}";
                    }
                    else
                    {
                        filter += $"'{masterKeyValue}'";
                    }
                    detailsXPC.CriteriaString = filter;
                    detailsXPC.LoadingEnabled = true;
                    masterKeyValue = objName;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                }

            };
            detailsGV.InitNewRow += (s, e) => 
            {
                XPBaseObject x = (XPBaseObject)detailsGV.GetRow(e.RowHandle);
                x.SetMemberValue(args.DetailsKeyName, masterKeyValue);
            };
        
        }

        private void InitObj()
        {
            masterXPC = new XPCollection(unitOfWork1, args.MasterClass) { LoadingEnabled = true};
            detailsXPC = new XPCollection(unitOfWork1, args.Details) { LoadingEnabled = false};

           
            masterGV.UnitOfWorkXpo = unitOfWork1;

            masterGC.DataSource = masterXPC;
            masterGC.RefreshDataSource();

            detailsGV.UnitOfWorkXpo = unitOfWork1;
            detailsGC.DataSource = detailsXPC;
            detailsGC.RefreshDataSource();

          

            AppLists.AppListInfo masterAppLists = new AppLists.AppListInfo(unitOfWork1);
            masterAppLists.LinkLookupsToGrid(masterGV, masterXPC);

            AppLists.AppListInfo detailsAppLists = new AppLists.AppListInfo(unitOfWork1);
            detailsAppLists.LinkLookupsToGrid(detailsGV, detailsXPC);
        }
    }
}
