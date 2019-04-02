using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"ACT_GROUP_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class AccountGroup:Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.AccountGroup;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = "ACT_GROUP_TB";
        public AccountGroup(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.AccountGroup);
            base.AfterConstruction();
        }

        string fGroupNum;
        [Size(20), Persistent(@"GROUP_NUM")]
        public string GroupNum
        {
            get { return fGroupNum; }
            set { SetPropertyValue<string>("GroupNum", ref fGroupNum, value); }
        }
        string fGroupName;
        [Size(150), Persistent("GROUP_NAME")]
        public string GroupName
        {
            get { return fGroupName; }
            set { SetPropertyValue<string>("GroupName", ref fGroupName, value); }
        }

        MyEnums.AccountType fAccountType;
        [Persistent(@"ACT_TYPE")]
        public MyEnums.AccountType AccountType
        {
            get { return fAccountType; }
            set { SetPropertyValue<MyEnums.AccountType>("AccountType", ref fAccountType, value); }
        }

        #region Associations 
        [Association(@"ACT_GRP_ACCOUNTS")]
        public XPCollection<Account> Accounts { get { return GetCollection<Account>("Accounts"); } }
        //[Association(@"DOC_TYPE_POST_PRO_GROUP_FK")]
        //public XPCollection<DocumentType> DocumentTypes { get { return GetCollection<DocumentType>("DocumentTypes"); } }
        #endregion

    }
}
