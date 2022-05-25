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
    public partial class Kullanicislemleriform : Form
    {
        public Kullanicislemleriform()
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


        //Kullanıcı tablosundaki kayıtları formda listeleyen method
        public void KayitListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Tablo1";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Tablo1");
                dataGridView1.DataSource = ds.Tables["Tablo1"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }





        private void Kullanicislemleriform_Activated(object sender, EventArgs e)
        {
            Kullanicislemleriform.Baglanti.Close();
            KayitListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullaniciekleform kefrm = new Kullaniciekleform();
            kefrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanicisilform ksfrm = new Kullanicisilform();
            ksfrm.txtksid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ksfrm.txtkskadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ksfrm.ShowDialog();
        }
    }
}
