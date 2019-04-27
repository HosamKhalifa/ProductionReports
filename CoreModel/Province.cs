using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"PROVINCE_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Province : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Province;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public Province(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Province);
            base.AfterConstruction();
        }

        Country fProvinceCountry;
        [Persistent(@"PROVINCE_COUNTRY")]
        [Association(@"COUNTRY_PROVINCE_FK")]
        public Country ProvinceCountry
        {
            get { return fProvinceCountry; }
            set { SetPropertyValue<Country>("ProvinceCountry", ref fProvinceCountry, value); }
        }
        string fProvinceCode;
        [Persistent(@"PROVINCE_CODE"), Size(7)]
        [Indexed(Name = "PROVINCE_CODE_UQ", Unique = true)]
        public string ProvinceCode
        {
            get { return fProvinceCode; }
            set { SetPropertyValue<string>("ProvinceCode", ref fProvinceCode, value); }
        }
        string fProvinceName;
        [Persistent(@"PROVINCE_NAME"), Size(100)]
        public string ProvinceName
        {
            get { return fProvinceName; }
            set { SetPropertyValue<string>("ProvinceName", ref fProvinceName, value); }
        }
        #region Association
        [Association(@"PROVINCE_CITY_FK")]
        public XPCollection<City> Cities { get { return GetCollection<City>("Cities"); } }
        #endregion

    }

}
