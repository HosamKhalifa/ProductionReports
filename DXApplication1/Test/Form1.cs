using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using CoreLib.SharedExt;
using CoreModel;
using DevExpress.Xpo.Metadata;
using System.Reflection;

namespace Test
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

           

            try
            {
                SecurityUser user = new SecurityUser();
                user.ReadConnection("Nour", "Nour");

                XpoDefault.DataLayer = XpoDefault.GetDataLayer(user.ConnectionString, DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
                SecurityUser.CurrentUser = user;
                SecurityUser.IsConnected = true;

                
                Session s = new Session();
                List<XPClassInfo> lst = new List<XPClassInfo>()
                {
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIMaster)),
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIParams)),
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIProfile)),
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIProfileLine))

                };
                //s.UpdateSchema();
                Assembly a = Assembly.GetAssembly(typeof(CoreLib.MyForm));
                s.UpdateSchema(a);
                myGridView1.UnitOfWorkXpo = unitOfWork1;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            unitOfWork1.ApplyLabels();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var frm = new CoreLib.Label.LabelEditorFrm("CoreLib;CoreModel");
            frm.ShowDialog();
        }

      
        private void comboBoxEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            string lang = comboBoxEdit1.EditValue.ToString();
            
            CoreLib.GlobalMethods.UILang =lang;
            //myGridView1.ApplyLabelToColumns();
        }
    }
}
