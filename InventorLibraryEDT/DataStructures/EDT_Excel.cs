using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorLibraryEDT.Interfaces;
//using _Excel = Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace InventorLibraryEDT.DataStructures
{
    public class EDT_Excel
    {
        _excel.Application oExcel = new _excel.Application();
        public _excel.Workbook wb;
        public _excel.Worksheet ws;
        public string WorkSheetName;
        public string FullFilePath = "";
        public EDT_LineLayout LineLayout;
        public List<EDT_IDocument> ElementList;
        public EDT_Excel(EDT_LineLayout lineLayout, List<EDT_IDocument> elementList)
        {
            LineLayout = lineLayout;
            ElementList = elementList;
        }
        public void CreateNewFile()
        {
            oExcel.Visible = true;
            WorkSheetName = LineLayout.LineNumber;
            wb = oExcel.Workbooks.Open(@"C:\Users\Gyure Balint\Documents\MyOwn\EDT\ExtendingInventorLibrary\InventorLibraryEDT\Book1.xlsx");
            ws = wb.Worksheets[1];
            ws.Name = WorkSheetName;
           
            this.InsertHeader();
        }
        public void ExportElementList(List<EDT_IDocument> elementList)
        {
            int rowIndex = 8;
            foreach (EDT_IDocument element in elementList)
            {
                if (element.SpecificElement == "MON")
                {
                    continue;
                }
                element.InsertIntoExcel(ws, rowIndex);
                rowIndex++;
            }
            if (LineLayout.Monoblocks.Count > 0)
            {
                LineLayout.Monoblocks[0].InsertIntoExcel(ws, rowIndex);
                ws.Cells[rowIndex, 2].Value2 = LineLayout.Monoblocks.Count;
            }
        }
        public void SaveAs(string fullFilePath)
        {
            FullFilePath = fullFilePath;
            ws.SaveAs(FullFilePath);
        }
        public void Open(string fullFilePath)
        {
            oExcel.Workbooks.Open(fullFilePath);
        }
        public void Close()
        {
            wb.Close();
        }
        private void InsertHeader()
        {

            ws.Cells[1, 1].Value2 = "Line Layout Properties";
            //ws.Cells["A1:G1"].Merge();

            ws.Cells[2, 1].Value2 = "Project Name";
            ws.Cells[3, 1].Value2 = "Project Number";
            ws.Cells[4, 1].Value2 = "Line Name";
            ws.Cells[5, 1].Value2 = "Line Number";
               
            ws.Cells[2, 5].Value2 = "Material";
            ws.Cells[2, 5].Value2 = "Conductor Quantity";
               
            ws.Cells[7, 1].Value2 = "ItemNr";
            ws.Cells[7, 2].Value2 = "Article no.";
            ws.Cells[7, 3].Value2 = "Description";
            ws.Cells[7, 4].Value2 = "Mass";
            ws.Cells[7, 5].Value2 = "X";
            ws.Cells[7, 6].Value2 = "Y";
            ws.Cells[7, 7].Value2 = "Z";
            ws.Cells[7, 8].Value2 = "Drawing no.";
        }
    }
}
