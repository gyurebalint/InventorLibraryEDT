using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventor;
using InventorLibraryEDT;
using InventorLibraryEDT.DataStructures;
using InventorLibraryEDT.Interfaces;

namespace InventorLibraryEDT.Models
{
    public class LineLayoutHandler
    {
        public EDT_StandardElement SetStandardElement(ComponentOccurrence occurrence)
        {
            EDT_StandardElement STE = new EDT_StandardElement(occurrence);
            return STE;
        }
        public List<EDT_IDocument> GetStandardElementsList(AssemblyDocument assembly)
        {
            List<EDT_IDocument> standardElements = new List<EDT_IDocument>();

            foreach (ComponentOccurrence OCC in assembly.ComponentDefinition.Occurrences)
            {
                Document oDoc = OCC.Definition.Document;
                try
                {
                    string category = oDoc.PropertySets["Inventor User Defined Properties"]["Category"].Value;
                    if (category == "STD")
                    {
                        //StandardElementHandler STDhandler = new StandardElementHandler();
                        EDT_StandardElement STD = new EDT_StandardElement(OCC);
                        standardElements.Add(STD);      //handler.SetStandardElementWithCheck(STD));
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Valami nem jo");
                }
            }
            return standardElements;
        }

        public List<EDT_IDocument> GetMonoblocksList(AssemblyDocument assembly)
        {
            List<EDT_IDocument> monoblocks = new List<EDT_IDocument>();

            foreach (ComponentOccurrence OCC in assembly.ComponentDefinition.Occurrences)
            {
                Document oDoc = OCC.Definition.Document;
                try
                {
                    string category = oDoc.PropertySets["Inventor User Defined Properties"]["SpecificElement"].Value;
                    if (category == "MON")
                    {
                        //StandardElementHandler STDhandler = new StandardElementHandler();
                        EDT_StandardElement STD = new EDT_StandardElement(OCC);
                        monoblocks.Add(STD);      //handler.SetStandardElementWithCheck(STD));
                    }
                }
                catch
                {
                    //throw new ArgumentException();   //MessageBox.Show("Valami nem jo");
                }
            }
            return monoblocks;
        }

        public EDT_TerminalElement SetTerminalElement(ComponentOccurrence occurrence)
        {
            EDT_TerminalElement terminalElement = new EDT_TerminalElement(occurrence);
            return terminalElement;
        }
        public List<EDT_IDocument> GetTerminalsList(AssemblyDocument assembly)
        {
            List<EDT_IDocument> monoblocks = new List<EDT_IDocument>();

            foreach (ComponentOccurrence OCC in assembly.ComponentDefinition.Occurrences)
            {
                Document oDoc = OCC.Definition.Document;
                try
                {
                    string category = oDoc.PropertySets["Inventor User Defined Properties"]["Category"].Value;
                    if (category == "TER")
                    {
                        //StandardElementHandler STDhandler = new StandardElementHandler();
                        EDT_StandardElement STD = new EDT_StandardElement(OCC);
                        monoblocks.Add(STD);      //handler.SetStandardElementWithCheck(STD));
                    }
                }
                catch
                {
                    throw new ArgumentException();   //MessageBox.Show("Valami nem jo");
                }
            }
            return monoblocks;
        }
    }
}