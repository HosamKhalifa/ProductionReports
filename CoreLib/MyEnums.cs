using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class MyEnums
    {
        public enum AutoLookUp {None=0, ValueMemberVisiable=5,ValueMemberHidden=7,DisplayMember1=10, DisplayMember2 = 20, DisplayMember3 = 30, DisplayMember4 = 40, DisplayMember5 = 50, DisplayMember6 = 60, DisplayMember7 = 70 }
        public enum UILabelType
        {
            FieldCaption=1,
            FieldHelp=2
        }
        public enum RelationConditionIndex { Line1=10,Line2=20,Line3=30,Line4=40,Line5=50}
        public enum RelationConditionType { Normal = 100,Filter=200,Association=300}
        
    }
}
