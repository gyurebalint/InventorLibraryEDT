using System;
using IO = System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventor;
using InventorLibraryEDT.DataStructures;
using InventorLibraryEDT.Interfaces;
using Microsoft.Office.Interop.Excel;

namespace InventorLibraryEDT.DataStructures
{
    public class EDT_StandardElement : EDT_IDocument
    {
        #region Properties
        //Returns the FilePath of the PartDocument this EDT_StandardElement refers to.
        public string FilePath
        {
            get
            {
                return PartDocument.FullDocumentName;
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
        //This property returns the parent object, which in case of a EDT_StandardElement is the EDT_LineLayout which this element is in.
        //public AssemblyDocument Parent
        //{
        //    get
        //    {
        //        try
        //        {
        //            if (PartDocument.Parent is null)
        //            {
        //                return null;
        //            }
        //            else
        //            {
        //                Document LineLayout = (Document)PartDocument.Parent;
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
        public ComponentOccurrence Occurrence { get; set; }
        public PartDocument PartDocument { get; }
        public EDT_iProperty iProperty { get; set; }

        public double? CurrentRating
        {
            get
            {
                try
                {
                    return PartDocument.ComponentDefinition.Parameters.UserParameters["Current"].Value;
                }
                catch (Exception)
                {

                    return 0;
                }
            }
            set { }
        }
        public double? ConductorQuantity
        {
            get
            {
                try
                {
                    return PartDocument.ComponentDefinition.Parameters.UserParameters["conductorQty"].Value;
                }
                catch (Exception)
                {

                    return 0;
                }
            }
            set { }
        }
        public string Material { get => PartDocument.ComponentDefinition.Parameters.UserParameters["material"].Value; set { } }
        public double X
        {
            get
            {
                try
                {
                    return PartDocument.ComponentDefinition.Parameters["X"].Value * 10;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
        public double Y
        {
            get
            {
                try
                {
                    return PartDocument.ComponentDefinition.Parameters.UserParameters["Y"].Value * 10;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
        public double Z
        {
            get
            {
                try
                {
                    return PartDocument.ComponentDefinition.Parameters.UserParameters["Z"].Value * 10;
                }
                catch (Exception)
                {
                    return 0;
                }

            }
        }
        public string Category { get => PartDocument.PropertySets["Inventor User Defined Properties"]["Category"].Value; }
        public string SpecificElement { get => PartDocument.PropertySets["Inventor User Defined Properties"]["SpecificElement"].Value; }
        public double Mass { get => PartDocument.ComponentDefinition.MassProperties.Mass; }
        public string ArticleNumber { get => PartDocument.PropertySets["Design Tracking Properties"]["Part Number"].Value; }

        //ItemNumber is a unique identifier of the current element
        public string ItemNumber { get; set; }
        #endregion

        public EDT_StandardElement(ComponentOccurrence occurrence)
        {
            Occurrence = occurrence;
            PartDocument = occurrence.Definition.Document;
            iProperty = new EDT_iProperty(this);
        }
        public void InsertIntoExcel(Worksheet ws, int rowIndex)
        {
            ws.Cells[rowIndex, 1].Value2 = ItemNumber;
            ws.Cells[rowIndex, 2].Value2 = ArticleNumber;
            ws.Cells[rowIndex, 3].Value2 = iProperty.Description;
            ws.Cells[rowIndex, 4].Value2 = Mass;
            ws.Cells[rowIndex, 5].Value2 = X;
            ws.Cells[rowIndex, 6].Value2 = Y;
            ws.Cells[rowIndex, 7].Value2 = Z;
            ws.Cells[rowIndex, 8].Value2 = "";
            ws.Cells[rowIndex, 9].Value2 = CurrentRating;
        }
    }
}
