using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"SEQU_VALUES_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SequenceValues : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SequenceValues;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = @"SEQU_VALUES_TB";
        public SequenceValues(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.SequenceValues);
            base.AfterConstruction();
        }
        Sequence fSequenceId;
        [Indexed(@"SequenceKey", Name = @"SEQU_VALUES_TB_UK", Unique = true)]
        [Persistent(@"SEQU_ID")]
        [Association(@"Sequence_SequenceValues")]
        public Sequence SequenceId
        {
            get { return fSequenceId; }
            set { SetPropertyValue<Sequence>("SequenceId", ref fSequenceId, value); }
        }
        string fSequenceKey;
        [Size(40)]
        [Persistent(@"SEQU_KEY")]
        public string SequenceKey
        {
            get { return fSequenceKey; }
            set { SetPropertyValue<string>("SequenceKey", ref fSequenceKey, value); }
        }
        int fCurrentValue;
        [Persistent(@"CURR_VAL")]
        public int CurrentValue
        {
            get { return fCurrentValue; }
            set { SetPropertyValue<int>("CurrentValue", ref fCurrentValue, value); }
        }
    }
}
