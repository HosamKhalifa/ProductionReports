using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CoreLib.Label
{
    public partial class FieldsSettingsFrm : CoreLib.MyForm
    {
        public TreeList ObjectTree { get { return treeList1; } }
        public DevExpress.Xpo.XPCollection UIObjectBaseXPC { get { return uIObjectBaseXPC; } }
        public FieldsSettingsFrm()
        {
            InitializeComponent();
            InitObj();
            InitTree();
            InitLookup();
            InitToolBar();
            
        }

        private void InitToolBar()
        {
            defaultEnglishColumnBI.ItemClick += (s, e) =>
            {
                BindingManagerBase bindingMgr = this.BindingContext[uIObjectBaseXPC];
                var currTab = (UIObjectBase)bindingMgr.Current;
                foreach (var col in currTab.ObjectLabels)
                {
                    foreach (var lang in col.Langs)
                    {
                        lang.Lang_en = col.ColumnName;
                        lang.Lang_ar = col.ColumnName;
                        lang.Lang_fr = col.ColumnName;
                        lang.Save();
                    }

                } 
            };
        }

        private void InitLookup()
        {
            RepositoryItemComboBox cmb = new RepositoryItemComboBox();
            PopulateObjectCombo(cmb);

            colParentObjectName.ColumnEdit = cmb;
            colChildObjectName.ColumnEdit = cmb;
            //PopulateObjectCombo(_comRI);
        }

        private void PopulateObjectCombo(RepositoryItemComboBox _comRI)
        {
            _comRI.Items.Clear();
            foreach (UIObjectBase item in uIObjectBaseXPC)
            {
                _comRI.Items.Add(item.ObjectName);
            }
        }

        private void InitObj()
        {

            myGridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Default;
            myGridView1.OptionsView.ColumnAutoWidth = true;
            myGridView1.FocusedRowChanged += (s, e) => 
            {
                if (e.FocusedRowHandle < 0) return;
                var objName = (UIObjectBase)myGridView1.GetRow(e.FocusedRowHandle);
                string filter = $"[ObjectName!Key] = {objName.Oid} ";
               
                uILabelXPC.CriteriaString =filter;
                filter = $"[ParentObjectName] = '{objName.ObjectName }' OR [ChildObjectName] = '{objName.ObjectName}'";
                objectRelationHeaderXPC.CriteriaString = filter;
            };
            myGridView2.FocusedRowChanged += (s, e) => 
            {
                if (e.FocusedRowHandle < 0) return;
                var label = (UILabel)myGridView2.GetRow(e.FocusedRowHandle);
                string filter = $"[UILabel!Key] = '{label.LabelId}'";
                uILabelLanXPC.CriteriaString = filter;
            };
            treeList1.FocusedNodeChanged += (s,e)=>
            {
                if (e.Node == null) return;
                var objType = e.Node["ObjectType"]??"";
                var objId = e.Node["Id"]??"";
                var objName = e.Node["Name"]??"";

                if (objType.ToString() == "Table")
                {
                    //Filter using Object name
                    string filter = $"[ObjectName!Key] = {objId} ";
                    var currentObj =(UIObjectBase) uIObjectBaseXPC.Lookup(objId);
                    uILabelXPC.CriteriaString = filter;
                    filter = $"[ParentObjectName] = '{currentObj.ObjectName}' OR [ChildObjectName] = '{currentObj.ObjectName}'";
                    objectRelationHeaderXPC.CriteriaString = filter;
                }
                else if(objType.ToString() == "Field")
                {
                    string filter = $"[LabelId] = '{objId}' ";
                    uILabelXPC.CriteriaString = filter;
                }
            };
           

        }

        private void InitTree()
        {
            // Create three columns. 
            treeList1.BeginUpdate();
            TreeListColumn colObjectId = treeList1.Columns.Add();
            colObjectId.Caption = "Id";
            colObjectId.Visible = false;

            TreeListColumn colObjectName = treeList1.Columns.Add();
            colObjectName.Caption = "Name";
            colObjectName.Visible = true;
            colObjectName.VisibleIndex = 0;
            Size columnSize = TextRenderer.MeasureText("".PadLeft(100, 'A'), colObjectName.AppearanceCell.Font);
            colObjectName.Width = columnSize.Width;

            TreeListColumn colObjectType = treeList1.Columns.Add();
            colObjectType.Caption = "ObjectType";
            colObjectId.Visible = false;

            treeList1.EndUpdate();
            // Create a root node . 
            TreeListNode parentForRootNodes = null;

            foreach (UIObjectBase table in uIObjectBaseXPC)
            {
                treeList1.BeginUnboundLoad();
                TreeListNode rootNode = treeList1.AppendNode(
                                                            new object[] {table.Oid, table.FriendlyName, "Table" },
                                                            parentForRootNodes);
                
                rootNode.ImageIndex = 0;
                // Create a child of the rootNode 
                foreach (UILabel field in table.ObjectLabels)
                {
                   var childNode =  treeList1.AppendNode(new object[] { field.LabelId,field.ColumnName,"Field" }, rootNode);
                    childNode.ImageIndex = 1;
                }
                 
                treeList1.EndUnboundLoad();
            }

           
        }

    }
}
