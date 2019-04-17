using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib.Xpo;
using DevExpress.Xpo;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using CoreLib.SharedExt;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid.Columns;
using System.Drawing;
using CoreLib.Grid;

namespace CoreLib.Label
{
   public class UILabel : XPLiteObjectExt
    {
        //private const string UI_LABEL_ID_SEQU = "UI_LABEL_ID_SEQU";
        private const string SP_NEXT_TASK_LINE = "dbo.sp_Sys_NextValue";
        enum SysSequence { LINE_ID_SEQU = 10, UI_LABEL_SEQU = 20, GL_COMB_ID_SEQU = 30, COMB_ID_SEQU = 40 }
        public UILabel(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            this.fLabelType = MyEnums.UILabelType.FieldCaption;
            this.fLabelId = NextLineVal(this.Session);
            this.Width = 10;//Default column width
            this.fLookupMemberCharWidth = 10;//Default column width


            base.AfterConstruction();
        }
        private static List<JsonLabelDict> jsonLabelDictionery;
        public static List<JsonLabelDict> GetLabelDictionery(string lang=".")
        {
                if (jsonLabelDictionery == null || lang != ".")
                {
                if (lang == ".")
                {
                    lang = string.IsNullOrEmpty(CoreLib.GlobalMethods.UILang) ? "en" : CoreLib.GlobalMethods.UILang;
                }
                   
                    string fileName = $@"{Environment.CurrentDirectory}\label_{lang}.json";
                    if (File.Exists(fileName))
                    {
                        string jsonTxt = File.ReadAllText(fileName);
                        var jsonArray = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<JsonLabelDict>>(jsonTxt);
                        jsonLabelDictionery = jsonArray.ToList();
                    }

                }
            return jsonLabelDictionery;
        }
        public static string ResolveLabelId(string lblId)
        {
            
            var lblRow = GetLabelDictionery().Where(x => x.LabelId == lblId).FirstOrDefault();
            return lblRow != null ? lblRow.LabelName : "";
        }
        public string ChooseValueForCurrentLang(MyEnums.UILabelType _uiLabelType)
        {
            string ret = "";
            //string lang = string.IsNullOrEmpty(CoreLib.GlobalMethods.UILang) ? "en" : CoreLib.GlobalMethods.UILang;
            UILabelLang lblLang = Langs.Where(x => x.UILabelType == _uiLabelType).FirstOrDefault();
            ret = lblLang.Lang;
            return ret;
        }
        public void ApplyFieldSettings(MyGridView gv ,GridColumn grdCol,bool enableAutoFormat)
        {
            //Save Column information in grid column Tag
            GridColumnInfo info = new GridColumnInfo() { ColumnLablel = this };
            grdCol.Tag = info;
           // gv.Columns.Remove()
            gv.Columns[ColumnName].Caption = ChooseValueForCurrentLang(MyEnums.UILabelType.FieldCaption);
            gv.Columns[ColumnName].ToolTip = ChooseValueForCurrentLang(MyEnums.UILabelType.FieldHelp);

            if (!enableAutoFormat) return;//Exit for non formated grid view

            Size columnSize = TextRenderer.MeasureText("".PadLeft(Width, 'A'), grdCol.AppearanceCell.Font);
            gv.Columns[ColumnName].Width = IsHidden ? 0: columnSize.Width;
            gv.Columns[ColumnName].OptionsColumn.ReadOnly = this.IsDisabled;
            gv.Columns[ColumnName].OptionsColumn.AllowEdit = !IsDisabled;
            gv.Columns[ColumnName].OptionsEditForm.Visible = IsDisabled ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.Default;
            
            gv.Columns[ColumnName].Visible = !IsHidden;
            gv.Columns[ColumnName].VisibleIndex = IsHidden ? -1 : VisibleOrder;
            gv.Columns[ColumnName].OptionsEditForm.VisibleIndex = IsHidden ? -1 : VisibleOrder;
        }
        public static string NextLineVal(Session unitOfWork)
        {
            #region EndCode
            //int sequId = 0;

            //var sequNameParm = new DevExpress.Xpo.DB.SprocParameter("@SequenceName", UI_LABEL_ID_SEQU);
            //var outputParm = new DevExpress.Xpo.DB.SprocParameter()
            //{
            //    ParameterName = "@NewID",
            //    Direction = DevExpress.Xpo.DB.SprocParameterDirection.Output,
            //    DbType = DevExpress.Xpo.DB.DBColumnType.Int32
            //};
            //var data = unitOfWork.ExecuteSprocParametrized(SP_NEXT_TASK_LINE, sequNameParm, outputParm);
            //SelectStatementResultRow row = data.ResultSet[1].Rows[0];

            //sequId = (int)row.Values[1];// data.ResultSet[1].Rows[1].Values[1];
            #endregion
            long returnIndex = 0;
            var sequIdParm = new DevExpress.Xpo.DB.SprocParameter("@SequenceId", SysSequence.UI_LABEL_SEQU);
            var sequNameParm = new DevExpress.Xpo.DB.SprocParameter("@SequenceName", Enum.GetName(typeof(SysSequence), SysSequence.UI_LABEL_SEQU));
            var startWithParm = new DevExpress.Xpo.DB.SprocParameter("@StartWith", 100*1000);
            var outputParm = new DevExpress.Xpo.DB.SprocParameter()
            {
                ParameterName = "@NewID",
                Direction = DevExpress.Xpo.DB.SprocParameterDirection.Output,
                DbType = DevExpress.Xpo.DB.DBColumnType.Int32
            };
            var data = unitOfWork.ExecuteSprocParametrized(SP_NEXT_TASK_LINE, sequIdParm, sequNameParm, startWithParm, outputParm);
            SelectStatementResultRow row = data.ResultSet[1].Rows[0];

            returnIndex = (int)row.Values[1];// data.ResultSet[1].Rows[1].Values[1];

            
            return ("@" + returnIndex.ToString());
            
        }

