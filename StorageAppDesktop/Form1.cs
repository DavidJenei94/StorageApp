using StorageAppWeb.Services;
using System;
using System.Windows.Forms;
using StorageAppWeb.Models;
using StorageAppWeb.Context;
using System.Linq;

namespace StorageAppDesktop
{
    public partial class MainWindow : Form
    {

        private Item selectedItem;
        private PictureBox selectedPictureBox;
        private DBService dbs;

        public MainWindow()
        {
            InitializeComponent();
            dbs = new DBService();
        }

        //
        //Adott szoba képek kiválasztás, azokhoz tartozó eszközök megjelenítése
        //
        private void LivingRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
            var items = dbs.getItems(1);
            ItemsDataGridView.DataSource = null;
            ItemsDataGridView.DataSource = items;
            ItemsDataGridView.Visible = true;

        }

        private void SmallRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
            var items = dbs.getItems(2);
            ItemsDataGridView.DataSource = null;
            ItemsDataGridView.DataSource = items;
            ItemsDataGridView.Visible = true;
        }

        private void CorridorImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
            var items = dbs.getItems(5);
            ItemsDataGridView.DataSource = null;
            ItemsDataGridView.DataSource = items;
            ItemsDataGridView.Visible = true;
        }

        private void BathRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
            var items = dbs.getItems(6);
            ItemsDataGridView.DataSource = null;
            ItemsDataGridView.DataSource = items;
            ItemsDataGridView.Visible = true;
        }

        private void KitchenImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
            var items = dbs.getItems(3);
            ItemsDataGridView.DataSource = null;
            ItemsDataGridView.DataSource = items;
            ItemsDataGridView.Visible = true;
        }

        private void BedRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
            var items = dbs.getItems(4);
            ItemsDataGridView.DataSource = null;
            ItemsDataGridView.DataSource = items;
            ItemsDataGridView.Visible = true;
        }

        //
        //Adott kép kijelölése
        //
        public void selectPictureBox(PictureBox oldPictureBox, PictureBox newPictureBox)
        {
            if (oldPictureBox == newPictureBox)
            {
                oldPictureBox.Padding = new Padding(0, 0, 0, 0);
                oldPictureBox.Refresh();
                selectedPictureBox = null;
                return;
            }

            if (oldPictureBox != null)
            {
                oldPictureBox.Padding = new Padding(0, 0, 0, 0);
                oldPictureBox.Refresh();
            }

            newPictureBox.Padding = new Padding(10, 10, 10, 10);
            newPictureBox.Refresh();

            selectedPictureBox = newPictureBox;
        }

        //
        //Adott eszköz kijelölése szerkesztéshez
        //
        private void ItemStorage_Clicked(object sender, EventArgs e)
        {
            using (var efc = new EFContext())
            {
                try
                {
                    var itemId = (int)ItemsDataGridView.Rows[ItemsDataGridView.SelectedCells[0].RowIndex].Cells[3].Value;
                    selectedItem = efc.Items.First(c => c.Id == itemId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No item in Storage");
                }


            }
        }

        private void AddStorageButton_Click(object sender, EventArgs e)
        {
            using var addStorage = new AddStorage();
            addStorage.ShowDialog();
        }

        private void EditStorageButton_Click(object sender, EventArgs e)
        {
            using var editStorage = new EditDeleteStorage();
            editStorage.ShowDialog();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            using var addItem = new AddItem();
            addItem.ShowDialog();
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {

            if (selectedItem != null)
            {
                using var editItem = new EditDeleteItem(selectedItem);
                editItem.ShowDialog();
            }

        }
    }
}
