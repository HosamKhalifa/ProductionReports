using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid.UserProfile
{
    [Persistent(@"UI_PARAMS_TB")]
    public class UIParams:XPObject
    {
        public UIParams(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        UIMaster fUIMaster;
        [Association("UIMaster-Params")]
        public UIMaster UIMaster
        {
            get { return fUIMaster; }
            set { SetPropertyValue<UIMaster>("UIMaster", ref fUIMaster, value); }
        }


    }
}
