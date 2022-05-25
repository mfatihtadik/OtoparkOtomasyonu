using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otopark_Otomasyonu
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }


        //Veritabanı bağlantı cümlesi

        public static OleDbConnection Baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0; data source= database.accdb");

        //Veritabanı Bağlantısını Açan Metod
        public static void BaglantiAc()
        {
            try
            {
                Baglanti.Open();    //Veritabanını Aç 
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Aç Hata Penceresi");
            }
        }

        
        //Personel tablosundaki kayıtları formda listeleyen method
        public void KayitListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Aractablosu";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Aractablosu");
                dataGridView1.DataSource = ds.Tables["Aractablosu"];               
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");               
            }
        }




        //BENZER ARA
        public void BenzerAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();

                //string SorguTum = "Select * from Aractablosu";


                string SorguTum = "Select * from Aractablosu where Plaka Like '%" + txtPlakara.Text + "%'";
               


                OleDbDataAdapter da = new OleDbDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Aractablosu");
                dataGridView1.DataSource = ds.Tables["Aractablosu"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ara Hata Penceresi");
            }
        }


        private void btnAracgiris_MouseMove(object sender, MouseEventArgs e)
        {
            pbAracg.BackColor = Color.FromArgb(218, 165, 32);           //Butonları renklendiriyoruz...
        }

        private void btnAracgiris_MouseLeave(object sender, EventArgs e)
        {
            pbAracg.BackColor = Color.FromArgb(34, 36, 49);           
        }

        private void btnAbone_MouseMove(object sender, MouseEventArgs e)
        {
            pbAbone.BackColor = Color.FromArgb(218,165,32);
        }

        private void btnAbone_MouseLeave(object sender, EventArgs e)
        {
            pbAbone.BackColor = Color.FromArgb(34,36,49);
        }

        private void btnKullanici_MouseMove(object sender, MouseEventArgs e)
        {
            pbKullanici.BackColor = Color.FromArgb(218,165,32);
        }

        private void btnKullanici_MouseLeave(object sender, EventArgs e)
        {
            pbKullanici.BackColor = Color.FromArgb(34,36,49);
        }

        private void Anaform_Activated(object sender, EventArgs e)
        {
            Anaform.Baglanti.Close();     //Aç-Kapat yaparak verileri anlık güncelliyoruz...
            KayitListele();
        }

        private void btnAracgiris_Click(object sender, EventArgs e)
        {
            Aracgiris agf = new Aracgiris();           
            agf.ShowDialog();
        }

        private void btnKsil_Click(object sender, EventArgs e)
        {
            Silform slfrm = new Silform();
            slfrm.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();  //Kayıt sil metodunda ekranda kayıt yoksa program hata veriyor, use to if-else!..
            slfrm.txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            slfrm.ShowDialog();         
        }






        private void btnodeme_Click(object sender, EventArgs e)
        {
            Odemeform odemefrm = new Odemeform();
            odemefrm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            odemefrm.txtAplaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            odemefrm.txtGtar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            odemefrm.txtCıktar.Text = DateTime.Now.ToString();
            

            DateTime gtar1 = Convert.ToDateTime(odemefrm.txtGtar.Text);
            DateTime ctar1 = DateTime.Now;
   
            TimeSpan sonuc;
            sonuc = ctar1 - gtar1; //Giriş-Çıkış tarihlerinin farkını aldık...

            
            odemefrm.txtKsaat.Text = sonuc.Duration().TotalMinutes.ToString("0");   //Sonucu yazdırdık

            int uchesap=0;       
            int dk = Convert.ToInt32(odemefrm.txtKsaat.Text);
           
            if (dk<=120)      //Ücret tarifesi=> 0-2s=5tl -- 2-5s=10tl -- 1gün=20tl --1günden sonra her saat 1tl...
            {
                uchesap = 5;
            }
            else if (dk<300)
            {
                uchesap = 10;
            }
            else if (dk < 1440)
            {
                uchesap = 20;
            }
            else if(dk>1440)
            {
                uchesap = dk / 70;
            }

            odemefrm.txtUcret.Text = uchesap.ToString()+" TL";
                   
            odemefrm.ShowDialog();
        }

        private void txtPlakara_TextChanged(object sender, EventArgs e)
        {
            BenzerAra();
        }

        private void btnAbone_Click(object sender, EventArgs e)
        {
            Aboneform abfrm = new Aboneform();         
            abfrm.ShowDialog();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            Kullanicislemleriform kifrm = new Kullanicislemleriform();
            kifrm.ShowDialog();
        }

        private void btnodeme_MouseMove(object sender, MouseEventArgs e)
        {
            pbOdeme.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void btnodeme_MouseLeave(object sender, EventArgs e)
        {
            pbOdeme.BackColor = Color.FromArgb(34, 36, 49);
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gecmiskayit gkfrm = new Gecmiskayit();
            gkfrm.ShowDialog();
        }
        
    }
}
