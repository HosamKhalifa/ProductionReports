using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CoreLib.Grid.AppService
{
    public partial class ExpressionColumnOptionsXtraForm : CoreLib.MyForm
    {
        
        public ExpressionColumnOptionsXtraForm(CoreLib.Grid.MyGridView grdView)
        {
            InitializeComponent();

            PopulateRadioGroup();
            gridView = grdView;
            gridType = CurrentGridType.GridView;
        }
        public ExpressionColumnOptionsXtraForm(DevExpress.XtraPivotGrid.PivotGridControl pvc)
        {
            InitializeComponent();

            PopulateRadioGroup();

            this.pvc = pvc;
            gridType = CurrentGridType.PivotGrid;

        }



        #region Members

        CoreLib.Grid.MyGridView gridView;
        DevExpress.XtraPivotGrid.PivotGridControl pvc;
        enum CurrentGridType { GridView,PivotGrid };
        CurrentGridType gridType;
        #endregion
            
        #region Properties
        #endregion
            
        #region Methods

        private void PopulateRadioGroup() 
        {
            DevExpress.Data.UnboundColumnType token;

            token = DevExpress.Data.UnboundColumnType.Decimal;
            radioGroup1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(token, "Numeric"));
            radioGroup1.EditValue = token;

            token = DevExpress.Data.UnboundColumnType.String;
            radioGroup1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(token, "Text"));

            token = DevExpress.Data.UnboundColumnType.DateTime;
            radioGroup1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(token, "DateTime"));

            token = DevExpress.Data.UnboundColumnType.Boolean;
            radioGroup1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(token, "Boolean"));


            
        }
            
            
        #endregion
            
        #region EventHandlers

        private void cancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okSimpleButton_Click(object sender, EventArgs e)
        {
            int columnCount;
            string fieldName="";
            DevExpress.Data.UnboundColumnType dataType;

            if (!dxValidationProvider1.Validate())
            {
                return;
            }

            try
            {
                dataType = (DevExpress.Data.UnboundColumnType)radioGroup1.EditValue;
                switch (gridType)
                {
                    case CurrentGridType.GridView:
                            
                            columnCount = gridView.Columns.Count;
                            fieldName = "ExpressionCol" + columnCount;
                            gridView.Columns.AddVisible(fieldName, captionTextEdit.Text);
                            gridView.Columns[fieldName].ShowUnboundExpressionMenu = true;
                            gridView.Columns[fieldName].UnboundType = dataType;
                            gridView.Columns[fieldName].OptionsColumn.AllowEdit = false;
                            gridView.ShowUnboundExpressionEditor(gridView.Columns[fieldName]);

                        break;
                    case CurrentGridType.PivotGrid:
                            columnCount = pvc.Fields.Count;
                            fieldName = "ExpressionCol" + columnCount;
                            DevExpress.XtraPivotGrid.PivotGridField expField = new DevExpress.XtraPivotGrid.PivotGridField(fieldName,DevExpress.XtraPivotGrid.PivotArea.FilterArea);
                            expField.Options.ShowUnboundExpressionMenu = true;
                            expField.UnboundType = dataType;
                            expField.Caption = captionTextEdit.Text;
                            pvc.Fields.Add(expField);
                            pvc.ShowUnboundExpressionEditor(pvc.Fields[fieldName]);
                            pvc.OptionsLayout.StoreAllOptions = true;
                            
                        break;
                    default:
                        break;
                }
               
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }


        }
            
            
            
        #endregion

    }
}
