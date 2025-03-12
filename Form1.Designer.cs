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
            panel1 = new Panel();
            btnYeniSinif = new Button();
            lbOgrenciler = new ListBox();
            label1 = new Label();
            cbSinif = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            btnYeniOgrenci = new Button();
            panel3 = new Panel();
            btnOnayla = new Button();
            lbTemizlikYapacakOgrenciler = new ListBox();
            label2 = new Label();
            btnCikar = new Button();
            btnAta = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(btnYeniSinif);
            panel1.Controls.Add(lbOgrenciler);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbSinif);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 450);
            panel1.TabIndex = 0;
            // 
            // btnYeniSinif
            // 
            btnYeniSinif.BackColor = Color.CornflowerBlue;
            btnYeniSinif.Cursor = Cursors.Hand;
            btnYeniSinif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniSinif.Location = new Point(12, 405);
            btnYeniSinif.Name = "btnYeniSinif";
            btnYeniSinif.Size = new Size(142, 38);
            btnYeniSinif.TabIndex = 3;
            btnYeniSinif.Text = "Yeni Sınıf ";
            btnYeniSinif.UseVisualStyleBackColor = false;
            btnYeniSinif.Click += btnYeniSinif_Click;
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.ItemHeight = 15;
            lbOgrenciler.Location = new Point(12, 65);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(142, 334);
            lbOgrenciler.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 5);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Sınıflar";
            // 
            // cbSinif
            // 
            cbSinif.Cursor = Cursors.Hand;
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(12, 33);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(142, 23);
            cbSinif.TabIndex = 0;
            cbSinif.SelectedValueChanged += cbSinif_SelectedValueChanged_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnYeniOgrenci);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnCikar);
            panel2.Controls.Add(btnAta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(168, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 450);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 425);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Arda Yalçın";
            // 
            // btnYeniOgrenci
            // 
            btnYeniOgrenci.BackColor = Color.CornflowerBlue;
            btnYeniOgrenci.Cursor = Cursors.Hand;
            btnYeniOgrenci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniOgrenci.Location = new Point(22, 405);
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
            panel3.Controls.Add(btnOnayla);
            panel3.Controls.Add(lbTemizlikYapacakOgrenciler);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(22, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 320);
            panel3.TabIndex = 2;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.CornflowerBlue;
            btnOnayla.Cursor = Cursors.Hand;
            btnOnayla.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.Location = new Point(22, 241);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(120, 34);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            // 
            // lbTemizlikYapacakOgrenciler
            // 
            lbTemizlikYapacakOgrenciler.BackColor = Color.LightSteelBlue;
            lbTemizlikYapacakOgrenciler.FormattingEnabled = true;
            lbTemizlikYapacakOgrenciler.ItemHeight = 15;
            lbTemizlikYapacakOgrenciler.Location = new Point(21, 66);
            lbTemizlikYapacakOgrenciler.Name = "lbTemizlikYapacakOgrenciler";
            lbTemizlikYapacakOgrenciler.Size = new Size(321, 169);
            lbTemizlikYapacakOgrenciler.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 21);
            label2.Name = "label2";
            label2.Size = new Size(246, 18);
            label2.TabIndex = 0;
            label2.Text = "Bu Hafta Temizlik Yapacaklar";
            // 
            // btnCikar
            // 
            btnCikar.BackColor = Color.CornflowerBlue;
            btnCikar.Cursor = Cursors.Hand;
            btnCikar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikar.Location = new Point(282, 19);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(108, 41);
            btnCikar.TabIndex = 1;
            btnCikar.Text = "Çıkar";
            btnCikar.UseVisualStyleBackColor = false;
            // 
            // btnAta
            // 
            btnAta.BackColor = Color.CornflowerBlue;
            btnAta.Cursor = Cursors.Hand;
            btnAta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAta.Location = new Point(22, 19);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(108, 41);
            btnAta.TabIndex = 0;
            btnAta.Text = "Ata";
            btnAta.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ListBox lbTemizlikYapacakOgrenciler;
        private Button btnYeniOgrenci;
        private Button btnOnayla;
        private Label label3;
    }
}