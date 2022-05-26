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

namespace goruntuısleme2
{
    public partial class grabCut : UserControl
    {
        Dictionary<string, Image<Bgr, byte>> imgList;
        Rectangle rect;
        Point StartROI, ENDROI;
        bool Selecting, MouseDown;
        

        public grabCut()
        {
            InitializeComponent();
            Selecting = false;
            rect =Rectangle.Empty;
            imgList = new Dictionary<string, Image<Bgr, byte>>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            panel1.Left = btnSave.Left;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if (DialogResult.OK == save.ShowDialog())
            {
                this.pictureBoxOrigin.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void grabCut_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxOrigin_MouseDown(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                MouseDown = true;
                StartROI = e.Location;
            }
        }

        private void pictureBoxOrigin_MouseMove(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
                int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
                rect = new Rectangle(Math.Min(StartROI.X, e.X), Math.Min(StartROI.Y, e.Y), width, height);
                Refresh();

            }
        }

        private void pictureBoxOrigin_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Yellow,3))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void pictureBoxOrigin_MouseUp(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                Selecting = false;
                MouseDown = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void selectROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selecting = true;
        }

        private void getRegionROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxOrigin.Image == null) return;
                if (rect == Rectangle.Empty) return;
                var img = new Bitmap(pictureBoxOrigin.Image).ToImage<Bgr, byte>();
                img.ROI = rect;
                var imgROI = img.Copy();
                img.ROI = Rectangle.Empty;
                pictureBoxOrigin.Image = imgROI.ToBitmap();
                AddImage(imgROI, "ROI Image");

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                pictureBoxOrigin.Image = imgList[e.Node.Text].AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void processROIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private int GetBiggestContourID(VectorOfVectorOfPoint contours)
        {
            double maxArea = double.MaxValue * (-1);
            int contourId = -1;
            for (int i = 0; i < contours.Size; i++)
            {
                double area = CvInvoke.ContourArea(contours[i]);
                if (area>maxArea)
                {
                    maxArea = area;
                    contourId = i;

                }
            }return contourId;
            
        }

        private void grabToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {
                if (pictureBoxOrigin.Image == null) return;
                var img = new Bitmap(pictureBoxOrigin.Image).ToImage<Bgr, byte>();
                var gray = img.Convert<Gray, byte>();
                var output = img.GrabCut(rect, 1);
                var img2 = output.Convert<byte>(delegate(byte b) {

                    return (b == 1 || b == 3) ? (byte)255 :(byte)0;

                });
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat m = new Mat();
                CvInvoke.FindContours(img2, contours, m, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                CvInvoke.DrawContours(img, contours, GetBiggestContourID(contours), new MCvScalar(0, 0, 255),3); 
                pictureBoxOrigin.Image = img.AsBitmap();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void harisCornerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgList["Input"] == null) return;

                int threshold = 150;
                var img = imgList["Input"].Clone();
                var gray = img.Convert<Gray, byte>();
                var corners = new Mat();
                CvInvoke.CornerHarris(gray,corners,2);
                CvInvoke.Normalize(corners, corners, 255, 0, Emgu.CV.CvEnum.NormType.MinMax);

                Matrix<float> matrix = new Matrix<float>(corners.Rows, corners.Cols);
                corners.CopyTo(matrix);
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        if (matrix[i,j]>threshold)
                        {
                            CvInvoke.Circle(img, new Point(j, i), 5, new MCvScalar(0, 0, 255),1);
                        }
                    }

                }
                pictureBoxOrigin.Image = img.AsBitmap();
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            try
            {
                imgList.Clear();
                panel1.Left = btnSec.Left;
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var img = new Image<Bgr, byte>(dialog.FileName);
                    AddImage(img, "Input");
                    pictureBoxOrigin.Image = img.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

        }
        private void AddImage(Image<Bgr,byte>img, string keyname)
        {
            if (!treeView1.Nodes.ContainsKey(keyname))
            {
                TreeNode node = new TreeNode(keyname);
                node.Name = keyname;
                treeView1.Nodes.Add(node);
                treeView1.SelectedNode = node;

            }
            if (!imgList.ContainsKey(keyname))
            {
                imgList.Add(keyname, img);
            }
            else
            {
                imgList[keyname] = img;
            }

        }
    }
}
