using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"JOURNAL_BASE")]
    public class JournalBase : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.JournalBase;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = "JOURNAL_BASE";

        
        public JournalBase(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.JournalBase);
            base.AfterConstruction();
        }
        #region Fields
        MyEnums.JournalType fJournalType;
        [Persistent(@"JOURNAL_TYPE")]
        public MyEnums.JournalType JournalType
        {
            get { return fJournalType; }
            set { SetPropertyValue<MyEnums.JournalType>("JournalType", ref fJournalType, value); }
        }
        Sequence fSequence;
        [Persistent(@"SEQU_ID")]
        [Association(@"SEQU_JOURNAL_FK")]
        public Sequence Sequence
        {
            get { return fSequence; }
            set { SetPropertyValue<Sequence>("Sequence", ref fSequence, value); }
        }
        MyEnums.WorkflowStatus fSequenceWorkflowStatus;//Which status will generate Sequ
        public MyEnums.WorkflowStatus SequenceWorkflowStatus
        {
            get { return fSequenceWorkflowStatus; }
            set { SetPropertyValue<MyEnums.WorkflowStatus>("SequenceWorkflowStatus", ref fSequenceWorkflowStatus, value); }
        }
        #endregion

        #region Association
        [Association("JOURNAL_DOC_BASE_FK")]
        public XPCollection<DocumentBase> Documents { get { return GetCollection<DocumentBase>("Documents"); } }
        #endregion

    }
}
