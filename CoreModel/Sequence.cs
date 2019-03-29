using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"SEQU_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public  class Sequence : Line
    {
        public static string TABLE_NAME = "SEQU_TB";
        public Sequence(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Sequence);
            base.AfterConstruction();
        }
        string fSequName;
        [Indexed(Name = @"SEQU_NAME_UK", Unique = true)]
        [Size(200)]
        [Persistent(@"SEQU_NAME")]
        public string SequName
        {
            get { return fSequName; }
            set { SetPropertyValue<string>("SequName", ref fSequName, value); }
        }
        string fSequMask;
        [Size(20)]
        [Persistent(@"SEQU_MASK")]
        public string SequMask
        {
            get { return fSequMask; }
            set { SetPropertyValue<string>("SequMask", ref fSequMask, value); }
        }
        string fSequType;
        [Size(1)]
        [Persistent(@"SEQU_TYPE")]
        public string SequType
        {
            get { return fSequType; }
            set { SetPropertyValue<string>("SequType", ref fSequType, value); }
        }
        byte fSequLength;
        [Persistent(@"SEQU_LENGTH")]
        public byte SequLength
        {
            get { return fSequLength; }
            set { SetPropertyValue<byte>("SequLength", ref fSequLength, value); }
        }
        DateTime fStartDate;
        [Persistent(@"START_DATE")]
        public DateTime StartDate
        {
            get { return fStartDate; }
            set { SetPropertyValue<DateTime>("StartDate", ref fStartDate, value); }
        }
        DateTime fEndDate;
        [Persistent(@"END_DATE")]
        public DateTime EndDate
        {
            get { return fEndDate; }
            set { SetPropertyValue<DateTime>("EndDate", ref fEndDate, value); }
        }
        string fSequRecycle;
        [Size(1)]
        [Persistent(@"SEQU_RECYCLE")]
        public string SequRecycle
        {
            get { return fSequRecycle; }
            set { SetPropertyValue<string>("SequRecycle", ref fSequRecycle, value); }
        }
        byte fWFStatusCreation;
        [Persistent(@"SEQU_WF_STATUS_CREATION")]
        public byte WFStatusCreation
        {
            get { return fWFStatusCreation; }
            set { SetPropertyValue<byte>("WFStatusCreation", ref fWFStatusCreation, value); }
        }
        #region Associations
        [Association(@"Sequence_SequenceValues")]
        public XPCollection<SequenceValues> SEQU_VALUES_s { get { return GetCollection<SequenceValues>("SequenceValues"); } }

        [Association(@"SEQU_JOURNAL_FK")]
        public XPCollection<JournalBase> Journals { get { return GetCollection<JournalBase>("Journals"); } }
        #endregion
    }
}
