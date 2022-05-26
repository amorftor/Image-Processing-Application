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
    public partial class Histogram : UserControl
    {
        Image<Bgr, byte> imageOrigin;
        Image<Gray, byte> imageGray;
        public Image<Gray, byte> grayımage { get; set; }
        Image<Gray, byte> blur { get; set; }
        Image<Gray, byte> sonresim { get; set; }
        Size size = new Size(7, 7);
        double kernel, alfa, beta, gama;
        

        public Histogram()
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
            if (pictureBoxOrigin.Image == null)
            {
                MessageBox.Show("Lütfen resim seçin!", "Resim uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OpenFileDialog resim = new OpenFileDialog();
                if (resim.ShowDialog() == DialogResult.OK)
                {
                    imageOrigin = new Image<Bgr, byte>(resim.FileName);
                    imageGray = imageOrigin.Convert<Gray, byte>();
                    pictureBoxOrigin.Image = imageGray.ToBitmap();

                }

            }
            if (checkedListBox1.SelectedItem == "Histogram Equalization ")
            {

                Mat histeq = new Mat();
                CvInvoke.EqualizeHist(imageGray, histeq);
                pictureBoxGray.Image = histeq.ToBitmap();
                
            }
            if (checkedListBox1.SelectedItem == "CLAHE")
            {
                
                try
                {
                    int chaleDeger = Convert.ToInt32(textBox1.Text);
                    Mat CLAHE = new Mat();
                    CvInvoke.CLAHE(imageGray, chaleDeger, new Size(8, 8), CLAHE);
                    pictureBoxGray.Image = CLAHE.ToBitmap();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (checkedListBox1.SelectedItem == "Keskinleştirme")
            {

                try
                {
                    sonresim = new Image<Gray, byte>(imageGray.Width, imageGray.Height);
                    blur = new Image<Gray, byte>(imageGray.Width, imageGray.Height);

                    kernel = Convert.ToInt32(tb1.Text);
                    alfa = Convert.ToDouble(tb2.Text);
                    beta = Convert.ToDouble(tb3.Text);
                    gama = Convert.ToDouble(tb4.Text);
                    CvInvoke.GaussianBlur(grayımage, blur, size, kernel);
                    CvInvoke.AddWeighted(grayımage, alfa, blur, beta * -1, gama, sonresim);
                    pictureBoxGray.Image = sonresim.ToBitmap();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }




        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            tb4.Visible = false;


            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem == "CLAHE")
            {
                label1.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                textBox1.Visible = false;
            }
            if (checkedListBox1.SelectedItem=="Keskinleştirme")
            {
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = true;
                tb4.Visible = true;


                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                
            }
            else
            {
                tb1.Visible = false;
                tb2.Visible = false;
                tb3.Visible = false;
                tb4.Visible = false;
                

                label2.Visible = false;
                label2.Visible = false;
                label2.Visible = false;
                label2.Visible = false;
               
            }
        }
    }
}
