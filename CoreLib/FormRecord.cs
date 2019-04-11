using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreLib
{
   public class FormRecord
    {
        public static XPLiteObject CurrentRecord { get; set; }

        public static object ObjectParm { get; set; }

        static string fCurrentUserId;
        public static string CurrentUserId
        { get
            {
                if (string.IsNullOrEmpty(fCurrentUserId))
                {
                    fCurrentUserId = Environment.UserName;
                }
                return fCurrentUserId;
            }
            set
            {
                fCurrentUserId = value;
            }
        }
        public static string ProfileConnStr { get; set; }

    }
}
