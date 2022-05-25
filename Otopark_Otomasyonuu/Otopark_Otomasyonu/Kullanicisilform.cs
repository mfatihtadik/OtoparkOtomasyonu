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
    public partial class Kullanicisilform : Form
    {
        public Kullanicisilform()
        {
            InitializeComponent();
        }

        //Kullanıcı Kayıt Silme metodu...
        public void KayitSilMetodu()
        {
            try
            {
                Kullanicislemleriform.BaglantiAc();
                string Sorgu = "Delete From Tablo1 where id=" + txtksid.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Kullanicislemleriform.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtksid.Text + " nolu Kayıt Silindi");
                Kullanicislemleriform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil hata penceresi");

            }
        }




        private void btnkSil_Click(object sender, EventArgs e)
        {
            KayitSilMetodu();
        }
    }
}
