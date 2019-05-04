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
        public static TableBase.TableEnum TableName = TableBase.TableEnum.GLParms;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        protected GLParms(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Methods
        public static void BuildTableRows(Session _uOW)
        {
            var GLP = _uOW.GetObjectByKey<GLParms>(-100);
            if(GLP == null)
            {
                GLP = new GLParms(_uOW)
                {
                    SingleLineKey = -100
                };
                GLP.Save();
                _uOW.CommitTransaction();
            }
        }

        #endregion

        #region Static Property
        public static GLParms GLParameters(Session _uOW)
        {
             return _uOW.GetObjectByKey<GLParms>(-100);
        }
        #endregion


        #region Fields

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
        #endregion

    }
}
