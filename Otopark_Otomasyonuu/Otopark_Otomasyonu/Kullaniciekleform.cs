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
    public partial class Kullaniciekleform : Form
    {
        public Kullaniciekleform()
        {
            InitializeComponent();
        }

        //Kullanıcı tablosuna yeni kayıt ekler...
        public void KayitEkle()
        {
            try
            {
                Kullanicislemleriform.BaglantiAc();
                string Sorgu = "Insert into Tablo1(kullanici_adi,sifre) Values(@kullanici_adi,@sifre)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Kullanicislemleriform.Baglanti);


                EkleKomut.Parameters.AddWithValue("@kullanici_adi", txtekKadi.Text);
                EkleKomut.Parameters.AddWithValue("@sifre", txtekSifre.Text);
              



                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Yeni Kayıt");
                Kullanicislemleriform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Yeni Kayıt Hata Penceresi");
            }
        }




        private void btnekEkle_Click(object sender, EventArgs e)
        {
            KayitEkle();
        }
    }
}
