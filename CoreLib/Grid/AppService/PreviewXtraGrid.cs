using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using System.Linq;
using CoreLib.Grid.UserProfile;
using DevExpress.Data.Filtering;
using CoreLib.SharedExt;

namespace CoreLib.Grid.AppService
{
    class PreviewXtraGrid
    {
        public PreviewXtraGrid(DevExpress.XtraGrid.GridControl gc)
        {
            if (gc.Tag is PreviewXtraGridInfo)
            {
                this.grdInfo = (PreviewXtraGridInfo)gc.Tag;
            }
            if (gc.Tag is XtraGridViewInfo)
            {
                this.grdInfo = ((XtraGridViewInfo)gc.Tag).PreviewGridInfo;
            }
            InitObj(gc);

            SetViewsOptions(gc);//To allow print filter info

            gcPrintableComponentLink.Component = gc;


        }

        public PreviewXtraGrid(DevExpress.XtraPivotGrid.PivotGridControl pvgc)
        {
            if (pvgc.Tag is PreviewXtraGridInfo)
            {
                this.grdInfo = (PreviewXtraGridInfo)pvgc.Tag;
            }
            if (pvgc.Tag is XtraGridViewInfo)
            {
                this.grdInfo = ((XtraGridViewInfo)pvgc.Tag).PreviewGridInfo;
            }
            InitObj(pvgc);
            SetViewsOptions(pvgc);
            gcPrintableComponentLink.Component = pvgc;
        }

        public PreviewXtraGrid(DevExpress.XtraCharts.ChartControl chart)
        {
            InitObj(chart);
            gcPrintableComponentLink.Component = chart;

        }

        public PreviewXtraGrid(DevExpress.XtraTreeList.TreeList treeLst)
        {
            InitObj(treeLst);
            gcPrintableComponentLink.Component = treeLst;

        }




        #region Members

        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink gcPrintableComponentLink;
       
        private PreviewXtraGridInfo grdInfo;

        #endregion

        #region Properties
        public DevExpress.XtraPrinting.PrintableComponentLink PrintableGridLink
        {
            set { this.gcPrintableComponentLink = value; }
            get { return this.gcPrintableComponentLink; }
        }
        #endregion

        #region Methods

