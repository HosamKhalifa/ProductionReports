using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using ProductionReports.SharedExt;
namespace ProductionReports
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
          
            SkinManager.EnableFormSkins();
            
            try
            {
                LoginXtraForm frm = new LoginXtraForm();
                frm.ShowDialog();
                if (!(SecurityUser.IsConnected && SecurityUser.CurrentUser != null))
                {
                    throw new Exception("Invalid login information !");
                }
                else
                {
                    Application.Run(new Form1());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetFullExceptionErrMessage());
                Application.Exit();
            }
            
        }
    }
}
