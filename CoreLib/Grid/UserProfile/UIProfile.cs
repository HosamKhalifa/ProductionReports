using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid.UserProfile
{
    [Persistent(@"UI_PROFILE_TB")]
    public class UIProfile:XPObject
    {
        public UIProfile(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        UIMaster fUIMaster;
        [Association("UIMaster-Profile")]
        public UIMaster UIMaster
        {
            get { return fUIMaster; }
            set { SetPropertyValue<UIMaster>("UIMaster", ref fUIMaster, value); }
        }

        string fUserId;
        public string UserId
        {
            get { return fUserId; }
            set { SetPropertyValue<string>("UserId", ref fUserId, value); }
        }
        [Association("UIProfile-UIProfileLines")]
        public XPCollection<UIProfileLine> UIProfileLines { get { return GetCollection<UIProfileLine>("UIProfileLines"); } }

    }
}
