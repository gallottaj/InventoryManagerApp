using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerApp
{
    class Inventory
    {
        private int _itemID;
        private string _itemName;
        private string _itemDescription;
        private string _manufacturerID;
        private int _quantity;
        private string _storageLocation;

        //constructor

        public Inventory()
        {
            //set ID = unique random number?

            _itemID = 0;
            _itemName = "";
            _itemDescription = "";
            _manufacturerID = "";
            _quantity = 0;
            _storageLocation = "";
        }

        public int ItemID
        { get { return _itemID; } set { _itemID = value; } }

        public string ItemName
        { get { return _itemName; } set { _itemName = value; } }

        public string ItemDescription
        { get { return _itemDescription; } set { _itemDescription = value; } }

        public string ManufacturerID
        { get { return _manufacturerID; } set { _manufacturerID = value; } }

        public int Quantity
        { get { return _quantity; } set { _quantity = value; } }

        public string StorageLocation
        { get { return _storageLocation; } set { _storageLocation = value; } }

    }
}
