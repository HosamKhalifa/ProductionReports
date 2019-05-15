using CoreLib.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoreLib.Label
{
    public class UIObjectBase : XPObject
    {
        public UIObjectBase(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        #region Methods
        public UILabel FindOrCreateUILabel(string _fieldName)
        {
            UILabel l = ObjectLabels.Where(x => x.FieldName == _fieldName ).FirstOrDefault();
            if(l == null) //Create new one
            {
                l = new UILabel(Session)
                {
                    FieldName = _fieldName
                };
                ObjectLabels.Add(l);

                UILabelLang cap = new UILabelLang(Session) { Lang_en = _fieldName, UILabelType = MyEnums.UILabelType.FieldCaption };
                UILabelLang hlp = new UILabelLang(Session) { Lang_en = _fieldName, UILabelType = MyEnums.UILabelType.FieldHelp };
                l.Langs.Add(cap);
                l.Langs.Add(hlp);
                l.Save();
                l.Session.CommitTransaction();
            }
            return l;         
        }
        public static UIObjectBase GetUIObjectByName(Type _type, UnitOfWork _uOW = null)
        {
            return GetUIObjectByName(_type.FullName, _uOW);
        }
        public static UIObjectBase GetUIObjectByName(string _ObjectName, UnitOfWork _uOW = null)
        {
            var sess = _uOW == null ? XpoDefault.Session : _uOW;
            var objectBase = sess.FindObject<CoreLib.Label.UIObjectBase>(new BinaryOperator(new OperandProperty("ObjectName"), new OperandValue(_ObjectName), BinaryOperatorType.Equal));
            return objectBase;
        }
        //Setup labels
        public void SetupGUILabels(DevExpress.XtraGrid.Views.Grid.GridView _list)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in _list.Columns)
            {
                var label = this.ObjectLabels.Where(x => x.ColumnName == item.FieldName).FirstOrDefault();
                if (label != null)
                {
                    item.Caption = label.ChooseValueForCurrentLang(CoreLib.MyEnums.UILabelType.FieldCaption);
                    item.ToolTip = label.ChooseValueForCurrentLang(CoreLib.MyEnums.UILabelType.FieldHelp);
                }
            }
        }
        public void SetupGUILabels(DevExpress.XtraTreeList.TreeList _list)
        {
            foreach (DevExpress.XtraTreeList.Columns.TreeListColumn item in _list.Columns)
            {
                var label = this.ObjectLabels.Where(x => x.ColumnName == item.FieldName).FirstOrDefault();
                if (label != null)
                {
                    item.Caption = label.ChooseValueForCurrentLang(CoreLib.MyEnums.UILabelType.FieldCaption);
                    item.ToolTip = label.ChooseValueForCurrentLang(CoreLib.MyEnums.UILabelType.FieldHelp);
                }
            }
        }
        public void SetupGUILabels(DevExpress.XtraEditors.LookUpEdit _list)
        {
            foreach (DevExpress.XtraEditors.Controls.LookUpColumnInfo item in _list.Properties.Columns)
            {
                var label = this.ObjectLabels.Where(x => x.ColumnName == item.FieldName).FirstOrDefault();
                if (label != null)
                {
                    item.Caption = label.ChooseValueForCurrentLang(CoreLib.MyEnums.UILabelType.FieldCaption);
                }
            }
        }
        public void SetupGUILabels(DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit _list)
        {
            SetupGUILabels(_list.View);
        }
        public void SetupGUILabels(DevExpress.XtraEditors.SearchLookUpEdit _list)
        {
            SetupGUILabels(_list.Properties.View);
        }

        public string LookUpValueMember()
        {
            var valuMember = this.ObjectLabels.Where(x => x.LookupMember == MyEnums.AutoLookUp.ValueMemberHidden ||
                                        x.LookupMember == MyEnums.AutoLookUp.ValueMemberVisiable).FirstOrDefault();
            if(valuMember != null)
            {
                return valuMember.ColumnName;
            }
            else
            {
                return "";
            }
        }
        public string LookUpDisplayMember()
        {
            var displayMember = this.ObjectLabels.Where(x => x.LookupMember == MyEnums.AutoLookUp.DisplayMember1 ).FirstOrDefault();
            if (displayMember != null)
            {
                return displayMember.ColumnName;
            }
            else
            {
                return "";
            }
        }
        #endregion
        string fObjectName;
        [Size(150),Indexed(Name ="UIObjectName_UQ",Unique =true)]
        public string ObjectName
        {
            get { return fObjectName; }
            set { SetPropertyValue<string>("ObjectName", ref fObjectName, value); }
        }
        string fAssemblyName;
        [Size(100)]
        public string AssemblyName
        {
            get { return fAssemblyName; }
            set { SetPropertyValue<string>("AssemblyName", ref fAssemblyName, value); }
        }

       
        [Association("UIObjectBase-UILabels")]
        public XPCollection<UILabel> ObjectLabels { get { return GetCollection<UILabel>("ObjectLabels"); } }
        [NonPersistent]
        public string LookupValueField
        {
            get
            {
                var lookupFieldName = ObjectLabels.Where(x => x.LookupMember == MyEnums.AutoLookUp.ValueMemberHidden ||
                                        x.LookupMember == MyEnums.AutoLookUp.ValueMemberVisiable).FirstOrDefault();
                return lookupFieldName != null ? lookupFieldName.ColumnName : "";
            }
        }
        [NonPersistent]
        public string FriendlyName
        {
            get { return !string.IsNullOrEmpty( ObjectName )?ObjectName.Substring(ObjectName.LastIndexOf('.') + 1):""; }
        }
        public Type ObjectType()
        {
            var a = CoreLib.GlobalMethods.GetAssemblyByName(AssemblyName);
            Type tabType = a.GetType(ObjectName);
            return tabType;
        }


    }
}
