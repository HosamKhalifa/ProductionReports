using CoreModel;
using CoreModelWin.AppLists;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Sales
{
    public partial class AccountBaseLineXUC : CoreModelWin.MyEditor.SalesCanvasXUC
    {
        public AccountBaseLineXUC()
        {

            InitializeComponent();
        }
        #region
        public void InitObj(UnitOfWork _uOW, CoreModel.MyEnums.AccountType _actType)
        {
            //AppListInfo l = new AppListInfo(_uOW);
            //l.LinkToDataLayout(dataLayoutControl1, accountBaseXPC);
            InitGroupLookup(_uOW,_actType);
            detailsLayoutGroup.CustomButtonClick += (s, e) => 
            {
                if(e.Button.Properties.Tag.ToString() == "New")
                {
                    accountAddressesBS.AddNew();
                } 
            };
        }
        public void InitGroupLookup(UnitOfWork _uOW, CoreModel.MyEnums.AccountType _actType)
        {
            unitOfWork1 = _uOW;
            GroupIdLookUpEdit.Properties.PopupControl = new DevExpress.XtraEditors.PopupContainerControl();
            var grpXUC = new View.Shared.AccountGroupingXUC();
            grpXUC.InitObj(_uOW);
            grpXUC.ActivateAccountType(_actType);
            grpXUC.Dock = DockStyle.Fill;
            GroupIdLookUpEdit.Properties.PopupControl.Controls.Add(grpXUC);
            GroupIdLookUpEdit.Properties.PopupControl.Size = new Size(702, 310);
            grpXUC.LookUp(typeof(CoreModel.AccountGroup), CoreModel.MyEnums.AccountType.Customer);
            GroupIdLookUpEdit.Properties.ShowPopupCloseButton = true;
            GroupIdLookUpEdit.CloseUp += (s, e) =>
            {
                if (grpXUC.SelectedRow != null)
                {
                    e.Value = ((CoreModel.Line)grpXUC.SelectedRow).LineId;
                }
                else
                {
                    e.Value = null;
                }
            };
            GroupNameTextEdit.DoubleClick += (s, e) => { MessageBox.Show(GroupNameTextEdit.Text); };
        }
        #endregion
        public BindingSource AccountBaseBS
        {
            get { return accountBaseBS; }
            set
            {
                accountBaseBS = value;
                dataLayoutControl1.DataSource = accountBaseBS;
                
                
            }
        }

        

    }
}
