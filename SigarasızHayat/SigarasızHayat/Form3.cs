/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: 02
** ÖĞRENCİ ADI............: Ahmet Demir     
** ÖĞRENCİ NUMARASI.......: B191200023
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
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

namespace SigarasızHayat
{
    public partial class Form3 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Ahmet\\Desktop\\Sigarasizhayatdb.mdb");
        //Burada iki tane public değişken oluşturup Form1'de girilen değerleri bu forma aktarıyorum.
        public string kullaniciadi;
        public TrackBar tbarSigara;
        

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Kullanici class'ında oluşturduğum parametreleri Form3'teki labellara girdisini yapıyorum.           
            Kullanici user = new Kullanici(kullaniciadi);
            lbl_kadi.Text = user.kullaniciAdi;
            lbl_adsoyad.Text = user.adSoyad;
            lbl_gunsayisi.Text = user.gunSayisi;
            lbl_sigarasayısı.Text = user.sigaraSayisi.ToString();
            lbl_para.Text = user.para.ToString();
            lbl_aylikgelir.Text = user.aylikGelir.ToString();
            lbl_katilansure.Text = user.katilanSure.ToString();
            lbl_zaman.Text = user.zaman.ToString();
            lbl_nikotinmg.Text = user.nikotinMg.ToString();
            lbl_motive.Text = user.motive;
               
            //Burada kullanıcının gün içinde ne kadar sigara içmek istediğinin değerini girdikten sonra
            //her değere göre birer durum belirtecek şekilde bir if döngüsü oluşturuyorum.
            if (tbarSigara.Value == 0)
            {
                lbl_durum.Text = "Çok İyi Gidiyorsun";
            }
            else if (tbarSigara.Value == 1)
            {
                lbl_durum.Text = "Çok iyisin";
            }
            else if (tbarSigara.Value == 2)
            {
                lbl_durum.Text = "Fena Gitmiyorsun";
            }
            else if (tbarSigara.Value == 3)
            {
                lbl_durum.Text = "Biraz Dahda Dikkat Et";
            }
            else if (tbarSigara.Value == 4)
            {
                lbl_durum.Text = "Kendini Meşgul Et";
            }
            else if (tbarSigara.Value == 5)
            {
                lbl_durum.Text = "Nefsine Hakim Ol!";
            }

            //Sigara içilmeyen gün sayısı arttıkça seviyeyi de bir yukarıya taşıyorum.
            int a=Convert.ToInt32(user.gunSayisi);
            if (a < 40)
            {
                lbl_seviye.Text = "Yeni Başlayan";
            }
            else if (a < 80)
            {
                lbl_seviye.Text = "Çaylak";
            }
            else if (a < 120)
            {
                lbl_seviye.Text = "Deneyimli";
            }
            else if (a < 160)
            {
                lbl_seviye.Text = "Usta";
            }
            else if (a < 200)
            { 
                lbl_seviye.Text = "Profesyonel";
            }


            //Sigara bırakıldıktan ortalama 200 gün sonra insan sağlığına yavaş yavaş kavuşmaya 
            //başladığı için eğer 200 gün sigara içilmemişse ekrana mesaj çıktısı yaptırıyorum. 
            //İlerlemeyi yüzdelik olarak takip etmek için progressbara veri girişini yapıyroum.
            pbar_saglik.Value = a;
            if (pbar_saglik.Value >= 200)
            {
                MessageBox.Show("TEBRİKLER SİGARAYI BIRAKIP SAĞLIĞINIZA KAVUŞTUNUZ!!!");
            }
            
            
        }

        
    }
}
