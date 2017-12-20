using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulation
{
    class Manipulating
    {
        public Manipulating()
        {

        }
        public static bool ConvertToGray(Bitmap b)
        {
            for (int i=0;i<b.Width;i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
        }
        public static bool ConvertToSunlight(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    int a = c.A;
                    int r = c.R;
                    int g = c.G;
                    int b1 = c.B;

                    b.SetPixel(i, j, Color.FromArgb(r, g, 100));
                }
            return true;
        }
        public static bool ConvertToRed(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    int a = c.A;
                    int r = c.R;
                    int g = c.G;
                    int b1 = c.B;

                    b.SetPixel(i, j, Color.FromArgb(r, 20, 20));
                }
            return true;
        }
        public static bool ConvertToGreen(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    int a = c.A;
                    int r = c.R;
                    int g = c.G;
                    int b1 = c.B;

                    b.SetPixel(i, j, Color.FromArgb(20, g, 20));
                }
            return true;
        }
        public static bool ConvertToBlue(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    int a = c.A;
                    int r = c.R;
                    int g = c.G;
                    int b1 = c.B;

                    b.SetPixel(i, j, Color.FromArgb(10, 10, b1));
                }
            return true;
        }
    }
}
