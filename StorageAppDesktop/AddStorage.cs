using StorageAppWeb.Context;
using StorageAppWeb.Models;
using StorageAppWeb.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StorageAppDesktop
{
    public partial class AddStorage : Form
    {


        public AddStorage()
        {
            InitializeComponent();

            DBService dbs = new DBService();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dbs.getRooms();

            RoomComboBox.ValueMember = "Id";
            RoomComboBox.DisplayMember = "Name";

            RoomComboBox.DataSource = bindingSource1.DataSource;
        }

        private void AddStorage_Click(object sender, EventArgs e)
        {

            using (var efc = new EFContext())
            {
                var storage = new Storage
                {
                    Name = StorageNameTextBox.Text,
                    RoomId = (int)RoomComboBox.SelectedValue
                };

                efc.Storages.Add(storage);
                efc.SaveChanges();
                this.Close();
            }

        }
    }
}
