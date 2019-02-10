using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProductionReports.SharedExt;
using System.Data.Entity;
using DevExpress.XtraEditors;
using ProductionReports.Models;
using ProductionReports.ModelXpo.OmarERP;
using DevExpress.XtraGrid.Views.Grid;

namespace ProductionReports
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        ProductionReports.Models.ProdContext dbContext;
        public Form1()
        {
            InitializeComponent();
            InitEF();
         
        }

        private void InitEF()
        {


            // Instantiate a new DBContext
            dbContext = new ProductionReports.Models.ProdContext();
            
            unitOfWork1.ConnectionString = ConnectionHelper.ConnectionString;
            
       




        }

        private void navigationPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
           
        }

        private void settingsNavPage_Enter(object sender, EventArgs e)
        {
            

        }

        private void retrieveBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }

        private void saveBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                unitOfWork1.CommitChanges();
                journalXUC1.Save();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
            
        }

        private void GV_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            (sender as GridView).ShowEditForm();
        }

        private void GV_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            e.Valid = unitOfWork1.SaveLine();
        }

        private void sIDBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var usr = System.Security.Principal.WindowsIdentity.GetCurrent().User;
            
            XtraMessageBox.Show(usr.Value);
        }
    }
}
