using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
