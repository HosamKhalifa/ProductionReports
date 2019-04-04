using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using CoreLib.SharedExt;
using DevExpress.Xpo.Metadata;
using System.Linq;
using DevExpress.Xpo;
using CoreLib.Xpo;
using DevExpress.Data.Filtering;
using System.IO;
using System.Reflection;

namespace CoreLib.Label
{
    public partial class LabelEditorFrm : CoreLib.MyForm
    {
        public LabelEditorFrm(string assemblyList)
        {
            InitializeComponent();
            //Build assembly list 
            this.assemblyList =  assemblyList.Split(';');

            
            
        }
        string[] assemblyList;
       

        private void syuncBtn_Click(object sender, EventArgs e)
        {
            SerializingLabel();
        }

        private void SynchronizeLabel()
        {
            DataTable tbl_AR, tbl_EN, tbl_FR;
            tbl_AR = new DataTable("Label_ar");
            tbl_AR.Columns.AddRange(new DataColumn[] { new DataColumn("LableId", typeof(string)), new DataColumn("LableName", typeof(string)) });
            tbl_EN = new DataTable("Label_en");
            tbl_EN.Columns.AddRange(new DataColumn[] { new DataColumn("LableId", typeof(string)), new DataColumn("LableName", typeof(string)) });
            tbl_FR = new DataTable("Label_fr");
            tbl_FR.Columns.AddRange(new DataColumn[] { new DataColumn("LableId", typeof(string)), new DataColumn("LableName", typeof(string)) });

            foreach (UILabel item in xpCollectionExt1)
            {
                tbl_AR.Rows.Add(item.LabelId, item.Lang_ar);
                tbl_EN.Rows.Add(item.LabelId, item.Lang_en);
                tbl_FR.Rows.Add(item.LabelId, item.Lang_fr);

            }
            //Dataset to pass it to JSON Convert
            var ds_AR = new DataSet(); ds_AR.Tables.Add(tbl_AR);
            var ds_EN = new DataSet(); ds_EN.Tables.Add(tbl_EN);
            var ds_FR = new DataSet(); ds_FR.Tables.Add(tbl_FR);
            string json_AR = JsonConvert.SerializeObject(ds_AR, Formatting.Indented);
            string json_EN = JsonConvert.SerializeObject(ds_EN, Formatting.Indented);
            string json_FR = JsonConvert.SerializeObject(ds_FR, Formatting.Indented);

            System.IO.File.WriteAllText($@"{Application.StartupPath}\label_ar.json", json_AR);
            System.IO.File.WriteAllText($@"{Application.StartupPath}\label_en.json", json_EN);
            System.IO.File.WriteAllText($@"{Application.StartupPath}\label_fr.json", json_FR);
        }
        private void SerializingLabel()
        {
            XPCollection<UILabel> labelXPC = new XPCollection<UILabel>(unitOfWork1);

            var ar_labelsList = new List<JsonLabelDict>();
            var en_labelsList = new List<JsonLabelDict>();
            var fr_labelsList = new List<JsonLabelDict>();
            foreach (UILabel item in labelXPC)
            {
                ar_labelsList.Add(new JsonLabelDict() { LabelId = item.LabelId, LabelName = item.Lang_ar });
                en_labelsList.Add(new JsonLabelDict() { LabelId = item.LabelId, LabelName = item.Lang_en });
                fr_labelsList.Add(new JsonLabelDict() { LabelId = item.LabelId, LabelName = item.Lang_fr });


            }
            string ar_outputJson = Newtonsoft.Json.JsonConvert.SerializeObject(ar_labelsList, Newtonsoft.Json.Formatting.Indented);
            string en_outputJson = Newtonsoft.Json.JsonConvert.SerializeObject(en_labelsList, Newtonsoft.Json.Formatting.Indented);
            string fr_outputJson = Newtonsoft.Json.JsonConvert.SerializeObject(fr_labelsList, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText($@"{Environment.CurrentDirectory}\label_ar.json", ar_outputJson + Environment.NewLine);
            File.WriteAllText($@"{Environment.CurrentDirectory}\label_en.json", en_outputJson + Environment.NewLine);
            File.WriteAllText($@"{Environment.CurrentDirectory}\label_fr.json", fr_outputJson + Environment.NewLine);
        }

       
        private void BuildObjectName(string[] assemblyNameList)
        {
            XPDictionary dict = new ReflectionDictionary();
           
            foreach (string assebly in assemblyNameList)
            {
                var assemblyInstance = GlobalMethods.GetAssemblyByName(assebly);
               
                dict.CollectClassInfos(assemblyInstance);
               
                foreach (XPClassInfo item in dict.Classes)
                {

                    //if (item.BaseClass !=null  &&
                    //   (
                    //    item.BaseClass.FullName.Contains("XPLiteObjectExt")||
                    //    item.BaseClass.FullName.Contains("XPLiteObject") ||
                    //    item.BaseClass.FullName.Contains("XPObject")      )
                    //    )
                    if(item.IsPersistent)

                    {
                        if(!(item.FullName.Contains("XPLiteObjectExt") || item.FullName.Contains("XPLiteObject") || item.FullName.Contains("XPObject")))
                        {
                            var obj = unitOfWork1.FindObject<UIObjectBase>(CriteriaOperator.Parse("[ObjectName] = ? ", item.FullName));
                            if (obj == null)
                            {
                                obj = new UIObjectBase(unitOfWork1) { ObjectName = item.FullName, AssemblyName =item.AssemblyName};
                                obj.Save();
                                
                            }
                            
                        }
                       
                    } 
                    
                }

                unitOfWork1.CommitChanges();


            }
        }
        private void BuildMemberName(UIObjectBase table)
        {
            #region Old
            //var classInfo = unitOfWork1.Dictionary.GetClassInfo(table.AssemblyName,table.ObjectName);
            //foreach (var m in classInfo.Members.Where(x => !string.IsNullOrEmpty(x.MappingField)))
            //{

            //    var caption = m.FindAttributeInfo("caption");
            //    var help = m.FindAttributeInfo("help");
            //    string fieldName = $"{m.Owner.FullName}.{m.Name}";
            //    if (caption != null)
            //    {
            //        string lblId = ((CustomAttribute)caption).Value;
            //        if (!string.IsNullOrEmpty(lblId))
            //        {

            //            var line = unitOfWork1.GetObjectByKey<UILabel>(lblId);
            //            if(line != null)
            //            {
            //                line.FieldName = fieldName;
            //                line.Save();
            //            }

            //        }

            //    }
            //    else
            //    {
            //        var objName = unitOfWork1.FindObject<UIObjectBase>(CriteriaOperator.Parse(" ObjectName = ? ", classInfo.FullName));
            //        //Test if label already existed but not referenced in Xpo yet
            //        var labelLine = unitOfWork1.FindObject<UILabel>(CriteriaOperator.Parse("[ObjectName] = ? AND [FieldName] = ? AND [LabelType] = ?  ",objName, fieldName, MyEnums.UILabelType.FieldCaption));
            //        if (objName != null && labelLine == null)
            //        {
            //            UILabel newLbl = new UILabel(unitOfWork1)
            //            {
            //                LabelType = MyEnums.UILabelType.FieldCaption,
            //                FieldName = fieldName,
            //                ObjectName = objName,
            //                Lang_en = m.Name,
            //                LookupMemberCharWidth=10,
            //                Width=10,
            //                IsDisabled=false,
            //                IsHidden=false,
            //                VisibleOrder=0
            //            };

            //            newLbl.Langs.Add(new UILabelLang(unitOfWork1) { UILabelType = MyEnums.UILabelType.FieldCaption, Lang_en = newLbl.FieldName });
            //            newLbl.Langs.Add(new UILabelLang(unitOfWork1) { UILabelType = MyEnums.UILabelType.FieldHelp, Lang_en = newLbl.FieldName });
            //            newLbl.Save();
            //        }
            //    }
            //    if (help != null)
            //    {
            //        string lblId = ((CustomAttribute)help).Value;
            //        if (!string.IsNullOrEmpty(lblId))
            //        {
            //            var line = unitOfWork1.GetObjectByKey<UILabel>(lblId);
            //            if (line != null)
            //            {
            //                line.FieldName = m.Name;
            //                line.Save();
            //            }
            //        }

            //    }

            //}
            #endregion
            var classInfo = unitOfWork1.Dictionary.GetClassInfo(table.AssemblyName, table.ObjectName);
            var objectBaseLine = table;
            if (objectBaseLine == null) { return; }
            foreach (var m in classInfo.Members.Where(x => !string.IsNullOrEmpty(x.MappingField) || x.FindAttributeInfo("NonPersistentAttribute") != null))
            {

                string fieldName = $"{m.Owner.FullName}.{m.Name}";
                var labelLine = objectBaseLine.FindOrCreateUILabel(fieldName);
              
            }

            unitOfWork1.CommitChanges();

        }
        private void buildClassListBtn_Click(object sender, EventArgs e)
        {
            BuildObjectName(assemblyList);
        }
        private void buildMembersBtn_Click(object sender, EventArgs e)
        {
            foreach (var line in objectMyGV.GetSelectedRows())
            {
                var obj = (UIObjectBase)objectMyGV.GetRow(line);
                BuildMemberName(obj);
            }
            
        }
    }
}
