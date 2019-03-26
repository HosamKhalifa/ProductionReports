using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"CURRENCY_TB")]
    public class Currency : Line
    {
        public Currency(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            
            base.AfterConstruction();
        }
        string fIsoCode;
        [Persistent(@"ISO_CODE"),Size(4)]
        [Indexed(Name ="ISO_CODE_UQ",Unique =true)]
        public string IsoCode
        {
            get { return fIsoCode; }
            set { SetPropertyValue<string>("IsoCode", ref fIsoCode, value); }
        }
        string fSymbol;
        [Persistent(@"SYMBOL"), Size(3)]
        public string Symbol
        {
            get { return fSymbol; }
            set { SetPropertyValue<string>("Symbol", ref fSymbol, value); }
        }


    }
}
