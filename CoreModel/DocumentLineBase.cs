using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"DOCUMENT_LINE")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class DocumentLineBase : Line
    {
        public DocumentLineBase(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        #region Fields
        DocumentBase fDocumentId;
        [Persistent(@"DOC_ID")]
        [Association(@"DOC_BASE_DOC_LINE_FK")]
        public DocumentBase DocumentId
        {
            get { return fDocumentId; }
            set { SetPropertyValue<DocumentBase>("DocumentId", ref fDocumentId, value); }
        }
        int fLineOrder;
        [Persistent(@"LINE_ORDER")]
        public int LineOrder
        {
            get { return fLineOrder; }
            set { SetPropertyValue<int>("LineOrder", ref fLineOrder, value); }
        }
        MainAccount fMainAccount;
        [Persistent(@"MAIN_ACCOUNT")]
        [Association(@"DOC_LINE_MAIN_ACCOUNT_FK")]
        public MainAccount MainAccount
        {
            get { return fMainAccount; }
            set
            {
                SetPropertyValue<MainAccount>("MainAccount", ref fMainAccount, value);
                if(value == null)
                {
                    MainAccountNum = "";
                    MainAccountDescription = "";
                }
                else
                {
                    MainAccountNum = value.DisplayNumber;
                    MainAccountDescription = value.DisplayNumber;
                }
            }
        }

        string fMainAccountNum;
        [Persistent(@"MAIN_ACCOUNT_NUM"), Size(9)]
        public string MainAccountNum//Computed
        {
            get { return fMainAccountNum; }
            private set { SetPropertyValue<string>("MainAccountNum", ref fMainAccountNum, value); }
        }
        string fMainAccountDescription;
        [Persistent(@"MAIN_ACCOUNT_DESC"), Size(250)]
        public string MainAccountDescription//Computed
        {
            get { return fMainAccountDescription; }
            private set { SetPropertyValue<string>("MainAccountDescription", ref fMainAccountDescription, value); }
        }



        #endregion


        #region Associations
        #endregion

    }
}
