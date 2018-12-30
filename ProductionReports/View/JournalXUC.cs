using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProductionReports.View
{
    public partial class JournalXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public JournalXUC()
        {
            InitializeComponent();
            InitObj();
        }

        private void InitObj()
        {
            fromBI.EditValue = DateTime.Today.Date;
            toBI.EditValue = DateTime.Today.Date;
            unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            unitOfWork1.ConnectionString = ProductionReports.ModelXpo.OmarERP.ConnectionHelper.ConnectionString;
            unitOfWork1.Connect();
        }
        public void Save()
        {
            unitOfWork1.CommitChanges();
        }
        private void retrieveBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //unitOfWork1.ConnectionString = ProductionReports.ModelXpo.OmarERP.ConnectionHelper.ConnectionString;
            string filter = $"[TransDate] Between(#{DateTime.Today.Date}#, #{DateTime.Today.Date}#)";
            journalXPC.CriteriaString = filter;
            journalXPC.Load();
        }
    }
}
