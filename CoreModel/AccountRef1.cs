﻿using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"ACT_REFNO1_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class AccountRef1:Line
    {
        public static string TABLE_NAME = "ACT_REFNO1_TB";
        public AccountRef1(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            TableId = Session.FindObject<TableBase>(CriteriaOperator.Parse(" [TABLE_NAME] = ? ", TABLE_NAME));

            base.AfterConstruction();
        }

        string fRefNo1Num;
        [Size(20), Persistent(@"REFNO1_NUM")]
        public string RefNo1Num
        {
            get { return fRefNo1Num; }
            set { SetPropertyValue<string>("RefNo1Num", ref fRefNo1Num, value); }
        }
        string fRefNo1Name;
        [Size(150), Persistent("REFNO1_NAME")]
        public string RefNo1Name
        {
            get { return fRefNo1Name; }
            set { SetPropertyValue<string>("RefNo1Name", ref fRefNo1Name, value); }
        }

        MyEnums.AccountType fAccountType;
        [Persistent(@"ACT_TYPE")]
        public MyEnums.AccountType AccountType
        {
            get { return fAccountType; }
            set { SetPropertyValue<MyEnums.AccountType>("AccountType", ref fAccountType, value); }
        }

        #region Associations 
        [Association(@"ACT_REFNO1_ACCOUNTS_FK")]
        public XPCollection<Account> Accounts { get { return GetCollection<Account>("Accounts"); } }
        [Association(@"DOC_TYPE_POST_PRO_REF_NO1_FK")]
        public XPCollection<DocumentType> DocumentTypes { get { return GetCollection<DocumentType>("DocumentTypes"); } }
        #endregion

    }
}
