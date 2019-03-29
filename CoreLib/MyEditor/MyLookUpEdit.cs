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
    [UserRepositoryItem("RegisterMyLookUpEdit")]
    public class RepositoryItemMyLookUpEdit : RepositoryItemLookUpEdit
    {
        static RepositoryItemMyLookUpEdit()
        {
            RegisterMyLookUpEdit();
        }

        public const string CustomEditName = "MyLookUpEdit";

        public RepositoryItemMyLookUpEdit()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterMyLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(MyLookUpEdit), typeof(RepositoryItemMyLookUpEdit), typeof(MyLookUpEditViewInfo), new MyLookUpEditPainter(), true, img));
            
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemMyLookUpEdit source = item as RepositoryItemMyLookUpEdit;
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
    public class MyLookUpEdit : LookUpEdit
    {
        static MyLookUpEdit()
        {
            RepositoryItemMyLookUpEdit.RegisterMyLookUpEdit();
        }

        public MyLookUpEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyLookUpEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemMyLookUpEdit;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemMyLookUpEdit.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new MyLookUpEditPopupForm(this);
        }
    }

    public class MyLookUpEditViewInfo : LookUpEditViewInfo
    {
        public MyLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class MyLookUpEditPainter : ButtonEditPainter
    {
        public MyLookUpEditPainter()
        {
        }
    }

    public class MyLookUpEditPopupForm : PopupLookUpEditForm
    {
        public MyLookUpEditPopupForm(MyLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
