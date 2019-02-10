using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DevExpress.Xpo;
using ProductionReports.ModelXpo.OmarERP;
namespace ProductionReports
{
   public class SecurityUser
    {
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
