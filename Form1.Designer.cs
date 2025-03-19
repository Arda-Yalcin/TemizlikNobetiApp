namespace TemizlikNobetiApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnOgrenciSil = new Button();
            btnSinifSil = new Button();
            lbOgrenciler = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            cbSinif = new ComboBox();
            btnYeniSinif = new Button();
            panel2 = new Panel();
            lblTarih = new Label();
            btnSec = new Button();
            lblBuHaftaSira = new Label();
            btnYeniOgrenci = new Button();
            panel3 = new Panel();
            dtpTarih = new DateTimePicker();
            btnOnayla = new Button();
            lbSecilenler = new ListBox();
            label2 = new Label();
            btnCikar = new Button();
            btnAta = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(btnOgrenciSil);
            panel1.Controls.Add(btnSinifSil);
            panel1.Controls.Add(lbOgrenciler);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbSinif);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 452);
            panel1.TabIndex = 0;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.BackColor = Color.CornflowerBlue;
            btnOgrenciSil.Cursor = Cursors.Hand;
            btnOgrenciSil.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgrenciSil.ForeColor = Color.Red;
            btnOgrenciSil.Location = new Point(98, 405);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(71, 46);
            btnOgrenciSil.TabIndex = 7;
            btnOgrenciSil.Text = "Öğrenci Sil";
            btnOgrenciSil.UseVisualStyleBackColor = false;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // btnSinifSil
            // 
            btnSinifSil.BackColor = Color.CornflowerBlue;
            btnSinifSil.Cursor = Cursors.Hand;
            btnSinifSil.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSinifSil.ForeColor = Color.Red;
            btnSinifSil.Location = new Point(12, 406);
            btnSinifSil.Name = "btnSinifSil";
            btnSinifSil.Size = new Size(71, 45);
            btnSinifSil.TabIndex = 6;
            btnSinifSil.Text = "Sınıf Sil";
            btnSinifSil.UseVisualStyleBackColor = false;
            btnSinifSil.Click += btnSinifSil_Click;
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.ItemHeight = 15;
            lbOgrenciler.Location = new Point(12, 170);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(157, 229);
            lbOgrenciler.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 113);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Sınıflar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 5;
            label3.Text = "Arda Yalçın";
            // 
            // cbSinif
            // 
            cbSinif.Cursor = Cursors.Hand;
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(12, 141);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(157, 23);
            cbSinif.TabIndex = 0;
            cbSinif.SelectedValueChanged += cbSinif_SelectedValueChanged;
            // 
            // btnYeniSinif
            // 
            btnYeniSinif.BackColor = Color.CornflowerBlue;
            btnYeniSinif.Cursor = Cursors.Hand;
            btnYeniSinif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniSinif.ForeColor = Color.Black;
            btnYeniSinif.Location = new Point(22, 405);
            btnYeniSinif.Name = "btnYeniSinif";
            btnYeniSinif.Size = new Size(142, 38);
            btnYeniSinif.TabIndex = 3;
            btnYeniSinif.Text = "Yeni Sınıf ";
            btnYeniSinif.UseVisualStyleBackColor = false;
            btnYeniSinif.Click += btnYeniSinif_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(lblTarih);
            panel2.Controls.Add(btnSec);
            panel2.Controls.Add(lblBuHaftaSira);
            panel2.Controls.Add(btnYeniSinif);
            panel2.Controls.Add(btnYeniOgrenci);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnCikar);
            panel2.Controls.Add(btnAta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(188, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 452);
            panel2.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarih.Location = new Point(380, 9);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(200, 33);
            lblTarih.TabIndex = 8;
            // 
            // btnSec
            // 
            btnSec.BackColor = Color.CornflowerBlue;
            btnSec.Cursor = Cursors.Hand;
            btnSec.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSec.Location = new Point(380, 188);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(200, 33);
            btnSec.TabIndex = 7;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = false;
            btnSec.Click += btnSec_Click;
            // 
            // lblBuHaftaSira
            // 
            lblBuHaftaSira.BackColor = Color.LightSteelBlue;
            lblBuHaftaSira.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuHaftaSira.Location = new Point(380, 66);
            lblBuHaftaSira.Name = "lblBuHaftaSira";
            lblBuHaftaSira.Size = new Size(200, 119);
            lblBuHaftaSira.TabIndex = 6;
            lblBuHaftaSira.Text = "Bu Hafta Temizlik yapacaklar";
            // 
            // btnYeniOgrenci
            // 
            btnYeniOgrenci.BackColor = Color.CornflowerBlue;
            btnYeniOgrenci.Cursor = Cursors.Hand;
            btnYeniOgrenci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniOgrenci.ForeColor = Color.Black;
            btnYeniOgrenci.Location = new Point(232, 405);
            btnYeniOgrenci.Name = "btnYeniOgrenci";
            btnYeniOgrenci.Size = new Size(142, 38);
            btnYeniOgrenci.TabIndex = 4;
            btnYeniOgrenci.Text = "Yeni Öğrenci";
            btnYeniOgrenci.UseVisualStyleBackColor = false;
            btnYeniOgrenci.Click += btnYeniOgrenci_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(dtpTarih);
            panel3.Controls.Add(btnOnayla);
            panel3.Controls.Add(lbSecilenler);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(22, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 333);
            panel3.TabIndex = 2;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(22, 296);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(200, 23);
            dtpTarih.TabIndex = 3;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.CornflowerBlue;
            btnOnayla.Cursor = Cursors.Hand;
            btnOnayla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.Black;
            btnOnayla.Location = new Point(22, 256);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(120, 34);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // lbSecilenler
            // 
            lbSecilenler.BackColor = Color.Lavender;
            lbSecilenler.FormattingEnabled = true;
            lbSecilenler.ItemHeight = 15;
            lbSecilenler.Location = new Point(21, 51);
            lbSecilenler.Name = "lbSecilenler";
            lbSecilenler.Size = new Size(310, 199);
            lbSecilenler.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(60, 30);
            label2.Name = "label2";
            label2.Size = new Size(248, 18);
            label2.TabIndex = 0;
            label2.Text = "Bu Hafta Temizlik Yapacaklar";
            // 
            // btnCikar
            // 
            btnCikar.BackColor = Color.CornflowerBlue;
            btnCikar.Cursor = Cursors.Hand;
            btnCikar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikar.ForeColor = Color.Red;
            btnCikar.Location = new Point(232, 19);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(142, 41);
            btnCikar.TabIndex = 1;
            btnCikar.Text = "Çıkar";
            btnCikar.UseVisualStyleBackColor = false;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnAta
            // 
            btnAta.BackColor = Color.CornflowerBlue;
            btnAta.Cursor = Cursors.Hand;
            btnAta.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAta.ForeColor = Color.Lime;
            btnAta.Location = new Point(22, 19);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(142, 41);
            btnAta.TabIndex = 0;
            btnAta.Text = "Ata";
            btnAta.UseVisualStyleBackColor = false;
            btnAta.Click += btnAta_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 452);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TemizlikApp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbSinif;
        private ListBox lbOgrenciler;
        private Label label1;
        private Button btnYeniSinif;
        private Panel panel2;
        private Panel panel3;
        private Button btnCikar;
        private Button btnAta;
        private Label label2;
        private ListBox lbSecilenler;
        private Button btnYeniOgrenci;
        private Button btnOnayla;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblBuHaftaSira;
        private Button btnSec;
        private DateTimePicker dtpTarih;
        private Button btnOgrenciSil;
        private Button btnSinifSil;
        private Label lblTarih;
        private System.Windows.Forms.Timer timer1;
    }
}