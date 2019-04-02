using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Label
{
   public class UILabelLang:XPObject
    {
        public UILabelLang(Session session) : base(session)
        {
        }
        //public string ChooseValueForCurrentLang()
        //{
        //    string ret = "";
        //    string lang = string.IsNullOrEmpty(CoreLib.GlobalMethods.UILang) ? "en" : CoreLib.GlobalMethods.UILang;
        //    ret = GetPropertyValue($"Lang_{lang.ToLower()}").ToString();
        //    return ret;
        //}
        UILabel fUILabel;
        [Association(@"UILABLE_UILABEL_LANG_FK")]
        public UILabel UILabel
        {
            get { return fUILabel; }
            set { SetPropertyValue<UILabel>("UILabel", ref fUILabel, value); }
        }
        MyEnums.UILabelType fUILabelType;
        public MyEnums.UILabelType UILabelType
        {
            get { return fUILabelType; }
            set { SetPropertyValue<MyEnums.UILabelType>("UILabelType", ref fUILabelType, value); }
        }
        [NonPersistent]
        public string Lang
        {
            get
            {
                string ret = "";
                string lang = string.IsNullOrEmpty(CoreLib.GlobalMethods.UILang) ? "en" : CoreLib.GlobalMethods.UILang;
                //ret = GetPropertyValue<string>($"Lang_{lang}");
                switch (lang.ToLower())
                {
                    case "en":
                        ret = Lang_en;
                        break;
                    case "ar":
                        ret = Lang_ar;
                        break;
                    case "fr":
                        ret = Lang_fr;
                        break;
                    default:
                        break;
                }
                return ret;
            }
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
    }
}
