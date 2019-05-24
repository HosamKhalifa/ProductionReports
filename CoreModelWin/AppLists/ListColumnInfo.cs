using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelWin.AppLists
{
   public class ListColumnInfo
    {
        public ListColumnInfo()
        {

        }
        public ListColumnInfo(DevExpress.XtraGrid.Columns.GridColumn _gridColumn)
        {
            GridColumn = _gridColumn;
        }
        public ListColumnInfo(DevExpress.XtraEditors.LookUpEditBase _lookUpEditor)
        {
            LookUpEditor = _lookUpEditor;
        }
        public ListColumnInfo(DevExpress.XtraTreeList.Columns.TreeListColumn _treeListColumn)
        {
            TreeListColumn = _treeListColumn;
        }
        public DevExpress.XtraGrid.Columns.GridColumn GridColumn { get; set; }
        public DevExpress.XtraEditors.LookUpEditBase LookUpEditor { get; set; }
        public DevExpress.XtraTreeList.Columns.TreeListColumn TreeListColumn { get; set; }
        public DevExpress.XtraEditors.ImageComboBoxEdit ImageComboBoxEdit { get; set; }
    }
}
