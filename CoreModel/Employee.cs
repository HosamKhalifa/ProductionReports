using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"EMPL_ACT_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Employee : Account
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Employee;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public Employee(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Employee);
            base.AfterConstruction();
        }
        MyEnums.Gender fGender;
        [Persistent("GENDER")]
        public MyEnums.Gender Gender
        {
            get { return fGender; }
            set { SetPropertyValue<MyEnums.Gender>("Gender", ref fGender, value); }
        }

    }
}
