using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
   public class MyEnums
    {
        public enum SysSequence { LINE_ID_SEQU=10, UI_LABEL_SEQU = 20 ,GL_COMB_ID_SEQU=30,COMB_ID_SEQU=40}
        public enum TableType
        {
            Master=10,Document=20,DocumentLine=30,Parameter=40,System=50
        }

        public enum AccountType
        {
            Employee=10,Customer=20,Vendor=30,InventoryItem=40,
            MainAccount=50
        }
        public enum DebitCredit { Debit=1,Credit=2}
        public enum InventoryDirection { Incoming=1,Outgoing= -1}
        public enum JournalType
        {
            AccountsPayable=1000,AccountsReceivable=1010,GeneralLedger=1030,FixedAssets=1040,CashAndBank=1050,Inventory=1060,
            Purchase=1070,Sales=1080
        }
        
        public enum WorkflowStatus
        {
            Draft=10,//Draft is inital status for document 
            ReadyForApprove=20,//Ready for apporve the status when document pass vaidation and then will be ready to starting approve rules
            Approving=30,//Approving after first approve action applied to the document and still til Last Approve happened
            Approved=40,//After all approve cycle member signed the document
            Rejected=-1,//These option will return document to Whom take ReadyForApprove 
            Posted=100//Can not changed
        }
    }
}
