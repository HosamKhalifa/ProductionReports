using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
   public class MyEnums
    {
        public enum MainAccountClass{ Total=0,Assets=1,Liabilities=2,Equity=3,Revenues=4,CostOfGoodsSold=5,Expenses=6}
        public enum BalanceControl {None=0,Debit=1,Credit=2 }
        public enum AccountClosingType { None=0,BalanceSheetAccounts=10,ResultAcounts=20,OwnershipAccounts=30}
        public enum DefinitionType { All=0,Group=10, ReferenceNumber1 =20, ReferenceNumber2=30, SpecificRow =40}
        public enum Module { GeneralLedger=10,AccountsPayable=20,AccountsReceivable=30,Inventory,Bank}
        public enum DocType
        {
            JournalEntry = 10,PayrollSheet = 20,InventoryTrans = 30,
            CustomerReceivable = 40,VendorPayment = 50,PurchaseOrder = 60,
            PurchaseBillAccrual = 70, SalesBillAccrual = 80,
            PurchaseBillCash = 90, SalesBillCash = 100
            
            
        }
        public enum SequRecycle { Continuous = 10,Monthly=20,Yearly=30}
        public enum SequenceType { Account=10,Document= 20}
        public enum SequenceGenerating { Automatic = 200 , Manual=400}
        public enum SequencUsedeDate {None=0, EffectiveDate=10,DocumentDate=20,LedgerDate}
        public enum SysSequence
        {
            None=0,
            LINE_ID_SEQU =10, UI_LABEL_SEQU = 20 ,GL_COMB_ID_SEQU=30,COMB_ID_SEQU=40
            //Dimension sequences
            ,MAIN_ACCOUNT_DIM_SEQU=50, EMPLOYEE_DIM_SEQU = 60, CUSTOMER_DIM_SEQU =70, VENDOR_DIM_SEQU =80
            ,INVENTORY_DIM_SEQU =90, PURPOSE_DIM_SEQU =100, LOCATION_DIM_SEQU =110, DEPARTMENT_DIM_SEQU =120
            ,EQUIPMENT_DIM_SEQU =130,PROJECT_DIM_SEQU =140, FIXED_ASSET_DIM_SEQU = 150

        }
        public enum TableType
        {
            Master=10,Document=20,DocumentLine=30,Parameter=40,System=50
        }

        public enum AccountType
        {
            MainAccountOnly = 0,Employee =10,Customer=20,Vendor=30,InventoryItem=40,Purpose=50,Location=60,Department=70,
            Equipment=80,FixedAssets
            
        }
        public enum DebitCredit { Debit=1,Credit=-1}
        public enum InventoryDirection { Incoming=1,Outgoing= -1}
        public enum JournalType
        {
            AccountsPayable=1000,AccountsReceivable=1010,GeneralLedger=1030,FixedAssets=1040,CashAndBank=1050,Inventory=1060,
            Purchase=1070,Sales=1080
        }
        public enum FiscalPeriodType { Opening = 0, Operating = 1, Closing = 2 }
        public enum FiscalPeriodStatus { Open = 1 ,Closed = 2}
        public enum FiscalPeriodQuarter { Q1 = 1 , Q2 = 2 , Q3 = 3 , Q4 = 4}
        public enum FiscalPeriodMonth { One=1, Two=2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Eleven = 11 , Twelve = 12 }
        public enum WorkflowStatus
        {
            Draft=10,//Draft is inital status for document 
            ReadyForApprove =20,//Ready for apporve the status when document pass vaidation and then will be ready to starting approve rules
            Approving=30,//Approving after first approve action applied to the document and still til Last Approve happened
            Approved =40,//After all approve cycle member signed the document
            Rejected =-1,//These option will return document to Whom take ReadyForApprove 
            Posted=100//Can not changed
        }
        public enum WorkflowTarget { Account = 10,Document=20}
        public enum WorkflowStep { MakeItReady = 10,Approve=20,Reopen=30,Reject=40,Post=50}

    }
}
