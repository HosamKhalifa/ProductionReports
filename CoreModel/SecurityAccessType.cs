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
        protected SecurityAccessType(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        int fAccessType;
        [Key]
        [Persistent(@"ACCESS_TYPE")]
        public int AccessType
        {
            get { return fAccessType; }
            set { SetPropertyValue<int>("AccessType", ref fAccessType, value); }
        }
        
        string fAccessTypeName;


        [Persistent(@"ACCESS_TYPE_NAME"),Size(50)]
        public string AccessTypeName
        {
            get { return fAccessTypeName; }
            set { SetPropertyValue<string>("AccessTypeName", ref fAccessTypeName, value); }
        }

        public static void BuildTableRows(Session _uOW)
        {
            var lst = new List<MyEnums.SecurityAccessEnum>()
            {
                MyEnums.SecurityAccessEnum.Deny,
                MyEnums.SecurityAccessEnum.Read,
                MyEnums.SecurityAccessEnum.Update,
                MyEnums.SecurityAccessEnum.Create,
                MyEnums.SecurityAccessEnum.Delete
            };

            foreach (var item in lst)
            {

                if (_uOW.GetObjectByKey<SecurityAccessType>((int)item) == null)
                {
                    var denyLine = new SecurityAccessType(_uOW)
                    {
                        AccessType = (int)item,
                        AccessTypeName = item.ToString()
                    };
                    denyLine.Save();
                }
            }
            _uOW.CommitTransaction();
        }

    }
}
