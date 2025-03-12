namespace TemizlikNobetiApp
{
    partial class FrmYeniSinif
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
            txtSinifAd = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Sınıf Adı";
            // 
            // txtSinifAd
            // 
            txtSinifAd.Cursor = Cursors.Hand;
            txtSinifAd.Location = new Point(107, 29);
            txtSinifAd.Name = "txtSinifAd";
            txtSinifAd.Size = new Size(133, 23);
            txtSinifAd.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.DarkSlateBlue;
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.ForeColor = SystemColors.Control;
            btnKaydet.Location = new Point(132, 56);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(109, 43);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmYeniSinif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(263, 118);
            Controls.Add(btnKaydet);
            Controls.Add(txtSinifAd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmYeniSinif";
            Text = "FrmYeniSinif";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSinifAd;
        private Button btnKaydet;
    }
}