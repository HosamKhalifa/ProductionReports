using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class MyEnums
    {
        public enum GridViewEditMode { ReadOnly=0,SimpleEdit=1,FormEdit=2}
        public enum AutoLookUp {None=0, ValueMemberVisiable=5,ValueMemberHidden=7,DisplayMember1=10, DisplayMember2 = 20, DisplayMember3 = 30, DisplayMember4 = 40, DisplayMember5 = 50, DisplayMember6 = 60, DisplayMember7 = 70 }
        public enum UILabelType
        {
            FieldCaption=1,
            FieldHelp=2
        }
        public enum RelationConditionIndex { Line1=10,Line2=20,Line3=30,Line4=40,Line5=50}
        public enum RelationConditionType { Normal = 100,Filter=200,Association=300}
        public enum FormEntityEnum
        {
            None=0,TestForm=1, FieldsSetting=2, Sequence=3, UILabel=4, TableBase=5, FiscalCalender=6, Currency=7, CurrencySetup=8,
            FiscalCalenderYear=9, LedgerChartOfAccounts=10,Ledger=11,MainAccountType=12,MainAccount=13,Customer=14,Vendor = 15,
            Employee=16,Equipment=17,Purpose=18,Country=19,City=20,Province=21,AccountGrouping=22,
            SecurityPrincipalUser=23, SecurityPrincipalRole=24
        }
        //this enum should assigned to general tool bar item.tag property 
        public enum MainFunction
        {
            Retrieve=5,Save=10,NewRecord=20,DeleteRecord=30,Print=40
        }

    }
}
