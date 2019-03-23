using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class MyFormLayoutPersist
    {

        public MyFormLayoutPersist(MyForm frm)
        {
            if(frm.FormWorkspaceManager == null) { frm.FormWorkspaceManager = new WorkspaceManager(); }

            frm.FormWorkspaceManager.TargetControl                  = frm;
            frm.FormWorkspaceManager.CloseStreamOnWorkspaceSaving   = DevExpress.Utils.DefaultBoolean.True;
            frm.FormWorkspaceManager.CloseStreamOnWorkspaceLoading  = DevExpress.Utils.DefaultBoolean.True;
            frm.FormWorkspaceManager.CaptureWorkspace("Default");
            frm.FormWorkspaceManager.TransitionType                 = new DevExpress.Utils.Animation.PushTransition();

        }

    }
}
