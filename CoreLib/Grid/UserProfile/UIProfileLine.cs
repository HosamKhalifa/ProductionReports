using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid.UserProfile
{
    [Persistent(@"UI_PROFILE_LINE_TB")]
    public class UIProfileLine:XPObject
    {
        public UIProfileLine(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        int fVersionId;
        public int VersionId
        {
            get { return fVersionId; }
            set { SetPropertyValue<int>("VersionId", ref fVersionId, value); }
        }
        string fVersionName;
        public string VersionName
        {
            get { return fVersionName; }
            set { SetPropertyValue<string>("VersionName", ref fVersionName, value); }
        }
        string fLayout;
        [Size(1500)]
        public string Layout
        {
            get { return fLayout; }
            set { SetPropertyValue<string>("Layout", ref fLayout, value); }
        }

        bool fIsDefault;
        public bool IsDefault
        {
            get { return fIsDefault; }
            set { SetPropertyValue<bool>("IsDefault", ref fIsDefault, value); }
        }
        UIProfile fUIProfile;
        [Association("UIProfile-UIProfileLines")]
        public UIProfile UIProfile
        {
            get { return fUIProfile; }
            set { SetPropertyValue<UIProfile>("UIProfile", ref fUIProfile, value); }
        }
    }
}
