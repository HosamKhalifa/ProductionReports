using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using CoreLib.Xpo;

namespace CoreModel
{
    [Persistent(@"COMB_TB")]
    public class CombinationTable : XPLiteObjectExt
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.CombinationTable;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = @"COMB_TB";

        public CombinationTable(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            CombinationId = SysSequence.NextVal(Session, MyEnums.SysSequence.COMB_ID_SEQU, (1000 * 1000));
            base.AfterConstruction();
        }
        #region Methods
       /* public static CombinationTable FindOrCreateCombination( MainAccount _mainAccount,
                                                                string _detAccountDim="",
                                                                string _LocationDim = "", 
                                                                string _DepartmentDim="",
                                                                string _ProjectDim="",
                                                                string _PurposeDim="",
                                                                string _EquipmentDim="",
                                                                string _BusinessPartner=""
                                                               )
        {
            CombinationTable combination;
            return combination;
        }*/
        #endregion
        #region Fields
        long fCombinationId;
        [Persistent(@"COMB_ID"), Key]
        public long CombinationId
        {
            get { return fCombinationId; }
            set { SetPropertyValue<long>("CombinationId", ref fCombinationId, value); }
        }
        CombinationHeader fGLCombinationId;
        [Persistent(@"GL_COMB_ID")]
        [Association(@"COMB_HEADER_COMB_TABLE_FK")]
        public CombinationHeader GLCombinationId
        {
            get { return fGLCombinationId; }
            set { SetPropertyValue<CombinationHeader>("GLCombinationId", ref fGLCombinationId, value); }
        }
        string fLocationDim;
        [Persistent(@"LOC_DIM"), Size(9)]
        public string LocationDim
        {
            get { return fLocationDim; }
            set { SetPropertyValue<string>("LocationDim", ref fLocationDim, value); }
        }

        string fDepartmentDim;
        [Persistent(@"DEPT_DIM"), Size(9)]
        public string DepartmentDim
        {
            get { return fDepartmentDim; }
            set { SetPropertyValue<string>("DepartmentDim", ref fDepartmentDim, value); }
        }
        string fProjectDim;
        [Persistent(@"PROJ_DIM"), Size(9)]
        public string ProjectDim
        {
            get { return fProjectDim; }
            set { SetPropertyValue<string>("ProjectDim", ref fProjectDim, value); }
        }

        string fPurposeDim;
        [Persistent(@"PURPOSE_DIM"), Size(9)]
        public string PurposeDim
        {
            get { return fPurposeDim; }
            set { SetPropertyValue<string>("PurposeDim", ref fPurposeDim, value); }
        }

        string fEquipmentDim;
        [Persistent(@"EQUIPMENT_DIM"), Size(9)]
        public string EquipmentDim
        {
            get { return fEquipmentDim; }
            set { SetPropertyValue<string>("EquipmentDim", ref fEquipmentDim, value); }
        }
        string fBusinessPartenerDim;
        [Persistent(@"BP_DIM"),Size(9)]
        public string BusinessPartenerDim
        {
            get { return fBusinessPartenerDim; }
            set { SetPropertyValue<string>("BusinessPartenerDim", ref fBusinessPartenerDim, value); }
        }

        #endregion
    }
}
