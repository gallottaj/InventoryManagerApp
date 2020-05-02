using System;
using System.Collections.Generic;
using System.Text;

namespace inventorymanager
{
    class Manager
    {
        // create new array
        string[] items = new string[3];

        public void addItem()
        {
            for (int index = 0; index < items.Length; index++)
            {
                Console.WriteLine("Enter an item:");
                items[index] = Console.ReadLine();
            }
        }

        public void removeItem()
        { }

        public void restockItem()
        { }

        public void showAll()
        {
            for (int index = 0; index < items.Length; index++)
            {
                Console.Write(items[index] + " ");
            }
        }

        public void showSpecific()
        { }
    }
}


