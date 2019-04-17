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
using DevExpress.Data.Filtering;

namespace CoreModelWin.MyEditor
{
    public partial class MasterDetailsForm : MyForm
    {
        public MasterDetailsForm()
        {
            InitializeComponent();
        }

      
        public MasterDetailsForm(Args _args)
        {
            InitializeComponent();
            if (_args.ParmObject == null || !(_args.ParmObject is MasterDetailsParm)) return;

            this.parms = (MasterDetailsParm)_args.ParmObject;
            InitObj();
           
            InitEvents();
            //Link GridView Events to this form 
            masterGV.ViewDetails += (s, e) => 
            {
                MenuController.LookupFormRefOpen(e);
            };
            //detailsGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Default;
        }

        MyEditor.MasterDetailsParm parms;
        object masterKeyObject;
        XPCollection masterXPC;
       
        XPCollection detailsXPC;

     

        private void InitEvents()
        {
            //GridView approach
            masterGV.FocusedRowChanged += (s, e) =>
            {
                try
                {
                    if (e.FocusedRowHandle < 0) return;
                    var objName = (XPLiteObject)masterGV.GetRow(e.FocusedRowHandle);
                    if(parms.KeyType == KeyTypeEnum.Object)
                    {
                        masterKeyObject = objName;
                    }
                    else
                    {
                        masterKeyObject = objName.GetMemberValue(parms.MasterKeyName);
                    }
                    
                    CriteriaOperator criteria = new BinaryOperator(new OperandProperty(parms.DetailsKeyName), new OperandValue(masterKeyObject), BinaryOperatorType.Equal);
                    detailsXPC.Criteria = criteria;
                    detailsXPC.LoadingEnabled = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                }

            };
            detailsGV.InitNewRow += (s, e) => 
            {

                DefaultNewRow(e.RowHandle);
            };
            
            detailsGV.EditFormShowing += (s, e) => 
            {
                DefaultNewRow(e.RowHandle);
            };
          

        }
        void DefaultNewRow (int _RowHandle)
        {
            var x = (XPLiteObject)detailsGV.GetRow(_RowHandle);
            //x?.SetMemberValue(parms.DetailsKeyName, masterKeyObject);

            var left = new OperandProperty(parms.DetailsKeyName).PropertyName;
            switch (parms.KeyType)
            {
                case KeyTypeEnum.Int:
                    x?.SetMemberValue(left, ((int)masterKeyObject));
                    break;
                case KeyTypeEnum.Long:
                    x?.SetMemberValue(left, ((long)masterKeyObject));
                    break;
                case KeyTypeEnum.String:
                    x?.SetMemberValue(left, $"'{masterKeyObject.ToString()}'");
                    break;
                case KeyTypeEnum.Object:
                    var defaultObj = ((XPBaseObject)masterKeyObject).This;
                    x?.SetMemberValue(left, defaultObj);

                    break;
                default:
                    break;
            }
        }
        private void InitObj()
        {
            masterXPC = new XPCollection(unitOfWork1, parms.MasterClass) { LoadingEnabled = true};
            detailsXPC = new XPCollection(unitOfWork1, parms.Details) { LoadingEnabled = false};

           
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
