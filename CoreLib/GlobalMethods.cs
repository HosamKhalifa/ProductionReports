using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.Win32;
using DevExpress.Xpo;
using CoreLib.Grid.UserProfile;
using System.Data.OleDb;
using System.Reflection;
using CoreLib.Label;

namespace CoreLib
{
   public class GlobalMethods
    {

        public static string UILang
        {
            get { return Properties.Settings.Default.UILang; }
            set {
                    Properties.Settings.Default.UILang = value;
                Properties.Settings.Default.Save();
                    UILabel.GetLabelDictionery(value);
                }
        }
        #region Methods
        public static string AskUser_SaveFilePath(string fileType)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.InitialDirectory = UserRegistry.GetLastExportFolder(Environment.SpecialFolder.MyDocuments);
            dlg.Filter = string.Format("Excel files (*.{0})|*.{0}", fileType, fileType);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UserRegistry.SetLastExportFolder(Path.GetDirectoryName(dlg.FileName));
                return dlg.FileName;
            }

            return "";

        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public static IEnumerable<T> GetEnumValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
        
        public static void ShutdownNow() 
        {
            //Search for FinERP and get ref to form 
            MainForm mainForm;
                foreach (var frm in Application.OpenForms)
	            {
                    string frmType = frm.GetType().ToString();
                    if (frmType == "CoreLib.MainForm")
                    {
                        mainForm = (MainForm)frm;
                        //mainForm.LockScreenXtraForm.ForceClose();
                    }
	            }
                Application.Exit();
        }
        
        public static object IsNull(object theValue, object valueIfNull) 
        {
            if (theValue == null)
            {
                return valueIfNull;
            }
            else
            {
                return theValue;
            }
        }
        
        public static decimal? IsNull(decimal? theValue, decimal valueIfNull)
        {
            if (theValue == null)
            {
                return valueIfNull;
            }
            else
            {
                return theValue;
            }
        }
        
        public static string IsNull(string theValue, string valueIfNull)
        {
            if (theValue == null)
            {
                return valueIfNull;
            }
            else
            {
                return theValue;
            }
        }
        
        public static DateTime IsNull(DateTime theValue, DateTime valueIfNull)
        {
            if (theValue == null)
            {
                return valueIfNull;
            }
            else
            {
                return theValue;
            }
        }

        public static Control FindControl(Form form, string name)
        {
            foreach (Control control in form.Controls)
            {
                Control result = FindControl(form, control, name);
                if (result != null)
                    return result;
            }

            return null;
        }

        private static Control FindControl(Form form, Control control, string name)
        {
            if (control.Name == name)
            {
                return control;
            }

            foreach (Control subControl in control.Controls)
            {
                Control result = FindControl(form, subControl, name);
                if (result != null)
                    return result;
            }

            return null;
        }

           

        public static void ConfigSqlCommand(SqlDataAdapter tableAdapterAdapter, SqlConnection conn)
        {
            //tabularAdapter.SelectCommand.Connection = HFrameWork.GlobalVariable.Sqlca;
            tableAdapterAdapter.InsertCommand.Connection = conn;
            tableAdapterAdapter.UpdateCommand.Connection = conn;
            tableAdapterAdapter.DeleteCommand.Connection = conn;

            tableAdapterAdapter.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
            tableAdapterAdapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
            tableAdapterAdapter.DeleteCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;

            if (tableAdapterAdapter.InsertCommand.Parameters.Contains("@ProcessType"))
            {
                tableAdapterAdapter.InsertCommand.Parameters["@ProcessType"].Value = 1;
            }
            else
            {
                tableAdapterAdapter.InsertCommand.Parameters.AddWithValue("@ProcessType", 1);
            }

            if (tableAdapterAdapter.UpdateCommand.Parameters.Contains("@ProcessType"))
            {
                tableAdapterAdapter.UpdateCommand.Parameters["@ProcessType"].Value = 2;
            }
            else
            {
                tableAdapterAdapter.UpdateCommand.Parameters.AddWithValue("@ProcessType", 2);
            }
            if (tableAdapterAdapter.DeleteCommand.Parameters.Contains("@ProcessType"))
            {
                tableAdapterAdapter.DeleteCommand.Parameters["@ProcessType"].Value = 3;
            }
            else
            {
                tableAdapterAdapter.DeleteCommand.Parameters.AddWithValue("@ProcessType", 3);
            }

        }
    
