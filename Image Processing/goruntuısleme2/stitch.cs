using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Stitching;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;

namespace goruntuısleme2
{
    public partial class stitch : UserControl
    {
        public stitch()
        {
            InitializeComponent();
        }

        private void stitch_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPEG files(*.jpeg)|*.jpeg";
                if (DialogResult.OK == save.ShowDialog())
                {
                    this.pictureBoxOrigin.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
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
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                VectorOfMat images = new VectorOfMat();
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    foreach (var file in dialog.FileNames)
                    {
                        images.Push(new Mat(file));
                    }
                    Brisk detector = new Brisk();
                    WarperCreator warper = new SphericalWarper();
                    Stitcher stitcher = new Stitcher();
                    stitcher.SetFeaturesFinder(detector);
                    stitcher.SetWarper(warper);

                    Mat output = new Mat();
                    var status = stitcher.Stitch(images, output);
                    if (status == Stitcher.Status.Ok)
                    {
                        pictureBoxOrigin.Image = output.ToBitmap();
                    }
                    else
                    {
                        MessageBox.Show("Birleştirilemedi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
