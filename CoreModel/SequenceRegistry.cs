using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"SEQU_REGISTRY")]
    public class SequenceRegistry : XPObject
    {
        protected SequenceRegistry(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        SequenceValues fSequValueKey;
        [Persistent(@"SEQU_VAL_KEY")]
        public SequenceValues SequValueKey
        {
            get { return fSequValueKey; }
            set { SetPropertyValue<SequenceValues>("SequValueKey", ref fSequValueKey, value); }
        }
        int fUsedValue;
        [Persistent(@"USED_VALUE")]
        public int UsedValue
        {
            get { return fUsedValue; }
            set { SetPropertyValue<int>("UsedValue", ref fUsedValue, value); }
        }

        MyEnums.WorkflowTarget fOwnerType;
        [Persistent(@"OWNER_TYPE")]
        public MyEnums.WorkflowTarget OwnerType
        {
            get { return fOwnerType; }
            set { SetPropertyValue<MyEnums.WorkflowTarget>("OwnerType", ref fOwnerType, value); }
        }

        Line fOwnerLineId;
        [Persistent(@"OWNER_LINE_ID")]
        public Line OwnerLineId
        {
            get { return fOwnerLineId; }
            set { SetPropertyValue<Line>("OwnerLineId", ref fOwnerLineId, value); }
        }

        DateTime fCreatedAt;
        [Persistent(@"CREATED_AT")]
        public DateTime CreatedAt
        {
            get { return fCreatedAt; }
            set { SetPropertyValue<DateTime>("CreatedAt", ref fCreatedAt, value); }
        }

    }
}
