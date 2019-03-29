using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"LINE_TYPE")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class DocumentLineTypeBase :CoreLib.Xpo.XPLiteObjectExt
    {
      

        public DocumentLineTypeBase(Session session) : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        #region Fields
        int fLineType;
        [Persistent(@"LINE_TYPE"),Key]
        public int LineType
        {
            get { return fLineType; }
            set { SetPropertyValue<int>("LineType",ref fLineType,value); }
        }

        string fLineTypeName;
        [Persistent(@"LINE_TYPE_NAME"),Size(150)]
        [Indexed(Name ="LINE_TYPE_NAME_UQ",Unique =true)]
        public string LineTypeName
        {
            get { return fLineTypeName; }
            set { SetPropertyValue<string>("LineTypeName", ref fLineTypeName, value); }
        }
        string fLineTypeDescription;
        [Persistent(@"LINE_TYPE_DESC"), Size(250)]
       
        public string LineTypeDescription
        {
            get { return fLineTypeDescription; }
            set { SetPropertyValue<string>("LineTypeDescription", ref fLineTypeDescription, value); }
        }
        MyEnums.DebitCredit fDebitOrCredit;
        [Persistent(@"DEBIT_OR_CREDIT")]
        public MyEnums.DebitCredit DebitOrCredit
        {
            get { return fDebitOrCredit; }
            set { SetPropertyValue<MyEnums.DebitCredit>("DebitOrCredit",ref fDebitOrCredit,value); }
        }

        #endregion
        #region Association
        [Association(@"LINE_TYPE_DOC_TYPE_ACCOUNTS_FK")]
        public XPCollection<DocumentTypeAccounts> LineTypeAccounts { get{ return GetCollection<DocumentTypeAccounts>("LineTypeAccounts"); } }
        #endregion

    }

}