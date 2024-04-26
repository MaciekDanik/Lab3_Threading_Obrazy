using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Threading_Obrazy
{
    public partial class ImageForm : Form
    {
        private OpenFileDialog ofd;
        private Bitmap? img;
        private Bitmap? img1;
        private Bitmap? img2;
        private Bitmap? img3;
        public ImageForm()
        {
            InitializeComponent();
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog()
            {
                FileName = "Select image file",
                Filter = "jpg files(*.jpg) | *.jpg",
                Title = "Select image"
            };

            ofd.ShowDialog();
            var file = ofd.FileName;

            if (file != null)
            {
                img = new Bitmap(file);
                img1 = new Bitmap(file);
                img2 = new Bitmap(file);
                img3 = new Bitmap(file);
                picBox_OGpic.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox_OGpic.Image = img;
            }
        }

        public Bitmap Threshold(Bitmap img)
        {
            double avgBright = 0;
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    // Get the brightness of this pixel
                    avgBright += img.GetPixel(x, y).GetBrightness();
                }
            }

            // Get the average brightness and limit it's min / max
            avgBright = avgBright / (img.Width * img.Height);
            avgBright = avgBright < .3 ? .3 : avgBright;
            avgBright = avgBright > .7 ? .7 : avgBright;

            // Convert image to black and white based on average brightness
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    // Set this pixel to black or white based on threshold
                    if (img.GetPixel(x, y).GetBrightness() > avgBright) img.SetPixel(x, y, Color.White);
                    else img.SetPixel(x, y, Color.Black);
                }
            }
            return img;

        }

        public void SetPixelColor(Bitmap image, int x, int y, int red, int green, int blue)
        {
            if (x >= 0 && x < image.Width && y >= 0 && y < image.Height)
            {
                image.SetPixel(x, y, Color.FromArgb(red, green, blue));
            }
        }
        public Bitmap Negative(Bitmap img) 
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    // Get the brightness of this pixel
                    var color = img.GetPixel(x, y);
                    int R = 255 - color.R;
                    int G = 255 - color.G;
                    int B = 255 - color.B;

                    SetPixelColor(img,x, y, R, G, B);
                }
            }

            return img;
        }

        public Bitmap GrayScale(Bitmap img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int avg = 0;
                    var color = img.GetPixel(x, y);
                    avg = (color.R + color.G + color.B)/3;

                    SetPixelColor(img, x, y, avg, avg, avg);

                }
            }

            return img;
        }

        public Bitmap GreenCol(Bitmap img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var color = img.GetPixel(x, y);
                    SetPixelColor(img, x, y, 0, (int)color.G , 0);

                }
            }
            return img;
        }

        public Bitmap MirrorRotation(Bitmap img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int lx = 0, rx = img.Width - 1; lx < img.Width; lx++, rx--)
                {
                    Color p = img.GetPixel(lx, y);

                    //MirrorImg.SetPixel(lx, y, p);
                    img.SetPixel(rx, y, p);
                }
            }

            return img;

        }

        private void btn_ImageOperations_Click(object sender, EventArgs e)
        {

            Bitmap thres;
            Bitmap neg;
            Bitmap gray;
            Bitmap green;

            picBox_Progowanie.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox_Negatyw.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox_Gray.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox_green.SizeMode = PictureBoxSizeMode.StretchImage;

            ParallelOptions opt = new ParallelOptions() { MaxDegreeOfParallelism = 6 };
            Parallel.For(0, 4, opt, x =>
            {
                if(x==0)
                {
                    thres = Threshold(img);
                    picBox_Progowanie.Image = thres;
                }
                else if(x==1)
                {
                    neg = Negative(img1);
                    picBox_Negatyw.Image = neg;
                }
                else if(x==2)
                {
                    gray = GrayScale(img2);
                    picBox_Gray.Image = gray;
                }
                else if(x==3)
                {
                    green = GreenCol(img3);
                    //green = MirrorRotation(img3);
                    picBox_green.Image = green;
                }
            });
        }
    }
}
