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
    public partial class Morfoloji : UserControl
    {
        Image<Bgr, byte> imageOrigin;
        Image<Gray, byte> imgGray;
        public Morfoloji()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSec.Left;
            try
            {
                OpenFileDialog resim = new OpenFileDialog();
                if (resim.ShowDialog() == DialogResult.OK)
                {
                    imageOrigin = new Image<Bgr, byte>(resim.FileName);

                    pictureBoxOrigin.Image = imageOrigin.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSec.Left;
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPEG files(*.jpeg)|*.jpeg";
                if (DialogResult.OK == save.ShowDialog())
                {
                    this.pictureBoxGray.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.SelectedItem == "Erosion")
            {
                try
                {
                    int erosionValue = Convert.ToInt32(textBox1.Text);
                    pictureBoxGray.Image = imageOrigin.Erode(erosionValue).ToBitmap();
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            if (checkedListBox1.SelectedItem == "Dilation")
            {
                try
                {
                    int erosionValue = Convert.ToInt32(textBox1.Text);

                    pictureBoxGray.Image = imageOrigin.Dilate(erosionValue).ToBitmap();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
           

            
        }
    }
}
