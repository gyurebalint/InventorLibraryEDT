using System;
using System.Collections.Generic;
using System.Text;
using Inventor;
using System.Windows.Forms


namespace InventorLibraryEDT
{
    class StandardElement
    {
        #region Private fields
        private int currentRating;
        private int numberOfConductors;
        private string material;
        private int x;
        private int y;
        private int z;
        private string category;
        #endregion

        #region Properties
        public PartDocument PartDocument {
            get ;
            set
            {
               
            }
        }
        public string Category
        {
            get
            {
                try
                {
                    PropertySet prop = this.PartDocument.PropertySets["Inventor User Defined Properties"];
                    string category = prop["Category"].Value.ToString();
                    return category;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.show()
                }
                
            }
        }
        public string Description {
            get 
            {
                PropertySet prop = this.partDocument.PropertySets["Design Tracking Properties"];
                this.Description = prop["Description"].ToString();
                return this.Description;
            }
            set 
            {
                PropertySet prop = this.partDocument.PropertySets["Design Tracking Properties"];
                prop["Description"].Value = value;
                Description = value;
            } 
        }
        #endregion
        public StandardElement()
        {

        }

        public StandardElement(PartDocument partDocument)
        {
            this.PartDocument = partDocument;
            
        }
    }
}
