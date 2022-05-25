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
    public partial class Aracgiris : Form
    {
        public Aracgiris()
        {
            InitializeComponent();
        }

        //------------------------------

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



        //------------------------------
       







        //Araç tablosuna yeni kayıt ekler...
        public void KayitEkle()
        {
            try
            {
                Anaform.BaglantiAc();                
                string Sorgu = "Insert into Aractablosu(Plaka,Marka,Model,Renk,Gtarihi) Values(@Plaka,@Marka,@Model,@Renk,@Gtarihi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Anaform.Baglanti);

                EkleKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                EkleKomut.Parameters.AddWithValue("@Marka", cmbMarka.Text);
                EkleKomut.Parameters.AddWithValue("@Model", cmbModel.Text);
                EkleKomut.Parameters.AddWithValue("@Renk", cmbRenk.Text);
                EkleKomut.Parameters.AddWithValue("@Gtarihi", lblTarih.Text);



                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Yeni Kayıt");
                Anaform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Yeni Kayıt Hata Penceresi");
            }
        }




        private void btnGiris_Click(object sender, EventArgs e)
        {
            txtPlaka.BackColor = Color.White;
            bool Abonevarmi = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == txtPlaka.Text)
                    Abonevarmi = true;
            }

            if (txtPlaka.Text == "")
            {
                MessageBox.Show("Araç plakasını giriniz!", "Yeni Kayıt");
                txtPlaka.BackColor = Color.Red;
            }
            else if (Abonevarmi == true)
            {
                MessageBox.Show(txtPlaka.Text + " Plakalı araç Abonedir!\nÜcretsiz giriş yapabilir...", "Abone Bildirim");
                this.Close();
            }
            else
                KayitEkle();
        }

        private void Aracgiris_Activated(object sender, EventArgs e)
        {
            Aboneform.Baglanti.Close();
            KayitListele();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
             
        }





        private void Aracgiris_Load(object sender, EventArgs e)
        {            
            tmrTarih.Enabled = true;           
        }

        private void tmrTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString();
                        
            //lblTarih.Text = DateTime.UtcNow.AddMonths(1).ToString();
        }

  
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Text = "Seçiniz";
                    
        }

        private void cmbMarka_MouseClick(object sender, MouseEventArgs e)
        {
            Anaform.BaglantiAc();
            DataTable dt = new DataTable();
            OleDbDataAdapter sorgu = new OleDbDataAdapter("Select * from Markalartab ORDER BY id ASC", Anaform.Baglanti);
            sorgu.Fill(dt);
            cmbMarka.ValueMember = "id";
            cmbMarka.DisplayMember = "Markalar";
            cmbMarka.DataSource = dt;
            Anaform.Baglanti.Close();

        }

        private void cmbModel_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbMarka.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Modellertab where Markaid=" + cmbMarka.SelectedValue, Anaform.Baglanti);
                da.Fill(dt);
                cmbModel.ValueMember = "id";
                cmbModel.DisplayMember = "Modeller";
                cmbModel.DataSource = dt;
            }
            
        }
    }
}
