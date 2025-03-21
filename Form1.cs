using System.ComponentModel;

namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> SeciliOgrenciListesi = new();
        public Form1()
        {
            InitializeComponent();

            //?lk a�?l??ta verileri y�kle 
            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = KayitYoneticisi.Ogrenciler;

            lbSecilenler.DisplayMember = "AdSoyad";
            lbSecilenler.ValueMember = "Id";
            lbSecilenler.DataSource = SeciliOgrenciListesi;

            Filtrele();
        }

        private void btnYeniSinif_Click(object sender, EventArgs e)
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

            if (cevap == DialogResult.OK)
            {
                Filtrele();
            }
        }

        private void Filtrele()
        {
            if (cbSinif.SelectedValue == null)
            {
                //S?n?f se�ili de?ilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //S?n?f se�ili
            string sinifId = cbSinif.SelectedValue.ToString();

            //LINQ ile sorgulama
            //Lambda x => x.....
            var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinifId).ToList();

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = liste;
        }

        private void cbSinif_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrele();
            BuHaftaTemizlikYapacaklar();
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            //Se�ili olan? �?renci gibi al (as=gibi)
            //Alamazsan null de?er ver
            Ogrenci ogr = lbOgrenciler.SelectedItem as Ogrenci;

            if (ogr != null)
            {

                if (SeciliOgrenciListesi.Contains(ogr))
                {
                    MessageBox.Show("��renci zaten se�ili");
                    return;
                }

                SeciliOgrenciListesi.Add(ogr);
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            //Se�ili olan? �?renci gibi al (as=gibi)
            //Alamazsan null de?er ver
            Ogrenci ogr = lbSecilenler.SelectedItem as Ogrenci;

            if (ogr != null)
            {
                SeciliOgrenciListesi.Remove(ogr);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (SeciliOgrenciListesi.Count == 0)
            {
                MessageBox.Show("��renci se�imi yap�n�z");
                return;
            }

            //Temizlik kayd? olu?tur
            foreach (Ogrenci ogr in SeciliOgrenciListesi)
            {
                TemizlikKayit kayit = new();
                kayit.Id = Guid.NewGuid().ToString();
                kayit.OgrenciId = ogr.Id;
                kayit.Tarih = dtpTarih.Value;

                KayitYoneticisi.TemizlikKayitlari.Add(kayit);
            }

            SeciliOgrenciListesi.Clear();

            KayitYoneticisi.Kaydet();
            Filtrele();
            BuHaftaTemizlikYapacaklar();
            MessageBox.Show("Kay�t olu�turuldu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void BuHaftaTemizlikYapacaklar()
        {
            if (cbSinif.SelectedValue == null)
            {
                //S?n?f se�ili de?ilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //S?n?f se�ili
            string sinifId = cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);
            lblBuHaftaSira.Text = "Bu haftaki S�ra:\n";

            if (liste.Count() == 0)
            {
                lblBuHaftaSira.Text += "Temizlik Yapacak Ki�i Yok";
            }

            foreach (Ogrenci ogr in liste)
            {
                lblBuHaftaSira.Text += $"{ogr.AdSoyad}\n";
            }
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (cbSinif.SelectedValue == null)
            {
                //S�n�f se�ili de�ilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //S�n�f se�ili
            string sinifId = cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);

            foreach (Ogrenci ogr in liste)
            {
                if (!SeciliOgrenciListesi.Contains(ogr))
                    SeciliOgrenciListesi.Add(ogr);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTarih.Text = $"Bug�n {dt:dd} {dt:MMMM} {dt:yyyy} Saat: {dt:HH}:{dt:mm}";
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = lbOgrenciler.SelectedItem as Ogrenci;
            if (ogr == null)
                return;

            DialogResult cevap = MessageBox.Show(
                ogr.AdSoyad + " isimli �?renciyi silmek istediginize emin misiniz?",
                "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                KayitYoneticisi.Ogrenciler.Remove(ogr);
                if (SeciliOgrenciListesi.Contains(ogr))
                {
                    SeciliOgrenciListesi.Remove(ogr);
                }

                Filtrele();
                BuHaftaTemizlikYapacaklar();
                KayitYoneticisi.Kaydet();
            }

        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            Sinif sinif = cbSinif.SelectedItem as Sinif;
            if (sinif == null)
                return;

            DialogResult cevap = MessageBox.Show(
                sinif.Ad + " isimli sinifi silmek istediginize emin misiniz?, Dikkat S�n�ftaki ��renciler de silinecek",
                "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinif.Id).ToList();

                foreach (var item in liste)
                {
                    KayitYoneticisi.Ogrenciler.Remove(item);

                    if (SeciliOgrenciListesi.Contains(item))
                    {
                        SeciliOgrenciListesi.Remove(item);
                    }
                }
                KayitYoneticisi.Siniflar.Remove(sinif);

                Filtrele();
                BuHaftaTemizlikYapacaklar();
                KayitYoneticisi.Kaydet();

            }
        }
    }
}