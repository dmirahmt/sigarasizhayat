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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SigarasızHayat
{
    class Kullanici
    {
        //Burada Form3'te kullanmak için public değişkenler oluşturuyorum.
        public string kullaniciAdi;
        public string adSoyad;
        public string gunSayisi;
        public int sigaraSayisi;
        public int para;
        public int aylikGelir;
        public int katilanSure;
        public int zaman;
        public double nikotinMg;
        public string motive;

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Ahmet\\Desktop\\Sigarasizhayatdb.mdb");

        public Kullanici(string kullaniciadi)
        {
            //Bağlantıyı açıp girilen kullanıcı adına göre sorgu yapması için parametre oluşturuyorum.
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From TBLKULLANICI where KullaniciAdi=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", kullaniciadi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //Bu while döngüsünde kullanıcı adının geçtiği satırdaki verileri okuyup 
                //sırayla verileri çekiyorum, tüm veriler çekildikten sonra while döngüsü bitiyor.
                kullaniciAdi = dr[0].ToString();
                adSoyad = dr[1].ToString();
                //Burada kullanıcının kayıt olurken girdiği tarihi veritabanından çekip bugünün tarihinden çıkarıp kaç gün geçtiğini öğreniyorum.
                TimeSpan fark;
                fark = DateTime.Now - DateTime.Parse(dr[5].ToString());
                //daha sonra bunu da gunSayisi değişkenine atıyıp diğer işlemlerde de kullanıyorum.
                gunSayisi = fark.Days.ToString();
                sigaraSayisi = Convert.ToInt32(gunSayisi) * Convert.ToInt32(dr[7]);
                para = Convert.ToInt32(gunSayisi) * Convert.ToInt32(dr[3]);
                aylikGelir = Convert.ToInt32(gunSayisi) * Convert.ToInt32(dr[3]) + Convert.ToInt32(dr[8]);
                //5 sayısı bir sigaranın insan ömründen kaç dakika aldığını gösteriyor.
                katilanSure = Convert.ToInt32(sigaraSayisi) * 5;
                //4 sayısı bir sigaranın ortalama kaç dakikada içildiğini gösteriyor.
                zaman = Convert.ToInt32(sigaraSayisi) * 4;
                nikotinMg = Convert.ToInt32(sigaraSayisi) * Convert.ToDouble(dr[4]);
                motive = Convert.ToString(dr[9]);
                

            }
            baglantı.Close();
        }
    }
}
