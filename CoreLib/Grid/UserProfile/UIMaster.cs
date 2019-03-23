using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid.UserProfile
{
    [Persistent(@"UI_MASTER_TB")]
    public class UIMaster :XPObject
    {
        public UIMaster(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string fObjCodeName;
        [Size(500), DisplayName("UI Object name")]
        public string ObjCodeName
        {
            get { return fObjCodeName; }
            set { SetPropertyValue<string>("ObjCodeName", ref fObjCodeName, value); }
        }

        string fObjCodeCaption;
        [Size(500), DisplayName("UI Object caption")]
        public string ObjCodeCaption
        {
            get { return fObjCodeName; }
            set { SetPropertyValue<string>("ObjCodeCaption", ref fObjCodeCaption, value); }
        }
        [Association("UIMaster-Profile")]
        public XPCollection<UIProfile> UIProfiles  { get { return GetCollection<UIProfile>("UIProfiles"); } }
        [Association("UIMaster-Params")]
        public XPCollection<UIParams> UIParams { get { return GetCollection<UIParams>("UIParams"); } }

    }
}
