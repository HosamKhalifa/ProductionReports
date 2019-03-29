using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;

namespace CoreLib.MyEditor
{
    [UserRepositoryItem("RegisterMySearchLookUpEdit")]
    public class RepositoryItemMySearchLookUpEdit : RepositoryItemSearchLookUpEdit
    {
        static RepositoryItemMySearchLookUpEdit()
        {
            RegisterMySearchLookUpEdit();
        }

        public const string CustomEditName = "MySearchLookUpEdit";

        public RepositoryItemMySearchLookUpEdit()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterMySearchLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(MySearchLookUpEdit), typeof(RepositoryItemMySearchLookUpEdit), typeof(MySearchLookUpEditViewInfo), new MySearchLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemMySearchLookUpEdit source = item as RepositoryItemMySearchLookUpEdit;
                if (source == null) return;
                //
                
            }
            finally
            {
                EndUpdate();
            }
        }
    }

    [ToolboxItem(true)]
    public class MySearchLookUpEdit : SearchLookUpEdit
    {
        static MySearchLookUpEdit()
        {
            RepositoryItemMySearchLookUpEdit.RegisterMySearchLookUpEdit();
        }

        public MySearchLookUpEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMySearchLookUpEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemMySearchLookUpEdit;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemMySearchLookUpEdit.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new MySearchLookUpEditPopupForm(this);
        }
    }

    public class MySearchLookUpEditViewInfo : SearchLookUpEditBaseViewInfo
    {
        public MySearchLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
              
        }
    }

    public class MySearchLookUpEditPainter : ButtonEditPainter
    {
        public MySearchLookUpEditPainter()
        {
        }
    }

    public class MySearchLookUpEditPopupForm : PopupSearchLookUpEditForm
    {
        public MySearchLookUpEditPopupForm(MySearchLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
