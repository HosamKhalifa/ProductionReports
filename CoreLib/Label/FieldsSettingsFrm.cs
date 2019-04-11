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
        public FieldsSettingsFrm()
        {
            InitializeComponent();
            InitObj();
            InitTree();
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
                xpCollectionExt2.CriteriaString =filter;
                filter = $"[LeftObjectName!Key] = {objName.Oid} OR [RightObjectName!Key] = {objName.Oid}";
                objectRelationHeaderXPC.CriteriaString = filter;
            };
            myGridView2.FocusedRowChanged += (s, e) => 
            {
                if (e.FocusedRowHandle < 0) return;
                var label = (UILabel)myGridView2.GetRow(e.FocusedRowHandle);
                string filter = $"[UILabel!Key] = '{label.LabelId}'";
                xpCollectionExt3.CriteriaString = filter;
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
                    xpCollectionExt2.CriteriaString = filter;
                    filter = $"[LeftObjectName!Key] = {objId} OR [RightObjectName!Key] = {objId}";
                    objectRelationHeaderXPC.CriteriaString = filter;
                }
                else if(objType.ToString() == "Field")
                {
                    string filter = $"[LabelId] = '{objId}' ";
                    xpCollectionExt2.CriteriaString = filter;
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
            foreach (UIObjectBase table in xpCollectionExt1)
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
