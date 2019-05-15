using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelWin.AppLists
{
   public class ListColumnInfo
    {
        public DevExpress.XtraGrid.Columns.GridColumn GridColumn { get; set; }
        public DevExpress.XtraEditors.LookUpEditBase LookUpEditor { get; set; }
        public DevExpress.XtraTreeList.Columns.TreeListColumn TreeListColumn { get; set; }
    }
}
