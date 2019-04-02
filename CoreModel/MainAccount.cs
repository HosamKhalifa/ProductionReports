using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"MAIN_ACCOUNT_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class MainAccount : Account
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.MainAccount;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = @"MAIN_ACCOUNT_TB";
        public MainAccount(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.MainAccount);
            base.AfterConstruction();
        }
        #region Fields
        int fDepth;
        [Persistent(@"DEPTH")]
        public int Depth
        {
            get { return fDepth; }
            set { SetPropertyValue<int>("Depth", ref fDepth, value); }
        }

        MainAccountType fMainAccountType;
        [Persistent(@"MAIN_ACCOUNT_TYPE")]
        public MainAccountType MainAccountType
        {
            get { return fMainAccountType; }
            set { SetPropertyValue<MainAccountType>("MainAccountType", ref fMainAccountType, value); }
        }
        DateTime fEffectiveFrom;
        [Persistent(@"EFFECTIVE_FROM")]
        public DateTime EffectiveFrom
        {
            get { return fEffectiveFrom; }
            set { SetPropertyValue<DateTime>("EffectiveFrom", ref fEffectiveFrom, value); }
        }

        MainAccount fOffsetMainAccount;
        public MainAccount OffsetMainAccount
        {
            get { return fOffsetMainAccount; }
            set { SetPropertyValue<MainAccount>("OffsetMainAccount", ref fOffsetMainAccount, value); }
        }

        #endregion

        #region Associations
        [Association(@"DOC_LINE_MAIN_ACCOUNT_FK")]
        public XPCollection<DocumentLineBase> DocumentLines { get{ return GetCollection<DocumentLineBase>("DocumentLines"); } }
        #endregion

    }
}
