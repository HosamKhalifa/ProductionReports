using System;
using DevExpress.Xpo;

namespace ProductionReports.ModelXpo.ProdModelCode
{
[Persistent("PRD_TransJournalLinesView")]
    public class JournalLineRpt : XPLiteObject
    {
        public JournalLineRpt() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public JournalLineRpt(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        int fRecId;
        [Key]
        public int RecId
        {
            get { return fRecId; }
            set { SetPropertyValue<int>("RecId", ref fRecId, value); }
        }

        int fLocationId;
        public int LocationId
        {
            get { return fLocationId; }
            set { SetPropertyValue<int>("LocationId", ref fLocationId, value); }
        }

        string fLocationName;
        [Size(150)]
        public string LocationName
        {
            get { return fLocationName; }
            set { SetPropertyValue<string>("LocationName", ref fLocationName, value); }
        }

        int fShiftId;
        public int ShiftId
        {
            get { return fShiftId; }
            set { SetPropertyValue<int>("ShiftId", ref fShiftId, value); }
        }
        string fShiftName;
        [Size(50)]
        public string ShiftName
        {
            get { return fShiftName; }
            set { SetPropertyValue<string>("ShiftName", ref fShiftName, value); }
        }

        string fEquipmentName;
        [Size(250)]
        public string EquipmentName
        {
            get { return fEquipmentName; }
            set { SetPropertyValue<string>("EquipmentName", ref fEquipmentName, value); }
        }

        int fProductId;
        public int ProductId
        {
            get { return fProductId; }
            set { SetPropertyValue<int>("ProductId", ref fProductId, value); }
        } 

        string fItemName;
        [Size(250)]
        public string ItemName
        {
            get { return fEquipmentName; }
            set { SetPropertyValue<string>("ItemName", ref fItemName, value); }
        }

        int fJournalId;
        public int JournalId
        {
            get { return fJournalId; }
            set { SetPropertyValue<int>("JournalId", ref fJournalId , value); }
        }

        DateTime fTransDate;
        public DateTime TransDate
        {
            get { return fTransDate; }
            set { SetPropertyValue<DateTime>("TransDate", ref fTransDate, value); }
        }

        decimal fWorkingHours;
        public decimal WorkingHours
        {
            get { return fWorkingHours; }
            set { SetPropertyValue<decimal>("WorkingHours", ref fWorkingHours, value); }
        }

        decimal fFaultsHours;
        public decimal FaultsHours
        {
            get { return fFaultsHours; }
            set { SetPropertyValue<decimal>("FaultsHours", ref fFaultsHours, value); }
        }

        string fDecription;
        [Size(500)]
        public string Decription
        {
            get { return fDecription; }
            set { SetPropertyValue<string>("Decription", ref fDecription, value); }
        }

        decimal fQuantity;
        public decimal Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<decimal>("Quantity", ref fQuantity, value); }
        }

        string fLineDescription;
        [Size(500)]
        public string LineDescription
        {
            get { return fDecription; }
            set { SetPropertyValue<string>("LineDescription", ref fLineDescription, value); }
        }
    }

}