using CoreLib.Label;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid
{
   public class GridColumnInfo
    {
        //Current column label
        public UILabel ColumnLablel { get; set; }
        public Args FormArgs { get; set; }
      //  public string LookupValue { get; set; }//Value of current row for lookup field
        public bool IsViewDetails
        {
            get
            {
                return ColumnLablel != null && ColumnLablel.LookupFormRef != MyEnums.FormEntityEnum.None;
            }
        }
       

    }
}
