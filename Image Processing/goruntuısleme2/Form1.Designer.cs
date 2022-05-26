
namespace goruntuısleme2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelMenu5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenu4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMorph = new System.Windows.Forms.Button();
            this.panelMenu3 = new System.Windows.Forms.Panel();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnEdge = new System.Windows.Forms.Button();
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnFilt = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnKont = new System.Windows.Forms.Button();
            this.btnesikleme = new System.Windows.Forms.Button();
            this.btnGri = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelApp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.griTon1 = new goruntuısleme2.griTon();
            this.anaMenu1 = new goruntuısleme2.AnaMenu();
            this.kontrast_parlaklik1 = new goruntuısleme2.Kontrast_parlaklik();
            this.histogram1 = new goruntuısleme2.Histogram();
            this.filtreler1 = new goruntuısleme2.Filtreler();
            this.edge1 = new goruntuısleme2.Edge();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.morfoloji1 = new goruntuısleme2.Morfoloji();
            this.morfoloji_2 = new goruntuısleme2.Morfoloji_2();
            this.watershed1 = new goruntuısleme2.watershed();
            this.stitch1 = new goruntuısleme2.stitch();
            this.grabCut1 = new goruntuısleme2.grabCut();
            this.panelSideMenu.SuspendLayout();
            this.panelMenu5.SuspendLayout();
            this.panelMenu4.SuspendLayout();
            this.panelMenu3.SuspendLayout();
            this.panelMenu2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBorder.SuspendLayout();
            this.panelApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSideMenu.Controls.Add(this.panelMenu5);
            this.panelSideMenu.Controls.Add(this.button2);
            this.panelSideMenu.Controls.Add(this.panelMenu4);
            this.panelSideMenu.Controls.Add(this.btnMorph);
            this.panelSideMenu.Controls.Add(this.panelMenu3);
            this.panelSideMenu.Controls.Add(this.btnEdge);
            this.panelSideMenu.Controls.Add(this.panelMenu2);
            this.panelSideMenu.Controls.Add(this.btnFilt);
            this.panelSideMenu.Controls.Add(this.panelMenu);
            this.panelSideMenu.Controls.Add(this.btnAna);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(230, 1920);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelMenu5
            // 
            this.panelMenu5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenu5.Controls.Add(this.button10);
            this.panelMenu5.Controls.Add(this.button9);
            this.panelMenu5.Controls.Add(this.button4);
            this.panelMenu5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu5.Location = new System.Drawing.Point(0, 728);
            this.panelMenu5.Name = "panelMenu5";
            this.panelMenu5.Size = new System.Drawing.Size(230, 153);
            this.panelMenu5.TabIndex = 10;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Gainsboro;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 101);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(230, 47);
            this.button10.TabIndex = 4;
            this.button10.Text = "Grab Cut, Harris corner";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Gainsboro;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 51);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(230, 50);
            this.button9.TabIndex = 3;
            this.button9.Text = "Görüntü birleştirme";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(230, 51);
            this.button4.TabIndex = 2;
            this.button4.Text = "Watershed ve Geometrik Op.";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 677);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(230, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Bölge genişletme";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // panelMenu4
            // 
            this.panelMenu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenu4.Controls.Add(this.button5);
            this.panelMenu4.Controls.Add(this.button6);
            this.panelMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu4.Location = new System.Drawing.Point(0, 573);
            this.panelMenu4.Name = "panelMenu4";
            this.panelMenu4.Size = new System.Drawing.Size(230, 104);
            this.panelMenu4.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 51);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(230, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "Open, Close ve Diğerleri";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(230, 51);
            this.button6.TabIndex = 2;
            this.button6.Text = "Erosion, Dilation";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMorph
            // 
            this.btnMorph.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMorph.FlatAppearance.BorderSize = 0;
            this.btnMorph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorph.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMorph.Image = ((System.Drawing.Image)(resources.GetObject("btnMorph.Image")));
            this.btnMorph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMorph.Location = new System.Drawing.Point(0, 522);
            this.btnMorph.Name = "btnMorph";
            this.btnMorph.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMorph.Size = new System.Drawing.Size(230, 51);
            this.btnMorph.TabIndex = 7;
            this.btnMorph.Text = "Görüntü Morfolojisi";
            this.btnMorph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMorph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMorph.UseVisualStyleBackColor = true;
            this.btnMorph.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panelMenu3
            // 
            this.panelMenu3.Controls.Add(this.btnSobel);
            this.panelMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu3.Location = new System.Drawing.Point(0, 470);
            this.panelMenu3.Name = "panelMenu3";
            this.panelMenu3.Size = new System.Drawing.Size(230, 52);
            this.panelMenu3.TabIndex = 6;
            // 
            // btnSobel
            // 
            this.btnSobel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSobel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSobel.FlatAppearance.BorderSize = 0;
            this.btnSobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSobel.Image = ((System.Drawing.Image)(resources.GetObject("btnSobel.Image")));
            this.btnSobel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobel.Location = new System.Drawing.Point(0, 0);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSobel.Size = new System.Drawing.Size(230, 51);
            this.btnSobel.TabIndex = 3;
            this.btnSobel.Text = "SOBEL, Canny ve Lablacian";
            this.btnSobel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSobel.UseVisualStyleBackColor = false;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnEdge
            // 
            this.btnEdge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdge.FlatAppearance.BorderSize = 0;
            this.btnEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdge.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdge.Image = ((System.Drawing.Image)(resources.GetObject("btnEdge.Image")));
            this.btnEdge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdge.Location = new System.Drawing.Point(0, 419);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEdge.Size = new System.Drawing.Size(230, 51);
            this.btnEdge.TabIndex = 5;
            this.btnEdge.Text = "Edge Detection";
            this.btnEdge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdge.UseVisualStyleBackColor = true;
            this.btnEdge.Click += new System.EventHandler(this.button11_Click);
            // 
            // panelMenu2
            // 
            this.panelMenu2.Controls.Add(this.btnMean);
            this.panelMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu2.Location = new System.Drawing.Point(0, 370);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Size = new System.Drawing.Size(230, 49);
            this.panelMenu2.TabIndex = 4;
            // 
            // btnMean
            // 
            this.btnMean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnMean.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMean.FlatAppearance.BorderSize = 0;
            this.btnMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMean.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMean.Image = ((System.Drawing.Image)(resources.GetObject("btnMean.Image")));
            this.btnMean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMean.Location = new System.Drawing.Point(0, 0);
            this.btnMean.Name = "btnMean";
            this.btnMean.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnMean.Size = new System.Drawing.Size(230, 51);
            this.btnMean.TabIndex = 3;
            this.btnMean.Text = "Lablace, Gaussian Filter";
            this.btnMean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMean.UseVisualStyleBackColor = false;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnFilt
            // 
            this.btnFilt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilt.FlatAppearance.BorderSize = 0;
            this.btnFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilt.Image = ((System.Drawing.Image)(resources.GetObject("btnFilt.Image")));
            this.btnFilt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilt.Location = new System.Drawing.Point(0, 319);
            this.btnFilt.Name = "btnFilt";
            this.btnFilt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFilt.Size = new System.Drawing.Size(230, 51);
            this.btnFilt.TabIndex = 3;
            this.btnFilt.Text = "Filtreler";
            this.btnFilt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilt.UseVisualStyleBackColor = true;
            this.btnFilt.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.btnKont);
            this.panelMenu.Controls.Add(this.btnesikleme);
            this.panelMenu.Controls.Add(this.btnGri);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 166);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 153);
            this.panelMenu.TabIndex = 2;
            // 
            // btnKont
            // 
            this.btnKont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnKont.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKont.FlatAppearance.BorderSize = 0;
            this.btnKont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKont.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKont.Image = ((System.Drawing.Image)(resources.GetObject("btnKont.Image")));
            this.btnKont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKont.Location = new System.Drawing.Point(0, 102);
            this.btnKont.Name = "btnKont";
            this.btnKont.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnKont.Size = new System.Drawing.Size(230, 51);
            this.btnKont.TabIndex = 5;
            this.btnKont.Text = "Kontrast ve Parlaklık";
            this.btnKont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKont.UseVisualStyleBackColor = false;
            this.btnKont.Click += new System.EventHandler(this.btnKont_Click);
            // 
            // btnesikleme
            // 
            this.btnesikleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnesikleme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnesikleme.FlatAppearance.BorderSize = 0;
            this.btnesikleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnesikleme.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnesikleme.Image = ((System.Drawing.Image)(resources.GetObject("btnesikleme.Image")));
            this.btnesikleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnesikleme.Location = new System.Drawing.Point(0, 51);
            this.btnesikleme.Name = "btnesikleme";
            this.btnesikleme.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnesikleme.Size = new System.Drawing.Size(230, 51);
            this.btnesikleme.TabIndex = 4;
            this.btnesikleme.Text = "CLAHE ve Histogram equ. ";
            this.btnesikleme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnesikleme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnesikleme.UseVisualStyleBackColor = false;
            this.btnesikleme.Click += new System.EventHandler(this.btnesikleme_Click);
            // 
            // btnGri
            // 
            this.btnGri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGri.FlatAppearance.BorderSize = 0;
            this.btnGri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGri.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGri.Image = ((System.Drawing.Image)(resources.GetObject("btnGri.Image")));
            this.btnGri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGri.Location = new System.Drawing.Point(0, 0);
            this.btnGri.Name = "btnGri";
            this.btnGri.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnGri.Size = new System.Drawing.Size(230, 51);
            this.btnGri.TabIndex = 2;
            this.btnGri.Text = "Renk tonları ve Treshold";
            this.btnGri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGri.UseVisualStyleBackColor = false;
            this.btnGri.Click += new System.EventHandler(this.btnGri_Click);
            // 
            // btnAna
            // 
            this.btnAna.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAna.FlatAppearance.BorderSize = 0;
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAna.Image = ((System.Drawing.Image)(resources.GetObject("btnAna.Image")));
            this.btnAna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAna.Location = new System.Drawing.Point(0, 115);
            this.btnAna.Name = "btnAna";
            this.btnAna.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAna.Size = new System.Drawing.Size(230, 51);
            this.btnAna.TabIndex = 1;
            this.btnAna.Text = "Ana menü";
            this.btnAna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 115);
            this.panelLogo.TabIndex = 0;
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelBorder.Controls.Add(this.button1);
            this.panelBorder.Controls.Add(this.panelApp);
            this.panelBorder.Controls.Add(this.btnQuit);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(974, 37);
            this.panelBorder.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(895, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panelApp
            // 
            this.panelApp.Controls.Add(this.label2);
            this.panelApp.Location = new System.Drawing.Point(361, 0);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(314, 37);
            this.panelApp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image processing application";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(932, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(37, 37);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // griTon1
            // 
            this.griTon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.griTon1.Location = new System.Drawing.Point(240, 52);
            this.griTon1.Name = "griTon1";
            this.griTon1.Size = new System.Drawing.Size(714, 554);
            this.griTon1.TabIndex = 6;
            // 
            // anaMenu1
            // 
            this.anaMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.anaMenu1.Location = new System.Drawing.Point(236, 43);
            this.anaMenu1.Name = "anaMenu1";
            this.anaMenu1.Size = new System.Drawing.Size(718, 563);
            this.anaMenu1.TabIndex = 7;
            // 
            // kontrast_parlaklik1
            // 
            this.kontrast_parlaklik1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.kontrast_parlaklik1.Location = new System.Drawing.Point(232, 43);
            this.kontrast_parlaklik1.MaximumSize = new System.Drawing.Size(722, 563);
            this.kontrast_parlaklik1.MinimumSize = new System.Drawing.Size(722, 563);
            this.kontrast_parlaklik1.Name = "kontrast_parlaklik1";
            this.kontrast_parlaklik1.Size = new System.Drawing.Size(722, 563);
            this.kontrast_parlaklik1.TabIndex = 8;
            // 
            // histogram1
            // 
            this.histogram1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.histogram1.grayımage = null;
            this.histogram1.Location = new System.Drawing.Point(236, 43);
            this.histogram1.MaximumSize = new System.Drawing.Size(722, 563);
            this.histogram1.MinimumSize = new System.Drawing.Size(722, 563);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(722, 563);
            this.histogram1.TabIndex = 9;
            // 
            // filtreler1
            // 
            this.filtreler1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.filtreler1.Location = new System.Drawing.Point(236, 43);
            this.filtreler1.MaximumSize = new System.Drawing.Size(722, 563);
            this.filtreler1.MinimumSize = new System.Drawing.Size(722, 563);
            this.filtreler1.Name = "filtreler1";
            this.filtreler1.Size = new System.Drawing.Size(722, 563);
            this.filtreler1.TabIndex = 10;
            // 
            // edge1
            // 
            this.edge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.edge1.Location = new System.Drawing.Point(236, 42);
            this.edge1.MaximumSize = new System.Drawing.Size(722, 563);
            this.edge1.MinimumSize = new System.Drawing.Size(722, 563);
            this.edge1.Name = "edge1";
            this.edge1.Size = new System.Drawing.Size(722, 563);
            this.edge1.TabIndex = 11;
            // 
            // morfoloji1
            // 
            this.morfoloji1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.morfoloji1.Location = new System.Drawing.Point(235, 42);
            this.morfoloji1.MaximumSize = new System.Drawing.Size(722, 563);
            this.morfoloji1.Name = "morfoloji1";
            this.morfoloji1.Size = new System.Drawing.Size(722, 563);
            this.morfoloji1.TabIndex = 12;
            // 
            // morfoloji_2
            // 
            this.morfoloji_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.morfoloji_2.Location = new System.Drawing.Point(236, 45);
            this.morfoloji_2.MaximumSize = new System.Drawing.Size(722, 563);
            this.morfoloji_2.MinimumSize = new System.Drawing.Size(722, 563);
            this.morfoloji_2.Name = "morfoloji_2";
            this.morfoloji_2.Size = new System.Drawing.Size(722, 563);
            this.morfoloji_2.TabIndex = 13;
            // 
            // watershed1
            // 
            this.watershed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.watershed1.Location = new System.Drawing.Point(235, 42);
            this.watershed1.MaximumSize = new System.Drawing.Size(722, 563);
            this.watershed1.MinimumSize = new System.Drawing.Size(722, 563);
            this.watershed1.Name = "watershed1";
            this.watershed1.Size = new System.Drawing.Size(722, 563);
            this.watershed1.TabIndex = 14;
            this.watershed1.Load += new System.EventHandler(this.watershed1_Load);
            // 
            // stitch1
            // 
            this.stitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.stitch1.Location = new System.Drawing.Point(235, 45);
            this.stitch1.MaximumSize = new System.Drawing.Size(722, 563);
            this.stitch1.MinimumSize = new System.Drawing.Size(722, 563);
            this.stitch1.Name = "stitch1";
            this.stitch1.Size = new System.Drawing.Size(722, 563);
            this.stitch1.TabIndex = 15;
            // 
            // grabCut1
            // 
            this.grabCut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.grabCut1.Location = new System.Drawing.Point(232, 42);
            this.grabCut1.MaximumSize = new System.Drawing.Size(737, 563);
            this.grabCut1.MinimumSize = new System.Drawing.Size(737, 563);
            this.grabCut1.Name = "grabCut1";
            this.grabCut1.Size = new System.Drawing.Size(737, 563);
            this.grabCut1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(974, 617);
            this.Controls.Add(this.grabCut1);
            this.Controls.Add(this.stitch1);
            this.Controls.Add(this.watershed1);
            this.Controls.Add(this.morfoloji_2);
            this.Controls.Add(this.morfoloji1);
            this.Controls.Add(this.edge1);
            this.Controls.Add(this.filtreler1);
            this.Controls.Add(this.histogram1);
            this.Controls.Add(this.kontrast_parlaklik1);
            this.Controls.Add(this.griTon1);
            this.Controls.Add(this.anaMenu1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMenu5.ResumeLayout(false);
            this.panelMenu4.ResumeLayout(false);
            this.panelMenu3.ResumeLayout(false);
            this.panelMenu2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelBorder.ResumeLayout(false);
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnGri;
        private System.Windows.Forms.Panel panelMenu2;
        private System.Windows.Forms.Button btnFilt;
        private System.Windows.Forms.Button btnMean;
        private System.Windows.Forms.Button btnKont;
        private System.Windows.Forms.Button btnesikleme;
        private System.Windows.Forms.Panel panelMenu3;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.Label label2;
        private griTon griTon1;
        private AnaMenu anaMenu1;
        private Kontrast_parlaklik kontrast_parlaklik1;
        private Histogram histogram1;
        private Filtreler filtreler1;
        private Edge edge1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMorph;
        private System.Windows.Forms.Panel panelMenu4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private Morfoloji morfoloji1;
        private Morfoloji_2 morfoloji_2;
        private System.Windows.Forms.Panel panelMenu5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private watershed watershed1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private stitch stitch1;
        private System.Windows.Forms.Button button10;
        private grabCut grabCut1;
    }
}

