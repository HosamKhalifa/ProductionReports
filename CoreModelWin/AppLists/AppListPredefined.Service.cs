using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using CoreLib.Label;
using DevExpress.XtraTreeList.Columns;

namespace CoreModelWin.AppLists
{
    public partial class AppListPredefined : DevExpress.XtraEditors.XtraUserControl
    {
        public AppListPredefined()
        {
            InitializeComponent();
        }
        public void AddImageToWorkflowCombo()
        {

        }
        public void LinkList(ListColumnInfo _col ,CoreModel.MyEnums.AppListPredefined _appList, CriteriaOperator _whereCO = null)
        {
            switch (_appList)
            {
                case CoreModel.MyEnums.AppListPredefined.AccountGroupTree:
                    LinkAccountGroup(_col,_whereCO);
                    break;
                case CoreModel.MyEnums.AppListPredefined.AccountRef1Tree:
                    LinkAccountRef1(_col, _whereCO);
                    break;
                case CoreModel.MyEnums.AppListPredefined.AccountRef2Tree:
                    LinkAccountRef2(_col, _whereCO);
                    
                    break;
                default:
                    break;
            }
        }
        
        #region Constants
        const string ACCOUNT_GROUPING = "accountGroupTreeList";
        const string ACCOUNT_REF1 = "accountRef1TreeList";
        const string ACCOUNT_REF2 = "accountRef2TreeList";
        #endregion
        #region Methods
        private void LinkAccountGroup(ListColumnInfo _col, CriteriaOperator _whereCO = null)
        {

            var listSrc = new XPCollection<CoreModel.AccountGroup>(session: unitOfWork1, loadingEnabled: false);
            listSrc.Criteria = _whereCO;
            listSrc.LoadingEnabled = true;
            accountGroupTreeList.DataSource = listSrc;
            //Setup labels
            var listObjectBase = UIObjectBase.GetUIObjectByName(typeof(CoreModel.AccountGroup), unitOfWork1);
            listObjectBase.SetupGUILabels(accountGroupTreeList.TreeList);
            if (_col.GridColumn != null) { _col.GridColumn.ColumnEdit = SharedPR.Items[ACCOUNT_GROUPING]; }
            if (_col.LookUpEditor != null)
            {
                var ed = _col.LookUpEditor as TreeListLookUpEdit;
                ed.Properties.TreeList = accountGroupTreeList.TreeList;
                ed.Properties.DataSource = listSrc;
                ed.Properties.DisplayMember = listObjectBase.LookUpDisplayMember();
                ed.Properties.ValueMember = listObjectBase.LookUpValueMember();
            }
            if (_col.TreeListColumn != null) { _col.TreeListColumn.ColumnEdit = SharedPR.Items[ACCOUNT_GROUPING]; }
        }
        private void LinkAccountRef1(ListColumnInfo _col, CriteriaOperator _whereCO = null)
        {
            var listSrc = new XPCollection<CoreModel.AccountRef1>(session: unitOfWork1, loadingEnabled: false);
            listSrc.Criteria = _whereCO;
            listSrc.LoadingEnabled = true;
            accountRef1TreeList.DataSource = listSrc;
            //Setup labels
            var listObjectBase = UIObjectBase.GetUIObjectByName(typeof(CoreModel.AccountRef1), unitOfWork1);
            listObjectBase.SetupGUILabels(accountRef1TreeList.TreeList);

            if (_col.GridColumn != null) { _col.GridColumn.ColumnEdit = SharedPR.Items[ACCOUNT_REF1]; }
            if (_col.LookUpEditor != null)
            {
                var ed = (_col.LookUpEditor as TreeListLookUpEdit);
                ed.Properties.TreeList = accountRef1TreeList.TreeList;
                ed.Properties.DataSource = listSrc;
                ed.Properties.DisplayMember = listObjectBase.LookUpDisplayMember();
                ed.Properties.ValueMember = listObjectBase.LookUpValueMember();
            }
            if (_col.TreeListColumn != null) { _col.TreeListColumn.ColumnEdit = SharedPR.Items[ACCOUNT_REF1]; }

        }
        private void LinkAccountRef2(ListColumnInfo _col, CriteriaOperator _whereCO = null)
        {
            var listSrc = new XPCollection<CoreModel.AccountRef2>(session: unitOfWork1, loadingEnabled: false);
            listSrc.Criteria = _whereCO;
            listSrc.LoadingEnabled = true;
            accountRef2TreeList.DataSource = listSrc;
            //Setup labels
            var listObjectBase = UIObjectBase.GetUIObjectByName(typeof(CoreModel.AccountRef2), unitOfWork1);
            listObjectBase.SetupGUILabels(accountRef1TreeList.TreeList);

            if (_col.GridColumn != null) { _col.GridColumn.ColumnEdit = SharedPR.Items[ACCOUNT_REF2]; }
            if (_col.LookUpEditor != null)
            {
                var ed = (_col.LookUpEditor as TreeListLookUpEdit);
                ed.Properties.TreeList = accountRef2TreeList.TreeList;
                ed.Properties.DataSource = listSrc;
                ed.Properties.DisplayMember = listObjectBase.LookUpDisplayMember();
                ed.Properties.ValueMember = listObjectBase.LookUpValueMember();
            }
            if (_col.TreeListColumn != null) { _col.TreeListColumn.ColumnEdit = SharedPR.Items[ACCOUNT_REF2]; }


        }
        #endregion
    }
}
