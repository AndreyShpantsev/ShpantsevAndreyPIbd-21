using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTipper
{
    public partial class FormParking : Form
    {
        Parking<ITipper> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITipper>(20, pictureBoxParking.Width,
pictureBoxParking.Height);
            Draw();

        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetTruck_Click_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var truck = new Truck(100, 1000, dialog.Color);
                int place = parking + truck;
                Draw();
            } 
        }

        private void buttonTakeTransport_Click_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(-215, -20, pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    car.DrawTipper(gr);
                    pictureBoxTakeCar.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    pictureBoxTakeCar.Image = bmp;
                }
                Draw();
            }
        }

        private void buttonSetTipper_Click_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var tipper = new Tipper(100, 1000, dialog.Color, dialogDop.Color,
                   true, false, true);
                    int place = parking + tipper;
                    Draw();
                }
            }
        }

    }
}
