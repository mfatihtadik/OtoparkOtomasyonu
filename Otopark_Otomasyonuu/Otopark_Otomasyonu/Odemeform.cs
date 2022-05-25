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
    public partial class Odemeform : Form
    {
        public Odemeform()
        {
            InitializeComponent();
        }

        //Geçmiş Kaydı Oluşturma methodu
        public void KayitEkle()
        {
            try
            {
                Anaform.BaglantiAc();
                string Sorgu = "Insert into Gecmistab(Plaka,Gtarihi,Ctarihi,Ucret) Values(@Plaka,@Gtarihi,@Ctarihi,@Ucret)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Anaform.Baglanti);

                EkleKomut.Parameters.AddWithValue("@Plaka", txtAplaka.Text);
                EkleKomut.Parameters.AddWithValue("@Gtarihi", txtGtar.Text);
                EkleKomut.Parameters.AddWithValue("@Ctarihi", txtCıktar.Text);
                EkleKomut.Parameters.AddWithValue("@Ucret", txtUcret.Text);



                if (EkleKomut.ExecuteNonQuery() == 1)
                    
                Anaform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Gecmis tablosu Kayıt Hata Penceresi");
            }
        }

        

        //Ödeme metodu...
        public void OdemeMetodu()
        {
            try
            {
                
                Anaform.BaglantiAc();
                string Sorgu = "Delete From Aractablosu where id=" +txtid.Text;
                OleDbCommand OdeKomut = new OleDbCommand(Sorgu, Anaform.Baglanti);
                if (OdeKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtid.Text + " Nolu araç ücreti ödendi");
                Anaform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Ödeme hata penceresi");


            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            KayitEkle();
            OdemeMetodu();       
        }
    }
}
