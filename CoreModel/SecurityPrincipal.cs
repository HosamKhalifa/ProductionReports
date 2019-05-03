using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"SEC_PRINCIPAL_TB")]
    public class SecurityPrincipal : XPLiteObject
    {
        protected SecurityPrincipal(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            EffectiveFrom = DateTime.Today.Date;
            EffectiveTo = EffectiveFrom.AddYears(3);
            base.AfterConstruction();
        }

        string fPrincipalId;
        [Persistent(@"PRINCIPAL_ID"), Key, Size(120)]
        public string PrincipalId
        {
            get { return fPrincipalId; }
            set { SetPropertyValue<string>("PrincipalId", ref fPrincipalId, value); }
        }

        string fPrincipalName;
        [Persistent(@"PRINCIPAL_NAME"), Size(150)]
        public string UserName
        {
            get { return fPrincipalName; }
            set { SetPropertyValue<string>("UserName", ref fPrincipalName, value); }
        }
        DateTime fEffectiveFrom;
        [Persistent("EFFECTIVE_FROM")]
        public DateTime EffectiveFrom
        {
            get { return fEffectiveFrom; }
            private set { SetPropertyValue<DateTime>("EffectiveFrom", ref fEffectiveFrom, value); }
        }

        DateTime fEffectiveTo;
        [Persistent("EFFECTIVE_TO")]
        public DateTime EffectiveTo
        {
            get { return fEffectiveTo; }
            private set { SetPropertyValue<DateTime>("EffectiveTo", ref fEffectiveTo, value); }
        }
      
    }
}
