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
    public partial class Edge : UserControl
    {
        Image<Bgr, byte> imageOrigin;

        Image<Gray, byte> imageGray;
        Image<Gray, byte> imageCanny { get; set; }
        Image<Gray, float> imageSobel { get; set; }
        Image<Gray, float> imageLablacian { get; set; }
        public Edge()
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
            
            if (pictureBoxOrigin.Image==null)
            {
                MessageBox.Show("Lütfen resim seçiniz!!","Resim hatası", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

                if (checkedListBox1.SelectedItem == "Canny")
                {
                


                try
                     {
                         int deger1 = Convert.ToInt32(textBox1.Text);
                         int deger2 = Convert.ToInt32(textBox2.Text);
                         imageCanny = new Image<Gray, byte>(imageGray.Height, imageGray.Width, new Gray(0));
                         imageCanny = imageGray.Canny(deger1, deger2);
                         pictureBoxGray.Image = imageCanny.ToBitmap();
                     }
                    catch (Exception)
                     {
                        MessageBox.Show("Lütfen kenar belirleme için geçerli değer giriniz!", "Değer uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                     }
                }
            if (checkedListBox1.SelectedItem == "Sobel")
            {
                
                try
                {
                    int deger1 = Convert.ToInt32(textBox1.Text);
                    int deger2 = Convert.ToInt32(textBox2.Text);
                    int deger3 = Convert.ToInt32(textBox3.Text);
                    imageSobel = new Image<Gray, float>(imageGray.Height, imageGray.Width, new Gray(0));
                    imageSobel = imageGray.Sobel(deger1,deger2,deger3);
                    pictureBoxGray.Image = imageSobel.ToBitmap();
                }
                catch (Exception )
                {
                    MessageBox.Show("Lütfen kenar belirleme için geçerli değer giriniz!", "Değer uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (checkedListBox1.SelectedItem == "Lablacian")
            {
                
                try
                {
                    int deger2 = Convert.ToInt32(textBox2.Text);
                    imageLablacian = new Image<Gray, float>(imageGray.Height, imageGray.Width, new Gray(0));
                    imageLablacian = imageGray.Laplace(deger2);
                    pictureBoxGray.Image = imageLablacian.ToBitmap();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen kenar belirleme için geçerli değer giriniz!", "Değer uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem=="Canny")
            {
                textBox3.Visible = false;
                textBox2.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (checkedListBox1.SelectedItem == "Sobel")
            {
                textBox3.Visible = true;
                textBox2.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (checkedListBox1.SelectedItem == "Lablacian")
            {
                textBox3.Visible = false;
                textBox2.Visible = true;
                textBox1.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void Edge_Load(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            textBox2.Visible = true;
            textBox1.Visible = false;
        }
    }
}
