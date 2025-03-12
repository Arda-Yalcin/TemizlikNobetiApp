namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //�lk a��l��ta verileri y�kle 
            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;
        }
        private void btnYeniSinif_Click_1(object sender, EventArgs e)
        {
            FrmYeniSinif form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni S�n�f kay�t edildi.");
            }
        }
        private void btnYeniOgrenci_Click(object sender, EventArgs e)
        {
            FrmYeniOgrenci form = new();
            var cevap = form.ShowDialog();
        }
    }
}