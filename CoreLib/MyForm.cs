using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using CoreLib.SharedExt;
using CoreLib.Xpo;
using DevExpress.Utils;

namespace CoreLib
{
    public partial class MyForm : DevExpress.XtraEditors.XtraForm
    {
        public MyForm()
        {
            InitializeComponent();
            formUnitOfWork = new UnitOfWork();
            
            
        }

       
        #region Members
        UnitOfWork formUnitOfWork;
       
        public WorkspaceManager FormWorkspaceManager { get; set; }

        #endregion
        #region Properties
        public virtual void SetStatusBarText(string txt="OK")
        {

            
        }
        #endregion
        #region Methods
        
        #endregion
        #region Events
        public virtual bool PreClosingOperations()
        {
           
            return true;
        }
        protected virtual bool SaveChangesWithAsk(UnitOfWork unitOfWork)
        {
            var saveXP = unitOfWork.GetObjectsToSave();
            var delXP = unitOfWork.GetObjectsToDelete();
                        
            if (saveXP.Count > 0 || delXP.Count > 0)
            {
               
                    try
                    {
                    unitOfWork.CommitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.GetFullExceptionErrMessage());
                        return false;
                    }

                
                return true;


            }
            return true;

        }
        protected virtual void FillAllTables()
        {
           //Should override in desctents with logic for requery 
         
        }
        public virtual bool HasChanges()
        {


            return formUnitOfWork.TrackingChanges;


        }
      
        public virtual DialogResult RefreshDataWithAsk()
        {
            if (this.HasChanges())
            {
                DialogResult r = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNoCancel);
                switch (r)
                {

                    case DialogResult.Cancel:
                        return r;


                    case DialogResult.No:
                        return r;

                    //Do no thing
                    case DialogResult.Yes:
                        SaveChangesWithAsk(formUnitOfWork);
                        return r;


                }

            }

            return DialogResult.OK;

        }
        protected virtual void RefreshData()
        {
            if (this.HasChanges())
            {
                DialogResult r = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNoCancel);
                switch (r)
                {

                    case DialogResult.Cancel:
                        break;

                    case DialogResult.No:
                        break;

                    //Do no thing
                    case DialogResult.Yes:
                        SaveChangesWithAsk(formUnitOfWork);
                        break;


                }

            }


        }



        #endregion

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PreClosingOperations())
            {
                if (MessageBox.Show("The information entered does not pass validation and must be corrected before changes can be saved.\n \n Close without saving changes?", "Error saving changes", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }

            }
        }
    }
}