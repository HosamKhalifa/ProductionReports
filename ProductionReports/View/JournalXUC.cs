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
using DevExpress.XtraGrid.Views.Grid;
using ProductionReports.SharedExt;
using DevExpress.Xpo;
using ProductionReports.ModelXpo.OmarERP;
using DevExpress.Data.Filtering;

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
            journalXPC.CollectionChanged += JournalXPC_CollectionChanged;
        }

        private void RetrieveLines(int journalId)
        {
            TransJournal journal = unitOfWork1.FindObject<TransJournal>(CriteriaOperator.Parse($" JournalId = {journalId}"));
            journalLinesGV.InitNewRow += (s, e) =>
            {
                var gv = (s as GridView);
                ((TransJournalLine)gv.GetRow(e.RowHandle)).JournalId = journal;
            };
            journalLinesXPC.LoadingEnabled = false;
            CriteriaOperator filter = new OperandProperty("JournalId") == new OperandValue(journalId);
            journalLinesXPC.Criteria = filter;
            
            journalLinesXPC.LoadingEnabled = true;
            journalLinesXPC.Load();
        }

        private void JournalXPC_CollectionChanged(object sender, DevExpress.Xpo.XPCollectionChangedEventArgs e)
        {
           if(e.CollectionChangedType == DevExpress.Xpo.XPCollectionChangedType.AfterRemove)
            {
                (sender as XPCollection).Session.Delete(e.ChangedObject);
                unitOfWork1.CommitChanges();
            }
        }

        public void Save()
        {
            try
            {
                unitOfWork1.CommitChanges();

            }
            catch (Exception ex)
            {
                unitOfWork1.DropChanges();
                unitOfWork1.ReloadChangedObjects();
                journalXPC.Reload();
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
          
        }
        private void retrieveBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime fromDate, toDate;
            fromDate = (DateTime)fromBI.EditValue;
            toDate = (DateTime)toBI.EditValue;
            //unitOfWork1.ConnectionString = ProductionReports.ModelXpo.OmarERP.ConnectionHelper.ConnectionString;
            string filter = $"[TransDate] Between(#{fromDate.Date}#, #{toDate.Date}#)";
            journalXPC.CriteriaString = filter;
            journalXPC.LoadingEnabled = true;
          

            journalGV.RefreshData();
        }

        private void journalGV_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var gv = (GridView)sender;
            gv.ShowEditForm();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if(e.Page.Name == journalLinesPage2.Name)
            {
                var j = (TransJournal)journalGV.GetFocusedRow();
                if(j != null)
                {
                    RetrieveLines(j.JournalId);
                }
                
            }
        }

      

        private void GV_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            
            e.Valid = unitOfWork1.SaveLine();
        }
    }
}
