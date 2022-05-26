
namespace goruntuısleme2
{
    partial class Kesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kesk));
            this.pictureBoxKontr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKontr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKontr
            // 
            this.pictureBoxKontr.Location = new System.Drawing.Point(109, 97);
            this.pictureBoxKontr.Name = "pictureBoxKontr";
            this.pictureBoxKontr.Size = new System.Drawing.Size(452, 390);
            this.pictureBoxKontr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKontr.TabIndex = 28;
            this.pictureBoxKontr.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Keskinlik :";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(239, 493);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 45);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.Value = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(453, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 3);
            this.panel1.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(567, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "   Kaydet";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Transparent;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.Image")));
            this.btnSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSec.Location = new System.Drawing.Point(453, 32);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(108, 40);
            this.btnSec.TabIndex = 21;
            this.btnSec.Text = "Dosya seç";
            this.btnSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSec.UseVisualStyleBackColor = false;
            // 
            // Kesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.pictureBoxKontr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSec);
            this.MaximumSize = new System.Drawing.Size(722, 563);
            this.MinimumSize = new System.Drawing.Size(722, 563);
            this.Name = "Kesk";
            this.Size = new System.Drawing.Size(722, 563);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKontr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKontr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSec;
    }
}
