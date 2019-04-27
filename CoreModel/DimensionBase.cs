using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreModel
{
    [Persistent(@"DIMENSION_BASE")]
    public class DimensionBase : XPLiteObject
    {
       
        public DimensionBase(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Methods

        public long NextDimKey()
        {
            long startValue = TableId * 1000 * 1000 * 10;
            long dimValue = SysSequence.NextVal(Session, DimensionSequence, startValue);
            return dimValue;
        }
        public static void TableBaseRowsBuilder(UnitOfWork session)
        {
            List<int> DimList = GetDimList();
            foreach (var item in DimList)
            {
                var tab = (TableBase.TableEnum)item;
                var dbTabRow = session.GetObjectByKey<DimensionBase>(item);
                if(dbTabRow == null)
                {
                    dbTabRow = new DimensionBase(session)
                    {
                        TableId = item,
                        DimensionPrefix =TableBase.DimPrefixEnum.GetTableDimPrefix(tab),
                        DimensionSequence=GetDimSequence(tab)
                    };
                    dbTabRow.Save();
                }
            }
            session.CommitChanges();

        }
        private static List<int> GetDimList()
        {
            var retList = new List<int>()
            {
                (int)TableBase.TableEnum.Employee,
                (int)TableBase.TableEnum.Customer,
                (int)TableBase.TableEnum.Vendor,
                (int)TableBase.TableEnum.Location,
                (int)TableBase.TableEnum.Department,
                (int)TableBase.TableEnum.Project,
                (int)TableBase.TableEnum.Purpose,
                (int)TableBase.TableEnum.Equipment,
                (int)TableBase.TableEnum.FixedAsset,
                (int)TableBase.TableEnum.Item
            };
            return retList;
        }
        private static MyEnums.SysSequence GetDimSequence(TableBase.TableEnum _dimTable)
        {
            MyEnums.SysSequence sequ = MyEnums.SysSequence.None;
            switch (_dimTable)
            {
                case TableBase.TableEnum.Customer:
                    sequ = MyEnums.SysSequence.CUSTOMER_DIM_SEQU;
                    break;
                case TableBase.TableEnum.MainAccount:
                    sequ = MyEnums.SysSequence.MAIN_ACCOUNT_DIM_SEQU;
                    break;
                case TableBase.TableEnum.Vendor:
                    sequ = MyEnums.SysSequence.VENDOR_DIM_SEQU;
                    break;
                case TableBase.TableEnum.Employee:
                    sequ = MyEnums.SysSequence.EMPLOYEE_DIM_SEQU ;
                    break;
                case TableBase.TableEnum.Department:
                    sequ = MyEnums.SysSequence.DEPARTMENT_DIM_SEQU ;
                    break;
                case TableBase.TableEnum.Location:
                    sequ = MyEnums.SysSequence.LOCATION_DIM_SEQU ;
                    break;
                case TableBase.TableEnum.Project:
                    sequ = MyEnums.SysSequence.PROJECT_DIM_SEQU;
                    break;
                case TableBase.TableEnum.Purpose:
                    sequ = MyEnums.SysSequence.PURPOSE_DIM_SEQU ;
                    break;
                case TableBase.TableEnum.Equipment:
                    sequ = MyEnums.SysSequence.EQUIPMENT_DIM_SEQU ;
                    break;
                case TableBase.TableEnum.FixedAsset:
                    sequ = MyEnums.SysSequence.FIXED_ASSET_DIM_SEQU ;
                    break;
                case TableBase.TableEnum.Item:
                    sequ = MyEnums.SysSequence.INVENTORY_DIM_SEQU;
                    break;
                ;
            }
            return sequ;
        }
        public static DimensionHeader FindOrCreateDimHeader(Account _account)
        {
            //CriteriaOperator.Parse("[AccountReferenceObject] = ?",new OperandValue(_account))
            var filter = new BinaryOperator(new OperandProperty("AccountReferenceObject"), new OperandValue(_account), BinaryOperatorType.Equal);
            DimensionHeader dim = _account.Session.FindObject<DimensionHeader>(filter);
            if(dim == null)
            {
                var dimBase = _account.Session.GetObjectByKey<DimensionBase>(_account.TableId.TableId);
                if(dimBase != null)
                {
                    dim = new DimensionHeader(_account.Session)
                    {
                        DimensionBase = dimBase,
                        DimensionKey = dimBase.NextDimKey(),
                        DimDisplayNumber = _account.DisplayNumber,
                        DimSearchName = _account.Name
                    };
                    dim.Save();
                    
                    _account.Session.CommitTransaction();
                }
            }
            return dim;

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
        string fDimensionPrefix;
        [Persistent(@"DIM_PREFIX"),Size(2)]
        public string DimensionPrefix
        {
            get { return fDimensionPrefix; }
            set { SetPropertyValue<string>("DimensionPrefix", ref fDimensionPrefix, value); }
        }
        MyEnums.SysSequence fDimensionSequence;
        [Persistent(@"DIM_SYS_SEQU")]
        public MyEnums.SysSequence DimensionSequence
        {
            get { return fDimensionSequence; }
            set { SetPropertyValue<MyEnums.SysSequence>("DimensionSequence", ref fDimensionSequence, value); }
        }
        #endregion
        
        #region Association
        [Association(@"DIMBASE_DIM_HEADER_FK")]
        public XPCollection<DimensionHeader> DimensionValues { get { return GetCollection<DimensionHeader>("DimensionValues"); } }
        #endregion

    }
}