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
    public partial class FormTipper : Form
    {
        private Tipper tipper;

        public FormTipper()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTipper.Width, pictureBoxTipper.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tipper.DrawCar(gr);
            pictureBoxTipper.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tipper = new Tipper(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow, 
                Color.Orange, true, true, true);
            tipper.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTipper.Width,
           pictureBoxTipper.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tipper.MoveTipper(Direction.Up);
                    break;
                case "buttonDown":
                    tipper.MoveTipper(Direction.Down);
                    break;
                case "buttonLeft":
                    tipper.MoveTipper(Direction.Left);
                    break;
                case "buttonRight":
                    tipper.MoveTipper(Direction.Right);
                    break;
            }
            Draw();
        }

        
    }
}
