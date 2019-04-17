using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid
{
    public class ViewDetailsEventArgs:EventArgs
    {
        private ViewDetailsEventArgs()
        {

        }
        public ViewDetailsEventArgs(GridColumnInfo _gridColumnInfo, MyGridView _callerGrid)
        {
            fGridColumnInfo = _gridColumnInfo;
            CallerGrid = _callerGrid;
        }
        private GridColumnInfo fGridColumnInfo;
        public GridColumnInfo GridColumnInfo
        {
            get
            {
                return fGridColumnInfo;
            }

            set
            {
                fGridColumnInfo = value;
            }
        }
        public MyGridView CallerGrid { get; set; }


    }
    public delegate void ViewDetailsHandler(object sender ,ViewDetailsEventArgs e);
}
