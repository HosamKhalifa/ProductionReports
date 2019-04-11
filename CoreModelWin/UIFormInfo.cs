using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoreModelWin
{
    public class UIFormInfo : XPLiteObject
    {
        public enum FormEntityEnum
    {
        TestForm, FieldsSetting , Sequence  , UILabel, TableBase, FiscalCalender, Currency, CurrencySetup
    }
        protected UIFormInfo(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        #region Fields

        int fFormEnity;
        [Key]
        public int FormEntity
        {
            get { return fFormEnity; }
            set { SetPropertyValue<int>("FormEntity", ref fFormEnity, value); }
        }
        string fFormName;
        [Size(120)]
        public string FormName
        {
            get { return fFormName; }
            set { SetPropertyValue<string>("FormName", ref fFormName, value); }
        }
        string fLinkCaption_en;
        [Size(120)]
        public string LinkCaption_en
        {
            get { return fLinkCaption_en; }
            set { SetPropertyValue("LinkCaption_en", ref fLinkCaption_en, value); }
        }
        string fLinkCaption_ar;
        [Size(120)]
        public string LinkCaption_ar
        {
            get { return fLinkCaption_ar; }
            set { SetPropertyValue("LinkCaption_ar", ref fLinkCaption_ar, value); }
        }
        string fLinkCaption_fr;
        [Size(120)]
        public string LinkCaption_fr
        {
            get { return fLinkCaption_fr; }
            set { SetPropertyValue("LinkCaption_fr", ref fLinkCaption_fr, value); }
        }
        [NonPersistent]
        public string LinkCaption
        {
            get
            {
                string ret = "";
                string lang = string.IsNullOrEmpty(CoreLib.GlobalMethods.UILang) ? "en" : CoreLib.GlobalMethods.UILang;
                //ret = GetPropertyValue<string>($"Lang_{lang}");
                switch (lang.ToLower())
                {
                    case "en":
                        ret = LinkCaption_en;
                        break;
                    case "ar":
                        ret = LinkCaption_ar;
                        break;
                    case "fr":
                        ret = LinkCaption_fr;
                        break;
                    default:
                        break;
                }
                return ret;
            }
        }
     
        #endregion

        #region Methods
        
        private static List<UIFormInfo> formInfoList;
        public static List<UIFormInfo> GetOrBuildFormEntityList(UnitOfWork session)//Create ddb rows for each Persistent calss 
        {
            if(formInfoList == null || formInfoList.Count == 0)
            {
                formInfoList = new List<UIFormInfo>();
                foreach (var item in Enum.GetNames(typeof(FormEntityEnum)))
                {
                    //Search if Table is existed in DB

                    var itemEnum = (FormEntityEnum)Enum.Parse(typeof(FormEntityEnum), item);
                    var dbFrmRow = session.GetObjectByKey<UIFormInfo>((int)itemEnum);
                    if (dbFrmRow == null)
                    {
                        UIFormInfo t = new UIFormInfo(session)
                        {
                            FormEntity = (int)itemEnum,
                            FormName = item.ToString(),
                            LinkCaption_en = item.ToString()
                        };
                        t.Save();
                    }

                    formInfoList.Add(dbFrmRow);

                }
                
            }

            return formInfoList;
        }

        
        #endregion

    }
}
