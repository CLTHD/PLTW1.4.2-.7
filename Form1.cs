using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofile.FileName);

            }

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);

            Manipulating.ConvertToGray(copy);
            this.picResult.Image = copy;

        }

        private void btnSunlight_Click(object sender, EventArgs e)
        {
            Bitmap test = new Bitmap((Bitmap)this.picOriginal.Image);

            Manipulating.ConvertToSunlight(test);
            this.picSunlight.Image = test;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Bitmap flamin = new Bitmap((Bitmap)this.picOriginal.Image);

            Manipulating.ConvertToRed(flamin);
            this.picRed.Image = flamin;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Bitmap grass = new Bitmap((Bitmap)this.picOriginal.Image);

            Manipulating.ConvertToGreen(grass);
            this.picGreen.Image = grass;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Bitmap sea = new Bitmap((Bitmap)this.picOriginal.Image);

            Manipulating.ConvertToBlue(sea);
            this.picBlue.Image = sea;
        }
    }
}
