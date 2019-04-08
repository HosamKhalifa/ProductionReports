using CoreLib;
using CoreModelWin.MyEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreModel;
using System.Windows.Forms;

namespace CoreModelWin
{
   public class MenuController
    {
        public static MyForm MdiParentForm;
        public static void CurrencySetupFormOpen()
        {
            //Curreny will use runtime Master - Details form
              var args = new MasterDetailsForm.FormParms()
              {
                  MasterClass = typeof(CurrencyPair),
                  MasterKeyName = "LineId",
                  Details = typeof(CurrencyPairExchangeRate),
                  DetailsKeyName = "CurrencyPair",
                  IsKeyValueNumeric = true
              };
            MasterDetailsForm frm = new MasterDetailsForm(args)
            { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();

            //View.Sys.CurrencySetupFrm frm = new View.Sys.CurrencySetupFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            //frm.Show();

        }
        public static void CurrencyFormOpen()
        {
            SimpleForm frm = new MyEditor.SimpleForm(typeof(Currency)) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void SequenceFormOpen()
        {
            SimpleForm frm = new MyEditor.SimpleForm(typeof(Sequence)) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void FieldsSettingFormOpen()
        {
            var frm = new CoreLib.Label.FieldsSettingsFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void UILabelFormOpen()
        {
            CoreLib.Label.LabelEditorFrm frm = new CoreLib.Label.LabelEditorFrm("CoreLib;CoreModel") { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }

        public static void TableBaseFormOpen()
        {
            TableBaseFrm frm = new TableBaseFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }

    }
}
