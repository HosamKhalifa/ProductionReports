using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"DOC_TYPE_BASE")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class DocumentType : Line
    {
        public static string TABLE_NAME = @"DOC_TYPE_BASE";
        public DocumentType(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = Session.FindObject<TableBase>(CriteriaOperator.Parse(" [TABLE_NAME] = ? ", TABLE_NAME));
            base.AfterConstruction();
        }
        #region Fields
        string fDocumentTypeName;
        [Persistent(@"DOC_TYPE_NAME"), Size(100)]
        [Indexed(Name = @"DOC_TYPE_NAME_UQ", Unique = true)]
        public string DocumentTypeName
        {
            get { return fDocumentTypeName; }
            set { SetPropertyValue<string>("DocumentTypeName", ref fDocumentTypeName, value); }
        }

        string fDocumentDisplayName;
        [Persistent(@"DOC_DISPLAY_NAME"), Size(100)]
       
        public string DocumentDisplayName
        {
            get { return fDocumentDisplayName; }
            set { SetPropertyValue<string>("DocumentDisplayName", ref fDocumentDisplayName, value); }
        }

        MainAccount fHeaderMainAccount;
        [Persistent(@"HEADER_MAIN_ACCOUNT")]
        public MainAccount HeaderMainAccount
        {
            get { return fHeaderMainAccount; }
            set { SetPropertyValue<MainAccount>("HeaderMainAccount", ref fHeaderMainAccount, value); }
        }

        AccountGroup fPostingProfileGroup;
        [Persistent(@"POSTING_PROFILE_GROUP")]
        [Association(@"DOC_TYPE_POST_PRO_GROUP_FK")]
        public AccountGroup PostingProfileGroup
        {
            get { return fPostingProfileGroup; }
            set { SetPropertyValue<AccountGroup>("PostingProfileGroup", ref fPostingProfileGroup, value); }
        }

        AccountRef1 fPostingProfileAccountRef1;
        [Persistent(@"POSTING_PROFILE_REF_NO1")]
        [Association(@"DOC_TYPE_POST_PRO_REF_NO1_FK")]
        public AccountRef1 PostingProfileAccountRef1
        {
            get { return fPostingProfileAccountRef1; }
            set { SetPropertyValue<AccountRef1>("PostingProfileAccountRef1", ref fPostingProfileAccountRef1, value); }
        }
        AccountRef2 fPostingProfileAccountRef2;
        [Persistent(@"POSTING_PROFILE_REF_NO2")]
        [Association(@"DOC_TYPE_POST_PRO_REF_NO2_FK")]
        public AccountRef2 PostingProfileAccountRef2
        {
            get { return fPostingProfileAccountRef2; }
            set { SetPropertyValue<AccountRef2>("PostingProfileAccountRef2", ref fPostingProfileAccountRef2, value); }
        }


        #endregion

        #region Associations
        [Association(@"DOC_TYPE_DOC_BASE_FK")]
        public XPCollection<DocumentBase> Documents { get { return GetCollection<DocumentBase>("Documents"); } }
        #endregion


    }
}
