using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SigarasızHayat
{
    public partial class Form1 : Form
    {
        //Access veritabanı ile bağlantıyı gerçekleştiriyorum.
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Ahmet\\Desktop\\Sigarasizhayatdb.mdb");


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            //Kayıt butonuna basıldığında kayıt ekranına gidip, Form1'ide gizliyorum.
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            //Giriş butonuna basıldığında textboxa yazılan kullanıcı adının veritabanından hangi kullanıcı adıyla 
            //uyuştuğunu kontrol etmek için girilen kullanıcı adı ile veritabanındaki KullaniciAdi'ni sorguluyorum.
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From TBLKULLANICI where KullaniciAdi ='" + txt_kadiniz.Text + "'", baglantı);
            OleDbDataReader dr = komut.ExecuteReader();
            //Eğer veritabanındaki kullanıcı adı ile uyuşuyorsa girilen kullanıcı adını ve belirlenen trackbar değerini From3'e gönderip Form3ü açıyorum.
            if (dr.Read())
            {     
                Form3 frm3 = new Form3();
                frm3.kullaniciadi = txt_kadiniz.Text;
                frm3.tbarSigara = tbar_sigara;
                frm3.Show();
                this.Hide();
            }
            //Eğer veritabanındaki kullanıcı adı ile uyuşmuyorsa ekrana bir mesaj kutusu çıkarıp tekrardan bir kullanıcı adı girmesini istiyorum.
            else
            {
                MessageBox.Show("Lütfen Kayıtlı Bir Kullanıcı Adı Giriniz.");
            }

            baglantı.Close();

        }

        

        private void tbar_sigara_Scroll(object sender, EventArgs e)
        {


        }
    }
}
