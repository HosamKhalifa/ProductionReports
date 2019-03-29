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
        #region Members
        public enum TableEnum
        {
            AccountGroup=1111, Sequence=1112, AccountRef1=1113, AccountRef2=1114,
            Customer=1115, MainAccountType=1116, MainAccount=1117, JournalBase=1118,
            AddressBook=1119, CombinationHeader=1120, CombinationTable=1121, 
            DocumentTypeAccounts=1122, SequenceValues=1123, TaxAgency=1124,TaxGroup=1125,
            Workflow=1126,Vendor=1127,Employee=1128,Department=1129,Location=1130,
            Project=1131,Purpose,Item=1132, Service =1133, Currency = 1134

        }
        #endregion

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
            public string DimensionPrefix { get; set; }
        }
        public class DimPrefixEnum
        {
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
        }
        #endregion


        #region Methods
        public static TableBase GetTable(Session session,TableEnum _table)
        {
            return  session.GetObjectByKey<TableBase>((int)_table);
        }
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
        private static List<TableInfo> GetTablesBasicInfo()
        {
            List<TableInfo> tables = new List<TableInfo>()
            {
                new TableInfo() {TableId=(int)TableEnum.AccountGroup,Name=typeof(AccountGroup).Name,DBName=AccountGroup.TABLE_NAME,TableType=MyEnums.TableType.System,DimensionPrefix= DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.Sequence,Name=typeof(Sequence).Name,DBName=Sequence.TABLE_NAME,TableType=MyEnums.TableType.System,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.AccountRef1,Name=typeof(AccountRef1).Name,DBName=AccountRef1.TABLE_NAME,TableType=MyEnums.TableType.Master ,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.AccountRef2,Name=typeof(AccountRef2).Name,DBName=AccountRef2.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.Customer,Name=typeof(Customer).Name,DBName=Customer.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.Customer}
                ,new TableInfo() {TableId=(int)TableEnum.MainAccountType,Name=typeof(MainAccountType).Name,DBName=MainAccountType.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.MainAccount,Name=typeof(MainAccount).Name,DBName=MainAccount.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.MainAccount}
                ,new TableInfo() {TableId=(int)TableEnum.JournalBase,Name=typeof(JournalBase).Name,DBName=JournalBase.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.AddressBook,Name=typeof(AddressBook).Name,DBName=AddressBook.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.CombinationHeader,Name=typeof(CombinationHeader).Name,DBName=CombinationHeader.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.CombinationTable,Name=typeof(CombinationTable).Name,DBName=CombinationTable.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.Currency,Name=typeof(Currency).Name,DBName=Currency.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.DocumentTypeAccounts,Name=typeof(DocumentTypeAccounts).Name,DBName=DocumentTypeAccounts.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.SequenceValues,Name=typeof(SequenceValues).Name,DBName=SequenceValues.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.TaxAgency,Name=typeof(TaxAgency).Name,DBName=TaxAgency.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.TaxGroup,Name=typeof(TaxGroup).Name,DBName=TaxGroup.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                ,new TableInfo() {TableId=(int)TableEnum.Workflow,Name=typeof(Workflow).Name,DBName=Workflow.TABLE_NAME,TableType=MyEnums.TableType.Master,DimensionPrefix=DimPrefixEnum.EmptyDimPrefix}
                //,new TableInfo() {TableId=(int)TableEnum.,Name=typeof().Name,DBName=.TABLE_NAME,TableType=MyEnums.TableType.Master}
                //,new TableInfo() {TableId=(int)TableEnum.,Name=typeof().Name,DBName=.TABLE_NAME,TableType=MyEnums.TableType.Master}
                //,new TableInfo() {TableId=(int)TableEnum.,Name=typeof().Name,DBName=.TABLE_NAME,TableType=MyEnums.TableType.Master}
                //,new TableInfo() {TableId=(int)TableEnum.,Name=typeof().Name,DBName=.TABLE_NAME,TableType=MyEnums.TableType.Master}
                //,new TableInfo() {TableId=(int)TableEnum.,Name=typeof().Name,DBName=.TABLE_NAME,TableType=MyEnums.TableType.Master}
                //,new TableInfo() {TableId=(int)TableEnum.,Name=typeof().Name,DBName=.TABLE_NAME,TableType=MyEnums.TableType.Master}
                //,new TableInfo() {TableId=(int)TableEnum.,Name=typeof().Name,DBName=.TABLE_NAME,TableType=MyEnums.TableType.Master}



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
                        TableType = tab.TableType,
                        DimensionPrefix=tab.DimensionPrefix
                    };
                    t.Save();
                }
            }
            session.CommitTransaction();
        }
        #endregion


    }
  


}
