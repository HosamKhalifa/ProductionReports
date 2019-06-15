using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"ACT_SEQU_RULE_TB")]
    public class AccountSequenceRule : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.AccountSequenceRule;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public AccountSequenceRule(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.AccountSequenceRule);
            base.AfterConstruction();
        }

        #region Methods
        public static List<Line> DeAssemblyDefinitionId(Session _uOW, MyEnums.DefinitionType _defType)
        {
            List<Line> lst = new List<Line>();
            var rules = new XPCollection<AccountSequenceRule>(_uOW).Where(x => x.DefinitionType == _defType).ToList<AccountSequenceRule>();
            foreach (var r in rules)
            {
                foreach (Line l in r.DefinitionId.GetLineShadowLines())
                {
                    lst.Add(l);
                }
            }
            return lst;
        }
        public static Sequence GetAppliedSequence(Session _uOW, Account _account)
        {
            //Check for primary group 
            if (_account.GroupId != null)
            {
                
                var ruleLines = AccountSequenceRule.DeAssemblyDefinitionId(_uOW, MyEnums.DefinitionType.Group);
                var rLine = ruleLines.Where(x => x.LineId.Equals(_account.GroupId)).FirstOrDefault();
                if(rLine != null)
                {
                    var rule = _uOW.GetObjectByKey<AccountSequenceRule>(rLine.LineId);
                    return rule.AccountSequence;
                }
              
            }
            return null;
        }
        #endregion

        #region Fields
        MyEnums.DefinitionType fDefinitionType;
        [Persistent(@"DEFINITION_TYPE")]
        public MyEnums.DefinitionType DefinitionType
        {
            get { return fDefinitionType; }
            set { SetPropertyValue<MyEnums.DefinitionType>("DefinitionType", ref fDefinitionType, value); }
        }

        Line fDefinitionId;
        [Persistent(@"DEFINITION_ID")]
        public Line DefinitionId
        {
            get { return fDefinitionId; }
            set { SetPropertyValue<Line>("DefinitionId", ref fDefinitionId, value); }
        }
        Sequence fAccountSequence;
        [Persistent(@"ACT_SEQU")]
        public Sequence AccountSequence
        {
            get { return fAccountSequence; }
            set { SetPropertyValue<Sequence>("AccountSequence", ref fAccountSequence, value); }
        }
        #endregion
    }
}
