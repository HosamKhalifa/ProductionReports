using CoreLib.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.MyEditor
{
    public partial class SimpleForm : CoreLib.MyForm
    {
        public SimpleForm()
        {
            InitializeComponent();
        }
        public SimpleForm(XtraUserControl _usrCtrl)
        {
            InitializeComponent();
            this.Controls.Add(_usrCtrl);
            _usrCtrl.Dock = DockStyle.Fill;
            this.ActiveControl = _usrCtrl;
        }
        public SimpleForm (Type _classType)
        {
            InitializeComponent();
            
            XPCollectionExt ds = new XPCollectionExt(unitOfWork1, _classType);
            myGridControl1.DataSource = ds;
            myGridControl1.RefreshDataSource();
            AppLists.AppListInfo lst = new AppLists.AppListInfo(unitOfWork1);
            lst.LinkLookupsToGrid(myGridView1,ds);


        }
    }
}
