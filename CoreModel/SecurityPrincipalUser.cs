using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"SEC_PRINCIPAL_USER_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SecurityPrincipalUser : SecurityPrincipal
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalUser;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        protected SecurityPrincipalUser(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Employee fEmployee;
        [Persistent("EMPL_ID")]
        public Employee Employee
        {
            get { return fEmployee; }
            set { SetPropertyValue<Employee>("Employee", ref fEmployee, value); }
        }

        string fPwd;
        [Persistent(@"PWD"), Size(200)]
        public string Pwd
        {
            get { return fPwd; }
            set { SetPropertyValue<string>("Pwd", ref fPwd, value); }
        }
        bool fChangeNextLogin;
        [Persistent(@"CHANGE_NEXT_LOGIN")]
        public bool ChangeNextLogin
        {
            get { return fChangeNextLogin; }
            set { SetPropertyValue<bool>("ChangeNextLogin", ref fChangeNextLogin, value); }
        }

        System.Drawing.Image fUserImage;
        [ValueConverter(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
        [Persistent("USER_IMG"),Size(256*128)]
        public System.Drawing.Image UserImage
        {
            get { return fUserImage; }
            set
            {
                SetPropertyValue("Image", ref fUserImage, value);
            }
        }

    }
}
