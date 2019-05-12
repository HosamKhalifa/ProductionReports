using CoreModel;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Shared
{
    public partial class AccountBaseXUC : CoreModelWin.MyEditor.SystemCanvasXUC
    {
        public AccountBaseXUC()
        {
            InitializeComponent();
            
        }


        #region Methods
        public void InitObj(UnitOfWork _uOW,TableBase.TableEnum _table)
        {
            unitOfWork1 = _uOW;
            AccountType = Account.TranslateTableEnumToActType(_table);


        }

        #endregion
        #region Properties
        public MyEnums.AccountType AccountType
        {
            get;set;
        }
        #endregion

    }
}
