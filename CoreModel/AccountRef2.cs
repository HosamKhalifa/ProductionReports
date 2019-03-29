using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"ACT_REFNO2_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class AccountRef2 : Line
    {
        public static string TABLE_NAME = "ACT_REFNO2_TB";
        public AccountRef2(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.AccountRef2);

            base.AfterConstruction();
        }

        string fRefNo2Num;
        [Size(20), Persistent(@"REFNO2_NUM")]
        public string RefNo2Num
        {
            get { return fRefNo2Num; }
            set { SetPropertyValue<string>("RefNo2Num", ref fRefNo2Num, value); }
        }
        string fRefNo2Name;
        [Size(150), Persistent("REFNO2_NAME")]
        public string RefNo1Name
        {
            get { return fRefNo2Name; }
            set { SetPropertyValue<string>("RefNo2Name", ref fRefNo2Name, value); }
        }

        MyEnums.AccountType fAccountType;
        [Persistent(@"ACT_TYPE")]

        public MyEnums.AccountType AccountType
        {
            get { return fAccountType; }
            set { SetPropertyValue<MyEnums.AccountType>("AccountType", ref fAccountType, value); }
        }
        #region Associations 
        [Association(@"ACT_REFNO2_ACCOUNTS_FK")]
        public XPCollection<Account> Accounts { get { return GetCollection<Account>("Accounts"); } }
      
        #endregion

    }
}
