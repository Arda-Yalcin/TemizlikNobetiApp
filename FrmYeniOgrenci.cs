using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemizlikNobetiApp
{
    public partial class FrmYeniOgrenci : Form
    {
        public FrmYeniOgrenci()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci yeni = new();
            //Benzersiz bir kimlik numarası oluştur
            yeni.Id = Guid.NewGuid().ToString();

            yeni.Ad = txtOgrenciAd.Text;
            yeni.Soyad = txtOgrenciSoyad.Text;
            

            KayitYoneticisi.Ogrenciler.Add(yeni);

            KayitYoneticisi.Kaydet();
            DialogResult = DialogResult.OK;//Diyalog Formunu Kapatır
            //Form kapatılırken geriye cevap "OK" döner
        }
    }
}