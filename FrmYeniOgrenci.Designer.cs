namespace TemizlikNobetiApp
{
    partial class FrmYeniOgrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnKaydet = new Button();
            cbSinif = new ComboBox();
            mtxtNumara = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 53);
            label1.TabIndex = 0;
            label1.Text = "Yeni Öğrenci Ekle";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 53);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(211, 18);
            label2.TabIndex = 2;
            label2.Text = "Öğrenci Bilgilerini Giriniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(56, 115);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 3;
            label3.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Cursor = Cursors.Hand;
            txtAd.Location = new Point(105, 113);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(186, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Cursor = Cursors.Hand;
            txtSoyad.Location = new Point(105, 142);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(186, 23);
            txtSoyad.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(33, 142);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 5;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(17, 171);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 9;
            label5.Text = "Numara:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(44, 202);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 7;
            label6.Text = "Sınıf:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumPurple;
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(191, 254);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 42);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cbSinif
            // 
            cbSinif.Cursor = Cursors.Hand;
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(105, 204);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(186, 23);
            cbSinif.TabIndex = 12;
            // 
            // mtxtNumara
            // 
            mtxtNumara.Cursor = Cursors.Hand;
            mtxtNumara.Location = new Point(105, 171);
            mtxtNumara.Mask = "000000";
            mtxtNumara.Name = "mtxtNumara";
            mtxtNumara.Size = new Size(186, 23);
            mtxtNumara.TabIndex = 13;
            mtxtNumara.ValidatingType = typeof(int);
            // 
            // FrmYeniOgrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(327, 308);
            Controls.Add(mtxtNumara);
            Controls.Add(cbSinif);
            Controls.Add(btnKaydet);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtSoyad);
            Controls.Add(label4);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmYeniOgrenci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmYeniOgrenci";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnKaydet;
        private ComboBox cbSinif;
        private MaskedTextBox mtxtNumara;
    }
}