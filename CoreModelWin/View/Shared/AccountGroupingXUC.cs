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
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace CoreModelWin.View.Shared
{
    public partial class AccountGroupingXUC :MyEditor.SalesCanvasXUC
    {
        public AccountGroupingXUC()
        {
            InitializeComponent();
        }
        CoreModel.MyEnums.AccountType currentActivatedAccType;
        private XPLiteObject fSelectedRow;
        public XPLiteObject SelectedRow
        {
            get { return fSelectedRow; }
        }
        public void InitObj(UnitOfWork _uOw )
        {
            unitOfWork1 = _uOw;
            accountTypeImageCombo.Properties.AddEnum(typeof(CoreModel.MyEnums.AccountType));
            accountTypeImageCombo.EditValueChanged += (s, e) => 
            {
                currentActivatedAccType = (CoreModel.MyEnums.AccountType)accountTypeImageCombo.EditValue;
                ActivateAccountType(currentActivatedAccType);
            };
            //Group

            grpXPC.Session  = _uOw;
            ref1XPC.Session = _uOw;
            ref2XPC.Session = _uOw;

            grpBS.PositionChanged += BS_PositionChanged;
            ref1BS.PositionChanged += BS_PositionChanged;
            ref2BS.PositionChanged += BS_PositionChanged;

            grpXPC.CollectionChanged += XPC_CollectionChanged;
            ref1XPC.CollectionChanged += XPC_CollectionChanged;
            ref2XPC.CollectionChanged += XPC_CollectionChanged;

            grpDataNavigator.ButtonClick += (s, e) => 
            {
                if (e.Button.ButtonType == NavigatorButtonType.Append)
                {
                    if(grpTreeList.Nodes.Count> 0)
                    {
                        var curr = grpTreeList.FocusedNode.GetValue(colLineId);
                        if(curr != null)
                        {
                            var parnetAccountGrp = _uOw.GetObjectByKey<CoreModel.AccountGroup>(curr);
                            grpXPC.Add(new CoreModel.AccountGroup(_uOw) { ParentLine = parnetAccountGrp });
                            e.Handled = true;
                        }
                    }
                }
            };
            ref1DataNavigator.ButtonClick += (s, e) => 
            {
                if (e.Button.ButtonType == NavigatorButtonType.Append)
                {
                    if (ref1TreeList.Nodes.Count > 0)
                    {
                        var curr = ref1TreeList.FocusedNode.GetValue(colLineId_ref1);
                        if (curr != null)
                        {
                            var parnetAccountGrp = _uOw.GetObjectByKey<CoreModel.AccountRef1>(curr);
                            ref1XPC.Add(new CoreModel.AccountRef1(_uOw) { ParentLine = parnetAccountGrp });
                            e.Handled = true;
                        }
                    }
                }
            };
            ref2DataNavigator.ButtonClick += (s, e) =>
            {
                if (e.Button.ButtonType == NavigatorButtonType.Append)
                {
                    if (ref2TreeList.Nodes.Count > 0)
                    {
                        var curr = ref2TreeList.FocusedNode.GetValue(colLineId_ref2);
                        if (curr != null)
                        {
                            var parnetAccountGrp = _uOw.GetObjectByKey<CoreModel.AccountRef2>(curr);
                            ref2XPC.Add(new CoreModel.AccountRef2(_uOw) { ParentLine = parnetAccountGrp });
                            e.Handled = true;
                        }
                    }
                }
            };


        }

        private void XPC_CollectionChanged(object sender, XPCollectionChangedEventArgs e)
        {
            if (e.ChangedObject is CoreModel.AccountGroup)
                ((CoreModel.AccountGroup)e.ChangedObject).AccountType = currentActivatedAccType;
            else if (e.ChangedObject is CoreModel.AccountRef1)
                ((CoreModel.AccountRef1)e.ChangedObject).AccountType = currentActivatedAccType;
            else if (e.ChangedObject is CoreModel.AccountRef2)
                ((CoreModel.AccountRef2)e.ChangedObject).AccountType = currentActivatedAccType;

        }

        private void BS_PositionChanged(object sender, EventArgs e)
        {
            var s = (BindingSource)sender;
            s.EndEdit();
            unitOfWork1.CommitChanges();
        }

        public void ActivateAccountType(CoreModel.MyEnums.AccountType _type)
        {
            var op = new BinaryOperator(new OperandProperty("AccountType"), new OperandValue(_type), BinaryOperatorType.Equal);
            grpXPC.Criteria = op;
            grpXPC.LoadingEnabled = true;

            ref1XPC.Criteria = op;
            ref1XPC.LoadingEnabled = true;

            ref2XPC.Criteria = op;
            ref2XPC.LoadingEnabled = true;



        }

        public void LookUp(Type _target,CoreModel.MyEnums.AccountType currAccType)
        {
            //Hide editor controls
            grpDataNavigator.Visible = false;
            ref1DataNavigator.Visible = false;
            ref2DataNavigator.Visible = false;
            grpTreeList.OptionsBehavior.Editable = false;
            ref1TreeList.OptionsBehavior.Editable = false;
            ref2TreeList.OptionsBehavior.Editable = false;

            accountTypeImageCombo.EditValue = currAccType;
            accountTypeImageCombo.Enabled = false;

            if (_target == typeof(CoreModel.AccountGroup))
            {
                //Hide others
                ref1TPage.PageVisible = false;
                ref2TPage.PageVisible = false;
                grpTreeList.Dock = DockStyle.Fill;
                grpTreeList.DoubleClick += TreeList_Click;
            }
            if (_target == typeof(CoreModel.AccountRef1))
            {
                //Hide others
                grpTPage.PageVisible = false;
                ref2TPage.PageVisible = false;
                ref1TreeList.Dock = DockStyle.Fill;
                ref1TreeList.DoubleClick += TreeList_Click;
            }
            if (_target == typeof(CoreModel.AccountRef2))
            {
                //Hide others
                grpTPage.PageVisible = false;
                ref1TPage.PageVisible = false;
                ref2TreeList.Dock = DockStyle.Fill;
                ref2TreeList.DoubleClick += TreeList_Click;
            }


        }
        
        private void TreeList_Click(object sender, EventArgs e)
        {
            
            var list = (DevExpress.XtraTreeList.TreeList)sender;
            if(list.FocusedNode != null)
            {
                var currRec = (CoreModel.Line)list.GetDataRecordByNode(list.FocusedNode);
                fSelectedRow = currRec;

                var popUpEditor = (PopupContainerControl)this.Parent;
                popUpEditor.OwnerEdit.EditValue = currRec.LineId;
                //popUpEditor.QueryDisplayText += (s, e) => { e.DisplayText = currR; };
                popUpEditor.OwnerEdit.ClosePopup();
            }
        }
    }
}
