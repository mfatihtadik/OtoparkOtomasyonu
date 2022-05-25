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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKadi_Click(object sender, EventArgs e)
        {
            if(txtKadi.Text=="Kullanıcı Adı")
            {
                txtKadi.Clear();
            }
            
            pbKadi.BackgroundImage = Properties.Resources.kadi_logo2; //txtKadi ye tıklandıgında fotoları ve texti maviye çeviriyor.
            txtKadi.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);

            pbSifre.BackgroundImage = Properties.Resources.sifrelogo;  //Şifre kısmını standart hale getiriyor.
            txtSifre.ForeColor = Color.WhiteSmoke;
            panel2.BackColor= Color.WhiteSmoke;
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Clear();
            }
            //Burda zıt kodları yazdık böylece hangisine tıklanırsa o mavi, diğeri standart olacak...
            
            txtSifre.PasswordChar = '*';
            pbSifre.BackgroundImage = Properties.Resources.sifrelogo2;
            txtSifre.ForeColor = Color.FromArgb(78,184,206);
            panel2.BackColor= Color.FromArgb(78, 184, 206);

            pbKadi.BackgroundImage = Properties.Resources.kadi_logo;
            txtKadi.ForeColor = Color.WhiteSmoke;
            panel1.BackColor= Color.WhiteSmoke;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0; data source= database.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from tablo1 where kullanici_adi='" + txtKadi.Text + "' and sifre='" + txtSifre.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                Anaform anafrm = new Anaform();
                anafrm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata");

                txtKadi.Clear();
                txtKadi.Focus();
                pbKadi.BackgroundImage = Properties.Resources.kadi_logo2; //txtKadi ye tıklandıgında fotoları ve texti maviye çeviriyor.
                txtKadi.ForeColor = Color.FromArgb(78, 184, 206);
                panel1.BackColor = Color.FromArgb(78, 184, 206);


                txtSifre.Clear();
                pbSifre.BackgroundImage = Properties.Resources.sifrelogo;  //Şifre kısmını standart hale getiriyor.
                txtSifre.ForeColor = Color.WhiteSmoke;
                panel2.BackColor = Color.WhiteSmoke;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
