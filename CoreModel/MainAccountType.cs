using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"MAIN_ACCOUNT_TYPE_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class MainAccountType : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.MainAccountType;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = @"MAIN_ACCOUNT_TYPE_TB";
        public MainAccountType(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.MainAccountType);
            base.AfterConstruction();
        }

        string fAccountTypeName;
        [Persistent(@"ACCOUNT_TYPE_NAME"), Size(40)]
        public string AccountTypeName
        {
            get { return fAccountTypeName; }
            set { SetPropertyValue<string>("AccountTypeName", ref fAccountTypeName, value); }
        }
        string fAccountTypeDescription;
        [Persistent(@"ACCOUNT_TYPE_DESC"), Size(150)]
        public string AccountTypeDescription
        {
            get { return fAccountTypeDescription; }
            set { SetPropertyValue<string>("AccountTypeDescription", ref fAccountTypeDescription, value); }
        }

    }
}
