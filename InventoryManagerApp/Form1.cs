using inventorymanager;
using System;
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
        public object Manager { get; private set; } = new Manager();
        public IEnumerable<InventoryItem> Inventory { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        //(itemName, itemDescription, manufacturerID, quantity, storageLocation)
        private void Form1_Load(object sender, EventArgs e)
        {
            InventoryItem itemOne = new InventoryItem("Test", "This is a test", "test", 10, "test");
            InventoryItem itemTwo = new InventoryItem("Test", "This is a test", "test", 10, "test");
            AddItem(itemOne);
            AddItem(itemTwo);
            UpdateInventoryList();
        }

        private void AddItem(InventoryItem itemOne)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventoryList()
        {
            searchTextBox.Text = "";
            inventoryListBox.ClearSelected();
            inventoryListBox.Items.Clear();
            foreach (InventoryItem item in Inventory)
            {
                inventoryListBox.Items.Add(item);
            }
            UpdateSelected();
        }

        private void UpdateInventoryList(List<InventoryItem> inventory)
        {
            inventoryListBox.ClearSelected();
            inventoryListBox.Items.Clear();
            foreach (InventoryItem item in inventory)
            {
                inventoryListBox.Items.Add(item);
            }
            UpdateSelected();
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                removeButton.Enabled = true;
                restockButton.Enabled = true;
                InventoryItem selectedItem = (InventoryItem)inventoryListBox.SelectedItem;
                UpdateSelected(selectedItem);
            }
            else
            {
                removeButton.Enabled = false;
                restockButton.Enabled = false;
                UpdateSelected();
            }
        }

        private void UpdateSelected()
        {
            throw new NotImplementedException();
        }

        private void UpdateSelected(InventoryItem selectedItem)
        {
            itemNameTextBox.Text = "";
            itemDescriptionTextBox.Text = "";
            manufacturerIDTextBox.Text = "";
            quantityTextBox.Text = "";
            storageLocationTextBox.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //clear text boxes
        private void ClearTextBoxes()
        {
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
            if (inventoryListBox.SelectedIndex != -1)
            {
                InventoryItem selectedItem = (InventoryItem)inventoryListBox.SelectedItem;
                RemoveItem(selectedItem);
                UpdateInventoryList();
            }
        }

        private void RemoveItem(InventoryItem selectedItem)
        {
            throw new NotImplementedException();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            int index = inventoryListBox.SelectedIndex;
            if (inventoryListBox.SelectedIndex == -1)
                MessageBox.Show("Must select an item first!");

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                InventoryItem selectedItem = (InventoryItem)inventoryListBox.SelectedItem;
                RestockItem(selectedItem);
                UpdateSelected(selectedItem);

            }
        }

        private void RestockItem(InventoryItem selectedItem)
        {
            throw new NotImplementedException();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
        
        }

        private void TextBox1_TextChanged()
        {

        }

        private void addedItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
  

