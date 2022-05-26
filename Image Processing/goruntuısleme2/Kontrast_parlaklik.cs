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
    public partial class Kontrast_parlaklik : UserControl
    {
        Image<Bgr, byte> imageOrigin;
        Image<Gray, byte> imageGray;
        public Kontrast_parlaklik()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSec.Left;

            OpenFileDialog resim = new OpenFileDialog();
            if (resim.ShowDialog() == DialogResult.OK)
            {
                imageOrigin = new Image<Bgr, byte>(resim.FileName);
                pictureBoxKontr.Image = imageOrigin.ToBitmap();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSave.Left;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if (DialogResult.OK == save.ShowDialog())
            {
                this.pictureBoxKontr.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void Kontrast_parlaklik_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {

                try
                {
                    var degisenResim = imageOrigin.Mul((Convert.ToDouble(trackBar1.Value/100))) + trackBar2.Value;
                    pictureBoxKontr.Image = degisenResim.AsBitmap();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var degisenResim = imageOrigin.Mul((Convert.ToDouble(trackBar1.Value/100))) + trackBar2.Value;
                pictureBoxKontr.Image = degisenResim.AsBitmap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
        }
    }
}
