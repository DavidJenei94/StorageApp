using StorageAppWeb.Services;
using StorageAppWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAppDesktop
{
    public partial class Form1 : Form
    {

        private PictureBox selectedPictureBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBService dbs = new DBService();
            foreach (var item in dbs.getRooms())
            {
                MessageBox.Show(item.Name);
            }
            
        }

        private void LivingRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
        }

        private void SmallRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
        }

        private void CorridorImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
        }

        private void BathRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
        }

        private void KitchenImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
        }

        private void BedRoomImageBox_Click(object sender, EventArgs e)
        {
            selectPictureBox(selectedPictureBox, (PictureBox)sender);
        }

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
    }
}