        private void InitObj(Control cntrl)
        {
            string parentFormName = cntrl.FindForm().Text;
            string leftHeaderText = "", rightHeaderText = "", middleHeaderText = "";
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem();
            this.gcPrintableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink();

            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.gcPrintableComponentLink});
            this.printingSystem1.Watermark.Text = "Runtime Inquiry";
            this.printingSystem1.Watermark.ShowBehind = false;
            this.printingSystem1.Watermark.ForeColor = System.Drawing.Color.LightGray;


            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Watermark, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Customize, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXls, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx, DevExpress.XtraPrinting.CommandVisibility.None);
            this.printingSystem1.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF, DevExpress.XtraPrinting.CommandVisibility.None);

            //Get default header from app code 
            if (grdInfo != null)
            {
                leftHeaderText = grdInfo.PageLeftHeader;
                middleHeaderText = grdInfo.PageMiddleHeader;
                rightHeaderText = grdInfo.PageRightHeader;

            }
            //Get any user defined headers or
            PreviewXtraGridHeaderXtraForm frm = new PreviewXtraGridHeaderXtraForm();
            frm.ShowDialog();
            if (FormRecord.ObjectParm != null)
            {
                List<string> headerTexts = (List<string>)FormRecord.ObjectParm;
                leftHeaderText += Environment.NewLine + headerTexts[0];
                middleHeaderText += Environment.NewLine + headerTexts[1];
                rightHeaderText += Environment.NewLine + headerTexts[2];
            }



            this.gcPrintableComponentLink.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                String.Format("FinERP {0}{1}{2}", parentFormName, Environment.NewLine, leftHeaderText),
                middleHeaderText,
                rightHeaderText}, new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "[Page # of Pages #]",
                "PrintedBy:" + FormRecord.CurrentUserId,
                "[Date Printed][Time Printed]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.gcPrintableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.gcPrintableComponentLink.PrintingSystem = this.printingSystem1;
            this.gcPrintableComponentLink.PrintingSystemBase = this.printingSystem1;


        }

        public void ShowPreviewDialog()
        {
            gcPrintableComponentLink.ShowPreviewDialog();

        }

        private void SetViewsOptions(DevExpress.XtraGrid.GridControl gc)
        {
            foreach (DevExpress.XtraGrid.Views.Grid.GridView v in gc.Views)
            {
                v.OptionsPrint.PrintFilterInfo = true;

            }
        }

        private void SetViewsOptions(DevExpress.XtraPivotGrid.PivotGridControl pvgc)
        {
            pvgc.OptionsPrint.PrintHeadersOnEveryPage = true;
            pvgc.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pvgc.OptionsPrint.PageSettings.Landscape = true;
            pvgc.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.True;

        }

        private void SetViewsOptions(DevExpress.XtraReports.UI.XtraReport rpt)
        {
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Watermark, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Customize, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXls, DevExpress.XtraPrinting.CommandVisibility.None);
            rpt.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx, DevExpress.XtraPrinting.CommandVisibility.None);


        }

        #endregion

        #region EventHandlers

        #endregion


    }

    public class PreviewXtraGridInfo
    {
        public PreviewXtraGridInfo()
        {

        }


        #region Members
        string pageMiddleHeader = "";
        string pageLeftHeader = "";
        string pageRightHeader = "";


        #endregion

        #region Properties

        public string PageMiddleHeader
        {
            set { pageMiddleHeader = value; }
            get { return pageMiddleHeader; }
        }
        public string PageLeftHeader
        {
            set { pageLeftHeader = value; }
            get { return pageLeftHeader; }
        }
        public string PageRightHeader
        {
            set { pageRightHeader = value; }
            get { return pageRightHeader; }
        }


        #endregion

        #region Methods
        public void AttachToGrid(DevExpress.XtraGrid.GridControl gc)
        {
            if (gc.Tag is AppService.XtraGridViewInfo)
            {
                ((AppService.XtraGridViewInfo)gc.Tag).PreviewGridInfo = this;
            }
            else
            {
                gc.Tag = this;
            }
        }

        public void AttachToGrid(DevExpress.XtraPivotGrid.PivotGridControl pvc)
        {
            if (pvc.Tag is AppService.XtraGridViewInfo)
            {
                ((AppService.XtraGridViewInfo)pvc.Tag).PreviewGridInfo = this;
            }
            else
            {
                pvc.Tag = this;
            }
        }

        public void AttachToGrid(DevExpress.XtraCharts.ChartControl chart)
        {
            if (chart.Tag is AppService.XtraGridViewInfo)
            {
                ((AppService.XtraGridViewInfo)chart.Tag).PreviewGridInfo = this;
            }
            else
            {
                chart.Tag = this;
            }
        }

        public void SetPageMiddleHeaderLines(params string[] lines)
        {
            foreach (string lin in lines)
            {
                this.pageMiddleHeader += Environment.NewLine + lin;
            }
        }

        public void SetPageRightHeaderLines(params string[] lines)
        {
            foreach (string lin in lines)
            {
                this.pageRightHeader += Environment.NewLine + lin;
            }
        }

        public void SetPageLeftHeaderLines(params string[] lines)
        {
            foreach (string lin in lines)
            {
                this.pageLeftHeader += Environment.NewLine + lin;
            }
        }

        public string GetTimeRangeString(DateTime fromDate, DateTime toDate)
        {
            string line = string.Format(" From : {0} To: {1} ", fromDate.ToShortDateString(), toDate.ToShortDateString());
            return line;


        }

        public string GetTimeRangeString(int fromPID, int toPID)
        {
            //string fromPName = GlobalMethods.SQLSelectScalar(String.Format("SELECT FP.FinPeriodName FROM FinancialPeriodTable FP WHERE FP.FinPeriodID = {0} ", fromPID)).ToString();
            //string toPName = GlobalMethods.SQLSelectScalar(String.Format("SELECT FP.FinPeriodName FROM FinancialPeriodTable FP WHERE FP.FinPeriodID = {0} ", toPID)).ToString();
            //string line = string.Format(" From : {0} To: {1} ", fromPName, toPName);
            //return line;
            return "";


        }


        #endregion

        #region EventHandlers

        #endregion

    }

    public class XtraGridViewInfo
    {
        public XtraGridViewInfo(CoreLib.Grid.MyGridView gv)
        {
            infoObject = InfoObjectType.GridView;
            this.gridView = gv;
            objFullName = String.Format("{0}.{1}", GetCSharpControlName(gv.GridControl), gv.Name);
            objFullCaption = GetCSharpGridViewCaption(gv);
            gridDBKey = GetGridViewDBKey(objFullName, objFullCaption);

            gridView.Tag = this;
        }

        public XtraGridViewInfo(DevExpress.XtraPivotGrid.PivotGridControl pivot)
        {
            infoObject = InfoObjectType.Pivot;
            this.pivotGrid = pivot;
            objFullName = GetCSharpControlName(pivot);
            objFullCaption = GetCSharpControlCaption(pivot);
            gridDBKey = GetGridViewDBKey(objFullName, objFullCaption);
            pivot.Tag = this;

        }
        public XtraGridViewInfo(DevExpress.XtraTreeList.TreeList treeLst)
        {
            infoObject = InfoObjectType.TreeList;
            this.treeList = treeLst;
            objFullName = GetCSharpControlName(treeList);
            objFullCaption = GetCSharpControlCaption(treeList);

            gridDBKey = GetGridViewDBKey(objFullName, objFullCaption);
            treeList.Tag = this;

        }

        #region Members
        public enum InfoObjectType { GridView, Pivot, TreeList }
        private InfoObjectType infoObject;
        UIMaster gridDBKey;
        UIProfile gridLayoutKey;
        CoreLib.Grid.MyGridView gridView;
        DevExpress.XtraPivotGrid.PivotGridControl pivotGrid;
        DevExpress.XtraTreeList.TreeList treeList;
        string gridControlFullName = "?";//Question mark mean you need recreate the name from code 
        string gridControlFullCaption = "?";

        PreviewXtraGridInfo previewXtraGridInfo;

        string objFullName = "?";
        string objFullCaption = "?";


        #endregion

        #region Properties
        public PreviewXtraGridInfo PreviewGridInfo
        {
            set { previewXtraGridInfo = value; }
            get { return previewXtraGridInfo; }
        }

        public InfoObjectType InfoObject
        {
            get { return infoObject; }
        }


        public UIMaster GridViewDBKey
        {
            get { return gridDBKey; }
        }


        public string GridControlFullName
        {
            get
            {
                if (gridControlFullName == "?")
                {
                    gridControlFullName = GetCSharpControlName(gridView.GridControl);
                }
                return gridControlFullName;
            }
        }

        public string GridControlFullCaption
        {
            get
            {
                if (gridControlFullCaption == "?")
                {
                    gridControlFullCaption = GetCSharpControlCaption(gridView.GridControl);
                }
                return gridControlFullCaption;
            }
        }

        public string GridViewFullName
        {
            get
            {
                if (objFullName == "?")
                {
                    objFullName = GetCSharpGridViewName(gridView);
                }
                return objFullName;
            }
        }

        public string GridViewFullCaption
        {
            get
            {
                if (objFullCaption == "?")
                {
                    objFullCaption = GetCSharpGridViewCaption(gridView);
                }
                return objFullCaption;
            }
        }


        #endregion

        #region Methods
        public UIMaster GetGridViewDBKey(string objName, string objCaption)
        {
           
            if(gridDBKey == null )
            {
                var gridDBKey = XpoDefault.Session.FindObject<UIMaster>(CriteriaOperator.Parse("[ObjCodeName] = ? ", objName));
                if (gridDBKey == null)//Create new line
                {
                    gridDBKey = new UIMaster(XpoDefault.Session) { ObjCodeName = objName, ObjCodeCaption = objCaption };
                    gridDBKey.Save();
                   
                }
            }
            
             
            return gridDBKey;
          /*  SqlCommand cmd = new SqlCommand();
            SqlParameter gridCSharpCodeNameParm = new SqlParameter("@GridCSharpCodeName", objName);
            SqlParameter gridCSharpCodeCaptionParm = new SqlParameter("@GridCSharpCodeCaption", objCaption);
            SqlParameter gridKeyParmOutPut = new SqlParameter("@GridKey", SqlDbType.Int);
            gridKeyParmOutPut.Direction = ParameterDirection.Output;

            cmd.Connection = HFrameWork.GlobalVariable.Sqlca;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ERPSys_Grid_GetGridViewDBKey";
            cmd.Parameters.Add(gridCSharpCodeNameParm);
            cmd.Parameters.Add(gridCSharpCodeCaptionParm);
            cmd.Parameters.Add(gridKeyParmOutPut);

            cmd.ExecuteNonQuery();

            return (int)gridKeyParmOutPut.Value;
            */


        }

        public string GetCSharpControlName(Control gc)
        {
            Control token;
            string fullName = "";
            List<string> orderNameList = new List<string>();


            token = gc.Parent;
            orderNameList.Add(gc.Name);
            Control topControl = token.TopLevelControl;

            while ((!(token.Equals(topControl) )) && (token != null))
            {
                orderNameList.Add(token.Name);
                token = token.Parent;
            }
            //Reverse name order
            for (int i = orderNameList.Count - 1; i >= 0; i--)
            {
                if (orderNameList[i] != string.Empty)
                {
                    fullName += orderNameList[i];
                    fullName += ".";
                }

            }
            //Remove last "."
            fullName = fullName.Remove(fullName.Length - 1);

            return fullName;
        }

        public string GetCSharpControlCaption(Control gc)
        {

            Control token;
            string fullCaption = "";
            List<string> orderCaptionList = new List<string>();


            token = gc.Parent;
            orderCaptionList.Add(gc.Text);
            Control topControl = token.TopLevelControl;

            while ((!(token.Equals(topControl))) && (token != null))
            {
                orderCaptionList.Add(token.Text);
                token = token.Parent;
            }
            //Reverse caption order
            for (int i = orderCaptionList.Count - 1; i >= 0; i--)
            {
                if (orderCaptionList[i] != string.Empty)
                {
                    fullCaption += orderCaptionList[i];
                    fullCaption += ".";
                }

            }
            //Remove last "."
            fullCaption = fullCaption.Remove(fullCaption.Length - 1);



            return fullCaption;
        }

        public string GetCSharpGridViewName(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            string gcName = GetCSharpControlName(gv.GridControl);
            string gvName = String.Format("{0}.{1}", gcName, gv.Name);
            return gvName;
        }

        public string GetCSharpGridViewCaption(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            string gcCaption = GetCSharpControlCaption(gv.GridControl);
            string viewCaption = gv.ViewCaption;
            if (viewCaption == string.Empty)
            {
                viewCaption = gv.Name;
            }
            string gvCaption = String.Format("{0}.{1}", gcCaption, viewCaption);
            return gvCaption;
        }

        public UIProfile GetGridViewLayoutKey()
        {
            if (gridLayoutKey == null )
            {
                gridLayoutKey = XpoDefault.Session.FindObject<UIProfile>(CriteriaOperator.Parse("[UIMaster] = ? AND [UserId] = ?", gridDBKey, FormRecord.CurrentUserId));
                if(gridLayoutKey == null)
                {
                    gridLayoutKey = new UIProfile(XpoDefault.Session) { UIMaster = gridDBKey, UserId = FormRecord.CurrentUserId };
                    gridLayoutKey.Save();

                }
                
            }

            return gridLayoutKey;
        }

        public string GetXMLSettings()
        {
            string xmlInString;

            string generetedFileName = String.Format("xmlSettins{0}save", DateTime.Now.Ticks);
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            fileName = String.Format(@"{0}\{1}.hos", fileName, generetedFileName);
            FileStream fs = File.Create(fileName);

            DevExpress.Utils.OptionsColumnLayout optionsColumnLayout = new DevExpress.Utils.OptionsColumnLayout();
            //GridView Settings
            if (InfoObject == InfoObjectType.GridView)
            {
                gridView.OptionsLayout.StoreAllOptions = true;
                gridView.OptionsLayout.Columns.StoreAllOptions = true;
                gridView.OptionsLayout.StoreAppearance = true;
                gridView.OptionsLayout.Columns.RemoveOldColumns = false;
                gridView.SaveLayoutToStream(fs);
            }
            if (InfoObject == InfoObjectType.Pivot)
            {
                //pivotGrid.OptionsLayout.StoreAllOptions = true;
                DevExpress.XtraPivotGrid.PivotGridOptionsLayout pivotOptions = new DevExpress.XtraPivotGrid.PivotGridOptionsLayout();
                pivotOptions.StoreAllOptions = true;
                pivotGrid.SaveLayoutToStream(fs, pivotOptions);
            }

            fs.Close();
            xmlInString = System.IO.File.ReadAllText(fileName);
            System.IO.File.Delete(fileName);
            return xmlInString;
        }

        public bool GetUserDefaultXMLSettings(out string defaultXMLSettings)
        {
            try
            {
                var layout = GetGridViewLayoutKey();
                var uIProfileLine = XpoDefault.Session.FindObject<UIProfileLine>(CriteriaOperator.Parse("[UIProfile] = ? AND [IsDefault] = true"));

                defaultXMLSettings = uIProfileLine.Layout;
                if (defaultXMLSettings.Length >= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception)
            {
                defaultXMLSettings = "";
                return false;
            }
           
          
        }

        public void RestoreLayoutFromXML(string xmlSettings)
        {
            string generetedFileName = String.Format("xmlSettins{0}save", DateTime.Now.Ticks);
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            fileName = String.Format(@"{0}\{1}.hos", fileName, generetedFileName);
            System.IO.File.WriteAllText(fileName, xmlSettings);
            if (InfoObject == InfoObjectType.GridView)
            {
                gridView.GridControl.ForceInitialize();

                //layoutGridControl.MainView.RestoreLayoutFromXml(fileName);
                gridView.OptionsLayout.Columns.StoreAllOptions = true;
                gridView.OptionsLayout.StoreAppearance = true;
                gridView.RestoreLayoutFromXml(fileName, OptionsLayoutBase.FullLayout);

            }
            if (InfoObject == InfoObjectType.Pivot)
            {
                pivotGrid.ForceInitialize();

                //pivotGrid.OptionsLayout.Columns.StoreAllOptions = false;
                //pivotGrid.OptionsLayout.Columns.RemoveOldColumns = true;
                DevExpress.XtraPivotGrid.PivotGridOptionsLayout pivotOptions = new DevExpress.XtraPivotGrid.PivotGridOptionsLayout();
                pivotOptions.StoreAllOptions = true;
                pivotGrid.RestoreLayoutFromXml(fileName, pivotOptions);
            }


            System.IO.File.Delete(fileName);

        }

        public void RestoreLayoutFromDefaultXML()
        {
            string xml;
            if (GetUserDefaultXMLSettings(out xml))
            {
                RestoreLayoutFromXML(xml);
            }

        }

        public void ClearAllSavedLayoutsFromDB()
        {
            try
            {
                var line = GetGridViewLayoutKey();
                XpoDefault.Session.Delete(line.UIProfileLines);
                XpoDefault.Session.Save(line.UIProfileLines);
                //string deleteSQL = string.Format("DELETE FROM dbo.SecurityUserDataGridLayoutLinesTable WHERE LayoutKey = {0}", GetGridViewLayoutKey());
                //SqlCommand cmd = new SqlCommand(deleteSQL, HFrameWork.GlobalVariable.Sqlca);
                //cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }


        #endregion

        #region EventHandlers


        #endregion


    }


}
