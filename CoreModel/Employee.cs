﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"EMPL_ACT_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Employee : Account
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Employee;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public Employee(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Employee);
            base.AfterConstruction();
        }
        DateTime fBirthDate;
        [Persistent(@"BIRTH_DATE")]
        public DateTime BirthDate
        {
            get { return fBirthDate; }
            set { SetPropertyValue<DateTime>("BirthDate", ref fBirthDate, value); }
        }
        string fIdentityCard;
        [Persistent(@"IDENT_CARD"),Size(30)]
        public string IdentityCard
        {
            get { return fIdentityCard; }
            set { SetPropertyValue<string>("IdentityCard", ref fIdentityCard, value); }
        }

        MyEnums.Gender fGender;
        [Persistent("GENDER")]
        public MyEnums.Gender Gender
        {
            get { return fGender; }
            set { SetPropertyValue<MyEnums.Gender>("Gender", ref fGender, value); }
        }

    }
}
