using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
   public class SysDataInit
    {
        public static void InitDB(Session _session)
        {
            using (UnitOfWork uOW = new UnitOfWork() )
            {
                TableBase.TableBaseRowsBuilder(uOW);
                DimensionBase.TableBaseRowsBuilder(uOW);
                Country.BuildTableRows(uOW);
                Currency.BuildTableRows(uOW);
                Workflow.BuildTableRows(uOW);
                WorkflowStep.BuildTableRows(uOW);
                GLParms.BuildTableRows(uOW);
                SecurityAccessType.BuildTableRows(uOW);

            }

            

        }
    }
}
