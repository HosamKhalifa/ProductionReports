using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.SharedExt;

namespace CoreLib.Xpo
{
    public class XPCollectionExt:XPCollection
    {
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
