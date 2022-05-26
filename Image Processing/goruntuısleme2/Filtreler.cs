using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace goruntuısleme2
{
    public partial class Filtreler : UserControl
    {
        Image<Bgr, byte> imageOrigin;
        Image<Gray, byte> imageGray;
        Image<Gray, byte> imageGaussian { get; set; }
        Image<Gray, float> imageLablace { get; set; }
        Image<Gray, byte> imageFilt { get; set; }
        
        
        public Filtreler()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSec.Left;
            OpenFileDialog resim = new OpenFileDialog();
            if (resim.ShowDialog() == DialogResult.OK)
            {
                imageOrigin = new Image<Bgr, byte>(resim.FileName);
                imageGray = imageOrigin.Convert<Gray, byte>();
                pictureBoxOrigin.Image = imageGray.ToBitmap();
                label1.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSave.Left;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if (DialogResult.OK == save.ShowDialog())
            {
                this.pictureBoxGray.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            #region gaussian filter
            try
            {
                if (checkedListBox1.SelectedItem == "Gaussian filter")
                {


                    imageGray = imageOrigin.Convert<Gray, byte>();
                    pictureBoxOrigin.Image = imageGray.ToBitmap();

                    imageGaussian = new Image<Gray, byte>(imageGray.Height, imageGray.Width, new Gray(0));
                    int gaussianDeger = Convert.ToInt32(textBox1.Text);

                    Size size = new Size(gaussianDeger, gaussianDeger);
                    CvInvoke.GaussianBlur(imageGray, imageGaussian, size, 2);
                    pictureBoxGray.Image = imageGaussian.ToBitmap();
                    label1.Visible = false;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            #endregion

            #region lablace filter
            if (checkedListBox1.SelectedItem == "Lablace filter")
            {
                try
                {
                            imageGray = imageOrigin.Convert<Gray, byte>();
                            pictureBoxOrigin.Image = imageGray.ToBitmap();
                            int lablaceDeger = Convert.ToInt32(textBox1.Text);

                            imageLablace = imageGray.Laplace(lablaceDeger);
                            pictureBoxGray.Image = imageLablace.ToBitmap();
                            label1.Visible = false;
                       
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            #endregion
            try
            {
                if (checkedListBox1.SelectedItem == "LOG")
                {

                    Image<Gray, byte> imgGray = imageOrigin.Convert<Gray, byte>();
                    imgGray = imageOrigin.Convert<Gray, byte>();
                    pictureBoxOrigin.Image = imgGray.ToBitmap();

                    int gaussianDeger = Convert.ToInt32(textBox1.Text);

                    Size size = new Size(gaussianDeger, gaussianDeger);
                    imageGaussian = new Image<Gray, byte>(imgGray.Height, imgGray.Width, new Gray(0));
                    CvInvoke.GaussianBlur(imgGray, imageGaussian, size, 2);



                    Image<Gray, float> imgLaplacian = new Image<Gray, float>(imageGaussian.Width, imageGaussian.Height, new Gray(0));

                    imgLaplacian = imgGray.Laplace(3);
                    pictureBoxGray.Image = imgLaplacian.ToBitmap();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFilt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGray_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBoxOrigin_Click(object sender, EventArgs e)
        {

        }

        private void Filtreler_Load(object sender, EventArgs e)
        {

        }
    }
}
