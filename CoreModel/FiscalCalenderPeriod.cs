using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"FISCAL_CALENDER_PERIOD")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class FiscalCalenderPeriod : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.FiscalCalenderPeriod;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public FiscalCalenderPeriod(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.FiscalCalenderPeriod);
            base.AfterConstruction();
        }
        protected override bool Validate()
        {
            return base.Validate() && StartDate <= EndDate ;
        }
        FiscalCalenderYear fFiscalCalenderYear;
       // [Indexed( "PERIOD_NAME",Name ="FISCAL_YEAR_PERIOD_NAME_UQ",Unique =true)]
        [Persistent(@"FISCAL_CALENDER_YEAR")]
        [Association(@"FISCAL_YEAR_PERIOD_FK")]
        public FiscalCalenderYear FiscalCalenderYear
        {
            get { return fFiscalCalenderYear; }
            set { SetPropertyValue<FiscalCalenderYear>("FiscalCalenderYear", ref fFiscalCalenderYear, value); }
        }
        MyEnums.FiscalPeriodQuarter fFiscalPeriodQuarter;
        [Persistent(@"PERIOD_QUARTER")]
        public MyEnums.FiscalPeriodQuarter FiscalPeriodQuarter
        {
            get { return fFiscalPeriodQuarter; }
            set { SetPropertyValue<MyEnums.FiscalPeriodQuarter>("FiscalPeriodQuarter", ref fFiscalPeriodQuarter, value); }
        }
        MyEnums.FiscalPeriodMonth fFiscalPeriodMonth;
        [Persistent(@"PERIOD_MONTH")]
        public MyEnums.FiscalPeriodMonth FiscalPeriodMonth
        {
            get { return fFiscalPeriodMonth; }
            set { SetPropertyValue<MyEnums.FiscalPeriodMonth>("FiscalPeriodMonth", ref fFiscalPeriodMonth, value); }
        }
        MyEnums.FiscalPeriodType fFiscalPeriodType;
        [Persistent(@"PERIOD_TYPE")]
        public MyEnums.FiscalPeriodType FiscalPeriodType
        {
            get { return fFiscalPeriodType; }
            set { SetPropertyValue<MyEnums.FiscalPeriodType>("FiscalPeriodType", ref fFiscalPeriodType, value); }
        }
        string fFiscalPeriodName;
        [Persistent(@"PERIOD_NAME"),Size(30)]
        public string FiscalPeriodName
        {
            get { return fFiscalPeriodName; }
            set { SetPropertyValue<string>("FiscalPeriodName", ref fFiscalPeriodName, value); }
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

    }

}
