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
using CoreLib.Grid;
using DevExpress.Data.Filtering;

namespace CoreLib
{
    public partial class MyForm : DevExpress.XtraEditors.XtraForm
    {
        public MyForm()
        {
            InitializeComponent();
            InitGrids();
        }
        public MyForm(Args _args)
        {
            InitializeComponent();
            Args = _args;
            InitGrids();

            this.Activated += (s, e) => { SelectLookupRow(); };
        }

        private void InitGrids()
        {
           
        }


        #region Members


        public WorkspaceManager FormWorkspaceManager { get; set; }

        #endregion
        public XPCollection MainDataSource { get; set; }
        Args fArgs;
        public Args Args
        {
            get { return fArgs; }
            set { SetupArgs(value); }
        }
        void SelectLookupRow()
        {
            //Check if lookup value was passed then filter Master data source
            if (Args.LookupField.IsNotNull() &&
                Args.LookupValue.IsNotNull() &&
                MainDataSource != null)
            {
                string lookupFilter = $"[{fArgs.LookupField}] = {fArgs.LookupValue}";
                var objectLookedFor = unitOfWork1.FindObject(MainDataSource.ObjectClassInfo, CriteriaOperator.Parse(lookupFilter));
                if (objectLookedFor == null) return;
                int pos = MainDataSource.IndexOf(objectLookedFor);

                BindingManagerBase bindingManager = this.BindingContext[MainDataSource];
                bindingManager.Position = pos;

            }
        }
        private void SetupArgs(Args argsValue)
        {
            fArgs = argsValue;
            ////Check if lookup value was passed then filter Master data source
            //if( argsValue.LookupField.IsNotNull() && 
            //    argsValue.LookupValue.IsNotNull() &&
            //    MainDataSource != null               )
            //{
            //    string lookupFilter = $"[{fArgs.LookupField}] = {fArgs.LookupValue}";
            //    if (MainDataSource.CriteriaString.Trim().IsNotNull())
            //    {
            //        MainDataSource.CriteriaString = $"{MainDataSource.CriteriaString} AND {lookupFilter}";
            //    }
            //    else
            //    {
            //        MainDataSource.CriteriaString = lookupFilter;
            //    }
                    
            //} 
        }
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
            
            return RefreshDataWithAsk() != DialogResult.Cancel;
        }
        public virtual bool SaveChangesWithAsk(UnitOfWork unitOfWork)
        {
           
            if (HasChanges())
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
        public virtual void FillAllTables()
        {
           //Should override in desctents with logic for requery 
         
        }
        public virtual bool HasChanges()
        {
            int modifiedRows = unitOfWork1.GetObjectsToSave().Count + unitOfWork1.GetObjectsToDelete().Count;
            SetStatusBarText($"Modified objects count : {modifiedRows}");
            return modifiedRows > 0 ;


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
                        SaveChangesWithAsk(unitOfWork1);
                        return r;


                }

            }

            return DialogResult.OK;

        }
        //public virtual void RefreshData()
        //{
        //    if (this.HasChanges())
        //    {
        //        DialogResult r = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNoCancel);
        //        switch (r)
        //        {

        //            case DialogResult.Cancel:
        //                break;

        //            case DialogResult.No:
        //                break;

        //            //Do no thing
        //            case DialogResult.Yes:
        //                SaveChangesWithAsk(unitOfWork1);
        //                break;


        //        }

        //    }


        //}




        #endregion

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PreClosingOperations())
            {
                //if (MessageBox.Show("The information entered does not pass validation and must be corrected before changes can be saved.\n \n Close without saving changes?", "Error saving changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //    e.Cancel = false;
                //    return;
                //}
                //else
                //{
                //    e.Cancel = true;
                //    return;
                //}
                e.Cancel = true;

            }
        }
        //Should be ovride 
        public virtual void Retrieve()
        {
            RefreshDataWithAsk();
        }
    }
}