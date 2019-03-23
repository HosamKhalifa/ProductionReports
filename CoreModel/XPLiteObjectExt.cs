using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [NonPersistent]
    public class XPLiteObjectExt: XPLiteObject
    {
        protected XPLiteObjectExt() : base() { }
        protected XPLiteObjectExt(Session session) : base(session) { }
        protected XPLiteObjectExt(Session session, DevExpress.Xpo.Metadata.XPClassInfo classInfo) : base(session, classInfo) { }
        protected virtual bool Validate()
        {
            // This method should override in desctent objects for further validation logic
            return true;
        }
        protected virtual new void OnSaving()
        {
            //Prevent saving for validation failure
            if (this.Validate())
            {
                base.OnSaving();
            }
                
        }

        //Fake key for passing from KeyPropertyAbsentException
       

    }
}
