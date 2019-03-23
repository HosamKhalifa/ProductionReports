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
    [UserRepositoryItem("RegisterMyDateEdit")]
    public class RepositoryItemMyDateEdit : RepositoryItemDateEdit
    {
        static RepositoryItemMyDateEdit()
        {
            RegisterMyDateEdit();
        }

        public const string CustomEditName = "MyDateEdit";

        public RepositoryItemMyDateEdit()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterMyDateEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(MyDateEdit), typeof(RepositoryItemMyDateEdit), typeof(MyDateEditViewInfo), new MyDateEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemMyDateEdit source = item as RepositoryItemMyDateEdit;
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
    public class MyDateEdit : DateEdit
    {
        static MyDateEdit()
        {
            RepositoryItemMyDateEdit.RegisterMyDateEdit();
        }

        public MyDateEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyDateEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemMyDateEdit;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemMyDateEdit.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new MyDateEditPopupForm(this);
        }
    }

    public class MyDateEditViewInfo : DateEditViewInfo
    {
        public MyDateEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class MyDateEditPainter : ButtonEditPainter
    {
        public MyDateEditPainter()
        {
        }
    }

    public class MyDateEditPopupForm : PopupDateEditForm
    {
        public MyDateEditPopupForm(MyDateEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
