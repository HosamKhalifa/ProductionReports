using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"WFLOW")]
    public class Workflow : Line
    {
        public static string TABLE_NAME = @"WFLOW";
        public Workflow(Session session) : base(session)
        {

        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Workflow);
            base.AfterConstruction();
        }
        string fWorkflowName;
        [Persistent(@"WFLOW_NAME")]
        public string WorkflowName
        {
            get { return fWorkflowName; }
            set { SetPropertyValue<string>("WorkflowName", ref fWorkflowName, value); }
        }

        string fWorkflowDescription;
        [Persistent(@"WFLOW_DESC")]
        public string WorkflowDescription
        {
            get { return fWorkflowDescription; }
            set { SetPropertyValue<string>("WorkflowDescription", ref fWorkflowDescription, value); }
        }

    }
}
