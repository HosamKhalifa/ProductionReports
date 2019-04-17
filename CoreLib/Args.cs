using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
   public  class Args
    {
        public object Caller { get; set; }
        public DevExpress.Xpo.XPBaseObject Record { get; set; }
        public int TableId { get; set; }
        public string LookupField { get; set; }
        public string LookupValue { get; set; }
        public string ParmString { get; set; }
        public Type ParmEnumType { get; set; }
        public int ParmEnumValue { get; set; }
        public object ParmObject { get; set; }

    }
}
