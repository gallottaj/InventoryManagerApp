using System;
using System.Collections.Generic;
using System.Text;

namespace inventorymanager
{
    class Manager
    {
        // create new array to hold inventory items
        Inventory[] items;

        public void addItem(Inventory item )

            //user enters item attributes in text boxes
            //button click adds data to items array
            //increase # of items in array
            //update list box display
        {
            for (int index = 0; index < items.Length; index++)
            {
                Console.WriteLine("Enter an item:");
                Console.ReadLine();
            }
        }

        public void removeItem()

        //display all items in items array
        //user selects an item to remove
        //item is removed from items array
        //items.Length decreased by 1
        //update list box display

        {
        //var = user input
        //var item_to_remove = " ";
        Console.WriteLine("Enter an item:");
        Console.ReadLine();

        //match user input to attributes of an object in items array

        }

        public void restockItem()
        //restock button
        //button click changes quantity field of all items in array to "10" 
        //update list box display
        
        { 
            foreach (var item in items)
            {
             //grab original quantity data
             //update quantity data in each object to 10
            }
        }

        public void showAll()
        {
            for (int index = 0; index < items.Length; index++)
            {
                Console.Write(items[index] + " ");
            }
        }

        public void showSpecific()
        { 
        //takes user input search by name or ID in search textbox
        //could use dropdown
        //matches data to array data
        //displays only the item that matches
        //update list box
        }
    }
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


