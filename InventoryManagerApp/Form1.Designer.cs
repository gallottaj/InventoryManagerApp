namespace InventoryManagerApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerIDTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.storageLocationTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.addedItemListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.Location = new System.Drawing.Point(106, 129);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemIDTextBox.TabIndex = 0;
            this.itemIDTextBox.Text = "Item ID";
            this.itemIDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(106, 169);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 1;
            this.itemNameTextBox.Text = "Name";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(106, 209);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemDescriptionTextBox.TabIndex = 2;
            this.itemDescriptionTextBox.Text = "Description";
            // 
            // manufacturerIDTextBox
            // 
            this.manufacturerIDTextBox.Location = new System.Drawing.Point(106, 248);
            this.manufacturerIDTextBox.Name = "manufacturerIDTextBox";
            this.manufacturerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerIDTextBox.TabIndex = 3;
            this.manufacturerIDTextBox.Text = "Manufacturer ID";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(106, 291);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 5;
            this.quantityTextBox.Text = "Quantity";
            // 
            // storageLocationTextBox
            // 
            this.storageLocationTextBox.Location = new System.Drawing.Point(106, 326);
            this.storageLocationTextBox.Name = "storageLocationTextBox";
            this.storageLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.storageLocationTextBox.TabIndex = 6;
            this.storageLocationTextBox.Text = "Storage Location";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(261, 291);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 7;
            this.addItemButton.Text = "ADD ITEM";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(551, 129);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(137, 147);
            this.inventoryListBox.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(426, 321);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(342, 320);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(261, 320);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 13;
            this.selectButton.Text = "SELECT";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(342, 291);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "RE-STOCK";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(426, 292);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addedItemListBox
            // 
            this.addedItemListBox.FormattingEnabled = true;
            this.addedItemListBox.Location = new System.Drawing.Point(261, 129);
            this.addedItemListBox.Name = "addedItemListBox";
            this.addedItemListBox.Size = new System.Drawing.Size(240, 147);
            this.addedItemListBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addedItemListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.inventoryListBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.storageLocationTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.manufacturerIDTextBox);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemIDTextBox);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox manufacturerIDTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox storageLocationTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox addedItemListBox;
    }
}

