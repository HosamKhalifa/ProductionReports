using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class InputBox
    {
        public static void Show(string _prompt,List<InputBoxInfo>  _parmsInfoList)
        {
            Args _args = new Args() {  ParmObject = _parmsInfoList };
            InputBoxFrm frm = new InputBoxFrm(_args);
            frm.promptLabelControl.Text = _prompt;
            frm.ShowDialog();

        }
    }
}
