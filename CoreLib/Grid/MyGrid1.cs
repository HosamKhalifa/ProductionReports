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

namespace CoreLib.Grid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
           
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
            this.UseEmbeddedNavigator = true;
        }
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
            this.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.OptionsEditForm.EditFormColumnCount = 2;
           
            this.InitNewRow += (s, e) =>
             {
                 this.ShowEditForm();
             };
        }

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
