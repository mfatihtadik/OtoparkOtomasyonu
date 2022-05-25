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
    public partial class Silform : Form
    {
        public  Silform()
        {
            InitializeComponent();
        }

        //Kayıt Silme metodu...
        public void KayitSilMetodu()
        {
            try
            {
                Anaform.BaglantiAc();
                string Sorgu = "Delete From Aractablosu where id=" + txtID.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Anaform.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtID.Text + " nolu Kayıt Silindi");
                Anaform.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil hata penceresi");


            }
        }

        




        private void btnSil_Click(object sender, EventArgs e)
        {        
            KayitSilMetodu();
        }

        private void Silform_Activated(object sender, EventArgs e)
        {
            
            
        }
    }
}
