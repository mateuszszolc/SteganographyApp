using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteganographyApp.ViewModel
{
    public  class SteganographyHelper
    {
       
        public static Bitmap EncryptBitmap(Bitmap container, Bitmap hide, int bits)
        {
            int movement = (8 - bits);
            int mask = 0xFF << bits;
            int hideMask = 0xFF >> movement;

            Bitmap outcome = new Bitmap(container.Width, container.Height);

            for (int i = 0; i < container.Width; i++)
            {
                for (int j = 0; j < container.Height; j++)
                {
                    Color color = container.GetPixel(i, j);
                    Color colorHide = hide.GetPixel(i, j);

                    int RED = (color.R & mask) + ((colorHide.R >> movement) & hideMask);
                    int GREEN = (color.G & mask) + ((colorHide.G >> movement) & hideMask);
                    int BLUE = (color.B & mask) + ((colorHide.B >> movement) & hideMask);
                    outcome.SetPixel(i, j, Color.FromArgb(RED, GREEN, BLUE));
                }
            }
            return outcome;
        }

        public static Bitmap DecryptBitmap(Bitmap encrypted, int bits)
        {
            int movement = (8 - bits);
            int mask = 0xFF >> movement;
            Bitmap decrypted = new Bitmap(encrypted.Width, encrypted.Height);
            for (int x = 0; x < encrypted.Width; x++)
            {
                for (int y = 0; y < encrypted.Height; y++)
                {
                    Color color = encrypted.GetPixel(x, y);
                    int r = (color.R & mask) << movement;
                    int g = (color.G & mask) << movement;
                    int b = (color.B & mask) << movement;
                    decrypted.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return decrypted;
        }

    }
}
