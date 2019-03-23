using System;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.Xpo.Metadata;
using System.Reflection;
using CoreLib.Label;

namespace CoreLib.SharedExt
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

        public static void ApplyLabels (this UnitOfWork UOWork,Assembly currentAssembly)
        {
           
            XPDictionary dict = new ReflectionDictionary();
                       
            dict.CollectClassInfos(currentAssembly);
            
            foreach (XPClassInfo item in dict.Classes)
            {
                foreach (var m in item.Members.Where(x => x.DisplayName.Length > 2 ))
                {
                    string lblId = m.DisplayName;
                    string lblValue = UILabel.ResolveLabelId(lblId);
                  
                }
                

               
                 
            }

           
            
        }
        public static void ApplyLabels(this UnitOfWork UOWork,string assemblyName = "")
        {
            Assembly assembly;
            if (string.IsNullOrEmpty(assemblyName.Trim()))
            {
                assembly = Assembly.GetExecutingAssembly();
            }
            else
            {
                assembly = GlobalMethods.GetAssemblyByName(assemblyName);
            }

            ApplyLabels(UOWork, assembly);
        }
    }
}
