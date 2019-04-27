using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"CITY_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class City : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.City;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public City(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.City);
            base.AfterConstruction();
        }
        Province fProvince;
        [Persistent(@"PROVINCE")]
        [Association(@"PROVINCE_CITY_FK")]
        public Province Province
        {
            get { return fProvince; }
            set { SetPropertyValue<Province>("Province", ref fProvince, value); }
        }
        string fCityCode;
        [Persistent(@"CITY_CODE"),Size(7)]
        [Indexed(Name ="CITY_CODE_UQ",Unique =true)]
        public string CityCode
        {
            get { return fCityCode; }
            set { SetPropertyValue<string>("CityCode", ref fCityCode, value); }
        }
        string fCityName;
        [Persistent(@"CITY_NAME"),Size(100)]
        public string CityName
        {
            get { return fCityName; }
            set { SetPropertyValue<string>("CityName", ref fCityName, value); }
        }

    }
}
