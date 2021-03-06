﻿using System;
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
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public JournalBase(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.JournalBase);
            base.AfterConstruction();
        }
        #region Fields
        string fJournalCode;
        [Persistent(@"JOURNAL_CODE"),Size(30)]//This code will be used to create Seurity role with same code value 
        [Indexed(Name ="JOURNAL_CODE_UQ",Unique =true)]
        public string JournalCode
        {
            get { return fJournalCode; }
            set { SetPropertyValue<string>("JournalCode", ref fJournalCode, value); }
        }
        string fJournalName;
        [Persistent(@"JOURNAL_NAME"),Size(120)]
        public string JournalName
        {
            get { return fJournalName; }
            set { SetPropertyValue<string>("JournalName", ref fJournalName, value); }
        }
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
