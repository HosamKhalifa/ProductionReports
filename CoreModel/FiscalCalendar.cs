using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"FISCAL_CALENDER")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class FiscalCalendar : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.FiscalCalendar;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public FiscalCalendar(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.FiscalCalendar);
            base.AfterConstruction();
        }

        string fCalenderId;
        [Persistent(@"CALENDER_ID"), Size(4)]
        [Indexed(Name ="FISCAL_CALENDER_ID_UQ",Unique =true)]
        public string CalenderId
        {
            get { return fCalenderId; }
            set { SetPropertyValue<string>("CalenderId", ref fCalenderId, value); }
        }
        string fCalenderDescription;
        [Persistent(@"CALENDER_DESC"), Size(150)]
        public string CalenderDescription
        {
            get { return fCalenderDescription; }
            set { SetPropertyValue<string>("CalenderDescription", ref fCalenderDescription, value); }
        }

        #region Association
        [Association(@"FISCAL_CAL_YEAR_FK")]
        public XPCollection<FiscalCalenderYear> CalenderYears {  get { return GetCollection<FiscalCalenderYear>("CalenderYears"); } }
        #endregion

    }
}
