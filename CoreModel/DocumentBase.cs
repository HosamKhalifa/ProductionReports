using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"DOCUMENT_BASE")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class DocumentBase : Line
    {
        public DocumentBase(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {

            base.AfterConstruction();
        }

        #region Fields
        MyEnums.DocType fDocumentType;
        [Persistent(@"DOC_TYPE")]
      
        public MyEnums.DocType DocumentType
        {
            get { return fDocumentType; }
            set { SetPropertyValue<MyEnums.DocType>("DocumentType", ref fDocumentType, value); }
        }

        JournalBase fJournal;
        [Persistent(@"JOURNAL_ID")]
        [Association("JOURNAL_DOC_BASE_FK")]
        public JournalBase Journal
        {
            get { return fJournal; }
            set { SetPropertyValue<JournalBase>("Journal", ref fJournal, value); }
        }

        string fReferenceNumber;
        [Persistent(@"REF_NUM"), Size(30)]
        public string ReferenceNumber
        {
            get { return fReferenceNumber; }
            set { SetPropertyValue<string>("ReferenceNumber", ref fReferenceNumber, value); }
        }

        string fFriendlyDocumentName;
        [Persistent(@"FRIENDLY_DOC_NAME"), Size(150)]
        public string FriendlyDocumentName
        {
            get { return fFriendlyDocumentName; }
            set { SetPropertyValue<string>("FriendlyDocumentName", ref fFriendlyDocumentName, value); }
        }

        string fDisplayNumber;
        [Persistent(@"DISPLAY_NUM"), Size(20)]
        public string DisplayNumber
        {
            get { return fDisplayNumber; }
            set { SetPropertyValue<string>("DisplayNumber", ref fDisplayNumber, value); }
        }
        Sequence fUsedSequence;
        public Sequence UsedSequence
        {
            get { return fUsedSequence; }
            set { SetPropertyValue<Sequence>("UsedSequence", ref fUsedSequence, value); }
        }
        string fUsedSequenceKey;
        [Persistent(@"USED_SEQU_KEY")]
        public string UsedSequenceKey
        {
            get { return fUsedSequenceKey; }
            set { SetPropertyValue<string>("UsedSequenceKey", ref fUsedSequenceKey, value); }
        }
        DateTime fDocumentDate;
        [Persistent(@"DOC_DATE")]
        public DateTime DocumentDate
        {
            get { return fDocumentDate; }
            set { SetPropertyValue<DateTime>("DocumentDate", ref fDocumentDate, value); }
        }

        DateTime fFinancialDate;
        [Persistent(@"FIN_DATE")]
        public DateTime FinancialDate
        {
            get { return fFinancialDate; }
            set
            {
                SetPropertyValue<DateTime>("FinancialDate", ref fFinancialDate, value);
                int dayId ;
                if (value == null)
                {
                    dayId = 0;
                }

                else
                {
                    dayId = ((value.Year * 100) + value.Month);
                    dayId = (dayId * 100) + value.Day;
                }
                DayId = dayId;
            }
        }
        DocumentBase fCreatedByDocument;
        [Persistent(@"CREATED_BY_DOC_ID")]
        public DocumentBase CreatedByDocument
        {
            get { return fCreatedByDocument; }
            set { SetPropertyValue<DocumentBase>("CreatedByDocument", ref fCreatedByDocument, value); }
        }
        decimal fTotalAmountBeforeTaxCC;//Total document lines before tax
        [Persistent(@"TOTAL_AMOUNT_BEFORE_TAX_CC")]
        public decimal TotalAmountBeforeTaxCC
        {
            get { return fTotalAmountBeforeTaxCC; }
            set { SetPropertyValue<decimal>("TotalAmountBeforeTaxCC", ref fTotalAmountBeforeTaxCC, value); }
        }

        decimal fTotalAmountCC;//Total document lines After tax
        [Persistent(@"TOTAL_AMOUNT_CC")]
        public decimal TotalAmountCC
        {
            get { return fTotalAmountCC; }
            set { SetPropertyValue<decimal>("TotalAmountCC", ref fTotalAmountCC, value); }
        }

        decimal fBalanceCC;//Document balance 
        [Persistent(@"BALANCE_CC")]
        public decimal BalanceCC
        {
            get { return fBalanceCC; }
            set { SetPropertyValue<decimal>("TotalAmountCC", ref fBalanceCC, value); }
        }

        string fCurrencyIsoCode;
        [Persistent(@"CURRENCY_ISO_CODE")]
        public string CurrencyIsoCode
        {
            get { return fCurrencyIsoCode; }
            set { SetPropertyValue<string>("CurrencyIsoCode", ref fCurrencyIsoCode, value); }
        }
        Account fCVEAccountId;
        [Persistent(@"CVE_AID")]
        public Account CVEAccountId
        {
            get { return fCVEAccountId; }
            set { SetPropertyValue<Account>("CVEAccountId", ref fCVEAccountId, value); }
        }
        string fCVEName;
        [Size(250)]
        [Persistent(@"CVE_NAME")]
        public string CVEName
        {
            get { return fCVEName; }
            set { SetPropertyValue<string>("CVEName", ref fCVEName, value); }
        }
        string fDocumentDescription;
        [Size(500), Persistent(@"DOC_DESC")]
        public string DocumentDescription
        {
            get { return fDocumentDescription; }
            set { SetPropertyValue<string>("DocumentDescription", ref fDocumentDescription, value); }
        }

        int fDayId;
        [Persistent(@"DAY_ID")]//Computed in C# not DB on FinancialDate Field
        public int DayId
        {
            get { return fDayId; }
            private set { SetPropertyValue<int>("DayId", ref fDayId, value); }
        }
        #endregion

        #region Association
        [Association(@"DOC_BASE_DOC_LINE_FK")]
        public XPCollection<DocumentLineBase> DocumentLines { get { return GetCollection<DocumentLineBase>("DocumentLines"); } }
        #endregion
    }
}