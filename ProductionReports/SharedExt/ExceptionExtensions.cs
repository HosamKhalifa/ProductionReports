using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionReports.SharedExt
{
  public static  class ExceptionExtensions
    {
        public static string GetFullExceptionErrMessage(this Exception exception)
        {
            string ret = "";
            string msg1 = "",msg2="",msg3="";
            msg1 = exception.Message ;
            if (exception.InnerException != null)
            {
                msg2 = exception.InnerException.Message;
                if (exception.InnerException.InnerException != null)
                {
                    msg3 = exception.InnerException.InnerException.Message;
                }
            }
            
            ret= $"{msg1} \n {msg2} \n {msg3}";
           
            return ret;
        }

    }
}
