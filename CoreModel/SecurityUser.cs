using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DevExpress.Xpo;

using DevExpress.Xpo.DB;

namespace CoreModel
{
   public class SecurityUser
    {
        private const string SP_NEXT_TASK_LINE = "dbo.sp_Sys_NextValue";
        private const string LINE_ID_SEQU = "LINE_ID_SEQU";
        public string UserId { get; set; }
        public string Pwd { get; set; }
        public string PwdSuffix { get { return "!@#$%^&*()"; }   }

        public string ConnectionString { get; set; }



        public void ReadConnection(string _userName,string _Pwd)
        {
            string serverVal = ConfigurationManager.AppSettings.Get("Server");
            string dbVal = ConfigurationManager.AppSettings.Get("Database");
            string UseSuffix = ConfigurationManager.AppSettings.Get("UseSuffix");

            string pwd = UseSuffix == "1" ? _Pwd + this.PwdSuffix : _Pwd; 
            string cn = $"Data Source={serverVal};Initial Catalog={dbVal};User ID={_userName};Password={pwd}";
            this.ConnectionString = cn;
            this.UserId = _userName;
            this.Pwd = _Pwd;

        }

        public static SecurityUser CurrentUser { get; set; }

        public static bool IsConnected { get; set; }

        public static SecurityAccessType UserPermission(string _permissionId)
        {
            int accessTypeId;
            
            string SQL = $"SELECT dbo.F_ERPSys_PrincipalPermission('{_permissionId}')  ";
            var returnObject = XpoDefault.Session.ExecuteScalar(SQL);
            accessTypeId = int.Parse(returnObject.ToString());

            string filter = $"SELECT * FROM SecurityAccessTypeTable where AccessDegree = {accessTypeId}";
            var accessType = XpoDefault.Session.GetObjectsFromQuery<SecurityAccessType>(filter).FirstOrDefault();
            return accessType;
        }
        public static int NextLineVal(Session unitOfWork)
        {
            int returnIndex = 0;
            var sequNameParm = new DevExpress.Xpo.DB.SprocParameter("@SequenceName", LINE_ID_SEQU);
            var outputParm = new DevExpress.Xpo.DB.SprocParameter()
            {   ParameterName = "@NewID",
                Direction = DevExpress.Xpo.DB.SprocParameterDirection.Output,
                DbType = DevExpress.Xpo.DB.DBColumnType.Int32 };
            var data = unitOfWork.ExecuteSprocParametrized(SP_NEXT_TASK_LINE,sequNameParm, outputParm);
            SelectStatementResultRow row = data.ResultSet[1].Rows[0];
            
            returnIndex = (int)row.Values[1];// data.ResultSet[1].Rows[1].Values[1];
           
            return returnIndex;
        }

        public static bool IsCreator()
        {
            bool ret = false;
            string creator = ConfigurationManager.AppSettings.Get("CreatorPermissionId");
            SecurityAccessType accessType = SecurityUser.UserPermission(creator);
            if(accessType.AccessDegree >= 2)
            {
                ret = true;
            }

            return ret;
        }
        public static bool IsApprover()
        {
            bool ret = false;
            string creator = ConfigurationManager.AppSettings.Get("ApproverPermissionId");
            SecurityAccessType accessType = SecurityUser.UserPermission(creator);
            if (accessType.AccessDegree >= 2)
            {
                ret = true;
            }

            return ret;
        }
    }
}
