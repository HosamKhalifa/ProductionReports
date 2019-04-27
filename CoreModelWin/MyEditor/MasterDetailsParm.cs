using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib;

namespace CoreModelWin.MyEditor
{
    public enum KeyTypeEnum { Int,Long,String,Object}
    public class MasterDetailsParm
    {
        public Type MasterClass { get; set; }
        public Type Details { get; set; }
        public string MasterKeyName { get; set; }
        public string DetailsKeyName { get; set; }
        public KeyTypeEnum KeyType { get; set; }

        public MyEnums.GridViewEditMode MasterGVEditMode
        {
            get
            {
                return fMasterGVEditMode;
            }

            set
            {
                fMasterGVEditMode = value;
            }
        }

        public MyEnums.GridViewEditMode DetailsGVEditMode
        {
            get
            {
                return fDetailsGVEditMode;
            }

            set
            {
                fDetailsGVEditMode = value;
            }
        }

        private CoreLib.MyEnums.GridViewEditMode fMasterGVEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;

        private CoreLib.MyEnums.GridViewEditMode fDetailsGVEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit;


    }
}
