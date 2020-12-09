using StorageAppWeb.Context;
using System;
using System.Windows.Forms;
using StorageAppWeb.Models;
using Microsoft.EntityFrameworkCore;
using StorageAppWeb.Services;
using System.Linq;

namespace StorageAppDesktop
{
    public partial class EditDeleteItem : Form
    {
        Item item;
        public EditDeleteItem(Item selectedItem)
        {
            InitializeComponent();

            DBService dbs = new DBService();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dbs.getRooms();

            RoomComboBox.ValueMember = "Id";
            RoomComboBox.DisplayMember = "Name";

            RoomComboBox.DataSource = bindingSource1.DataSource;


            item = selectedItem;

            nameTextBox.Text = item.Name;

            Storage selectedStorage;
            Room selectedRoom;
            using (var efc = new EFContext())
            {
                selectedStorage = efc.Storages.First(c => c.Id == item.StorageId);
                selectedRoom = efc.Rooms.First(c => c.Id == selectedStorage.RoomId);
            }

            RoomComboBox.SelectedValue = selectedRoom.Id;
            StorageComboBox.SelectedValue = item.StorageId;
            quantityNumericUpDown.Value = item.Quantity;
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            using (var efc = new EFContext())
            {
                //var item = new Item { Id = (int)StorageComboBox.SelectedValue };
                efc.Entry(item).State = EntityState.Deleted;
                efc.SaveChanges();
                this.Close();
            }
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            using (var efc = new EFContext())
            {
                var result = efc.Items.SingleOrDefault(b => b.Id == item.Id);
                if (result != null)
                {
                    result.StorageId = (int)StorageComboBox.SelectedValue;
                    result.Name = nameTextBox.Text;
                    result.Quantity = (int)quantityNumericUpDown.Value;

                    efc.SaveChanges();
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
