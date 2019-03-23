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
using CoreLib.Grid;
using ProductionReports.ModelXpo.OmarERP;
using DevExpress.Xpo;

namespace ProductionReports.View.Task
{
    public partial class TaskMastersXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public TaskMastersXUC()
        {
            InitializeComponent();
        }

      
        public void InitObj()
        {
            unitOfWork1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            unitOfWork1.ConnectionString = ConnectionHelper.ConnectionString;
            unitOfWork1.Connect();


            taskCatGV.ValidateRow += (s, e) => 
            {

                try
                {
                    var cat = (ArticalCategory)e.Row;
                    cat.Save();
                    unitOfWork1.CommitChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    e.Valid = false;
                }
            };

            trackerGV.ValidateRow += (s, e) =>
            {

                try
                {
                    var line = (Tracker)e.Row;
                    line.Save();
                    unitOfWork1.CommitChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    e.Valid = false;
                }
            };

            projectGV.ValidateRow += (s, e) =>
            {

                try
                {
                    var line = (Project)e.Row;
                    line.Save();
                    unitOfWork1.CommitChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    e.Valid = false;
                }
            };

            categoryXPC.CollectionChanged += (s, e) =>
            {
                if (e.CollectionChangedType == DevExpress.Xpo.XPCollectionChangedType.AfterRemove)
                {
                    (s as XPCollection).Session.Delete(e.ChangedObject);
                    unitOfWork1.CommitChanges();
                }
            };
            trackerXPC.CollectionChanged += (s, e) =>
            {
                if (e.CollectionChangedType == DevExpress.Xpo.XPCollectionChangedType.AfterRemove)
                {
                    (s as XPCollection).Session.Delete(e.ChangedObject);
                    unitOfWork1.CommitChanges();
                   
                }
            };
            projectXPC.CollectionChanged += (s, e) =>
            {
                if (e.CollectionChangedType == DevExpress.Xpo.XPCollectionChangedType.AfterRemove)
                {
                    (s as XPCollection).Session.Delete(e.ChangedObject);
                    unitOfWork1.CommitChanges();
                }
            };

        }
    }
}
