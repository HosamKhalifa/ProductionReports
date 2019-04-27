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
        public void InitObj(UnitOfWork _uOW,XPCollection _header,XPCollection _address)
        {
            accountBaseXPC = _header;
            addressXPC.Session = _uOW;
            addressXPC = _address??addressXPC;

        }
        #endregion

    }
}
