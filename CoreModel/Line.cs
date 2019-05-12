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
                BuildTreeNodes();
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
        #region Fields
        
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

        Line fParentLine;
        [Persistent(@"PARENT_LINE")]
        public Line ParentLine
        {
            get { return fParentLine; }
            set
                {
                    SetPropertyValue<Line>("ParentLine", ref fParentLine, value);
                    if (!IsLoading)
                    {
                        FamilyRegistration();
                        BuildTreeNodes();
                    }
                }
        }

        string fLineShadow;
        [Persistent(@"LINE_SHADOW"),Size(350)]
        public string LineShadow
        {
            get { return fLineShadow; }
            private set { SetPropertyValue<String>("LineShadow", ref fLineShadow,value); }
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

        #endregion
      
        [NonPersistent]
        public bool IsEditable
        {
            get{ return WorkflowStatus == MyEnums.WorkflowStatus.Draft; }
        }

        #region Association
        [Association("LineId_ShadowLineId")]
        public XPCollection<LineShadow> LineShadowLines { get { return GetCollection<LineShadow>("LineShadowLines"); } }
        [Association("LineId_ShadowFamilyLineId")]
        public XPCollection<LineShadow> LineShadowFamilyLines { get { return GetCollection<LineShadow>("LineShadowFamilyLines"); } }

        #endregion

        #region Methods
        public virtual void SetWorkflowStatus(MyEnums.WorkflowStatus _wrkFlow)
        {
            //This should called by approve menu 
            this.fWorkflowStatus = _wrkFlow;
        }

        class Shadowinfo
        {
            public Line LineId { get; set; }
            public Line Family { get; set; }
        }
        public void FamilyRegistration()
        {
            var lst = new List<Shadowinfo>();
            lst.Add(new Shadowinfo() { LineId = this, Family = this });
            if (ParentLine != null)//non Root insert
            {
                //Get Parent family
                foreach (LineShadow sh in this.ParentLine.LineShadowLines)
                {
                    lst.Add(new Shadowinfo() { LineId = sh.LineId, Family = sh.Family });
                }
            }
            //Loop for each pairs and try insert if not alredy existed
            foreach (var item in lst)
            {
                var dbLine = Session.FindObject<LineShadow>(CriteriaOperator.Parse("[LineId] = ? AND [Family] = ? ", item.LineId, item.Family));
                if(dbLine == null)
                {
                    dbLine = new LineShadow(Session) { LineId=item.LineId,Family=item.Family};
                    dbLine.Save();
                }
            }


        }
        
        public void BuildTreeNodes()
        {
            string lineShadow = "";
            if(ParentLine != null )
            {
                lineShadow = ParentLine.LineShadow + "-" + LineId.ToString().PadRight(15, ' ');
            }
            else
            {
                lineShadow= LineId.ToString().PadRight(15, ' ');
            }
            this.LineShadow = lineShadow;
        }

        private List<Line> GetLineShadowLines()
        {
            List<Line> retList = new List<Line>();
            var lst = LineShadow.Split('-');
            foreach (string item in lst)
            {
                long lineOid;
                if(long.TryParse(item.Trim(), out lineOid))
                {
                    var line = Session.GetObjectByKey<Line>(lineOid);
                    if (line != null) retList.Add(line);
                }
            }
            return retList;
        }

        #endregion

        #region Events

        #endregion



    }

}
