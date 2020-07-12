using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorLibraryEDT.Interfaces;
using Microsoft.Office.Interop.Excel;
using Inventor;

namespace InventorLibraryEDT.Interfaces
{
    public interface EDT_IDocument 
    {
        string FilePath { get; }
        //Returns the folder this PartDocument is in.
        string Folder { get; }
        double? CurrentRating { get; set; }
        double? ConductorQuantity { get; set; }
        string Material { get; set; }
        string Category { get; }
        string SpecificElement { get; }
        double Mass { get; }
        string ArticleNumber { get; }
        //ItemNumber is a unique identifier of the current element
        string ItemNumber { get; set; }
        void InsertIntoExcel(Worksheet ws, int rowIndex);
    }
}
