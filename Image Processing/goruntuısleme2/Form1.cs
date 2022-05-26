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
using System.Diagnostics;

namespace goruntuısleme2
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();

            customiseDesing();
            
        }
        
        private void customiseDesing()
        {
            panelMenu.Visible = false;
            panelMenu2.Visible = false;
            panelMenu3.Visible = false;
            panelMenu4.Visible=false;
            panelMenu5.Visible = false;
            


            //... devam edebiliriz.
        }
        #region Görüür_Görünmez
        private void hideMenu()
        {
            if (panelMenu.Visible == true)
                panelMenu.Visible = false;

            if (panelMenu2.Visible == true)
                panelMenu2.Visible = false ;

            if (panelMenu3.Visible == true)
                panelMenu3.Visible = false;

            if (panelMenu4.Visible == true)
                panelMenu4.Visible = false;

            if (panelMenu5.Visible == true)
                panelMenu5.Visible = false;

                
           

        }
        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion
        
        private void Form1_Load(object sender, EventArgs e)
        {
            kontrast_parlaklik1.Visible = false;
            griTon1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            showMenu(panelMenu);
            anaMenu1.Visible = true;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            showMenu(panelMenu2);
            anaMenu1.Visible = true;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            watershed1.Visible = false;
            morfoloji_2.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            showMenu(panelMenu3);
            anaMenu1.Visible = true;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kapatmak istediğinize emin misiniz? ", "Çıkış uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btnGri_Click(object sender, EventArgs e)
        {
            griTon1.Visible = true;
            anaMenu1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void btnKont_Click(object sender, EventArgs e)
        {
            kontrast_parlaklik1.Visible = true;
            griTon1.Visible = false;
            anaMenu1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void btnesikleme_Click(object sender, EventArgs e)
        {
            griTon1.Visible = false;
            anaMenu1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = true;
            filtreler1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void btnMean_Click(object sender, EventArgs e)
        {
            griTon1.Visible = false;
            anaMenu1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            morfoloji1.Visible = false;
            filtreler1.Visible = true;
            watershed1.Visible = false;
            morfoloji_2.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;

        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            anaMenu1.Visible = false;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = true;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void btnKesk_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showMenu(panelMenu4);
            anaMenu1.Visible = true;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            morfoloji1.Visible = true;
            griTon1.Visible = true;
            anaMenu1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;

        }

        private void morfoloji2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            morfoloji_2.Visible = true;
            morfoloji1.Visible = false;
            griTon1.Visible = false;
            anaMenu1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            showMenu(panelMenu5);
            anaMenu1.Visible = true;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            anaMenu1.Visible = false;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = true;
            stitch1.Visible = false;
            grabCut1.Visible = false;
        }

        private void watershed1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            anaMenu1.Visible = false;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false ;
            stitch1.Visible = true;
            grabCut1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            anaMenu1.Visible = false;
            griTon1.Visible = false;
            kontrast_parlaklik1.Visible = false;
            histogram1.Visible = false;
            filtreler1.Visible = false;
            edge1.Visible = false;
            morfoloji1.Visible = false;
            morfoloji_2.Visible = false;
            watershed1.Visible = false;
            stitch1.Visible = false;
            grabCut1.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("https://github.com/amorftor");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
