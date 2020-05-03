﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerApp
{
    public partial class Form1 : Form
    {
        Inventory[] inventoryList = new Inventory[0];
        int numberOfItems = 0;
        Inventory selectedItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void InventoryItem(Inventory item)
        {
            //get item ID
            if (int.TryParse(itemIDTextBox.Text, out int itemID))
            {
                item.ItemID = itemID;
            }
            else
            {
                MessageBox.Show("Invalid");
            }

            //get item name
            item.ItemName = itemNameTextBox.Text;

            //get item description
            item.ItemDescription = itemDescriptionTextBox.Text;

            //get manufacturer ID
            item.ManufacturerID = manufacturerIDTextBox.Text;

            //get quantity in stock
            if (int.TryParse(quantityTextBox.Text, out int quantity))
            {
                item.Quantity = quantity;
            }
            else
            {
                MessageBox.Show("Invalid");
            }

            //get item storage location
            item.StorageLocation = storageLocationTextBox.Text;
            inventoryList[numberOfItems + 1] = item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Inventory item = new Inventory();

                //get item ID
                if (int.TryParse(itemIDTextBox.Text, out int itemID))
                {
                    item.ItemID = itemID;
                }
                else
                {
                    MessageBox.Show("Invalid");
                }

                //get item name
                item.ItemName = itemNameTextBox.Text;

                //get item description
                item.ItemDescription = itemDescriptionTextBox.Text;

                //get manufacturer ID
                item.ManufacturerID = manufacturerIDTextBox.Text;

                //get quantity in stock
                if (int.TryParse(quantityTextBox.Text, out int quantity))
                {
                    item.Quantity = quantity;
                }
                else
                {
                    MessageBox.Show("Invalid");
                }

                //get item storage location
                item.StorageLocation = storageLocationTextBox.Text;


                inventoryList[numberOfItems + 1] = item;
            // update list of items in form

            }


        private void ClearTextBoxes()
        {
            itemIDTextBox.Clear();
            itemNameTextBox.Clear();
            itemDescriptionTextBox.Clear();
            manufacturerIDTextBox.Clear();
            quantityTextBox.Clear();
            storageLocationTextBox.Clear();
            itemNameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = inventoryListBox.SelectedIndex;

            if (inventoryListBox.SelectedIndex == -1)
                MessageBox.Show("Must select an item first!");

            inventoryList[index].ItemID = 0;
            inventoryList[index].ItemName = "";
            inventoryList[index].ItemDescription = "";
            inventoryList[index].ManufacturerID = "";
            inventoryList[index].Quantity = 0;
            inventoryList[index].StorageLocation = "";

            inventoryListBox.Items.Remove(inventoryList[index].ItemID);


            ClearTextBoxes();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            int index = inventoryListBox.SelectedIndex;
            if (inventoryListBox.SelectedIndex == -1)
                MessageBox.Show("Must select an item first!");

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // index of item
            int index = inventoryListBox.SelectedIndex;

            if (inventoryListBox.SelectedIndex == -1)
                MessageBox.Show("Select an item!");

            // show field
            if (itemIDTextBox.Text != (inventoryList[index].ItemID.ToString()))
            {
                if (int.TryParse(itemIDTextBox.Text, out int ID))
                { inventoryList[index].ItemID = ID; }
                else
                {   // error
                    MessageBox.Show("Invalid");
                }
            }

            if (itemNameTextBox.Text != inventoryList[index].ItemName)
            { inventoryList[index].ItemDescription = itemNameTextBox.Text; }

            if (itemDescriptionTextBox.Text != inventoryList[index].ItemDescription)
            { inventoryList[index].ItemDescription = itemDescriptionTextBox.Text; }

            if (manufacturerIDTextBox.Text != inventoryList[index].ManufacturerID)
            { inventoryList[index].ManufacturerID = manufacturerIDTextBox.Text; }

            if (itemIDTextBox.Text != (inventoryList[index].ItemID.ToString()))
            {
                if (int.TryParse(itemIDTextBox.Text, out int ID))
                { inventoryList[index].ItemID = ID; }
                else
                {   // error
                    MessageBox.Show("Invalid");
                }
            }

            if (quantityTextBox.Text != inventoryList[index].Quantity.ToString())
            {
                if (int.TryParse(quantityTextBox.Text, out int quantity))
                { inventoryList[index].Quantity = quantity; }
                else
                {   // error
                    MessageBox.Show("Invalid");
                }
            }
            storageLocationTextBox.Text = inventoryList[index].StorageLocation;


            ClearTextBoxes();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //search by item name or item ID

            //error
            if (String.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Enter an item name.");
            }

            if (!String.IsNullOrEmpty(itemNameTextBox.Text))
            {
                TextBox1_TextChanged();
            }

            //error
            if (String.IsNullOrEmpty(itemIDTextBox.Text))
            {
                MessageBox.Show("Enter an item ID.");
            }

            if (!String.IsNullOrEmpty(itemIDTextBox.Text))
            {
                TextBox1_TextChanged();

            }
        }

        private void TextBox1_TextChanged()

        {
            int index = inventoryListBox.FindString(this.itemNameTextBox.Text);
            if (0 <= index)
            {
                inventoryListBox.SelectedIndex = index;

                itemNameTextBox.Text = inventoryList[index].ItemName;

            }
        }

        private void addedItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // for loop through array to update inventory list box
        }
    }
}
  

