using SteganographyApp.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace SteganographyApp
{
    public partial class Form1 : Form
    {
        private string bmpFile;
        private string sourceFile;
        private static int nrBit = 3;
        private string _decryptImg;

        public Form1()
        {
            InitializeComponent();
        }

        private void openAndDecryptFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP files (*.bmp)|*.bmp;";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var bmp = new BitmapImage(new Uri(openFileDialog.FileName));
                int pixelFormat = bmp.Format.BitsPerPixel;

                if (pixelFormat < 24)
                {
                    MessageBox.Show("You have to choose at least 24-bit bmp file");
                }
                else
                {
                    _decryptImg = openFileDialog.FileName;
                    decryptPictureBox.Image = new Bitmap(_decryptImg);
                }
            }
        }
        private void saveDecryptedFileButton_Click(object sender, EventArgs e)
        {
            if(outcomePictureBox.Image == null)
            {
                MessageBox.Show("There is no decrypted file to save");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outcomePictureBox.Image.Save(saveFileDialog.FileName + ".bmp");
                }
            }
        }

        private void saveEncodedFileButton_Click(object sender, EventArgs e)
        {
            if(afterPictureBox.Image == null)
            {
              MessageBox.Show("There is no encoded bmp file to save!");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    afterPictureBox.Image.Save(saveFileDialog.FileName + ".bmp");
                }
            }

        }

        private void selectSourceFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP files (*.bmp)|*.bmp;;";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFile = openFileDialog.FileName;
                sourceNameLabel.Text = Path.GetFileName(sourceFile);
                FileInfo fileInfo = new FileInfo(sourceFile);
                var fileSize = fileInfo.Length;
                sourceSizeLabel.Text = fileSize.ToString() + " B";
                infoPictureBox.Image = new Bitmap(sourceFile);
            }
            else
            {
                MessageBox.Show("Source file failed to load!");
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (decryptPictureBox.Image == null)
            {
                MessageBox.Show("There is no bmp file to decrypt");
            }
            else
            {
                try
                {
                    outcomePictureBox.Image = SteganographyHelper.DecryptBitmap((Bitmap)decryptPictureBox.Image, nrBit);
                }
                catch(Exception)
                {
                    MessageBox.Show("The file couldnot be decoded");
                }
            }
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            if ((bmpFile == null) || (sourceFile == null))
            {
                MessageBox.Show("You have to load bmp file and file to encrypt!");
            }
            else
            {
               
                Image containerImg = Image.FromFile(bmpFile);
                Image toHideImg = Image.FromFile(sourceFile);

                Bitmap containerBitmap = new Bitmap(containerImg);
                Bitmap toHideBitap = new Bitmap(toHideImg);


                try
                {
                    afterPictureBox.Image = SteganographyHelper.EncryptBitmap(containerBitmap, toHideBitap, nrBit);
                }
                catch(Exception)
                {
                    MessageBox.Show("The file couldnot be encoded");
                }

            }
        }

        private void selectBmpFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP files (*.bmp)|*.bmp;";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var bmp = new BitmapImage(new Uri(openFileDialog.FileName));
                int pixelFormat = bmp.Format.BitsPerPixel;

                if (pixelFormat < 24)
                {
                    MessageBox.Show("You have to choose at least 24-bit bmp file");
                }
                else
                {
                    bmpFile = openFileDialog.FileName;
                    beforePictoreBox.Image = new Bitmap(bmpFile);
                    bmpNameLabel.Text = Path.GetFileName(bmpFile);
                    FileInfo fileInfo = new FileInfo(bmpFile);
                    var fileSize = fileInfo.Length;
                    bmpSizeLabel.Text = fileSize.ToString() + " B";
                    var image = Image.FromFile(bmpFile);
                    bmpResolutionLabel.Text = image.Width.ToString() + "x" + image.Height.ToString();
                }
            }
            else
            {
                MessageBox.Show("BMP file failed to load!");
            }
        }
    }
}
