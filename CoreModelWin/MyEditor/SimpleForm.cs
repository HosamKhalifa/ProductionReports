using CoreLib.Xpo;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraBars;
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
        public SimpleForm (CoreLib.Args _args):base(_args)
        {
            InitializeComponent();
            if(_args == null || _args.ParmObject == null)//Parm object will represent Type instance 
            {
                SetStatusBarText("Type of object does not passed to Simple form ");
                return;
            }
            Type _classType = (Type)_args.ParmObject;
            XPCollection ds = new XPCollection(unitOfWork1, _classType);
            ds.LoadingEnabled = true;
            MainDataSource = ds;//Link main data source
            myGridControl1.DataSource = ds;
            //myGridControl1.RefreshDataSource();
            AppLists.AppListInfo lst = new AppLists.AppListInfo(unitOfWork1);
            lst.LinkLookupsToGrid(myGridView1,ds);


        }

        public CoreLib.Grid.MyGridView MainGridView { get { return myGridView1; }  }
        public Bar MainBar { get { return mainBar; }}

    }
}
