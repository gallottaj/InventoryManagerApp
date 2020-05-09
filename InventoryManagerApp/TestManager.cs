using InventoryManagerApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventorymanager
{
    public class Manager
    {

        //change from array to list 
            public List<InventoryItem> Inventory { get; private set; } = new List<InventoryItem>();
            public static int initialQuantiy { get; } = 10;

            
        //add an item to inventory
            public InventoryItem AddItem(InventoryItem item)
            {
                if (ContainsItem(item))
                {
                    InventoryItem foundItem = FindItem(item);
                    foundItem.Quantity += item.Quantity;
                    return foundItem;
                }
                else
                {
                    Inventory.Add(item);
                    return item;
                }
            }

        // find item by name
            public InventoryItem FindItem(string itemName)
            {
                return Inventory.Find(x => x.Equals(itemName));
            }

            public InventoryItem FindItem(InventoryItem item)
            {
                return Inventory.Find(x => x.Equals(item));
            }

            public List<InventoryItem> FindItems(string itemName, string desc)
            {
                List<InventoryItem> results = new List<InventoryItem>();
                return Inventory.FindAll(x => x.Equals(itemName, desc));
            }

            public bool ContainsItem(InventoryItem item)
            {
                return Inventory.Contains(item);
            }

            //remove item
            public bool RemoveItem(InventoryItem item)
            {
                if (ContainsItem(item))
                {
                    Inventory.Remove(item);
                    return true;
                }
                return false;
            }
            
            //set quantity = 10 if out of stock
            public void RestockItem(string item)
            {
                InventoryItem inventoryItem = FindItem(item);
                if (inventoryItem.OutOfStock())
                {
                    inventoryItem.Quantity = 10;
                }
            }

            //restock item
            //public void RestockItem(InventoryItem item)
            //{
            //InventoryItem inventoryItem = FindItem(item);
            //inventoryItem.Quantity = initialQuantiy;
            //}

            public override string ToString()
            {
                string value = "";
                foreach (InventoryItem item in Inventory)
                {
                    value += "[" + item.ToString() + "]\n\n";
                }
                return value;
            }
        }
    }
