using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreLib.SharedExt
{
  public static class MyFormExt
    {
        public static void ForeachControl(this Control parent, Action<Control> action)
        {
            foreach (Control c in parent.Controls)
            {
                action(c);
                ForeachControl(c, action);
            }
        }
    }
}
