
namespace goruntuısleme2
{
    partial class grabCut
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grabCut));
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSec = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prosessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRegionROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harisCornerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(589, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "   Kaydet";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOrigin.Location = new System.Drawing.Point(143, 92);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(415, 415);
            this.pictureBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrigin.TabIndex = 51;
            this.pictureBoxOrigin.TabStop = false;
            this.pictureBoxOrigin.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxOrigin_Paint);
            this.pictureBoxOrigin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOrigin_MouseDown);
            this.pictureBoxOrigin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOrigin_MouseMove);
            this.pictureBoxOrigin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOrigin_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(475, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 3);
            this.panel1.TabIndex = 56;
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Transparent;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.Image")));
            this.btnSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSec.Location = new System.Drawing.Point(475, 37);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(108, 40);
            this.btnSec.TabIndex = 55;
            this.btnSec.Text = "Dosya seç";
            this.btnSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.treeView1.Location = new System.Drawing.Point(51, 92);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(86, 91);
            this.treeView1.TabIndex = 57;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prosessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prosessToolStripMenuItem
            // 
            this.prosessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processROIToolStripMenuItem,
            this.grabToolStripMenuItem,
            this.harisCornerToolStripMenuItem});
            this.prosessToolStripMenuItem.Name = "prosessToolStripMenuItem";
            this.prosessToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.prosessToolStripMenuItem.Text = "Process";
            // 
            // processROIToolStripMenuItem
            // 
            this.processROIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectROIToolStripMenuItem,
            this.getRegionROIToolStripMenuItem});
            this.processROIToolStripMenuItem.Name = "processROIToolStripMenuItem";
            this.processROIToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.processROIToolStripMenuItem.Text = "Process ROI";
            this.processROIToolStripMenuItem.Click += new System.EventHandler(this.processROIToolStripMenuItem_Click);
            // 
            // selectROIToolStripMenuItem
            // 
            this.selectROIToolStripMenuItem.Name = "selectROIToolStripMenuItem";
            this.selectROIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.selectROIToolStripMenuItem.Text = "Select ROI";
            this.selectROIToolStripMenuItem.Click += new System.EventHandler(this.selectROIToolStripMenuItem_Click);
            // 
            // getRegionROIToolStripMenuItem
            // 
            this.getRegionROIToolStripMenuItem.Name = "getRegionROIToolStripMenuItem";
            this.getRegionROIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.getRegionROIToolStripMenuItem.Text = "Get region ROI";
            this.getRegionROIToolStripMenuItem.Click += new System.EventHandler(this.getRegionROIToolStripMenuItem_Click);
            // 
            // grabToolStripMenuItem
            // 
            this.grabToolStripMenuItem.Name = "grabToolStripMenuItem";
            this.grabToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.grabToolStripMenuItem.Text = "Grab Cut";
            this.grabToolStripMenuItem.Click += new System.EventHandler(this.grabToolStripMenuItem_Click);
            // 
            // harisCornerToolStripMenuItem
            // 
            this.harisCornerToolStripMenuItem.Name = "harisCornerToolStripMenuItem";
            this.harisCornerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.harisCornerToolStripMenuItem.Text = "Harris Corner";
            this.harisCornerToolStripMenuItem.Click += new System.EventHandler(this.harisCornerToolStripMenuItem_Click);
            // 
            // grabCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBoxOrigin);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(722, 563);
            this.MinimumSize = new System.Drawing.Size(722, 563);
            this.Name = "grabCut";
            this.Size = new System.Drawing.Size(722, 563);
            this.Load += new System.EventHandler(this.grabCut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prosessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getRegionROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harisCornerToolStripMenuItem;
    }
}
