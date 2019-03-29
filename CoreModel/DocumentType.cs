using CoreLib.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"DOC_TYPE")]
    public class DocumentType : XPLiteObjectExt
    {
        protected DocumentType(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {

            base.AfterConstruction();
        }

        int fDocType;
        [Persistent(@"DOC_TYPE"),Key]
        public int DocType
        {
            get { return fDocType; }
            set { SetPropertyValue<int>("DocType", ref fDocType, value); }
        }

        string fDocTypeName;
        [Persistent(@"DOC_TYPE_NAME"),Size(150)]
        public string DocTypeName
        {
            get { return fDocTypeName; }
            set { SetPropertyValue<string>("DocTypeName", ref fDocTypeName, value); }
        }
        TableBase fCVE_TableId;//Used to filter Group,RefNo1 and RefNo2
        [Persistent(@"CVE_TABLE_ID")]
        public TableBase CVE_TableId
        {
            get { return fCVE_TableId; }
            set { SetPropertyValue<TableBase>("CVE_TableId", ref fCVE_TableId, value); }
        }

        MyEnums.Module fModule;
        [Persistent(@"MODULE")]
        public MyEnums.Module Module
        {
            get { return fModule; }
            set { SetPropertyValue<MyEnums.Module>("Module", ref fModule, value); }
        }
        #region Associations
        [Association(@"DOC_TYPE_DOC_TYPE_ACCOUNTS_FK")]
        public XPCollection<DocumentTypeAccounts> DocTypeAccounts { get { return GetCollection<DocumentTypeAccounts>("DocTypeAccounts"); } }
        #endregion

    }
}
