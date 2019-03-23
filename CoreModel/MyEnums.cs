using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
   public class MyEnums
    {
        public enum TableType
        {
            Master=10,Document=20,DocumentLine=30,Parameter=40,System=50
        }

        public enum AccountType
        {
            Employee=10,Customer=20,Vendor=30,InventoryItem=40,
            MainAccount=50
        }
    }
}
