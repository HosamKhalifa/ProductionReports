using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using DevExpress.Xpo;
using ProductionReports.SharedExt;
namespace ProductionReports
{
    public partial class LoginXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public LoginXUC()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProvider1.Validate() )
                {
                    SecurityUser user = new SecurityUser();
                    user.ReadConnection(userTxt.Text, pwdTxt.Text);

                    XpoDefault.DataLayer = XpoDefault.GetDataLayer(user.ConnectionString,DevExpress.Xpo.DB.AutoCreateOption.None);
                    SecurityUser.CurrentUser = user;
                    SecurityUser.IsConnected = true;
                    ParentForm.Close();
                }
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                SecurityUser.IsConnected = false;
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
