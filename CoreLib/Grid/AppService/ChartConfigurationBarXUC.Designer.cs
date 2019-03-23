namespace CoreLib.Grid.AppService
{
    partial class ChartConfigurationBarXUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.colorLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.chartPaletteDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appServicesDataSet = new AppServicesDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seUpdateDelay = new DevExpress.XtraEditors.SpinEdit();
            this.lblUpdateDelay = new DevExpress.XtraEditors.LabelControl();
            this.ceShowRowGrandTotals = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowColumnGrandTotals = new DevExpress.XtraEditors.CheckEdit();
            this.ceSelectionOnly = new DevExpress.XtraEditors.CheckEdit();
            this.ceChartDataVertical = new DevExpress.XtraEditors.CheckEdit();
            this.checkShowPointLabels = new DevExpress.XtraEditors.CheckEdit();
            this.comboChartType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaletteDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appServicesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seUpdateDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowRowGrandTotals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumnGrandTotals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectionOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChartDataVertical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.colorLookUpEdit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.seUpdateDelay);
            this.panelControl1.Controls.Add(this.lblUpdateDelay);
            this.panelControl1.Controls.Add(this.ceShowRowGrandTotals);
            this.panelControl1.Controls.Add(this.ceShowColumnGrandTotals);
            this.panelControl1.Controls.Add(this.ceSelectionOnly);
            this.panelControl1.Controls.Add(this.ceChartDataVertical);
            this.panelControl1.Controls.Add(this.checkShowPointLabels);
            this.panelControl1.Controls.Add(this.comboChartType);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(805, 66);
            this.panelControl1.TabIndex = 11;
            // 
            // colorLookUpEdit
            // 
            this.colorLookUpEdit.Location = new System.Drawing.Point(663, 12);
            this.colorLookUpEdit.Name = "colorLookUpEdit";
            this.colorLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaletteDisplayName", "Palette Display Name", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.colorLookUpEdit.Properties.DataSource = this.chartPaletteDataTableBindingSource;
            this.colorLookUpEdit.Properties.DisplayMember = "PaletteDisplayName";
            this.colorLookUpEdit.Properties.ValueMember = "PaletteName";
            this.colorLookUpEdit.Size = new System.Drawing.Size(132, 20);
            this.colorLookUpEdit.TabIndex = 16;
            this.colorLookUpEdit.EditValueChanged += new System.EventHandler(this.colorLookUpEdit_EditValueChanged);
            // 
            // chartPaletteDataTableBindingSource
            // 
            this.chartPaletteDataTableBindingSource.DataMember = "ChartPaletteDataTable";
            this.chartPaletteDataTableBindingSource.DataSource = this.appServicesDataSet;
            // 
            // appServicesDataSet
            // 
            this.appServicesDataSet.DataSetName = "AppServicesDataSet";
            this.appServicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(582, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Color palette";
            // 
            // seUpdateDelay
            // 
            this.seUpdateDelay.EditValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.seUpdateDelay.Location = new System.Drawing.Point(184, 37);
            this.seUpdateDelay.Name = "seUpdateDelay";
            this.seUpdateDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seUpdateDelay.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seUpdateDelay.Properties.IsFloatValue = false;
            this.seUpdateDelay.Properties.Mask.EditMask = "N00";
            this.seUpdateDelay.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.seUpdateDelay.Size = new System.Drawing.Size(48, 20);
            this.seUpdateDelay.TabIndex = 10;
            this.seUpdateDelay.ToolTip = "Sets the Chart update delay when PivotGrid selection changes.";
            this.seUpdateDelay.EditValueChanged += new System.EventHandler(this.seUpdateDelay_EditValueChanged);
            // 
            // lblUpdateDelay
            // 
            this.lblUpdateDelay.Location = new System.Drawing.Point(107, 40);
            this.lblUpdateDelay.Name = "lblUpdateDelay";
            this.lblUpdateDelay.Size = new System.Drawing.Size(69, 13);
            this.lblUpdateDelay.TabIndex = 13;
            this.lblUpdateDelay.Text = "Update Delay:";
            // 
            // ceShowRowGrandTotals
            // 
            this.ceShowRowGrandTotals.Location = new System.Drawing.Point(412, 10);
            this.ceShowRowGrandTotals.Name = "ceShowRowGrandTotals";
            this.ceShowRowGrandTotals.Properties.AutoWidth = true;
            this.ceShowRowGrandTotals.Properties.Caption = "Show Row Grand Totals";
            this.ceShowRowGrandTotals.Size = new System.Drawing.Size(137, 19);
            this.ceShowRowGrandTotals.TabIndex = 7;
            this.ceShowRowGrandTotals.ToolTip = "Toggles whether row grand total values are shown in the Chart control";
            this.ceShowRowGrandTotals.CheckedChanged += new System.EventHandler(this.ceShowRowGrandTotals_CheckedChanged);
            // 
            // ceShowColumnGrandTotals
            // 
            this.ceShowColumnGrandTotals.Location = new System.Drawing.Point(412, 37);
            this.ceShowColumnGrandTotals.Name = "ceShowColumnGrandTotals";
            this.ceShowColumnGrandTotals.Properties.AutoWidth = true;
            this.ceShowColumnGrandTotals.Properties.Caption = "Show Column Grand Totals";
            this.ceShowColumnGrandTotals.Size = new System.Drawing.Size(151, 19);
            this.ceShowColumnGrandTotals.TabIndex = 13;
            this.ceShowColumnGrandTotals.ToolTip = "Toggles whether column grand total values are shown in the Chart control";
            this.ceShowColumnGrandTotals.CheckedChanged += new System.EventHandler(this.ceShowColumnGrandTotals_CheckedChanged);
            // 
            // ceSelectionOnly
            // 
            this.ceSelectionOnly.EditValue = true;
            this.ceSelectionOnly.Location = new System.Drawing.Point(10, 37);
            this.ceSelectionOnly.Name = "ceSelectionOnly";
            this.ceSelectionOnly.Properties.AutoWidth = true;
            this.ceSelectionOnly.Properties.Caption = "Selection Only";
            this.ceSelectionOnly.Size = new System.Drawing.Size(91, 19);
            this.ceSelectionOnly.TabIndex = 9;
            this.ceSelectionOnly.ToolTip = "Toggles whether all PivotGrid cells or selected cells only should be represented " +
    "in the Chart";
            this.ceSelectionOnly.CheckedChanged += new System.EventHandler(this.ceSelectionOnly_CheckedChanged);
            this.ceSelectionOnly.CursorChanged += new System.EventHandler(this.ceSelectionOnly_CheckedChanged);
            // 
            // ceChartDataVertical
            // 
            this.ceChartDataVertical.Location = new System.Drawing.Point(238, 37);
            this.ceChartDataVertical.Name = "ceChartDataVertical";
            this.ceChartDataVertical.Properties.AutoWidth = true;
            this.ceChartDataVertical.Properties.Caption = "Generate Series from Columns";
            this.ceChartDataVertical.Size = new System.Drawing.Size(168, 19);
            this.ceChartDataVertical.TabIndex = 12;
            this.ceChartDataVertical.ToolTip = "Toggles whether series in a chart control are created based on PivotGrid columns " +
    "or rows";
            this.ceChartDataVertical.CheckedChanged += new System.EventHandler(this.ceChartDataVertical_CheckedChanged);
            // 
            // checkShowPointLabels
            // 
            this.checkShowPointLabels.Location = new System.Drawing.Point(238, 10);
            this.checkShowPointLabels.Name = "checkShowPointLabels";
            this.checkShowPointLabels.Properties.AutoWidth = true;
            this.checkShowPointLabels.Properties.Caption = "Show Point Labels";
            this.checkShowPointLabels.Size = new System.Drawing.Size(109, 19);
            this.checkShowPointLabels.TabIndex = 4;
            this.checkShowPointLabels.ToolTip = "Toggles whether value labels are shown in the Chart control";
            this.checkShowPointLabels.CheckedChanged += new System.EventHandler(this.checkShowPointLabels_CheckedChanged);
            // 
            // comboChartType
            // 
            this.comboChartType.EditValue = "Pie";
            this.comboChartType.Location = new System.Drawing.Point(78, 10);
            this.comboChartType.Name = "comboChartType";
            this.comboChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboChartType.Size = new System.Drawing.Size(154, 20);
            this.comboChartType.TabIndex = 3;
            this.comboChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit2_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Chart Type:";
            // 
            // ChartConfigurationBarXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ChartConfigurationBarXUC";
            this.Size = new System.Drawing.Size(805, 66);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaletteDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appServicesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seUpdateDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowRowGrandTotals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumnGrandTotals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectionOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChartDataVertical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit seUpdateDelay;
        private DevExpress.XtraEditors.LabelControl lblUpdateDelay;
        private DevExpress.XtraEditors.CheckEdit ceShowRowGrandTotals;
        private DevExpress.XtraEditors.CheckEdit ceShowColumnGrandTotals;
        private DevExpress.XtraEditors.CheckEdit ceSelectionOnly;
        private DevExpress.XtraEditors.CheckEdit ceChartDataVertical;
        private DevExpress.XtraEditors.CheckEdit checkShowPointLabels;
        private DevExpress.XtraEditors.ComboBoxEdit comboChartType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit colorLookUpEdit;
        private System.Windows.Forms.BindingSource chartPaletteDataTableBindingSource;
        private AppServicesDataSet appServicesDataSet;
    }
}
