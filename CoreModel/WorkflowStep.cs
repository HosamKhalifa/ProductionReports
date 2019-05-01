using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"WFLOW_STEPS")]
    public class WorkflowStep : XPObject
    {
        protected WorkflowStep(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        MyEnums.WorkflowStep fWorkflowStepId;
        [Persistent(@"WFLOW_STEP_ID")]

        public MyEnums.WorkflowStep WorkflowStepId
        {
            get { return fWorkflowStepId; }
            set { SetPropertyValue<MyEnums.WorkflowStep>("WorkflowStepId", ref fWorkflowStepId, value); }
        }
        string fWorkflowStepName;
        [Persistent(@"WFLOW_STEP_NAME"),Size(30)]
        public string WorkflowStepName
        {
            get { return fWorkflowStepName; }
            set { SetPropertyValue<string>("WorkflowStepName", ref fWorkflowStepName, value); }
        }

        MyEnums.WorkflowTarget fWorkflowTarget;
        [Persistent(@"WFLOW_TARGET")]
        public MyEnums.WorkflowTarget WorkflowTarget
        {
            get { return fWorkflowTarget; }
            set { SetPropertyValue<MyEnums.WorkflowTarget>("WorkflowTarget", ref fWorkflowTarget, value); }
        }

        MyEnums.WorkflowStatus  fCurrentWorkflow;
        [Persistent(@"CURR_WFLOW")]
        public MyEnums.WorkflowStatus CurrentWorkflow
        {
            get { return fCurrentWorkflow; }
            set { SetPropertyValue<MyEnums.WorkflowStatus>("CurrentWorkflow", ref fCurrentWorkflow, value); }
        }
        MyEnums.WorkflowStatus fNextWorkflow;
        [Persistent(@"NEXT_WFLOW")]
        public MyEnums.WorkflowStatus NextWorkflow
        {
            get { return fNextWorkflow; }
            set { SetPropertyValue<MyEnums.WorkflowStatus>("NextWorkflow", ref fNextWorkflow, value); }
        }

        public static void BuildTableRows(Session _uOW)
        {
            foreach (var item in GetList())
            {
                var dbLine = _uOW.FindObject<WorkflowStep>(CriteriaOperator.Parse("[WorkflowStepId] = ? AND [CurrentWorkflow] = ?", item.WorkflowStepId, item.CurrentWorkflow));
                if(dbLine == null)
                {
                    dbLine = new WorkflowStep(_uOW)
                    {
                        WorkflowStepId = item.WorkflowStepId,
                        WorkflowStepName=item.WorkflowStepName,
                        WorkflowTarget=item.Target,
                        CurrentWorkflow = item.CurrentWorkflow,
                        NextWorkflow=item.NextWorkflow
                    };
                    dbLine.Save();
                }
            }
            _uOW.CommitTransaction();
        }

        class WorkflowStepInfo
        {
            public MyEnums.WorkflowStep WorkflowStepId { get; set; }
            public string WorkflowStepName { get; set; }
            public MyEnums.WorkflowTarget Target { get; set; }
            public MyEnums.WorkflowStatus CurrentWorkflow { get; set; }
            public MyEnums.WorkflowStatus  NextWorkflow { get; set; }

        }
        static List<WorkflowStepInfo> GetList()
        {
            return  new List<WorkflowStepInfo>()
            {
                //Account actions
                //====================================================================================================
                //Make it ready
                new WorkflowStepInfo() {Target = MyEnums.WorkflowTarget.Account,
                                        WorkflowStepId = MyEnums.WorkflowStep.MakeItReady,
                                        WorkflowStepName = "MakeItReady",
                                        CurrentWorkflow = MyEnums.WorkflowStatus.Draft,
                                        NextWorkflow = MyEnums.WorkflowStatus.ReadyForApprove
                                        },
                //Approve
                new WorkflowStepInfo(){Target = MyEnums.WorkflowTarget.Account,
                                       WorkflowStepId = MyEnums.WorkflowStep.Approve ,
                                       WorkflowStepName="Approve",
                                       CurrentWorkflow=MyEnums.WorkflowStatus.ReadyForApprove,
                                       NextWorkflow=MyEnums.WorkflowStatus.Approved
                                      },
                //Reopen
                new WorkflowStepInfo(){Target= MyEnums.WorkflowTarget.Account,
                                       WorkflowStepId=MyEnums.WorkflowStep.Reopen,
                                       WorkflowStepName="Reopen",
                                       CurrentWorkflow=MyEnums.WorkflowStatus.Approved,
                                       NextWorkflow=MyEnums.WorkflowStatus.Draft
                                      },
//Document actions
                //====================================================================================================
                //Make it ready
                new WorkflowStepInfo() {Target = MyEnums.WorkflowTarget.Document,
                                        WorkflowStepId = MyEnums.WorkflowStep.MakeItReady,
                                        WorkflowStepName = "ReadyForApprove",
                                        CurrentWorkflow = MyEnums.WorkflowStatus.Draft,
                                        NextWorkflow = MyEnums.WorkflowStatus.ReadyForApprove
                                        },
                //Approve
                new WorkflowStepInfo(){Target = MyEnums.WorkflowTarget.Document,
                                       WorkflowStepId = MyEnums.WorkflowStep.Approve ,
                                       WorkflowStepName="Approve",
                                       CurrentWorkflow=MyEnums.WorkflowStatus.ReadyForApprove,
                                       NextWorkflow=MyEnums.WorkflowStatus.Approving
                                      },
                //Reject approved
                new WorkflowStepInfo(){Target= MyEnums.WorkflowTarget.Document,
                                       WorkflowStepId=MyEnums.WorkflowStep.Reject,
                                       WorkflowStepName="Reject approved",
                                       CurrentWorkflow=MyEnums.WorkflowStatus.Approved,
                                       NextWorkflow=MyEnums.WorkflowStatus.Draft
                                      },
                //Reject approving
                new WorkflowStepInfo(){Target= MyEnums.WorkflowTarget.Document,
                                       WorkflowStepId=MyEnums.WorkflowStep.Reject,
                                       WorkflowStepName="Reject approving",
                                       CurrentWorkflow=MyEnums.WorkflowStatus.Approving,
                                       NextWorkflow=MyEnums.WorkflowStatus.Draft
                                      },
                //Post
                new WorkflowStepInfo(){Target= MyEnums.WorkflowTarget.Document,
                                       WorkflowStepId=MyEnums.WorkflowStep.Post,
                                       WorkflowStepName="Post approved",
                                       CurrentWorkflow=MyEnums.WorkflowStatus.Approved,
                                       NextWorkflow=MyEnums.WorkflowStatus.Posted
                                      }

            };
        }


    }
}
