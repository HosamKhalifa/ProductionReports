using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        #region Methods
        public string NextVal()
        {
            const string YEAR4D_MM = "{YYYYMM}";
            const string YEAR4D = "{YYYY}";
            const string YEAR2D = "{YY}";
            const string YEAR2D_MM = "{YYMM}";
            const string YEAR4D_MMM = "{YYYYMMM}";
            string[] simpleList = new string[] { YEAR2D, YEAR2D_MM, YEAR4D, YEAR4D, YEAR4D_MM };
            CurrentValue +=1;
            string currVal = CurrentValue.ToString().PadLeft(SequenceId.SequLength, '0');
            Save();
            string value = SequenceId.SequMask.Replace("{$}",currVal);

            if (value.Contains(YEAR4D_MMM) )
            {
                int monVal = int.Parse(SequenceKey.Substring(4, 2));
                string monName = new DateTime(2010, monVal, 1).ToString("MMM", CultureInfo.InvariantCulture);
                string yearPart = SequenceKey.Substring(0, 4) + monName;

                value = value.Replace(YEAR4D_MMM, yearPart);
            }
            else
            {
                foreach (var item in simpleList)
                {
                    
                    if(value.Contains(item) && SequenceKey.Length > (item.Length-2))
                    {
                        value = value.Replace(item, SequenceKey.Substring(0, item.Length));
                        break;
                    }
                }
            }
            
            return value;
        }
        #endregion
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
