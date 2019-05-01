using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"WFLOW")]
    public class Workflow : XPLiteObject
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Workflow;
        public static MyEnums.TableType TableType = MyEnums.TableType.System;
        public Workflow(Session session) : base(session)
        {

        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

        }
        
        #region Methods
        public static void BuildTableRows(UnitOfWork session)
        {
            var DimList = GetList();
            foreach (WorkflowInfo item in DimList)
            {
                var dbTabRow = session.GetObjectByKey<Workflow>((int)item.StatusId);
                if (dbTabRow == null)
                {
                    dbTabRow = new Workflow(session)
                    {
                        WorkflowStatus = (int)item.StatusId,
                        WorkflowName=item.Name,
                        WorkflowDescription=item.Description
                    };
                    dbTabRow.Save();
                }
            }
            session.CommitChanges();
        }
        class WorkflowInfo
        {
            public MyEnums.WorkflowStatus StatusId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public MyEnums.WorkflowTarget WorkflowTarget { get; set; }
        }
        static List<WorkflowInfo> GetList()
        {
            var lst = new List<WorkflowInfo>()
            {
                new WorkflowInfo() {StatusId= MyEnums.WorkflowStatus.Draft,Name="Draft",Description="Draft is the inital status for newly created document" },
                new WorkflowInfo() {StatusId=MyEnums.WorkflowStatus.ReadyForApprove,Name="ReadyForApprove",Description="Ready for apporve is the status when document pass vaidation and then will be ready to starting approve rules application"},
                new WorkflowInfo() {StatusId=MyEnums.WorkflowStatus.Approving,Name="Approving",Description="Approving after first approve action applied to the document and still til Last required approve happened" },
                new WorkflowInfo() {StatusId=MyEnums.WorkflowStatus.Approved,Name="Approved",Description="After all approve cycle member signed the document " },
                new WorkflowInfo() {StatusId=MyEnums.WorkflowStatus.Posted,Name="Posted",Description="Can not changed after posted and could not reject" },
                new WorkflowInfo() {StatusId=MyEnums.WorkflowStatus.Rejected,Name="Rejected",Description="These option will return document to Whom take ReadyForApprove action and need to change status to Draft to be able modify it" }
            };
            return lst;                
        }
        #endregion

        #region Fields


        int fWorkflowStatus;
        [Persistent(@"WFLOW_STATUS"),Key]
        public int WorkflowStatus
        {
            get { return fWorkflowStatus; }
            set { SetPropertyValue<int>("WorkflowStatus", ref fWorkflowStatus, value); }
        }
        string fWorkflowName;
        [Persistent(@"WFLOW_NAME")]
        public string WorkflowName
        {
            get { return fWorkflowName; }
            set { SetPropertyValue<string>("WorkflowName", ref fWorkflowName, value); }
        }

        string fWorkflowDescription;
        [Persistent(@"WFLOW_DESC"),Size(200)]
        public string WorkflowDescription
        {
            get { return fWorkflowDescription; }
            set { SetPropertyValue<string>("WorkflowDescription", ref fWorkflowDescription, value); }
        }

       


        #endregion

     


    }
}
