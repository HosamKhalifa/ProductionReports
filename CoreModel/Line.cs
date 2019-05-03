﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using CoreLib.Xpo;
//using System.ComponentModel;
namespace CoreModel
{

    [Persistent(@"LINE_BASE")]
    public  class Line : XPLiteObject
    {
        public Line(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            this.CreatedBy = SecurityUser.CurrentUser.UserId;
            this.CreatedAt = DateTime.Now;

            this.ModifiedBy = SecurityUser.CurrentUser.UserId;
            this.ModifiedAt = DateTime.Now;

            this.LineId = SysSequence.NextVal(Session,MyEnums.SysSequence.LINE_ID_SEQU,(10 * 1000 * 1000));

            base.AfterConstruction();
        }
        protected virtual bool Validate()
        {
            //Not null column
            if (string.IsNullOrEmpty(ModifiedBy.Trim())) return false;
            if (ModifiedAt == null) return false;
            if (string.IsNullOrEmpty(CreatedBy.Trim())) return false;
            if (ModifiedAt == null) return false;

            return true;
        }
        protected override void OnSaving()
        {
            this.ModifiedBy = SecurityUser.CurrentUser.UserId;
            this.ModifiedAt = DateTime.Now;
            if (Validate())
            {
                base.OnSaving();
            }
            
        }
        protected bool SetPropertyValueExt<T>(string propertyName, ref T propertyValueHolder, T newValue)
        {
            if (!IsLoading && !IsEditable)
            {
                return false;
            }
            return SetPropertyValue<T>(propertyName, ref propertyValueHolder, newValue);
           
        }

        //Definition
        //====================================================================

        long fLineId;
        [Key]
        [Persistent(@"LINE_ID")]
        public long LineId
        {
            get { return fLineId; }
            set { SetPropertyValue<long>("LineId", ref fLineId, value); }
        }
        string fCreatedBy;
        [Size(30)]
        public string CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<string>("CreatedBy", ref fCreatedBy, value); }
        }
        DateTime fCreatedAt;
       
        public DateTime CreatedAt
        {
            get { return fCreatedAt; }
            set { SetPropertyValue<DateTime>("CreatedAt", ref fCreatedAt, value); }
        }
        string fModifiedBy;
        [Size(30)]
        public string ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<string>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fModifiedAt;
        public DateTime ModifiedAt
        {
            get { return fModifiedAt; }
            set { SetPropertyValue<DateTime>("ModifiedAt", ref fModifiedAt, value); }
        }

        TableBase fTableId;
        [Persistent(@"TABLE_ID")]
        [Association("TableBase-Line")]
        public TableBase TableId
        {
            get { return fTableId; }
            set { SetPropertyValue<TableBase>("TableId", ref fTableId, value); }
        }

        MyEnums.WorkflowStatus fWorkflowStatus = MyEnums.WorkflowStatus.Draft;
        [Persistent(@"WFLOW_STATUS")]
        public MyEnums.WorkflowStatus WorkflowStatus
        {
            get { return fWorkflowStatus; }
            // set { SetPropertyValue<MyEnums.WorkflowStatus>("WorkflowStatus", ref fWorkflowStatus, value); }
        }

      
        [NonPersistent]
        public bool IsEditable
        {
            get{ return WorkflowStatus == MyEnums.WorkflowStatus.Draft; }
        }

        public virtual void SetWorkflowStatus(MyEnums.WorkflowStatus _wrkFlow)
        {
            //This should called by approve menu 
            this.fWorkflowStatus = _wrkFlow;
        }





    }

}
