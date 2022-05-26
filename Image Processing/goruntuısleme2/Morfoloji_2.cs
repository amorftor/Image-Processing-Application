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
    public partial class Morfoloji_2 : UserControl
    {
        Image<Bgr, byte> imageOrigin;

        public Morfoloji_2()
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
            if (checkedListBox1.SelectedItem == "Open")
            {
                try
                {
                    int OpenValue = Convert.ToInt32(textBox1.Text);
                    Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
                   pictureBoxGray.Image= imageOrigin.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Open,kernel, new Point(-1, -1), OpenValue, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0)).ToBitmap();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            if (checkedListBox1.SelectedItem == "Close")
            {
                try
                {
                    int OpenValue = Convert.ToInt32(textBox1.Text);
                    Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
                    pictureBoxGray.Image = imageOrigin.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Close, kernel, new Point(-1, -1), OpenValue, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0)).ToBitmap();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            if (checkedListBox1.SelectedItem == "Gradient")
            {
                try
                {
                    int OpenValue = Convert.ToInt32(textBox1.Text);
                    Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
                    pictureBoxGray.Image = imageOrigin.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Gradient, kernel, new Point(-1, -1), OpenValue, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0)).ToBitmap();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            if (checkedListBox1.SelectedItem == "Top hat")
            {
                try
                {
                    int OpenValue = Convert.ToInt32(textBox1.Text);
                    Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
                    pictureBoxGray.Image = imageOrigin.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Tophat, kernel, new Point(-1, -1), OpenValue, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0)).ToBitmap();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            if (checkedListBox1.SelectedItem == "Black hat")
            {
                try
                {
                    int OpenValue = Convert.ToInt32(textBox1.Text);
                    Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
                    pictureBoxGray.Image = imageOrigin.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Blackhat, kernel, new Point(-1, -1), OpenValue, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0)).ToBitmap();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Lütfen döngü değeri giriniz!", "Değer uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }
    }
}
