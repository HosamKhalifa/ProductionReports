using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"SEC_ACCESS_TYPE_TB")]
    public partial class SecurityAccessType : XPLiteObject
    {
        string fAccessType;
        [Key]
        [Persistent(@"ACCESS_TYPE"), Size(1)]
        public string AccessType
        {
            get { return fAccessType; }
            set { SetPropertyValue<string>("AccessType", ref fAccessType, value); }
        }
        int fAccessDegree;
        [Persistent(@"ACCESS_DEGREE")]
        public int AccessDegree
        {
            get { return fAccessDegree; }
            set { SetPropertyValue<int>("AccessDegree", ref fAccessDegree, value); }
        }
        string fAccessTypeName;
        [Persistent(@"ACCESS_TYPE_NAME"),Size(50)]
        public string AccessTypeName
        {
            get { return fAccessTypeName; }
            set { SetPropertyValue<string>("AccessTypeName", ref fAccessTypeName, value); }
        }
    }
}
