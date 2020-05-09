using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerApp
{
    public class InventoryItem
    {
      
        //removed itemID
            public string ItemName { get; set; }
            public string ItemDescription { get; set; }
            public string ManufacturerID { get; set; }
            public int Quantity { get;  set; }
            public string StorageLocation { get; set; }

           // create an InventoryItem

        public InventoryItem(string itemName, string itemDescription, string manufacturerID, int quantity, string storageLocation)
            {
                this.ItemName = itemName;
                this.ItemDescription = itemDescription;
                this.ManufacturerID = manufacturerID;
                this.Quantity = quantity;
                this.StorageLocation = storageLocation;
            }


        // to find an item by search
        public override bool Equals(Object obj)
        {
            return (obj is InventoryItem) && ((InventoryItem)obj).ItemName == ItemName;
        }

        public bool Equals(string name)
        {
            return name == ItemName;
        }

        public bool Equals(string name, string desc)
        {
            return ItemName.ToLower().Contains(name.ToLower()) || ItemDescription.ToLower().Contains(desc.ToLower());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return ItemName;
        }


        // determine if item is out of stock so it can be restocked
        public bool OutOfStock()
        {
            return Quantity == 0;
        }
     }
}