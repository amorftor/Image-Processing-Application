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
using Emgu.CV.Util;
using Emgu.CV.Stitching;
using Emgu.CV.Features2D;


namespace goruntuısleme2
{
    public partial class watershed : UserControl
    {
        Image<Bgr, byte> imageOrigin;
        Image<Gray, byte> imageGray;
        
        public watershed()
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
            if (checkedListBox1.SelectedItem=="Watershed")
            {
                try
                {
                    int kalinlik = Convert.ToInt32(textBox1.Text);
                    var img = new Bitmap(pictureBoxOrigin.Image).ToImage<Bgr, byte>();
                    var mask = img.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
                    Mat distanceTransofrm = new Mat();
                    CvInvoke.DistanceTransform(mask, distanceTransofrm, null, Emgu.CV.CvEnum.DistType.L2, 3);
                    CvInvoke.Normalize(distanceTransofrm, distanceTransofrm, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
                    var markers = distanceTransofrm.ToImage<Gray, byte>().ThresholdBinary(new Gray(25), new Gray(255));
                    CvInvoke.ConnectedComponents(markers, markers);
                    var finalMarkers = markers.Convert<Gray, Int32>();
                    CvInvoke.Watershed(img, finalMarkers); 
                    Image<Gray, byte> boundaries = finalMarkers.Convert<byte>(delegate(Int32 x)
                    {
                        return (byte)(x == -1 ? 255:0) ;                    
                    });
                    boundaries._Dilate(kalinlik);
                    img.SetValue(new Bgr(0, 255, 0), boundaries);
                    
                    pictureBoxGray.Image = img.ToBitmap();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (checkedListBox1.SelectedItem == "Rotate")
            {
                try
                {
                    Bitmap bm = new Bitmap(pictureBoxOrigin.Image);
                    imageGray = imageOrigin.Convert<Gray, byte>();
                    
                    int aci = Convert.ToInt32(textBox1.Text);

                    Image<Gray, Byte> imgOut = imageGray.Rotate(aci, new Gray(255), false);
                    pictureBoxGray.Image = imgOut.ToBitmap();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                    
                }
            }

           

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem == "Rotate")
            {
                label2.Visible = true;
                textBox1.Visible = true;
                label1.Visible = false;
            }
            else if (checkedListBox1.SelectedItem == "Watershed")
            {
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = false;
            }
            else
            {
                label2.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
            }
        }

        private void watershed_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
        }
    }
}