        public static object SQLSelectScalar(string sql, SqlConnection conn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;


            }

        }
     
       

       

      
        

       

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static byte[] imageToByteArray(System.Drawing.Image imageIn,System.Drawing.Imaging.ImageFormat imgFormat)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, imgFormat);
            return ms.ToArray();
        }
    
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static string ParseIntListToString(List<Int32> intList,string separatorChar)
        {
            string parsedValue = "";
            
            foreach (int item in intList)
            {
                parsedValue += item.ToString() + separatorChar;

            }
            parsedValue = parsedValue.Remove(parsedValue.Length - 1);
            return parsedValue;

        }

        public static DataSet ImportExcelXLS(string FileName, bool hasHeaders)
        {
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (FileName.Substring(FileName.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";

            DataSet output = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();

                DataTable schemaTable = conn.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                foreach (DataRow schemaRow in schemaTable.Rows)
                {
                    string sheet = schemaRow["TABLE_NAME"].ToString();

                    if (!sheet.EndsWith("_"))
                    {
                        try
                        {
                            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                            cmd.CommandType = CommandType.Text;

                            DataTable outputTable = new DataTable(sheet);
                            output.Tables.Add(outputTable);
                            new OleDbDataAdapter(cmd).Fill(outputTable);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message + string.Format("Sheet:{0}.File:F{1}", sheet, FileName), ex);
                        }
                    }
                }
            }
            return output;
        }

        public static  void GetStartAndEndDateForSpecifiedDate(DateTime dateValue, out DateTime startDate, out DateTime endDate)
        {
           
            int year, month;
            year    = dateValue.Year;
            month   = dateValue.Month;
            startDate = new DateTime(year, month, 1);
            endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
        }

        public static decimal LowestAmounts(params decimal[] amountsList) 
        {
            decimal lowstValue = amountsList[0];//Start value

            foreach (decimal item in amountsList)
            {
                if (lowstValue > item )
                {
                    lowstValue = item;
                }
            }

            return lowstValue;
        }
        public static decimal HighestAmounts(params decimal[] amountsList)
        {
            decimal highestValue = amountsList[0];//Start value
            foreach (decimal item in amountsList)
            {
                if (highestValue < item)
                {
                    highestValue = item;
                }
            }

            return highestValue;
        }
        
        public static Assembly GetAssemblyByName(string name)
        {
            return AppDomain.CurrentDomain.GetAssemblies().
                   SingleOrDefault(assembly => assembly.GetName().Name == name);
        }
        #endregion

        #region EventHandlers
        #endregion

    }

    class        FinERPAppSettings
    {
        #region Members
        
      
        
        public  enum AppSettingEnum
        {
            LineID, CompanyName, CompanyAddress, CompanyTel1, CompanyTel2, CompanyTaxFileNo, CompanyTaxCardNo, CompanyTaxRegisterNo, CompanyLogo, AccountsReceivableFinancialAccountID, AccountsPayableFinancialAccountID, AssetsSupplierFinancialAccountID, FixedAssetCostYearID, POSFinancialAccountID, IncomeStatementParentFAAccountID, CashDiscountGivenFinancialAccountID, CashDiscountTakenFinancialAccountID, UndepositedFundsFinancialAccountID, BankChargeFinancialAccountID, RetainedEarningFinancialAccountID, TaxPayableFinancialAccountID, PurchaseTaxFinancialAccountID, OpeningBalancesFinancialAccountID, EmployeePicturePath, EmployeePictureExtension, EmployeeInuranceID, EmployeeBasicInsuranceID, EmployeeVariableInsuranceID, EmployeeTaxID, EmployeeAbsenceID, EmployeePenaltyID, IsEmployeeNetDueRounded, RoundedToSupportingID, PayrollSheetTotalIncomeID, PayrollSheetTotalDeductionID, PayrollSheetNetIncomeID, PayrollSheetTreasuryAccountID, PayrollAccruedWages, AdminName, AdminPWD, StoreWastedStoreAccountID, CompanyCurrencyID, DefaultSalesPriceID, ClosingJournalEntryJournalID, ProductionCostAccountID, TradingAccountID, ProfitAndLossAccountID, UnFinishedProductsStockAccountID, FinishedProductsStockAccountID, PurchasedGoodsForSale, PreventAnyConnection, Payroll_EnablePermissionPerAuditor, Payroll_DefaultAuditorSecurityRole, DefaultImageSizeForArticalLineInBytes, ImageSizeForArchiverRoleInBytes, ArchiverRole
        }
        public enum CurrentUserInfoEnum 
        {
            PrincipalID, PrincipalName, Active, EmployeeAccountID, IdleTimeSeconds, SkinName, EnableMultiSessions, Default_CalenderView, Default_FromToDateRange
        }
        
        public enum JournalClassName 
        {
            ApEntry, ArEntry, JournalEntry, PurchaseBill, PurchaseOrder, SalesBill, StoreDocument, SalesDeliverNote, PurchaseSupplierPriceOffer
        }
  
        public enum DocumentType
        {
            PayrollSheet,
            InventoryItemReceipt,
            InventoryItemDisburse,
            InventoryAdjustment,
            InventoryWastedItem,
            JournalEntry,
            CustomerReceivable,
            VendorPayment,
            PurchaseOrder,
            PurchaseBill,
            SalesLocalBill,
            JournalEntryPayroll,
            JournalEntryCustomer,
            JournalEntryVendor,
            JournalEntryBank,
            EmployeeReceivable,
            VendorReceivable,
            DepositReceivable,
            POSReceivable,
            BankTransfer,
            BankRevenues,
            PurchaseBillFreight,
            InventoryReturnedFromProduction,
            InventorySoldToCustomerVendor,
            TaxInsurancePayment,
            PurchaseBillFixedAssets,
            InventoryReturnedToVendor,
            SalesDeliverNoteToPOS,
            SalesDeliverNoteToCustomers,
            SalesDeliverNoteToHarbor,
            SalesPOSBill,
            SalesExportBill,
            SalesNoteWeightDifference,
            SalesNotePriceDifference,
            SalesNoteReturns,
            SalesNoteAgentMotivation,
            InventoryTransferIncoming,
            InventoryTransferOutgoing,
            SalesDeliverNoteTransferOutgoing,
            SalesDeliverNoteTransferIncoming
            
        }

        public enum PurchaseBillLine 
        {
            PBFixedAssetLine,PBInventoryLine,PBNonInventoryLine,PBTaxLine,PBFinancialAccount
        }

        public enum BankingStatus
        {
            None,
            UnderCollection,
            Collected,
            Refused,
        }

        public enum BankingType 
        {
            CashReceiable,
            CheckReceivable,
            NotesReceivable,
            CashDepositReceivable,
            BankTransfeerReceiable,
            CashPayment,
            CheckPayment,
            NotesPayable,
            CashDepositPayable,
            BankTransfeerPayable,
            CheckDepositPayable
        }

        public enum SecurityPermission 
        {
            ApDocumentTypeSettings,
            ApEntityView,
            ApEntryJournalReport,
            ApEntryReport,
            ArEntityView,
            ArEntryJournalReport,
            ArEntryReport,
            BankAccountEntityView,
            CostAccountEntityView,
            CurrencyEntityView,
            CustomerAccountEntityView,
            CustomerGroupEntityView,
            EmployeeAccountEntityView,
            FinancialAccountEntityView,
            FinancialAccountEntityViewTree,
            FinancialPeriodEntityView,
            FinancialYearEntityView,
            FixedAssetAccountEntityView,
            FixedAssetCategoryEntityView,
            FixedAssetSettings,
            InventoryItemAccountEntityView,
            InventoryStoreEntityView,
            ItemAccountCategoryEntityView,
            ItemAccountGroupEntityView,
            ItemAccountManufacturerEntityView,
            ItemAccountOriginCountryEntityView,
            JournalEntityView,
            JournalEntryEntityView,
            JournalEntryEntityViewDOTPost,
            JournalEntryReport,
            NonInventoryItemAccountEntityView,
            POSAccountEntityView,
            PostingApEntry,
            PostingArEntry,
            PostingJournalEntry,
            PostingPurchaseBill,
            PurchaseBillEntityView,
            PurchaseBillJournalReport,
            PurchaseBillReport,
            PurchaseBillTaxesEntityView,
            PurchaseOrderEntityView,
            PurchaseOrderItemsType,
            PurchaseOrderPaymentType,
            PurchasePerson,
            RegionEntityView,
            SalesDeliverNoteEntityView,
            SalesItemAccountEntityView,
            SalesItemAccountGroupEntityView,
            SalesPerson,
            SecurityRolesPrincipalsEntityView,
            SecurityUsersPrincipalsEntityView,
            StoreDocumentEntityView,
            TaxAgencyEntityView,
            VendorAccountEntityView,
            VendorGroupEntityView,
            SalesLocations,
            SalesTransportVendor
}

        public enum DocumentLineType
        {
            InvalidDocumentLineType,
            SummaryLineType,
            ExpenseLineType,
            TaxLineType,
            NonInventoryItemLineType,
            DescriptionLineType,
            JournalLine,
            SettlementLine,
            TaxVendorPaymentLine,
            DepositLine,
            POFixedAssetLine,
            POInventoryLine,
            PONonInventoryLine,
            POWithoutItemLine,
            ArBankLine,
            ArReceviablePerson,
            PBFixedAssetLine,
            PBInventoryLine,
            PBNonInventoryLine,
            PBTaxLine,
            PBFinancialAccount,
            ApBankLine,
            ApPayeePerson,
            InventoryLine,
            SalesDeliverNoteLine,
            SalesBillLineFromDeliverNote,
            SalesBillLineManual,
            SalesBillTaxLine,
            SalesBillFinancialAccount,
            PBBillHeaderLine,
            SalesBillHeaderLine,
            InventoryHeaderLine,
            PBDeliverNoteLine
        }

       
   
       

        #endregion

        

        #region Methods
       
        #endregion

        #region EventHandlers
        #endregion
    }

    

    


    
    

    
    class FlexObject : Object
    {
        public FlexObject() 
        {

        }

     public FlexObject(object realObject) 
        {
         this.realObject = realObject;
        }

        #region Members
        object realObject;

        #endregion

        #region Properties
        public object RealObject
        {
            set { realObject = value; }
            get { return realObject; }
        }

        public decimal ToDecimal 
        {
            get 
            {
                return Convert.ToDecimal(realObject);
            }
        }

        public DateTime ToDateTime
        {
            get
            {
                return Convert.ToDateTime(realObject);
            }
        }
     
        public int ToInt32
        {
            get
            {
                return Convert.ToInt32(realObject);
            }
        }
        
        public byte ToByte
        {
            get
            {
                return Convert.ToByte(realObject);
            }
        }

        public double ToDouble
        {
            get
            {
                return Convert.ToDouble(realObject);
            }
        }
     
        public bool ToBoolean
        {
            get
            {
                return Convert.ToBoolean (realObject);
            }
        }
        
        
        #endregion

        #region Methods

        public override string ToString()
        {
            string strValue = "";
            if (realObject != null)
            {
                strValue = realObject.ToString();
            }
            return strValue;
        }

        #endregion

        #region EventHandlers

        #endregion

    }

    static class UserRegistry 
    {


        #region Members

        const string FinERPUserKey="Software\\FinERP";
        const string lastFileOpenDirectory = "LastFileOpenDirectory";
        const string lastExportFolder = "LastExportFolder";
        
        #endregion

        #region Properties





        #endregion

        #region Methods
        private static RegistryKey GetMasterRegKey() 
        {
            RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey, true);
            if (finERPKey == null)
            {
                finERPKey = Registry.CurrentUser.CreateSubKey(FinERPUserKey);
            }
            return finERPKey;
        }


        public static void SetLastFileOpenFolder(string folderPath) 
        {
            //RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey,true);
            GetMasterRegKey().SetValue(lastFileOpenDirectory, folderPath, RegistryValueKind.String);
        }
        
        public static string GetLastFileOpenFolder(Environment.SpecialFolder defaultFolder )
        {
                string val = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey);

                if (finERPKey != null)
                {
                    val = finERPKey.GetValue(lastFileOpenDirectory, Environment.GetFolderPath(defaultFolder)).ToString();
                }
                
                return val;
               
        }




        public static void SetLastExportFolder(string folderPath)
        {
            //RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey, true);
            GetMasterRegKey().SetValue(lastExportFolder, folderPath, RegistryValueKind.String);
        }

        public static string GetLastExportFolder(Environment.SpecialFolder defaultFolder)
        {
            string val = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            RegistryKey finERPKey = Registry.CurrentUser.OpenSubKey(FinERPUserKey);
            if (finERPKey != null)
            {
                val = finERPKey.GetValue(lastExportFolder, Environment.GetFolderPath(defaultFolder)).ToString();                
            }
            
            return val;

        }
        
        

        #endregion

        #region EventHandlers


        #endregion

    }

    static class MarkersIconsComboBox
    {

        #region Members
        private static XPCollection<UIMarkerIcons> markerImagesTable;
        private static DevExpress.Utils.ImageCollection markerImageList;
        
        #endregion
        
        #region Methods
        
        public static void RetrieveMarkerImages()
        {
            if (markerImagesTable == null)
            {
                markerImageList = new DevExpress.Utils.ImageCollection();
                markerImagesTable = new XPCollection<UIMarkerIcons>(XpoDefault.Session);
                markerImagesTable.Load();
                foreach (var dr in markerImagesTable)
                {
                    Image img = GlobalMethods.byteArrayToImage(dr.SymbolImage);
                    markerImageList.AddImage(img, dr.SymbolName);
                }
                
            }
            
        }

        public static void PopulateMarkerImageComboBox(DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox imageBox)
        {
            RetrieveMarkerImages();
            imageBox.Items.Clear();
            imageBox.SmallImages = markerImageList;
            imageBox.LargeImages = markerImageList;
            //Add null item
            imageBox.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("N/A", null, -1));
            foreach (var dr in markerImagesTable)
            {
                DevExpress.XtraEditors.Controls.ImageComboBoxItem item = 
                    new DevExpress.XtraEditors.Controls.ImageComboBoxItem(dr.SymbolTitle, dr.SymbolValue , dr.SymbolValue - 1);
                imageBox.Items.Add(item);
            }

        }

       
        #endregion

      
    }



 




}
