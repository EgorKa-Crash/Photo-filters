using System; 
using System.Drawing; 
using System.Windows.Forms;

namespace CGLaba4
{
    public partial class PhotoFilters : Form
    {
        public PhotoFilters()
        {
            InitializeComponent();
        }
        Bitmap image;
        Bitmap image1;

        private void OpenFileClick(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GrayFilterClick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap origImage = new Bitmap(pictureBox1.Image);
                Bitmap newImage = new Bitmap(origImage.Width, origImage.Height);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                for (int i = 0; i < origImage.Width; i++)
                {
                    for (int j = 0; j < origImage.Height; j++)
                    {
                        Color clr = origImage.GetPixel(i, j);
                        int newClr = (int)(clr.R * 0.3 + clr.G * 0.59 + clr.B * 0.11);
                        newImage.SetPixel(i, j, Color.FromArgb(newClr, newClr, newClr));
                    }
                }
                pictureBox2.Image = newImage;
                image1 = newImage;
            }
        }

        private void LinecontrastFilterClick(object sender, EventArgs e)
        {
            if (image1 != null)//pictureBox1.Image != null)
            {
                float f0 = float.Parse(linecontrastVal.Text) / 255;
                int gmin = 0;
                int gMax = 255;
                Bitmap origImage = new Bitmap(image1);//(pictureBox1.Image);
                Bitmap newImage = new Bitmap(origImage.Width, origImage.Height);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                for (int i = 0; i < origImage.Width; i++)
                {
                    for (int j = 0; j < origImage.Height; j++)
                    {
                        float f = origImage.GetPixel(i, j).GetBrightness();
                        int g = f > f0 ? gmin : gMax;
                        newImage.SetPixel(i, j, Color.FromArgb(g, Color.Black));
                    }
                }
                pictureBox3.Image = newImage;
            }
        }

        private void BlurFilterClick(object sender, EventArgs e)
        {
            Bitmap orig = new Bitmap(pictureBox1.Image);
            Bitmap bluringP = new Bitmap(orig.Width, orig.Height);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            for (int i = 2; i < orig.Height - 2 ; i++)
                for (int j = 2; j < orig.Width - 2; j++)
                    CountXatrix(i, j, bluringP);
            pictureBox4.Image = bluringP;

        }
        private void CountXatrix(int i, int j, Bitmap bluringImage)
        {
            if (image != null)
            {
                float ResR = new float();
                float ResG = new float();
                float ResB = new float();
                float X = new float();

                for (int k = i - 2; k < i + 3; k++)
                    for (int z = j - 2; z < j + 3; z++)
                    {
                        Color clr = image.GetPixel(z, k);

                        ResR += clr.R * Matr[k + 2 - i, z + 2 - j];
                        ResG += clr.G * Matr[k + 2 - i, z + 2 - j];
                        ResB += clr.B * Matr[k + 2 - i, z + 2 - j];

                        X += Matr[k + 2 - i, z + 2 - j];
                    }
                int ResRR = Convert.ToInt32(ResR / X);
                int ResGG = Convert.ToInt32(ResG / X);
                int ResBB = Convert.ToInt32(ResB / X);
                bluringImage.SetPixel(j, i, Color.FromArgb(ResRR, ResGG, ResBB));
            }
               
        }
          
        float[,] Matr = new float[5, 5] { { 1f, 1f, 1f, 1f, 1f }, 
            { 1f, 1f, 1f, 1f, 1f }, 
            { 1f, 1f, 1f, 1f, 1f }, 
            { 1f, 1f, 1f, 1f, 1f }, 
            { 1f, 1f, 1f, 1f, 1f } };  
    }
}
