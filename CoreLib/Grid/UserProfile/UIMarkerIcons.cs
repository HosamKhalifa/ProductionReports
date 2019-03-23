using CoreLib.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Grid.UserProfile
{
    [Persistent(@"UI_MARKER_ICONS_TB")]
    public class UIMarkerIcons:XPLiteObjectExt
    {
        public UIMarkerIcons(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        

        int fSymbolValue;
        [Key]
        public int SymbolValue
        {
            get { return fSymbolValue; }
            set { SetPropertyValue<int>("SymbolValue", ref fSymbolValue, value); }
        }
        byte[] fSymbolImage;
        public byte[] SymbolImage
        {
            get { return fSymbolImage; }
            set { SetPropertyValue<byte[]>("SymbolImage", ref fSymbolImage, value); }
        }
        string fSymbolName;
        public string SymbolName
        {
            get { return fSymbolName; }
            set { SetPropertyValue<string>("SymbolName", ref fSymbolName, value); }

        }
        string fSymbolTitle;
        public string SymbolTitle
        {
            get { return fSymbolTitle; }
            set { SetPropertyValue<string>("SymbolTitle", ref fSymbolTitle, value); }

        }


    }
}
