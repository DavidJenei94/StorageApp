using Microsoft.EntityFrameworkCore;
using StorageAppWeb.Context;
using StorageAppWeb.Models;
using StorageAppWeb.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StorageAppDesktop
{
    public partial class EditDeleteStorage : Form
    {
        public EditDeleteStorage()
        {
            InitializeComponent();

            DBService dbs = new DBService();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dbs.getRooms();

            RoomComboBox.ValueMember = "Id";
            RoomComboBox.DisplayMember = "Name";

            RoomComboBox.DataSource = bindingSource1.DataSource;


            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = dbs.getStorages();

            StorageComboBox.ValueMember = "Id";
            StorageComboBox.DisplayMember = "Name";

            StorageComboBox.DataSource = bindingSource2.DataSource;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (var efc = new EFContext())
            {
                var result = efc.Storages.SingleOrDefault(b => b.Id == (int)StorageComboBox.SelectedValue);
                if (result != null)
                {
                    result.RoomId = (int)RoomComboBox.SelectedValue;
                    if (StorageNameTextBox.Text != "")
                    {
                        result.Name = StorageNameTextBox.Text;
                    }

                    efc.SaveChanges();
                    this.Close();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var efc = new EFContext())
            {
                var storage = new Storage { Id = (int)StorageComboBox.SelectedValue };
                efc.Entry(storage).State = EntityState.Deleted;
                efc.SaveChanges();
                this.Close();
            }

        }
    }
}
