using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.SharedExt;
using DevExpress.Xpo.Metadata;

namespace CoreLib.Xpo
{
    public class XPCollectionExt:XPCollection
    {
        public XPCollectionExt() : base() { }
        public XPCollectionExt(Session session, XPClassInfo objType) : base(session, objType) { }
        public XPCollectionExt(Session session, Type type) : base(session, type) { }

        protected override void OnCollectionChanged(XPCollectionChangedEventArgs args)
        {
            if (args.CollectionChangedType == DevExpress.Xpo.XPCollectionChangedType.AfterRemove)
            {
                if(this.Session is UnitOfWork)//Should be UnitOfWork to use extension method SaveLine
                {
                    UnitOfWork unit = (UnitOfWork)this.Session;
                    unit.Delete(args.ChangedObject);
                    unit.SaveLine();
                }
                
            }
            base.OnCollectionChanged(args);
        }
        
    }
}
