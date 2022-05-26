using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;



namespace goruntuısleme2
{
    public partial class griTon : UserControl
    {
        public griTon()
        {
            InitializeComponent();
          
        }
        Image<Bgr, byte> imageOrigin;
        Image<Gray, byte> imageGray;
        Image<Gray, byte> imgBinarize;
        Image<Gray, byte> imageTreshold { get; set; }
        

        private void btnSec_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSec.Left;
            OpenFileDialog resim = new OpenFileDialog();
            if (resim.ShowDialog()==DialogResult.OK)
            {
                imageOrigin = new Image<Bgr, byte>(resim.FileName);
                pictureBoxOrigin.Image = imageOrigin.ToBitmap();
                
            }
            
        }

        private void btnGriyap_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (pictureBoxOrigin.Image==null)
            {
                MessageBox.Show("Lütfen resim seçin!", "Resim uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OpenFileDialog resim = new OpenFileDialog();
                if (resim.ShowDialog() == DialogResult.OK)
                {
                    imageOrigin = new Image<Bgr, byte>(resim.FileName);
                    pictureBoxOrigin.Image = imageOrigin.ToBitmap();
                    
                }

            }
            if (checkedListBox1.SelectedItem=="Gri ton")
            {
               
                try
                {
                    imageGray = imageOrigin.Convert<Gray, byte>();
                    pictureBoxGray.Image = imageGray.ToBitmap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            }
            //trashold
            
            if (checkedListBox1.SelectedItem == "YCrCb")
            {

                try
                {
                    Image<Ycc, byte> imageYcc = new Image<Ycc, byte>(imageOrigin.Width, imageOrigin.Height);

                    CvInvoke.CvtColor(imageOrigin, imageYcc, Emgu.CV.CvEnum.ColorConversion.YCrCb2Rgb);
                    pictureBoxGray.Image = imageYcc.ToBitmap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            }
            if (checkedListBox1.SelectedItem == "HSV")
            {

                try
                {
                    Image<Ycc, byte> imageHsv = new Image<Ycc, byte>(imageOrigin.Width,imageOrigin.Height);

                    CvInvoke.CvtColor(imageOrigin, imageHsv, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
                    pictureBoxGray.Image = imageHsv.ToBitmap();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            if (checkedListBox1.SelectedItem == "LUV")
            {

                try
                {
                    Image<Ycc, byte> imageLuv = new Image<Ycc, byte>(imageOrigin.Width, imageOrigin.Height);

                    CvInvoke.CvtColor(imageOrigin, imageLuv, Emgu.CV.CvEnum.ColorConversion.Bgr2Luv);
                    pictureBoxGray.Image = imageLuv.ToBitmap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }

            #region Treshold ve adaptif th

            
            if (checkedListBox1.SelectedItem == "Threshold")
            {

                if (checkedListBox2.SelectedItem == "Binary")
                {
                    try
                    {
                        imageGray = imageOrigin.Convert<Gray, byte>();
                        double trasholdDeger = Convert.ToInt32(textBox1.Text);
                        imgBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

                        CvInvoke.Threshold(imageGray, imgBinarize, trasholdDeger, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                        pictureBoxGray.Image = imgBinarize.ToBitmap();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                if (checkedListBox2.SelectedItem == "BinaryInv")
                {
                    try
                    {
                        imageGray = imageOrigin.Convert<Gray, byte>();
                        double trasholdDeger = Convert.ToInt32(textBox1.Text);
                        imgBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

                        CvInvoke.Threshold(imageGray, imgBinarize, trasholdDeger, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);

                        pictureBoxGray.Image = imgBinarize.ToBitmap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    


                }
                if (checkedListBox2.SelectedItem == "Otsu")
                {
                    try
                    {
                        imageGray = imageOrigin.Convert<Gray, byte>();
                        double trasholdDeger = Convert.ToInt32(textBox1.Text);
                        imgBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

                        CvInvoke.Threshold(imageGray, imgBinarize, trasholdDeger, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);

                        pictureBoxGray.Image = imgBinarize.ToBitmap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                   


                }

            }

            if (checkedListBox1.SelectedItem == "Adaptive Th.")
            {

                if (checkedListBox2.SelectedItem == "Binary")
                {
                    try
                    {
                        imageGray = imageOrigin.Convert<Gray, byte>();
                        int trasholdDeger = Convert.ToInt32(textBox1.Text);
                        imageTreshold = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

                        CvInvoke.AdaptiveThreshold(imageGray, imageTreshold, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, trasholdDeger, 0.0);

                        pictureBoxGray.Image = imageTreshold.ToBitmap();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                if (checkedListBox2.SelectedItem == "BinaryInv")
                {
                    try
                    {
                        imageGray = imageOrigin.Convert<Gray, byte>();
                        int trasholdDeger = Convert.ToInt32(textBox1.Text);
                        imageTreshold = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

                        CvInvoke.AdaptiveThreshold(imageGray, imageTreshold, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.BinaryInv, trasholdDeger, 0.0);
                        pictureBoxGray.Image = imageTreshold.ToBitmap();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }


                }
                if (checkedListBox2.SelectedItem == "Otsu")
                {
                    try
                    {
                        imageGray = imageOrigin.Convert<Gray, byte>();
                        double trasholdDeger = Convert.ToInt32(textBox1.Text);
                        imgBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

                        CvInvoke.Threshold(imageGray, imgBinarize, trasholdDeger, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);

                        pictureBoxGray.Image = imgBinarize.ToBitmap();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }


                }

            }
            #endregion



        }

        private void griTon_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Visible = false;
            checkedListBox2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem == "Adaptive Th.")
            {
                checkedListBox2.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
            }
            else if (checkedListBox1.SelectedItem == "Threshold")
            {
                checkedListBox2.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                checkedListBox2.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
            }
            
        }
    }
}
