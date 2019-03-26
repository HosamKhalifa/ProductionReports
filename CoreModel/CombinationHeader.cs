using CoreLib.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"COMB_HEADER_TB")]
    public class CombinationHeader : XPLiteObjectExt
    {
        
        protected CombinationHeader(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {

            GLCombinationId = SysSequence.NextVal(Session, MyEnums.SysSequence.GL_COMB_ID_SEQU,(100*1000));
            base.AfterConstruction();
        }

        long fGLCombinationId;
        [Persistent(@"GL_COMB_ID"),Key]
        public long GLCombinationId
        {
            get { return fGLCombinationId; }
            set { SetPropertyValue<long>("GLCombinationId", ref fGLCombinationId, value); }
        }

        string fMainAccountNum;
        [Persistent(@"MAIN_ACCOUNT_DIM"), Size(9)]
        [Indexed("DetailAccountDim", Name = "MAIN_ACT_DETAIL_ACT_UQ",  Unique = true)]
        public string MainAccountNum
        {
            get { return fMainAccountNum; }
            set { SetPropertyValue<string>("MainAccountNum", ref fMainAccountNum, value); }
        }
        string fDetailAccountDim;
        /*Can contain any Dim value from another accounts object */
        [Persistent(@"DETAIL_ACCOUNT_DIM"), Size(9)]
        public string DetailAccountDim
        {
            get { return fDetailAccountDim; }
            set { SetPropertyValue<string>("DetailAccountDim", ref fDetailAccountDim, value); }
        }

        #region Associations
        [Association(@"COMB_HEADER_COMB_TABLE_FK")]
        public XPCollection<CombinationTable> CombinationLines { get{ return GetCollection<CombinationTable>("CombinationLines"); }}
        #endregion

    }
}
