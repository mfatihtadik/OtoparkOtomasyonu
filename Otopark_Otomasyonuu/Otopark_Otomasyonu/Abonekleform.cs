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
    public partial class Abonekleform : Form
    {
        public Abonekleform()
        {
            InitializeComponent();
        }


        //Araç tablosuna yeni kayıt ekler...
        public void KayitEkle()
        {
            try
            {
                Aboneform.BaglantiAc();
                string Sorgu = "Insert into Abonetab(AdSoyad,Telefon,Plaka,Marka,Model,Renk,KayitTarihi,KayitBitis) Values(@AdSoyad,@Telefon,@Plaka,@Marka,@Model,@Renk,@KayitTarihi,@KayitBitis)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Aboneform.Baglanti);


                EkleKomut.Parameters.AddWithValue("@AdSoyad",txtaAdsoyad.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txtaTelefon.Text);
                EkleKomut.Parameters.AddWithValue("@Plaka", txtaPlaka.Text);               
                EkleKomut.Parameters.AddWithValue("@Marka", cmbaMarka.Text);
                EkleKomut.Parameters.AddWithValue("@Model", cmbaModel.Text);
                EkleKomut.Parameters.AddWithValue("@Renk", cmbaRenk.Text);
                EkleKomut.Parameters.AddWithValue("@KayitTarihi", lblKayittar.Text);
                EkleKomut.Parameters.AddWithValue("@KayitBitis", lblKayitbit.Text);



                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Abonelik Ücreti 300 TL!..\nKayıt Ekleniyor", "Yeni Kayıt");
                Aboneform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Yeni Kayıt Hata Penceresi");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtaAdsoyad.BackColor = Color.White;
            txtaPlaka.BackColor = Color.White;
            txtaTelefon.BackColor = Color.White;
            cmbaMarka.BackColor = Color.White;
            cmbaModel.BackColor = Color.White;
            cmbaRenk.BackColor = Color.White;
            if (txtaAdsoyad.Text=="")
            {
                txtaAdsoyad.BackColor = Color.Red;
                MessageBox.Show("Ad-Soyad Giriniz...");
            }
            else if (txtaTelefon.Text=="")
            {
                txtaTelefon.BackColor = Color.Red;
                MessageBox.Show("Telefon Giriniz...");
            }
            else if (txtaPlaka.Text=="")
            {
                txtaPlaka.BackColor = Color.Red;
                MessageBox.Show("Plaka Giriniz...");
            }
            else if (cmbaMarka.Text=="Seçiniz")
            {
                cmbaMarka.BackColor = Color.Red;
                MessageBox.Show("Marka Seçiniz...");
            }
            else if (cmbaModel.Text=="Seçiniz")
            {
                cmbaModel.BackColor = Color.Red;
                MessageBox.Show("Model Seçiniz...");
            }
            else if (cmbaRenk.Text == "Seçiniz")
            {
                cmbaRenk.BackColor = Color.Red;
                MessageBox.Show("Renk Seçiniz...");
            }
            else
            {
                KayitEkle();
            }
        }

        private void Abonekleform_Load(object sender, EventArgs e)
        {
            tmr1.Enabled = true;
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            
            lblKayittar.Text = DateTime.Now.ToString();

            lblKayitbit.Text = DateTime.UtcNow.AddMonths(1).ToString();


        }

        private void cmbaMarka_Click(object sender, EventArgs e)
        {

        }

        private void cmbaMarka_MouseClick(object sender, MouseEventArgs e)
        {
            Aboneform.BaglantiAc();
            DataTable dt = new DataTable();
            OleDbDataAdapter sorgu = new OleDbDataAdapter("Select * from Markalartab ORDER BY id ASC", Aboneform.Baglanti);
            sorgu.Fill(dt);
            cmbaMarka.ValueMember = "id";
            cmbaMarka.DisplayMember = "Markalar";
            cmbaMarka.DataSource = dt;
            Aboneform.Baglanti.Close();
        }

        private void cmbaMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbaModel.Text = "Seçiniz";
        }

        private void cmbaModel_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbaMarka.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Modellertab where Markaid=" + cmbaMarka.SelectedValue, Aboneform.Baglanti);
                da.Fill(dt);
                cmbaModel.ValueMember = "id";
                cmbaModel.DisplayMember = "Modeller";
                cmbaModel.DataSource = dt;
            }
        }
    }
}
