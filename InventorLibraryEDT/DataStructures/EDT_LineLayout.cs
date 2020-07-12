using System;
using IO = System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventor;
using InventorLibraryEDT.Enums;
using InventorLibraryEDT.Interfaces;
using InventorLibraryEDT.Models;
using InventorLibraryEDT.DataStructures;
using Microsoft.Office.Interop.Excel;

namespace InventorLibraryEDT.DataStructures
{
    public class EDT_LineLayout : EDT_IDocument
    {
        StandardElementHandler STDHandler = new StandardElementHandler();

        #region IDocument Properties
        //Returns the FilePath of the PartDocument this EDT_StandardElement refers to.
        public string FilePath
        {
            get
            {
                return Assembly.FullDocumentName;
            }
        }
        //Returns the folder this PartDocument is in.
        public string Folder
        {
            get
            {
                return IO.Path.GetDirectoryName(FilePath);
            }
        }
        public AssemblyDocument Assembly;
        //public EDT_StandardElements StandardElements { get; set; }
        public EDT_iProperty iProperty { get; set; }
        public List<EDT_IDocument> StandardElements { get => STDHandler.GetStandardElementsList(Assembly); set { } }
        public double? CurrentRating 
        {
            get => Assembly.PropertySets["Inventor User Defined Properties"]["CurrentRating"].Value;
            set { }
        }
        
        public double? ConductorQuantity { get => null; set { } }
        public string Material { get => Assembly.PropertySets ["Inventor User Defined Properties"]["Material"].Value; set { } }
        public string Category =>  Assembly.PropertySets["Inventor User Defined Properties"]["Category"].Value;
        public string SpecificElement => Assembly.PropertySets["Inventor User Defined Properties"]["SpecificElement"].Value;
        public double Mass => Assembly.ComponentDefinition.MassProperties.Mass;
        public string ArticleNumber => null;
        public string ItemNumber { get => null; set { } }
        #endregion

        #region Lists of different types of elements
        public List<EDT_IDocument> Monoblocks => STDHandler.GetMonoblocksList(Assembly);
        #endregion

        #region LineLayout Specific Properties
        public string LineName => Assembly.PropertySets["Inventor User Defined Properties"]["LineName"].Value;
        public string LineNumber => Assembly.PropertySets["Inventor User Defined Properties"]["LineNumber"].Value;
        public string ProjectName => Assembly.PropertySets["Inventor User Defined Properties"]["ProjectName"].Value;
        public string ProjectNumber => Assembly.PropertySets["Inventor User Defined Properties"]["ProjectNumber"].Value;
        #endregion
        public EDT_LineLayout(AssemblyDocument assembly)
        {
            Assembly = assembly;
            iProperty = new EDT_iProperty(assembly);
        }
        public override string ToString()
        {
            return this.Assembly.DisplayName;
        }
        public void ExportToFile(List<EDT_IDocument> elements , EDT_Enums.ExportEnum exportEnum)
        {
            if (exportEnum == EDT_Enums.ExportEnum.Excel)
            {
                //Create a new workbook
                EDT_Excel excelFile = new EDT_Excel(this, elements);
                excelFile.CreateNewFile();
                excelFile.ExportElementList(elements);

                IO.DirectoryInfo dir = IO.Directory.CreateDirectory($@"{Folder}\Data");   //($@"{Folder}\Data");
                excelFile.SaveAs(dir.FullName);
                excelFile.Close();
            }
            else if (exportEnum == EDT_Enums.ExportEnum.Text)
            {

            }
        }
        public void InsertIntoExcel(Worksheet ws, int rowIndex)
        {
           
        }
    }
}