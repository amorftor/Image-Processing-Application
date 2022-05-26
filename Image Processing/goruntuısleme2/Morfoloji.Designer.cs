
namespace goruntuısleme2
{
    partial class Morfoloji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morfoloji));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxGray = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Döngü sayısı:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.textBox1.Location = new System.Drawing.Point(534, 457);
            this.textBox1.Mask = "00000";
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 31;
            this.textBox1.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Location = new System.Drawing.Point(484, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 3);
            this.panel1.TabIndex = 30;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Erosion",
            "Dilation"});
            this.checkedListBox1.Location = new System.Drawing.Point(286, 457);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(146, 36);
            this.checkedListBox1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(320, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 37);
            this.button1.TabIndex = 28;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxGray
            // 
            this.pictureBoxGray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxGray.Location = new System.Drawing.Point(368, 100);
            this.pictureBoxGray.Name = "pictureBoxGray";
            this.pictureBoxGray.Size = new System.Drawing.Size(338, 338);
            this.pictureBoxGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGray.TabIndex = 27;
            this.pictureBoxGray.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(598, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "   Kaydet";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Transparent;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.Image")));
            this.btnSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSec.Location = new System.Drawing.Point(484, 39);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(108, 40);
            this.btnSec.TabIndex = 25;
            this.btnSec.Text = "Dosya seç";
            this.btnSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOrigin.Location = new System.Drawing.Point(13, 100);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(338, 338);
            this.pictureBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrigin.TabIndex = 24;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // Morfoloji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxGray);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.pictureBoxOrigin);
            this.MaximumSize = new System.Drawing.Size(722, 563);
            this.Name = "Morfoloji";
            this.Size = new System.Drawing.Size(722, 563);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxGray;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private UserControl1 userControl11;
    }
}
