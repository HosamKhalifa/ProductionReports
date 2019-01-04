using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.XtraEditors;

namespace ProductionReports.SharedExt
{
   public static class UnitOfWorkExtensions
    {
        public static bool SaveLine(this UnitOfWork UOWork)
        {
            try
            {
                UOWork.CommitChanges();
                return true;
            }
            catch (Exception ex)
            {
                UOWork.DropChanges();
                UOWork.ReloadChangedObjects();
                
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                return false;
            }
        }
    }
}
