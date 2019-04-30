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
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Sequence;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = "SEQU_TB";
        public Sequence(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Sequence);
            base.AfterConstruction();
        }
        #region Methods
        protected override bool Validate()
        {
          
            bool isValid = true;
            if((this.SequRecycle == MyEnums.SequRecycle.Monthly || SequRecycle == MyEnums.SequRecycle.Yearly) &&
                this.SequencUsedeDate == MyEnums.SequencUsedeDate.None)
            {
                isValid = false;
                throw new Exception("Monthly and Yearly sequence need to be used date selected");
                
            }
            return base.Validate() && isValid;
        }
        public string NextValue(DateTime _date) //Date should be passed as Sequ type {Document,Finance or Effective date}
        {
            string newValue = "";
            if(_date == null) { _date = CoreLib.FormRecord.EffectiveDate; }
            if (!(_date >= StartDate && _date <= EndDate)) return "";
            var sequValueLine = FindOrCreateSequenceValue(GetHash(_date));
            newValue = sequValueLine.NextVal();
            return newValue;
        }
        SequenceValues FindOrCreateSequenceValue(string _hash)
        {
            var line = this.SequenceValues.Where(x => x.SequenceKey == _hash).FirstOrDefault();
            if(line == null)
            {
                line = new CoreModel.SequenceValues(Session)
                {
                    SequenceId = this,
                    SequenceKey = _hash,
                    CurrentValue = 0
                };
                SequenceValues.Add(line);
            }
            return line;
        }
        private string GetHash(DateTime _date)
        {
            string hashCode = "";
            switch (SequRecycle)
            {
                case MyEnums.SequRecycle.Continuous:
                    hashCode += "XXXXXX"; 
                    break;
                case MyEnums.SequRecycle.Monthly:
                    hashCode += (_date.Year * 100 + _date.Month).ToString();
                    break;
                case MyEnums.SequRecycle.Yearly:
                    hashCode += (_date.Year * 100 ).ToString();
                    break;
                default:
                    break;
            }
            return hashCode;
        }

        
        #endregion

        #region Fields

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
        MyEnums.SequenceType fSequType;
        [Persistent(@"SEQU_TYPE")]
        public MyEnums.SequenceType SequType
        {
            get { return fSequType; }
            set { SetPropertyValue<MyEnums.SequenceType>("SequType", ref fSequType, value); }
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
        MyEnums.SequRecycle fSequRecycle;
        [Persistent(@"SEQU_RECYCLE")]
        public MyEnums.SequRecycle SequRecycle
        {
            get { return fSequRecycle; }
            set { SetPropertyValue<MyEnums.SequRecycle>("SequRecycle", ref fSequRecycle, value); }
        }

        MyEnums.SequencUsedeDate fSequencUsedeDate;
        [Persistent(@"SEQU_USED_DATE")]
        public MyEnums.SequencUsedeDate SequencUsedeDate
        {
            get { return fSequencUsedeDate; }
            set { SetPropertyValue<MyEnums.SequencUsedeDate>("SequencUsedeDate", ref fSequencUsedeDate, value); }
        }

        MyEnums.SequenceGenerating fSequenceGenerating;
        [Persistent(@"SEQU_GEN")]
        public MyEnums.SequenceGenerating SequenceGenerating
        {
            get { return fSequenceGenerating; }
            set { fSequenceGenerating = value; }
        }
        #endregion

        #region Associations
        [Association(@"Sequence_SequenceValues")]
        public XPCollection<SequenceValues> SequenceValues { get { return GetCollection<SequenceValues>("SequenceValues"); } }

        [Association(@"SEQU_JOURNAL_FK")]
        public XPCollection<JournalBase> Journals { get { return GetCollection<JournalBase>("Journals"); } }
        #endregion
    }
}
