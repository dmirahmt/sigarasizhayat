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
    
    

    public partial class Form2 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Ahmet\\Desktop\\Sigarasizhayatdb.mdb");


        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        
        }


        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            //İlk olarak tik atılmamışsa ekrana bir uyarı çıkartıp tik atılmasını istiyorum.
            if (cb_yemin.Checked == false) { 

            MessageBox.Show("Lütfen And İçiniz!");

                }
            //Eğer tik atılmışsa aşağıdaki adımlara geçiyorum.
            else
                {             
            //Burada boş bir alan olup olmadığına bakıyorum, eğer boş bir alan var ise bu sefer ekrana mesaj kutusu çıkarıp tüm 
            //alanların doldurulmasını istiyorum.
            if (txt_adsoyad.Text.ToString() == "" || txt_fiyat.Text.ToString() == "" || txt_kullaniciad.Text.ToString() == "" || txt_motive.Text.ToString() == "" || txt_nikotin.Text.ToString() == "" || txt_sigara.Text.ToString() == "" || mtxt_adetsayi.Text.ToString() == "" || mtxt_aylikgelir.Text.ToString() == "" || mtxt_yas.Text.ToString() == "" )
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!");

            }
            //Kayıt butonuna basılmadan önce tüm değerleri kullanıcıdan alıp veritabanına girdisini yapıyorum.
                else {
                    baglantı.Open();
                    OleDbCommand komut = new OleDbCommand("insert into TBLKULLANICI (KullaniciAdi,AdSoyad,SigaraMarkasi,SigaraFiyat,NikotinMiktar,BirakilanTarih,Yas,GundeIcilenAdet,AylikGelir,Motive)values (@KullaniciAdi,@AdSoyad,@SigaraMarkasi,@SigaraFiyat,@NikotinMiktar,@BirakilanTarih,@Yas,@GundeIcilenAdet,@AylikGelir,@Motive)", baglantı);
                    komut.Parameters.Add("@KullaniciAdi", OleDbType.VarChar, 50).Value = Convert.ToString(txt_kullaniciad.Text);
                    komut.Parameters.Add("@AdSoyad", OleDbType.VarChar, 50).Value = Convert.ToString(txt_adsoyad.Text);
                    komut.Parameters.Add("@SigaraMarkasi", OleDbType.VarChar, 50).Value = Convert.ToString(txt_sigara.Text);
                    komut.Parameters.Add("@SigaraFiyat", OleDbType.Integer).Value = Convert.ToInt32(txt_fiyat.Text);
                    komut.Parameters.Add("@NikotinMiktar", OleDbType.Double).Value = Convert.ToDouble(txt_nikotin.Text);
                    komut.Parameters.Add("@BirakilanTarih", OleDbType.Date).Value = Convert.ToDateTime(dtp_sigarabirakma.Text);
                    komut.Parameters.Add("@Yas", OleDbType.Integer).Value = Convert.ToInt32(mtxt_yas.Text);
                    komut.Parameters.Add("@GundeIcilenAdet", OleDbType.Integer).Value = Convert.ToInt32(mtxt_adetsayi.Text);
                    komut.Parameters.Add("@AylikGelir", OleDbType.Integer).Value = Convert.ToInt32(mtxt_aylikgelir.Text);
                    komut.Parameters.Add("@Motive", OleDbType.VarChar, 250).Value = Convert.ToString(txt_motive.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                   
                    MessageBox.Show("Kayıt Başarılı Bir Şekilde Tamamlandı.");
                    MessageBox.Show("Lütfen Giriş Yapınız.");
                   //Tüm alanlar doldurulduktan sonra kullanıcı tekrardan Form1'e gönderip giriş yapmasını istiyorum.
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }
            }
        }

        public void dtp_sigarabirakma_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
