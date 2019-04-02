using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"DOC_TYPE_ACCOUNTS")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class DocumentTypeAccounts : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.DocumentTypeAccounts;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = @"DOC_TYPE_ACCOUNTS";
        public DocumentTypeAccounts(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.DocumentTypeAccounts);
            base.AfterConstruction();
        }
        #region Fields
        DocumentType fDocType;
        [Persistent(@"DOC_TYPE")]
        [Association(@"DOC_TYPE_DOC_TYPE_ACCOUNTS_FK")]
        public DocumentType DocType
        {
            get { return fDocType; }
            set { SetPropertyValue<DocumentType>("DocType", ref fDocType, value); }
        }
        DocumentLineTypeBase fLineType;
        [Persistent(@"LINE_TYPE")]
        [Association(@"LINE_TYPE_DOC_TYPE_ACCOUNTS_FK")]
        public DocumentLineTypeBase LineType
        {
            get { return fLineType; }
            set { SetPropertyValue<DocumentLineTypeBase>("LineType",ref fLineType,value); }
        }
        TableBase fCVE_TableId;//Used to filter Group,RefNo1 and RefNo2
        [Persistent(@"CVE_TABLE_ID")]
        public TableBase CVE_TableId
        {
            get { return fCVE_TableId; }
            set { SetPropertyValue<TableBase>("CVE_TableId", ref fCVE_TableId, value); }
        }
        MyEnums.DefinitionType fDefinitionType;
        [Persistent(@"DEFINITION_TYPE")]
        public MyEnums.DefinitionType DefinitionType
        {
            get { return fDefinitionType; }
            set { SetPropertyValue<MyEnums.DefinitionType>("DefinitionType", ref fDefinitionType, value); }
        }
        Account fDefinitionId;
        [Persistent(@"DEFINITION_ID")]
        public Account DefinitionId
        {
            get { return fDefinitionId; }
            set { SetPropertyValue<Account>("DefinitionId", ref fDefinitionId, value); }
        }
        MainAccount fMainAccount;
        [Persistent(@"MAIN_ACCOUNT")]
        public MainAccount MainAccount
        {
            get { return fMainAccount; }
            set { SetPropertyValue<MainAccount>("MainAccount", ref fMainAccount, value); }
        }

        MainAccount fOffsetMainAccount;
        [Persistent(@"OFFSET_MAIN_ACCOUNT")]
        public MainAccount OffsetMainAccount
        {
            get { return fOffsetMainAccount; }
            set { SetPropertyValue<MainAccount>("OffsetMainAccount", ref fOffsetMainAccount, value); }
        }

        #endregion

    }
}
