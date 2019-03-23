using CoreLib.Xpo;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoreLib.Label
{
    public class UIObjectBase : XPObject
    {
        public UIObjectBase(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string fObjectName;
        [Size(150)]
        public string ObjectName
        {
            get { return fObjectName; }
            set { SetPropertyValue<string>("ObjectName", ref fObjectName, value); }
        }
        string fAssemblyName;
        [Size(100)]
        public string AssemblyName
        {
            get { return fAssemblyName; }
            set { SetPropertyValue<string>("AssemblyName", ref fAssemblyName, value); }
        }
        [Association("UIObjectBase-UILabels")]
        public XPCollection<UILabel> ObjectLabels { get { return GetCollection<UILabel>("ObjectLabels"); } }



    }
}
