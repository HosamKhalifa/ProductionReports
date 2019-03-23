using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace CoreLib.Grid.AppService
{
    public partial class ChartConfigurationBarXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public ChartConfigurationBarXUC()
        {
            InitializeComponent();

        }
        #region Members
        
        DevExpress.XtraPivotGrid.PivotGridControl   pivotGridCntrol;
        DevExpress.XtraCharts.ChartControl          chartCntrol;

        #endregion
        
        #region Properties
        
        public DevExpress.XtraPivotGrid.PivotGridControl PivotGridCntrol 
        {
            set { pivotGridCntrol = value; }
            get { return pivotGridCntrol;  }
        }
        
        public DevExpress.XtraCharts.ChartControl ChartCntrol 
        {
            set { chartCntrol = value; }
            get { return chartCntrol;  }
        }

        #endregion
        
        #region Methods
        
        public void InitPanel(DevExpress.XtraPivotGrid.PivotGridControl pivotGridCntrol, DevExpress.XtraCharts.ChartControl chartCntrol) 
        {
            this.pivotGridCntrol    = pivotGridCntrol;
            this.chartCntrol        = chartCntrol;

            #region ChartInitialization
            pivotGridCntrol.OptionsChartDataSource.ProvideDataByColumns         = ceChartDataVertical.Checked;
            pivotGridCntrol.OptionsChartDataSource.SelectionOnly                = ceSelectionOnly.Checked;
            pivotGridCntrol.OptionsChartDataSource.ProvideColumnGrandTotals     = ceShowColumnGrandTotals.Checked;
            pivotGridCntrol.OptionsChartDataSource.ProvideRowGrandTotals        = ceShowRowGrandTotals.Checked;
            ChartCntrol.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;//                            = this.checkShowPointLabels.Checked;
            
            ViewType[] restrictedTypes = new ViewType[] { ViewType.PolarArea, ViewType.PolarLine, ViewType.SideBySideGantt,
				ViewType.SideBySideRangeBar, ViewType.RangeBar, ViewType.Gantt, ViewType.PolarPoint, ViewType.Stock, ViewType.CandleStick,
				ViewType.Bubble };
            

            foreach (ViewType type in Enum.GetValues(typeof(ViewType)))
            {
                if (Array.IndexOf<ViewType>(restrictedTypes, type) >= 0) continue;
                comboChartType.Properties.Items.Add(type);
            }
            comboChartType.SelectedItem = ViewType.Pie;
            #endregion

            #region BuildColorsComboBox
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Apex"                 , "Color set #01");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Black and White"      , "Color set #02");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Chameleon"            , "Color set #03");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Civic"                , "Color set #04");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Concourse"            , "Color set #05");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Equity"               , "Color set #05");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Flow"                 , "Color set #06");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Foundry"              , "Color set #07");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Grayscale"            , "Color set #08");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("In A Fog"             , "Color set #09");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Median"               , "Color set #10");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Metro"                , "Color set #11");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Mixed"                , "Color set #12");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Module"               , "Color set #13");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Nature Colors"        , "Color set #14");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Northern Lights"      , "Color set #15");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Office"               , "Color set #16");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Opulent"              , "Color set #17");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Oriel"                , "Color set #18");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Origin"               , "Color set #19");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Paper"                , "Color set #20");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Pastel Kit"           , "Color set #21");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Solstice"             , "Color set #22");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Technic"              , "Color set #23");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Terracotta Pie"       , "Color set #24");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("The Trees"            , "Color set #25");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Trek"                 , "Color set #26");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Urban"                , "Color set #27");
            appServicesDataSet.ChartPaletteDataTable.AddChartPaletteDataTableRow("Verve"                , "Color set #28");
            chartPaletteDataTableBindingSource.EndEdit();
            #endregion


        }

        #endregion
        
        #region EventHandlers

        void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartCntrol.SeriesTemplate.ChangeView((ViewType)comboChartType.SelectedItem);
            if (ChartCntrol.SeriesTemplate.Label != null)
            {
                ChartCntrol.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;// = checkShowPointLabels.Checked;
                checkShowPointLabels.Enabled = true;
            }
            else
            {
                checkShowPointLabels.Enabled = false;
            }
            if ((ChartCntrol.SeriesTemplate.View as SimpleDiagramSeriesViewBase) == null)
                ChartCntrol.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            if (ChartCntrol.Diagram is Diagram3D)
            {
                Diagram3D diagram = (Diagram3D)ChartCntrol.Diagram;
                diagram.RuntimeRotation = true;
                diagram.RuntimeZooming = true;
                diagram.RuntimeScrolling = true;
            }
            foreach (Series series in ChartCntrol.Series)
            {
                ISupportTransparency supportTransparency = series.View as ISupportTransparency;
                if (supportTransparency != null)
                {
                    if ((series.View is AreaSeriesView) || (series.View is Area3DSeriesView)
                        || (series.View is RadarAreaSeriesView) || (series.View is Bar3DSeriesView))
                        supportTransparency.Transparency = 135;
                    else
                        supportTransparency.Transparency = 0;
                }
            }
        }

        void checkShowPointLabels_CheckedChanged(object sender, EventArgs e)
        {

            ChartCntrol.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;// = checkShowPointLabels.Checked;
            
        }

        void ceChartDataVertical_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridCntrol.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked;
        }

        void ceSelectionOnly_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridCntrol.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked;
            lblUpdateDelay.Enabled = seUpdateDelay.Enabled = ceSelectionOnly.Checked;
        }

        void ceShowColumnGrandTotals_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridCntrol.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked;
        }

        void ceShowRowGrandTotals_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridCntrol.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked;
        }

        void seUpdateDelay_EditValueChanged(object sender, EventArgs e)
        {
            pivotGridCntrol.OptionsChartDataSource.UpdateDelay = (int)seUpdateDelay.Value;
        }

        private void colorLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            chartCntrol.PaletteName =  colorLookUpEdit.EditValue.ToString();

        }

        #endregion


    }
}
