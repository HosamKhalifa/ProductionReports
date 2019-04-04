using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"FISCAL_CALENDER_YEAR")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class FiscalCalenderYear : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.FiscalCalenderYear;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public FiscalCalenderYear(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        protected override bool Validate()
        {

            return base.Validate() && StartDate <= EndDate;
        }
        FiscalCalendar fFiscalCalendar;
        [Persistent(@"FISCAL_CALENDER")]
        [Association(@"FISCAL_CAL_YEAR_FK")]
        public FiscalCalendar FiscalCalendar
        {
            get { return fFiscalCalendar; }
            set { SetPropertyValue<FiscalCalendar>("FiscalCalendar", ref fFiscalCalendar, value); }
        }
        string fYearName;
        [Persistent(@"YEAR_NAME"),Size(10)]
        [Indexed(Name ="FISCAL_YEAR_UQ",Unique =true)]
        public string YearName
        {
            get { return fYearName; }
            set { SetPropertyValue<string>("YearName", ref fYearName, value); }
        }

        DateTime fStartDate;
        [Persistent(@"START_DATE")]
        public DateTime StartDate
        {
            get { return fStartDate; }
            set { SetPropertyValue<DateTime>("StartDate", ref fStartDate, value); }
        }
        DateTime fEndDate;
        [Persistent(@"END_DATE")]
        public DateTime EndDate
        {
            get { return fEndDate; }
            set { SetPropertyValue<DateTime>("EndDate", ref fEndDate, value); }
        }
        #region Association
        [Association(@"FISCAL_YEAR_PERIOD_FK")]
        public XPCollection<FiscalCalenderPeriod> YearPeriods { get { return GetCollection<FiscalCalenderPeriod>("YearPeriods"); } }
        #endregion
    }
}
