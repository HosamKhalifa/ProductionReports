using DevExpress.XtraEditors;
using System;
using System.Configuration;
using ProductionReports.SharedExt;
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
            try
            {
                DateTime fromDate, toDate;

                fromDate = (DateTime)fromBI.EditValue;
                toDate = (DateTime)toBI.EditValue;
                pRD_TransJournalLinesViewTableAdapter.Connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["SQLCA"].ConnectionString);
                pRD_TransJournalLinesViewTableAdapter.Fill(rptDS.PRD_TransJournalLinesView, fromDate.Date, toDate.Date);

                pivotGridControl1.RefreshData();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }
    }
}
