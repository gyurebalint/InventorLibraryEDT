using InventorLibraryEDT.Interfaces;
using Inventor;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EDT_CommonFunctions;

namespace InventorLibraryEDT.DataStructures
{
    public class EDT_TerminalElement : EDT_IDocument
    {
        public EDT_iProperty iProperty;
        public ComponentOccurrence Occurrence { get; }
        public AssemblyDocument Assembly { get; }
        //public AssemblyDocument Parent
        //{
        //    get
        //    {
        //        try
        //        {
        //            if (Assembly.Parent is null)
        //            {
        //                return null;
        //            }
        //            else
        //            {
        //                Document LineLayout = (Document)Assembly.ReferencedFiles;
        //                if (LineLayout.DocumentType == Inventor.DocumentTypeEnum.kAssemblyDocumentObject)
        //                {
        //                    AssemblyDocument LL = (AssemblyDocument)LineLayout;
        //                    if (LL.PropertySets["Inventor User Defined Properties"]["Category"].Value = "LL")
        //                    {
        //                        return PartDocument.Parent;
        //                    }
        //                    else
        //                    {
        //                        return null;
        //                    }
        //                }
        //                else
        //                {
        //                    return null;
        //                }
        //            }
        //        }
        //        catch (Exception)
        //        {

        //            return null;
        //        }
        //    }
        //}
        #region EDT_IDocument Properties
        public string FilePath => Assembly.FullFileName;

        public string Folder => System.IO.Path.GetDirectoryName(FilePath);

        public double? CurrentRating { get; set; }

        public double? ConductorQuantity { get; set; }

        public string Material { get; set; }

        public string Category => Assembly.PropertySets["Inventor User Defined Properties"]["Category"].Value;

        public string SpecificElement => Assembly.PropertySets["Inventor User Defined Properties"]["SpecificElement"].Value;

        public double Mass => Assembly.ComponentDefinition.MassProperties.Mass;

        public string ArticleNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string ItemNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        public string DrawingNumber { get; set; }

        public EDT_TerminalElement(ComponentOccurrence occurrence)
        {
            Occurrence = occurrence;
            Assembly = occurrence.Definition.Document;
            iProperty = new EDT_iProperty(this);
            SetProperties();

        }
        private void SetProperties()
        {
            FileHandling terminalElement = new FileHandling(Assembly.FullDocumentName);

            string[] properties = terminalElement.FileName.Split(' ');
            DrawingNumber = properties[0];
            CurrentRating = Convert.ToDouble(terminalElement.CutCharactersFromTheEnd(properties[3], 1));
            Material = properties[4].ToString();
            ConductorQuantity = Convert.ToDouble(terminalElement.CutCharactersFromTheEnd(properties[5], 1));
        }
        public void InsertIntoExcel(Worksheet ws, int rowIndex)
        {
            ws.Cells[rowIndex, 1].Value2 = ItemNumber;
            ws.Cells[rowIndex, 2].Value2 = "";
            ws.Cells[rowIndex, 3].Value2 = iProperty.Description;
            ws.Cells[rowIndex, 4].Value2 = Mass;
            ws.Cells[rowIndex, 5].Value2 = "";
            ws.Cells[rowIndex, 6].Value2 = "";
            ws.Cells[rowIndex, 7].Value2 = "";
            ws.Cells[rowIndex, 8].Value2 = DrawingNumber;
            ws.Cells[rowIndex, 9].Value2 = CurrentRating;
        }
    }
}
