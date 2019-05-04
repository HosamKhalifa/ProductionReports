using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    public class LineShadow : XPObject
    {
        public LineShadow(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Fields
        Line fLineId;
        [Persistent("LINE_ID")]
        [Indexed("Family", Name ="LineFamily_UQ",Unique =true)]
        [Association("LineId_ShadowLineId")]
        public Line LineId
        {
            get { return fLineId; }
            set { SetPropertyValue<Line>("LineId", ref fLineId, value); }
        }

        Line fFamily;
        [Persistent(@"FAMILY")]
        [Association("LineId_ShadowFamilyLineId")]
        public Line Family
        {
            get { return fFamily; }
            set { SetPropertyValue<Line>("Family", ref fFamily, value); }
        }

        #endregion

        #region Methods
      
        #endregion
    }
}
