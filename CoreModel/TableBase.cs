using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.Xpo;
namespace CoreModel
{
    [Persistent(@"TABLE_BASE")]
    public class TableBase :XPLiteObjectExt
    {
        public TableBase(Session session) : base(session) { }
        public override void AfterConstruction()
        {

            base.AfterConstruction();
        }
        int fTableId;
        #region Fields


        [Persistent(@"TABLE_ID"),Key]
        public int TableId
        {
            get { return fTableId; }
            set { SetPropertyValue<int>("TableId", ref fTableId, value); }
        }

        string fTableDBName;
        [Persistent(@"TABLE_DBNAME"),Size(30)]
        public string TableDBName
        {
            get { return fTableDBName; }
            set { SetPropertyValue<string>("TableDBName", ref fTableDBName, value); }
        }
        string fTableName;
        [Persistent(@"TABLE_NAME"),Size(150)]
        public string TableName
        {
            get { return fTableName; }
            set { SetPropertyValue<string>("TableName", ref fTableName, value); }
        }

        string fTableDescription;
        [Persistent(@"TABLE_DESCRIPTION"),Size(250)]
        public string TableDescription
        {
            get { return fTableDescription; }
            set { SetPropertyValue<string>("TableDescription", ref fTableDescription, value); }
        }
        MyEnums.TableType fTableType;
        [Persistent(@"TABLE_TYPE"),Size(20)]
        public MyEnums.TableType TableType
        {
            get { return fTableType; }
            set { SetPropertyValue<MyEnums.TableType>("TableType", ref fTableType, value); }
        }

        string fDimensionPrefix;
        [Persistent(@"DIM_PREFIX"),Size(2)]
        public string DimensionPrefix
        {
            get { return fDimensionPrefix; }
            set { SetPropertyValue<string>("DimensionPrefix", ref fDimensionPrefix, value); }
        }

        int fLastIndex;
        [Persistent(@"LAST_INDEX")]
        public int LastIndex
        {
            get { return fLastIndex; }
            set { SetPropertyValue<int>("LastIndex", ref fLastIndex, value); }
        }
        
        long fSequId;
        [Persistent("SEQU_ID")]
        public long SequId
        {
            get { return fSequId; }
            set { SetPropertyValue<long>("SequId", ref fSequId, value); }
        }



        #endregion

        [Association("TableBase-Line")]
        public XPCollection<Line> TableLines{ get{ return GetCollection<Line>("TableLines"); } }

        #region Classes
        public class TableInfo
        {
            public int TableId { get; set; }
            public string Name { get; set; }
            public string DBName { get; set; }
            public MyEnums.TableType TableType { get; set; }
        }

        #endregion


        #region Methods
        private static List<TableInfo> GetTablesBasicInfo()
        {
            List<TableInfo> tables = new List<TableInfo>()
            {
                new TableInfo() {TableId=1111,Name=typeof(AccountGroup).Name,DBName = AccountGroup.TABLE_NAME ,TableType=MyEnums.TableType.Master},
                new TableInfo() {TableId=1112,Name=typeof(Sequence).Name,DBName=Sequence.TABLE_NAME,TableType=MyEnums.TableType.System },
                new TableInfo() {TableId=1113,Name=typeof(AccountRef1).Name,DBName=AccountRef1.TABLE_NAME,TableType=MyEnums.TableType.Master },
                new TableInfo() {TableId=1114,Name=typeof(AccountRef2).Name,DBName=AccountRef2.TABLE_NAME,TableType=MyEnums.TableType.Master},
                new TableInfo() {TableId=1115,Name=typeof(Customer).Name,DBName=Customer.TABLE_NAME,TableType=MyEnums.TableType.Master}
            };
            return tables;

        }
        public static void TableBaseRowsBuilder(UnitOfWork session)//Create ddb rows for each Persistent calss 
        {

            var tabList = GetTablesBasicInfo();
            foreach (var tab in tabList)
            {
                //Search if Table is existed in DB
                var dbTabRow = session.GetObjectByKey<TableBase>(tab.TableId);
                if(dbTabRow == null)
                {
                    TableBase t = new TableBase(session)
                    {
                        TableId = tab.TableId,
                        TableName = tab.Name,
                        TableDBName = tab.DBName,
                        TableType = tab.TableType
                    };
                    t.Save();
                }
            }
            session.CommitTransaction();
        }
        #endregion


    }
  


}
