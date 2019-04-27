using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.Xpo;
using DevExpress.Xpo.Metadata;
using System.Reflection;
using CoreLib;

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
        #region Members
        public enum TableEnum
        {
            AccountGroup=1111, Sequence=1112, AccountRef1=1113, AccountRef2=1114,
            Customer=1115, MainAccountType=1116, MainAccount=1117, JournalBase=1118,
            AddressBook=1119, CombinationHeader=1120, CombinationTable=1121, 
            DocumentTypeAccounts=1122, SequenceValues=1123, TaxAgency=1124,TaxGroup=1125,
            Workflow=1126,Vendor=1127,Employee=1128,Department=1129,Location=1130,
            Project=1131,Purpose, Service =1133, Currency = 1134,
            CurrencyPair=1135, CurrencyPairExchangeRate= 1136,Ledger = 1137,
            FiscalCalendar = 1138, FiscalCalenderYear=1139, FiscalCalenderPeriod=1140,
            LedgerChartOfAccounts = 1141,Equipment=1142,
            FixedAsset = 1143, Item = 1144, DimensionBase=1145,DimensionHeader=1146,
            Country=1147,City=1148,Province=1149
        }
        #endregion

        #region Fields
        int fTableId;
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
        string fClassName;
        [Persistent(@"CLASS_NAME")]
        public string ClassName
        {
            get { return fClassName; }
            set { SetPropertyValue<string>("ClassName", ref fClassName, value); }
        }
        string fAssemblyName;
        [Persistent(@"ASSEMBLY_NAME")]
        public string AssemblyName
        {
            get { return fAssemblyName; }
            set { SetPropertyValue<string>("AssemblyName", ref fAssemblyName, value); }
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
            public string ClassName { get; set; }
            public string AssemblyName { get; set; }
            public MyEnums.TableType TableType { get; set; }
            public string DimensionPrefix { get; set; }
        }
        public class DimPrefixEnum
        {
            public static string GetTableDimPrefix(TableEnum _table)
            {

                var lst = typeof(DimPrefixEnum).GetProperties().Where(x => x.Name == Enum.GetName(typeof(TableEnum), _table)).FirstOrDefault();
                if(lst != null)
                {

                    var ret =  lst.GetValue(null).ToString();
                    return ret;
                }
                else
                {
                    return EmptyDimPrefix;
                }
            }
            public static string EmptyDimPrefix { get { return "@"; } }
            public static string MainAccount{ get { return "FA"; } }
            public static string Customer { get { return "CU"; } }
            public static string Vendor { get { return "VE"; } }
            public static string Employee { get { return "EM"; } }
            public static string Department { get { return "DT"; } }
            public static string Location { get { return "LC"; } }
            public static string Project { get { return "PJ"; } }
            public static string Purpose { get { return "PR"; } }
            public static string Item { get { return "IT"; } }
            public static string Service { get { return "SR"; } }
            public static string FixedAsset { get { return "FX"; } }
            public static string Equipment { get { return "EQ"; } }
            
            

        }
        #endregion


        #region Methods
        public static TableBase GetTable(Session session,TableEnum _table)
        {
            return  session.GetObjectByKey<TableBase>((int)_table);
        }
        [Obsolete]
        public string NextDimValue()
        {
            if (string.IsNullOrEmpty(DimensionPrefix))
            {
                return "";
            }
            string dimVal = DimensionPrefix;
            this.LastIndex += 1;
            dimVal = dimVal + LastIndex.ToString().PadLeft((9 - this.DimensionPrefix.Length), '0');
            return dimVal; 
        }
        public static string GetTableAttribute(Type _className)
        {
            XPClassInfo cinfo = XpoDefault.Session.GetClassInfo(_className);
            var tabAttr = cinfo.FindAttributeInfo(typeof(PersistentAttribute)).ToString();
            return cinfo.TableName;
            
        }
       
        private static List<TableInfo> GetTablesBasicInfo()
        {
            List<TableInfo> tables = new List<TableInfo>();
            XPDictionary dict = new ReflectionDictionary();
            
                var assemblyInstance = GlobalMethods.GetAssemblyByName("CoreModel");

                dict.CollectClassInfos(assemblyInstance);

                foreach (XPClassInfo item in dict.Classes)
                {
                if (item.ClassType == typeof(TableBase)) continue;
                var tableNameProp = item.ClassType.GetField("TableName");
                var tableTypeProp = item.ClassType.GetField("TableType");
                    if (item.IsPersistent 
                        && tableNameProp != null
                        && tableTypeProp != null)
                {
                    var tn = tableNameProp.GetValue(null);
                    var tt = tableTypeProp.GetValue(null);
                    if(tn != null && tt != null)
                    {
                        var le_TableName = (TableEnum)tn;
                        var le_TableType = (MyEnums.TableType)tt;
                        var info = ReadClassInfo(item.ClassType,le_TableName,le_TableType);
                        tables.Add(info);
                    }
                }

                }

            return tables;

        }

        private static TableInfo ReadClassInfo(Type _type, TableEnum le_TableName, MyEnums.TableType le_TableType)
        {
            TableInfo ret = new TableInfo();
            

            //var TableNameProp = _type.GetProperty("TableName");
            //var tableName = (TableEnum)TableNameProp.GetValue(null);
            ret.TableId = (int)le_TableName;

            ret.Name = _type.Name;
            ret.DBName = GetTableAttribute(_type);

            //var tableTypeProp = _type.GetProperty("TableType");
            //var tableType = tableTypeProp.GetValue(null);
            ret.TableType = (MyEnums.TableType)le_TableType;

            ret.DimensionPrefix = DimPrefixEnum.GetTableDimPrefix(le_TableName);
            ret.AssemblyName = _type.Assembly.FullName;
            ret.ClassName = _type.Name;

            return ret;
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
                        TableType = tab.TableType,
                        DimensionPrefix=tab.DimensionPrefix,
                        LastIndex=0,
                        ClassName=tab.ClassName,
                        AssemblyName=tab.AssemblyName
                        
                    };
                    t.Save();
                }
            }
            session.CommitTransaction();
        }
        #endregion


    }
  


}
