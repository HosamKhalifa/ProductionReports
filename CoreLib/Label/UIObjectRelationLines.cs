using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Label
{
    public class UIObjectRelationLines : XPObject
    {
        protected UIObjectRelationLines(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        UIObjectRelationHeader fObjectRelationHeader;
        [Association(@"OBJ_HEADER_LINES_FK")]
        public UIObjectRelationHeader ObjectRelationHeader
        {
            get { return fObjectRelationHeader; }
            set { SetPropertyValue<UIObjectRelationHeader>("ObjectRelationHeader", ref fObjectRelationHeader, value); }
        }

        MyEnums.RelationConditionIndex fConditionIndex;
       
        public MyEnums.RelationConditionIndex ConditionIndex
        {
            get { return fConditionIndex; }
            set { SetPropertyValue<MyEnums.RelationConditionIndex>("ConditionIndex", ref fConditionIndex, value); }
        }
        MyEnums.RelationConditionType fConditionType;
        public MyEnums.RelationConditionType ConditionType
        {
            get { return fConditionType; }
            set { SetPropertyValue<MyEnums.RelationConditionType>("ConditionType", ref fConditionType, value); }
        }
        string fConitionExpression;
        public string ConitionExpression
        {
            get { return fConitionExpression; }
            set { SetPropertyValue<string>("ConitionExpression", ref fConitionExpression, value); }
        }



    }
}
