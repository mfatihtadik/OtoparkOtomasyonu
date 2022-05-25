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
    public partial class Gecmiskayit : Form
    {
        public Gecmiskayit()
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


        //Abone tablosundaki kayıtları formda listeleyen method
        public void KayitListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Gecmistab";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Gecmistab");
                dataGridView1.DataSource = ds.Tables["Gecmistab"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Gecmiş talo Kayıt Listele Hata Penceresi");
            }
        }

        private void Gecmiskayit_Activated(object sender, EventArgs e)
        {
            Anaform.Baglanti.Close();
            KayitListele();
        }





    }
}
