using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    public class SysSequence
    {
        private const string SP_NEXT_TASK_LINE = "dbo.sp_Sys_NextValue";
       

        public static long NextVal(Session unitOfWork,MyEnums.SysSequence sysSequenceName,long  startWith=0)
        {
            
            long returnIndex = 0;
            var sequIdParm = new DevExpress.Xpo.DB.SprocParameter("@SequenceId", sysSequenceName);
            var sequNameParm = new DevExpress.Xpo.DB.SprocParameter("@SequenceName", Enum.GetName(typeof(MyEnums.SysSequence),sysSequenceName));
            var startWithParm = new DevExpress.Xpo.DB.SprocParameter("@StartWith", startWith);
            var outputParm = new DevExpress.Xpo.DB.SprocParameter()
            {
                ParameterName = "@NewID",
                Direction = DevExpress.Xpo.DB.SprocParameterDirection.Output,
                DbType = DevExpress.Xpo.DB.DBColumnType.Int32
            };
            var data = unitOfWork.ExecuteSprocParametrized(SP_NEXT_TASK_LINE,sequIdParm, sequNameParm,startWithParm, outputParm);
            SelectStatementResultRow row = data.ResultSet[1].Rows[0];

            returnIndex = (int)row.Values[1];// data.ResultSet[1].Rows[1].Values[1];

            return returnIndex;
        }
    }
}
