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
    public partial class Abonesilform : Form
    {
        public Abonesilform()
        {
            InitializeComponent();
        }

        //Abone Kayıt Silme metodu...
        public void KayitSilMetodu()
        {
            try
            {
                Aboneform.BaglantiAc();
                string Sorgu = "Delete From Abonetab where id=" + txtaid.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Aboneform.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtaid.Text + " nolu Kayıt Silindi");
                Aboneform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil hata penceresi");

            }
        }

        private void btnasfSil_Click(object sender, EventArgs e)
        {
            KayitSilMetodu();
        }






    }
}
