using Inventor;
using InventorLibraryEDT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorLibraryEDT.DataStructures
{ 
    public class EDT_iProperty
    {
        public Document Document;
        public string PartNumber
        {
            get => Document.PropertySets["Design Tracking Properties"]["Part Number"].Value;
            set => Document.PropertySets["Design Tracking Properties"]["Part Number"].Value = value;
        }    
        public string StockNumber
        {
            get => Document.PropertySets["Design Tracking Properties"]["Stock Number"].Value;
            set => Document.PropertySets["Design Tracking Properties"]["Stock Number"].Value = value;
        }
        public string Description
        {
            get => Document.PropertySets["Design Tracking Properties"]["Description"].Value;
            set => Document.PropertySets["Design Tracking Properties"]["Description"].Value = value;
        }
        public string Designer
        {
            get => Document.PropertySets["Design Tracking Properties"]["Designer"].Value;
            set => Document.PropertySets["Design Tracking Properties"]["Designer"].Value = value;
        }
        public string EstimatedCost
        {
            get => Document.PropertySets["Design Tracking Properties"]["Cost"].Value;
            set => Document.PropertySets["Design Tracking Properties"]["Cost"].Value = value;
        }
        public DateTime CreationDate
        {
            get => Document.PropertySets["Design Tracking Properties"]["Creation Time"].Value;
            set => Document.PropertySets["Design Tracking Properties"]["Creation Time"].Value = value;
        }
        public string EnglishDescription
        {
            get => Document.PropertySets["Inventor User Defined Properties"]["English Description"].Value;
            set => Document.PropertySets["Inventor User Defined Properties"]["English Description"].Value = value;
        }

        //Every Document type has an EDT_iProperty, and can be reached via Document.
        public EDT_iProperty(Document document)
        {
            Document = document;
        }
        public EDT_iProperty(PartDocument partDocument)
        {
            Document = partDocument.Parent;
        }
        public EDT_iProperty(AssemblyDocument assemblyDocument)
        {
            Document = (Document)assemblyDocument;
        }
        public EDT_iProperty(EDT_StandardElement standardElement)
        {
            Document = standardElement.Occurrence.Definition.Document;
        }
        public EDT_iProperty(EDT_TerminalElement terminalElement)
        {
            Document = terminalElement.Occurrence.Definition.Document;
        }
    }
}