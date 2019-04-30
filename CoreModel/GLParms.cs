using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    public class GLParms : XPLiteObject
    {
        protected GLParms(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        int fSingleLineKey = -100;
        [Persistent(@"SINGLE_LINE_KEY"),Key]
        public int SingleLineKey
        {
            get { return fSingleLineKey; }
            set { fSingleLineKey = -100; }
        }
        Sequence fTempDocumentSequ;
        [Persistent(@"TEMP_DOC_SEQU")]
        public Sequence TempDocumentSequ
        {
            get { return fTempDocumentSequ; }
            set { SetPropertyValue<Sequence>("TempDocumentSequ", ref fTempDocumentSequ, value); }
        }

        Sequence fTempAccountSequ;
        [Persistent(@"TEMP_ACT_SEQU")]
        public Sequence TempAccountSequ
        {
            get { return fTempAccountSequ; }
            set { SetPropertyValue<Sequence>("TempAccountSequ", ref fTempAccountSequ, value); }
        }
    }
}
