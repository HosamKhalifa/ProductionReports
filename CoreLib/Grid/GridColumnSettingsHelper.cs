using CoreLib.Label;
using CoreLib.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid
{
    public class GridColumnSettingsHelper
    {
        public static void ApplyLabel(MyGridView gv,XPCollectionExt ds)
        {
            if (gv.UnitOfWorkXpo == null)
            {
                string errTxt = $"GridView has null UnitOfWorkXpo please set data source for this gridView{gv.GridControl.TopLevelControl.Name}.{gv.GridControl.Name}.{gv.Name}";
                if (gv.GridControl.TopLevelControl is MyForm)
                {
                    var frm = (CoreLib.MyForm)gv.GridControl.TopLevelControl;
                    if (frm.IsMdiContainer)
                    { frm.SetStatusBarText(errTxt); }
                    else
                    {
                        XtraMessageBox.Show(errTxt);
                    }
                }
                return;
            }

            var classInfo = ds.ObjectClassInfo;
            var objectBaseLine = gv.UnitOfWorkXpo.FindObject<UIObjectBase>(CriteriaOperator.Parse("[ObjectName] = ? ", classInfo.FullName));
            if (objectBaseLine == null) { return; }
            foreach (var m in classInfo.Members/*.Where(x => !string.IsNullOrEmpty(x.MappingField) || x.FindAttributeInfo("NonPersistent") != null)*/)
            {
                // bool isNonPersist = m.FindAttributeInfo("NonPersistentAttribute") != null;

                var c = gv.Columns.ColumnByFieldName(m.Name);
                if (c != null)
                {
                    string fieldName = $"{m.Owner.FullName}.{m.Name}";
                    var labelLine = objectBaseLine.FindOrCreateUILabel(fieldName);
                    if (labelLine != null)
                    {
                        labelLine.ApplyFieldSettings(gv, c);

                    }
                }
            }


        }
    }
}
