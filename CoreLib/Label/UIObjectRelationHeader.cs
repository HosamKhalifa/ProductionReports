using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Label
{
    public class UIObjectRelationHeader : XPLiteObject
    {
        protected UIObjectRelationHeader(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        int fRelationId;
        [Key]
        public int RelationId
        {
            get { return fRelationId; }
            set { SetPropertyValue<int>("RelationId", ref fRelationId, value); }
        }

        string fRelationName;
        [Size(150)]
        public string RelationName
        {
            get { return fRelationName; }
            set { SetPropertyValue<string>("RelationName", ref fRelationName, value); }
        }

        string fLeftObjectName;
        [Size(150)]
        public string LeftObjectName
        {
            get { return fLeftObjectName; }
            set { SetPropertyValue<string>("LeftObjectName", ref fLeftObjectName, value); }
        }
        string fRightObjectName;
        [Size(150)]
        public string RightObjectName
        {
            get { return fRightObjectName; }
            set { SetPropertyValue<string>("RightObjectName", ref fRightObjectName, value); }
        }
        #region Association
        [Association(@"OBJ_HEADER_LINES_FK")]
        public XPCollection<UIObjectRelationLines> Lines { get {return GetCollection<UIObjectRelationLines>("Lines"); } }
        #endregion


    }
}
