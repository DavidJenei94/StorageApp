using StorageAppWeb.Context;
using StorageAppWeb.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StorageAppWeb.Models;

namespace StorageAppDesktop
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();

            DBService dbs = new DBService();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dbs.getRooms();

            RoomComboBox.ValueMember = "Id";
            RoomComboBox.DisplayMember = "Name";

            RoomComboBox.DataSource = bindingSource1.DataSource;

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            using (var efc = new EFContext())
            {

                try
                {
                    var item = new Item
                    {
                        Name = nameTextBox.Text,
                        StorageId = (int)StorageComboBox.SelectedValue,
                        Quantity = (int)quantityNumericUpDown.Value
                    };

                    efc.Items.Add(item);
                    efc.SaveChanges();
                }
                catch (NullReferenceException ne) //NullReferenceException
                {
                    MessageBox.Show("One of the list item is not valid.");
                }

                this.Close();
            }
        }

        private void SelectedValue_Change(object sender, EventArgs e)
        {
            DBService dbs = new DBService();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = dbs.getStoragesOfRoom((int)RoomComboBox.SelectedValue);

            StorageComboBox.ValueMember = "Id";
            StorageComboBox.DisplayMember = "Name";

            StorageComboBox.DataSource = bindingSource2.DataSource;
        }
    }
}
