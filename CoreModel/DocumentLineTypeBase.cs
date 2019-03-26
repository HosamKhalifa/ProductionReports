using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"DOC_LINE_TYPE_BASE")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class DocumentLineTypeBase : Line
    {
      

        public DocumentLineTypeBase(Session session) : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        #region Fields
        string fLineTypeName;
        [Persistent(@"LINE_TYPE_NAME"),Size(100)]
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

    }

}