        #region Fields

        string fLabelId;
        [Key,Size(7)]
        public string LabelId
        {
            get { return fLabelId; }
            set { SetPropertyValue<string>("LabelId", ref fLabelId, value); }
        }

        string fLang_en;
        [Size(250)]
        public string Lang_en
        {
            get { return fLang_en; }
            set { SetPropertyValue<string>("Lang_en", ref fLang_en, value); }
        }

        string fLang_ar;
        [Size(250)]
        public string Lang_ar
        {
            get { return fLang_ar; }
            set { SetPropertyValue<string>("Lang_ar", ref fLang_ar, value); }
        }
        string fLang_fr;
        [Size(250)]
        public string Lang_fr
        {
            get { return fLang_fr; }
            set { SetPropertyValue<string>("Lang_fr", ref fLang_fr, value); }
        }
        
        MyEnums.UILabelType fLabelType;
        [Indexed("FieldName;ObjectName", Unique =true)]
        public MyEnums.UILabelType LabelType
        {
            get { return fLabelType; }
            set { SetPropertyValue<MyEnums.UILabelType>("LabelType", ref fLabelType,value); }
        }
        UIObjectBase fObjectName;
        [Association("UIObjectBase-UILabels")]
        public UIObjectBase ObjectName
        {
            get { return fObjectName; }
            set { SetPropertyValue<UIObjectBase>("ObjectName",ref fObjectName,value); }
        }
        string fFieldName;
        public string FieldName
        {
            get { return fFieldName; }
            set { SetPropertyValue<string>("FieldName", ref fFieldName, value); }
        }

        MyEnums.AutoLookUp fLookupMember;
        public MyEnums.AutoLookUp LookupMember
        {
            get { return fLookupMember; }
            set { SetPropertyValue<MyEnums.AutoLookUp>("LookupMember", ref fLookupMember, value); }
        }
        int fLookupMemberCharWidth;
        public int LookupMemberCharWidth
        {
            get { return fLookupMemberCharWidth; }
            set { SetPropertyValue<int>("LookupMemberCharWidth", ref fLookupMemberCharWidth, value); }
        }

        UIObjectBase fLookupEditor; //Class name to be used as lookup for current field
        public UIObjectBase LookupEditor
        {
            get { return fLookupEditor; }
            set { SetPropertyValue<UIObjectBase>("LookupEditor", ref fLookupEditor, value); }
        }
        UILabel fLookupEditorAlernateValueMember;//To enfore value member instead default 
        public UILabel LookupEditorAlernateValueMember
        {
            get { return fLookupEditorAlernateValueMember; }
            set { SetPropertyValue<UILabel>("LookupEditorAlernateValueMember", ref fLookupEditorAlernateValueMember, value); }
        }

        bool fIsHidden;
        public bool IsHidden
        {
            get { return fIsHidden; }
            set { SetPropertyValue<bool>("IsHidden", ref fIsHidden, value); }
        }

        bool fIsDisabled;
        public bool IsDisabled
        {
            get { return fIsDisabled; }
            set { SetPropertyValue<bool>("IsDisabled", ref fIsDisabled, value); }
        }
        int fWidth;
        public int Width
        {
            get { return fWidth; }
            set { SetPropertyValue<int>("Width", ref fWidth, value); }
        }
        
        int fVisibleOrder;
        public int VisibleOrder
        {
            get { return fVisibleOrder; }
            set { SetPropertyValue<int>("VisibleOrder", ref fVisibleOrder, value); }
        }
        MyEnums.FormEntityEnum fLookupFormRef;
        public MyEnums.FormEntityEnum LookupFormRef
        {
            get { return fLookupFormRef; }
            set { SetPropertyValue<MyEnums.FormEntityEnum>("LookupFormRef", ref fLookupFormRef, value); }
        }
        [NonPersistent]
        public string ColumnName
        {
            get { return FieldName?.Substring(FieldName.LastIndexOf('.') + 1); }
        }


        #endregion


        #region Associations
        [Association(@"UILABLE_UILABEL_LANG_FK")]
        public XPCollection<UILabelLang> Langs { get { return GetCollection<UILabelLang>("Langs"); } }
        #endregion



    }
}
