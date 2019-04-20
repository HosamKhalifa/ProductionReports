using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using CoreLib.SharedExt;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.Xpo.Metadata;
using CoreLib.Xpo;
using CoreLib.Label;
using DevExpress.Data.Filtering;
using System.Windows.Forms;
using CoreLib.Grid.AppService;

namespace CoreLib.Grid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        public MyGridControl()
        {
            this.GotFocus += (s, e) => 
            {
                foreach (var v in this.Views)
                {
                    var gv = v as MyGridView;
                    gv.EnableEditButtons();
                }
            };
        }
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
           
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
         
            this.KeyDown += (s, e) => 
            {
                try
                {

                    var gc = this;

                    if (gc != null)
                    {
                        ControlNavigator cn = (ControlNavigator)gc.EmbeddedNavigator;
                        switch (e.KeyCode)
                        {
                            case Keys.F6:
                                if (e.Shift)
                                {
                                    if (cn.Buttons.Remove.Enabled && cn.Buttons.Remove.Visible)
                                    {
                                        cn.Buttons.DoClick(cn.Buttons.Remove);
                                    }

                                }
                                else
                                {
                                    if (cn.Buttons.Append.Enabled && cn.Buttons.Append.Visible)
                                    {
                                        cn.Buttons.DoClick(cn.Buttons.Append);
                                    }
                                }

                                break;


                        }
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                }
            };
        }

        #region Properties

      

        #endregion
    }

    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName
        {
            get
            {
                return "MyGridView";
            }
        }

        public override BaseView CreateView(GridControl grid)
        {
           return new MyGridView(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new MyGridViewInfo(view as MyGridView);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new MyGridViewHandler(view as MyGridView);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new MyGridViewPainter(view as MyGridView);
        }
    }

    public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView
    {
        public MyGridView()
        {
            this.OptionsView.ColumnAutoWidth = false;
            this.OptionsView.ShowAutoFilterRow = true;
            this.OptionsView.ShowFooter = true;
            this.OptionsView.EnableAppearanceEvenRow = true;
            this.OptionsMenu.ShowGroupSummaryEditorItem = true;
            
            //Labels
            //Should calling after datasource settings ApplyLabelToColumns();
            this.DataSourceChanged += (s, e) => 
            {
                if (!this.DesignMode)
                {
                    
                    if (this.DataSource is XPCollection)
                    {
                        var ds = (XPCollection)this.DataSource;
                        
                        this.BeginInit();
                        ApplyLabel((XPCollection)ds);
                        ds.CollectionChanged += (sndr, arg) => 
                        {
                            if (arg.CollectionChangedType == DevExpress.Xpo.XPCollectionChangedType.AfterRemove)
                            {
                                if (ds.Session is UnitOfWork)//Should be UnitOfWork to use extension method SaveLine
                                {
                                    UnitOfWork unit = (UnitOfWork)ds.Session;
                                    unit.Delete(arg.ChangedObject);
                                    //unit.SaveLine();
                                }

                            }
                        };
                        this.EndInit();
                    }

                    //ApplyLabelToColumns();
                }

            };   
            this.InitNewRow += (s, e) =>
             {
                 try
                 {
                     switch (this.OptionsBehavior.EditingMode)
                     {
                         case GridEditingMode.EditForm:
                         case GridEditingMode.EditFormInplace:
                         case GridEditingMode.EditFormInplaceHideCurrentRow:
                                this.ShowEditForm();
                             break;
                         default:
                             break;
                     }
                 }
                 catch (Exception)
                 {
                     
                 }
                 
             };
            this.FocusedRowChanged += (s, e) => 
            {
                var row = this.GetRow(e.FocusedRowHandle); 
                if(row != null && row is XPLiteObject)
                {
                    FormRecord.CurrentRecord = (XPLiteObject)row;                  
                }
            };
            if (this.EnableAutoSave && this.UnitOfWorkXpo != null)
            {
                this.ValidateRow += (s, e) =>
                    {
                        try
                        {
                            e.Valid = UnitOfWorkXpo.SaveLine();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                        }
                    }; 
            }
            this.PopupMenuShowing += (sender, argE) => 
            {
                var gv = (MyGridView)sender;
                gv.OptionsMenu.ShowConditionalFormattingItem = true;
                //Row menu configuration
                #region RowMenu
                if (argE.HitInfo.InRow)
                {
                    DevExpress.Utils.Menu.DXMenuItem printGridMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Print");
                    DevExpress.Utils.Menu.DXMenuItem previewGridMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Preview");
                    DevExpress.Utils.Menu.DXMenuItem exportMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Export");
                    DevExpress.Utils.Menu.DXMenuItem refreshMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Refresh");
                    DevExpress.Utils.Menu.DXMenuItem conditionalFormatMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Conditional Format");
                    DevExpress.Utils.Menu.DXMenuItem saveLayoutMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Save layout");
                    DevExpress.Utils.Menu.DXMenuItem restoreLayoutMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Restore layout");
                    DevExpress.Utils.Menu.DXMenuItem clearLayoutMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Clear layout settings");
                    DevExpress.Utils.Menu.DXMenuItem bulkUpdateMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Multi rows update");
                    DevExpress.Utils.Menu.DXMenuItem pivotGridMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Pivot grid");
                    DevExpress.Utils.Menu.DXMenuItem sendSMSMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Send SMS");
                    DevExpress.Utils.Menu.DXMenuItem viewDetailsMenuItem = new DevExpress.Utils.Menu.DXMenuItem("View details");
                    //get icons
                    Image printGridIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/print_16x16.png");
                    Image previewGridIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/preview_16x16.png");
                    Image exportIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxlsx_16x16.png");
                    Image refreshIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh2_16x16.png");
                    Image conditionalFormatIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/palette_16x16.png");
                    Image saveLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/addgroupheader_16x16.png");
                    Image restoreLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/deletegroupheader_16x16.png");
                    Image clearLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/saveandclose_16x16.png");
                    Image bulkUpdateLayoutIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/scripts_16x16.png");
                    Image pivotGridIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/pivot_16x16.png");
                    Image sendSMSIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/editfeed_16x16.png");
                    Image viewDetailsIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/showproduct_16x16.png");
                    //Assign icon to its menus
                    printGridMenuItem.Image = printGridIcon;
                    previewGridMenuItem.Image = previewGridIcon;
                    exportMenuItem.Image = exportIcon;
                    refreshMenuItem.Image = refreshIcon;
                    conditionalFormatMenuItem.Image = conditionalFormatIcon;
                    saveLayoutMenuItem.Image = saveLayoutIcon;
                    restoreLayoutMenuItem.Image = restoreLayoutIcon;
                    clearLayoutMenuItem.Image = clearLayoutIcon;
                    bulkUpdateMenuItem.Image = bulkUpdateLayoutIcon;
                    pivotGridMenuItem.Image = pivotGridIcon;
                    sendSMSMenuItem.Image = sendSMSIcon;
                    viewDetailsMenuItem.Image = viewDetailsIcon;
                    //Link this grid view to menu object via Tag property
                    printGridMenuItem.Tag = gv;
                    previewGridMenuItem.Tag = gv;
                    exportMenuItem.Tag = gv;
                    refreshMenuItem.Tag = gv;
                    conditionalFormatMenuItem.Tag = gv;
                    saveLayoutMenuItem.Tag = gv;
                    restoreLayoutMenuItem.Tag = gv;
                    clearLayoutMenuItem.Tag = gv;
                    bulkUpdateMenuItem.Tag = gv;
                    pivotGridMenuItem.Tag = gv;
                    sendSMSMenuItem.Tag = gv;
                    viewDetailsMenuItem.Tag = gv;
                    //Event handler for each menu item
                    //=======================================================================================

                    printGridMenuItem.Click+= (s, e) => 
                    {
                        this.OptionsPrint.ExpandAllDetails = false;//To reserve user settings during printing
                        this.OptionsPrint.ExpandAllGroups = false;
                        this.Print();

                    };
                    previewGridMenuItem.Click += (s, e) => 
                    {
                        AppService.PreviewXtraGrid previewXtraGrid;

                        try
                        {
                            this.OptionsPrint.ExpandAllDetails = false;//To reserve user settings during printing
                            this.OptionsPrint.ExpandAllGroups = false;
                            previewXtraGrid = new AppService.PreviewXtraGrid(gv.GridControl);
                            previewXtraGrid.PrintableGridLink.Landscape = true;
                            previewXtraGrid.ShowPreviewDialog();
                        }
                        catch (Exception ex)
                        {

                            XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                        }
                    };
                    exportMenuItem.Click += (s, e) => 
                    {
                        string fileName = "";
                        fileName = GlobalMethods.AskUser_SaveFilePath("Xlsx");
                        if (string.IsNullOrEmpty(fileName)){ return; }
                        gv.ExportToXls(fileName);
                    };
                    refreshMenuItem.Click += (s, e) => 
                    {
                        gv.UnitOfWorkXpo.ReloadChangedObjects();
                    };
                    pivotGridMenuItem.Click += (s, e)=>
                    {
                        try
                        {
                            
                           
                            AppService.XtraGridPopupMenu_PivotXtraForm frm = new AppService.XtraGridPopupMenu_PivotXtraForm(this);
                            //Inhriet pivot form from caller form
                            //frm.IsSaveLayout = parentForm.IsSaveLayout;Disable this option 
                            //frm.IsPreviewable = parentForm.IsPreviewable;
                            //frm.IsPrintable = parentForm.IsPrintable;
                            //frm.IsExportable = parentForm.IsExportable;
                            var parentForm = this.GridControl.TopLevelControl as XtraForm;
                           
                            if (parentForm.IsMdiChild)
                            {
                                frm.MdiParent = parentForm;
                                frm.WindowState = FormWindowState.Maximized;
                                frm.Show();
                                //Stacked windows
                                StackingChildForms(MdiLayout.TileHorizontal, parentForm, frm);

                            }
                            else
                            {
                                frm.WindowState = FormWindowState.Maximized;
                                frm.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                        }


                    };
                    viewDetailsMenuItem.Click += (s, e) => 
                    {
                        if (argE.HitInfo.InRow && argE.HitInfo.RowHandle >= 0 )
                        {
                            var colInfo = (GridColumnInfo)argE.HitInfo.Column.Tag;
                            if (colInfo == null) return;
                            if (colInfo.IsViewDetails)
                            {
                                colInfo.FormArgs = new Args();
                                //Save current row value 
                                string cellVal = this.GetRowCellValue(argE.HitInfo.RowHandle, argE.HitInfo.Column).ToString();
                                var col = argE.HitInfo.Column;
                                if(col.ColumnType == typeof(string)      || 
                                   col.ColumnType == typeof(DateTime)       )
                                {
                                    cellVal = $"'{cellVal}'";
                                }
                                colInfo.FormArgs.Caller = this.GridControl.FindForm();
                                colInfo.FormArgs.LookupField = colInfo.ColumnLablel.LookupEditor.LookupValueField;
                                colInfo.FormArgs.LookupValue = cellVal;
                                colInfo.FormArgs.Record = (XPBaseObject)GetRow(argE.HitInfo.RowHandle);
                                OnViewDetails(new ViewDetailsEventArgs(colInfo, this));
                            }     
                        }
                    };
                    //=======================================================================================
                    //Add menu to grid 
                    //=======================================================================================
                    argE.Menu.Items.Add(printGridMenuItem);
                    argE.Menu.Items.Add(previewGridMenuItem);
                    argE.Menu.Items.Add(exportMenuItem);
                    argE.Menu.Items.Add(pivotGridMenuItem);
                    argE.Menu.Items.Add(refreshMenuItem);
                    argE.Menu.Items.Add(viewDetailsMenuItem);
                    

                }
                #endregion

                #region ColumnMenu
                if (argE.HitInfo.InColumn)
                {

                    //Checked filter with sub menu
                    DevExpress.Utils.Menu.DXSubMenuItem checkedFilterSubMenuItem = new DevExpress.Utils.Menu.DXSubMenuItem("Filter popup mode");
                    DevExpress.Utils.Menu.DXMenuItem checkedListOptionMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Checked list");
                    DevExpress.Utils.Menu.DXMenuItem listOptionMenuItem = new DevExpress.Utils.Menu.DXMenuItem("List");
                    DevExpress.Utils.Menu.DXMenuItem defaultOptionMenuItem = new DevExpress.Utils.Menu.DXMenuItem("Default");

                    checkedFilterSubMenuItem.Items.Add(defaultOptionMenuItem);
                    checkedFilterSubMenuItem.Items.Add(checkedListOptionMenuItem);
                    checkedFilterSubMenuItem.Items.Add(listOptionMenuItem);

                    System.Drawing.Image filterIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/forcetesting_16x16.png");
                    System.Drawing.Image freezeIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/alignverticalleft_16x16.png");
                    System.Drawing.Image expColumnIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/scripts_16x16.png");
                    System.Drawing.Image removeColumnIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/deleteheader_16x16.png");
                    System.Drawing.Image columnsSetupIcon = DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/customizegrid_16x16.png");

                    checkedFilterSubMenuItem.Image = filterIcon;
                    checkedFilterSubMenuItem.ImageDisabled = filterIcon;
                    checkedFilterSubMenuItem.LargeImage = filterIcon;
                    checkedFilterSubMenuItem.LargeImageDisabled = filterIcon;

                    defaultOptionMenuItem.Click += (s,e)=> 
                    {
                        argE.HitInfo.Column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
                    };
                    checkedListOptionMenuItem.Click += (s,e)=> 
                    {
                        argE.HitInfo.Column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
                    };
                    listOptionMenuItem.Click += (s,e)=> 
                    {
                        argE.HitInfo.Column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
                    };

                    defaultOptionMenuItem.Tag = argE.HitInfo;
                    checkedListOptionMenuItem.Tag = argE.HitInfo;
                    listOptionMenuItem.Tag = argE.HitInfo;
                    argE.Menu.Items.Add(checkedFilterSubMenuItem);

                    //Freeze column
                    DevExpress.Utils.Menu.DXSubMenuItem freezeColumnSubMenuItem = new DevExpress.Utils.Menu.DXSubMenuItem("Freeze column");
                    freezeColumnSubMenuItem.Image = freezeIcon;
                    freezeColumnSubMenuItem.ImageDisabled = freezeIcon;
                    freezeColumnSubMenuItem.LargeImage = freezeIcon;
                    freezeColumnSubMenuItem.LargeImageDisabled = freezeIcon;

                    DevExpress.Utils.Menu.DXMenuItem freezeColumnToLeft = new DevExpress.Utils.Menu.DXMenuItem("Left");
                    DevExpress.Utils.Menu.DXMenuItem freezeColumnToRight = new DevExpress.Utils.Menu.DXMenuItem("Right");
                    DevExpress.Utils.Menu.DXMenuItem freezeColumnClear = new DevExpress.Utils.Menu.DXMenuItem("None");

                    freezeColumnSubMenuItem.Items.Add(freezeColumnToLeft);
                    freezeColumnSubMenuItem.Items.Add(freezeColumnToRight);
                    freezeColumnSubMenuItem.Items.Add(freezeColumnClear);

                    freezeColumnToLeft.Click += (s,e)=> { argE.HitInfo.Column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left; };
                    freezeColumnToRight.Click += (s, e) => { argE.HitInfo.Column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right; };
                    freezeColumnClear.Click += (s, e) => { argE.HitInfo.Column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None; };

                    freezeColumnToLeft.Tag = argE.HitInfo;
                    freezeColumnToRight.Tag = argE.HitInfo;
                    freezeColumnClear.Tag = argE.HitInfo;

                    argE.Menu.Items.Add(freezeColumnSubMenuItem);
                    if (argE.HitInfo.Column.UnboundType == DevExpress.Data.UnboundColumnType.Bound)
                    {
                        DevExpress.Utils.Menu.DXMenuItem addExpColumnMenu = new DevExpress.Utils.Menu.DXMenuItem("New expression column");
                        addExpColumnMenu.Image = expColumnIcon;
                        addExpColumnMenu.Tag = gv;
                        addExpColumnMenu.Click += (s,e)=> 
                        {
                            CoreLib.Grid.AppService.ExpressionColumnOptionsXtraForm frm = new AppService.ExpressionColumnOptionsXtraForm(this);
                            frm.ShowDialog();
                        };
                        argE.Menu.Items.Add(addExpColumnMenu);

                    }
                    else
                    {
                        DevExpress.Utils.Menu.DXMenuItem removeExpColumnMenu = new DevExpress.Utils.Menu.DXMenuItem("Remove expression column");
                        removeExpColumnMenu.Image = removeColumnIcon;
                        removeExpColumnMenu.Tag = argE.HitInfo;
                        removeExpColumnMenu.Click += (s,e)=> 
                        {
                            argE.HitInfo.Column.View.Columns.Remove(argE.HitInfo.Column);
                        };
                        argE.Menu.Items.Add(removeExpColumnMenu);


                    }

                    //Column setup
                    DevExpress.Utils.Menu.DXMenuItem setupColumnsMenu = new DevExpress.Utils.Menu.DXMenuItem("Advanced settings");
                    setupColumnsMenu.Image = columnsSetupIcon;
                    setupColumnsMenu.Tag = gv;
                    setupColumnsMenu.Click += (s,e) => //setupColumnsMenu_Click
                    {
                        AppService.XtraGridPopupMenu_ColumnsReorderXtraForm frm = new XtraGridPopupMenu_ColumnsReorderXtraForm(gv);
                        frm.Show();
                    };
                    argE.Menu.Items.Add(setupColumnsMenu);

                }
                #endregion

            };
        }

        private void StackingChildForms(MdiLayout mDiLayout, params Form[] childWindows)
        {
            //Minimize all others winow 
            var parentForm = (XtraForm)this.GridControl.TopLevelControl;
            foreach (Form child in parentForm.MdiChildren)
            {
                child.WindowState = FormWindowState.Minimized;
            }
            foreach (Form child in childWindows)
            {
                child.WindowState = FormWindowState.Normal;

            }

            parentForm.LayoutMdi(mDiLayout);


        }

        #region Methods

        [Obsolete]
        public void ApplyLabelToColumns( )
        {
            string lblValue = "";
            foreach (GridColumn c in this.Columns)
            {
                try
                {
                    //Caption
                    if (c.CustomizationSearchCaption.StartsWith("@"))
                    {
                        lblValue = Label.UILabel.ResolveLabelId(c.CustomizationSearchCaption);
                        c.Caption = lblValue;
                    }
                    //Tool tip
                    if (c.ToolTip.StartsWith("@"))
                    {
                        lblValue = Label.UILabel.ResolveLabelId(c.ToolTip);
                        c.ToolTip = c.ToolTip.Replace(c.ToolTip, lblValue);
                    }
                }
                catch (Exception )
                {

                }
            }
        }
        public void ApplyLabel(XPCollection ds)
        {
            if(this.UnitOfWorkXpo == null)
            {
                string errTxt = $"GridView has null UnitOfWorkXpo please set data source for this gridView{this.GridControl.TopLevelControl.Name}.{this.GridControl.Name}.{this.Name}";
                if (this.GridControl.TopLevelControl is CoreLib.MyForm)
                {
                    var frm = (CoreLib.MyForm)this.GridControl.TopLevelControl;
                    if (frm.IsMdiContainer)
                         { frm.SetStatusBarText(errTxt); }
                    else {XtraMessageBox.Show(errTxt);}

                }
                
                
                return;
            }
            
            var classInfo = ds.ObjectClassInfo;
            var objectBaseLine = this.UnitOfWorkXpo.FindObject<UIObjectBase>(CriteriaOperator.Parse("[ObjectName] = ? ", classInfo.FullName));
            if(objectBaseLine == null) { return; }
            //Disable and hide all columns before start enable and show based on user settings 

            if (EnableAutoFormat)
            {
                foreach (GridColumn grdC in this.Columns)
                {
                    grdC.Visible = false;
                    grdC.VisibleIndex = -1;
                    grdC.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
                    grdC.OptionsColumn.AllowEdit = false;
                } 
            }
            foreach (var m in classInfo.Members/*.Where(x => !string.IsNullOrEmpty(x.MappingField) || x.FindAttributeInfo("NonPersistent") != null)*/)
            {
               // bool isNonPersist = m.FindAttributeInfo("NonPersistentAttribute") != null;

                var c = this.Columns.ColumnByFieldName(m.Name);
                if(c != null)
                {
                    string fieldName = $"{m.Owner.FullName}.{m.Name}";
                    var labelLine = objectBaseLine.FindOrCreateUILabel(fieldName);
                        if (labelLine != null)
                        {
                            labelLine.ApplyFieldSettings(this,c,EnableAutoFormat);
                            
                        }
                   }
            }
            
            
        }
        public void EnableEditButtons()
        {
            var gc = this.GridControl;
            ControlNavigator cn = (ControlNavigator)gc.EmbeddedNavigator;
            cn.Buttons.Remove.Enabled = EnableNavBarEditButtons;
            cn.Buttons.Append.Enabled = EnableNavBarEditButtons;
            cn.Buttons.Edit.Enabled = EnableNavBarEditButtons;
            if (EnableNavBarEditButtons)
            {
                this.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
                this.OptionsEditForm.BindingMode = EditFormBindingMode.Cached;
                this.OptionsEditForm.EditFormColumnCount = 2;
            }

        }
        #endregion //Helper methods

        #region Events
        public event ViewDetailsHandler ViewDetails;
        protected virtual void OnViewDetails(ViewDetailsEventArgs e)
        {
            ViewDetails?.Invoke(this, e);
        }
        #endregion

        #region Properties
        private bool fEnableNavBarEditButtons = true;
        public bool EnableNavBarEditButtons
        {
            get
            {
                return fEnableNavBarEditButtons;
            }

            set
            {
                fEnableNavBarEditButtons = value;
            }
        }
        private bool fEnableAutoFormat=true;
        public bool EnableAutoFormat
        {
            get { return fEnableAutoFormat; }
            set { fEnableAutoFormat = value; }
        }

        private bool fEnableAutoSave = true;
        public bool EnableAutoSave
        {
            get { return fEnableAutoSave; }
            set { fEnableAutoSave = value; }
        }

      
        #endregion

        public MyGridView(GridControl grid) : base(grid)
        {
           
        }

        protected override string ViewName
        {
            get
            {
                return "MyGridView";
            }
        }
        //UNit of work holder is an access to database
        public UnitOfWork UnitOfWorkXpo { get; set; }

    }

    public class MyGridViewInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo
    {
        public MyGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
            
        }
    }

    public class MyGridViewHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public MyGridViewHandler(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class MyGridViewPainter : DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter
    {
        public MyGridViewPainter(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }
}
