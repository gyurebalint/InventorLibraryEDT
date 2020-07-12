using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorLibraryEDT.DataStructures;
using InventorLibraryEDT.Models;

namespace InventorLibraryEDT.Models
{
    public class StandardElementHandler:LineLayoutHandler
    {
        private void CheckErrors(EDT_StandardElement STD)
        {
            string errors = "";

            if (STD.Category != "STD")
            {
                errors += "The Element must have a Custom iProperty called 'Category' that is set to 'STD'. \n";
            }
            if (STD.ConductorQuantity != 3 || STD.ConductorQuantity != 4 || STD.ConductorQuantity != 5 || STD.ConductorQuantity != 6)
            {
                errors += "The Element can only have 3-6 conductors. \n";
            }
            if (STD.CurrentRating != 400 || STD.CurrentRating != 630 || STD.CurrentRating != 800 || STD.CurrentRating != 1000 || STD.CurrentRating != 1350 || STD.CurrentRating != 1250 || STD.CurrentRating != 1400 || STD.CurrentRating != 1600 || STD.CurrentRating != 1700 || STD.CurrentRating != 2000 || STD.CurrentRating != 2500 || STD.CurrentRating != 3200 || STD.CurrentRating != 4000 || STD.CurrentRating != 5000 || STD.CurrentRating != 6300)
            {
                errors += $"An element with the current rating of {STD.CurrentRating} does NOT exist. \n";
            }
            //if (STD.Material != "Cu" || STD.Material != "Al")
            //{
            //    errors += $"A standard element can only be of 'Cu' or 'Al' material. \n";
            //}
            if (STD.Mass <= 0)
            {
                errors += "The element has to weigh more than 0kg \n";
            }
            if (errors.Length>0)
            {
                throw new ArgumentException(errors);
            }
        }
        public EDT_StandardElement SetStandardElementWithCheck(EDT_StandardElement STD)
        {
            CheckErrors(STD);
            EDT_StandardElement checkedSTD = SetStandardElement(STD.Occurrence);
            return checkedSTD;
        }
    }
}
