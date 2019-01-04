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
    public partial class PivotJournalXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public PivotJournalXUC()
        {
            InitializeComponent();
        }

        private void retrieveBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime fromDate, toDate;
            fromDate = (DateTime)fromBI.EditValue;
            toDate = (DateTime)toBI.EditValue;
            //unitOfWork1.ConnectionString = ProductionReports.ModelXpo.OmarERP.ConnectionHelper.ConnectionString;
            string filter = $"[TransDate] Between(#{fromDate.Date}#, #{toDate.Date}#)";

            xpCollection1.CriteriaString = filter;

            xpCollection1.LoadingEnabled = true;


            pivotGridControl1.RefreshData();
        }
    }
}
