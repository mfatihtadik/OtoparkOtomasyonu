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
    public partial class Aboneform : Form
    {
        public Aboneform()
        {
            InitializeComponent();
        }

        //----------------------------

        //-----------------------------

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
                string Sorgu = "Select * from Abonetab";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Abonetab");
                dataGridView1.DataSource = ds.Tables["Abonetab"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        private void Aboneform_Activated(object sender, EventArgs e)
        {

       
            /////////////
            Aboneform.Baglanti.Close();
            KayitListele();
            //txtTarkont.Text = DateTime.Now.ToString();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abonekleform abnekfrm = new Abonekleform();
            abnekfrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Abonesilform aslfrm = new Abonesilform();
            aslfrm.txtaid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            aslfrm.txtasfAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            aslfrm.txtasfPlaka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            aslfrm.ShowDialog();
        }





    }
}
