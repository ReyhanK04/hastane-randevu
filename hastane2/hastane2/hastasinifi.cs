using hastane2.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace hastane2
{
    public class hastasinifi
    {
        // Veritabanı bağlantısı
        private SqlConnection connection;

        // Kurucu metod
        public hastasinifi(SqlConnection conn)
        {
            connection = conn;
        }

        // Hasta silme metodu
        public void HastaSil(string hastaid)
        {
            // Bağlantının paylaşılmadığından ve doğru şekilde başlatıldığından emin olmak için using kullanılır
            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                try
                {
                    // Veritabanı bağlantısını aç
                    conn.Open();

                    // SQL sorgusu
                    string query = "DELETE FROM hastanetablo WHERE hastaid = @hastaid";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parametre ekleyin
                    cmd.Parameters.AddWithValue("@hastaid", hastaid);

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    throw new Exception("Hasta silme işlemi sırasında hata oluştu: " + ex.Message);
                }
                // Using bloğu, bir istisna meydana gelse bile bağlantıyı otomatik olarak kapatır
            }
        }

        public void HastaGuncelle(int hastaID, string ad, string soyad, string dogumtarihi, string cinsiyet, string telno, string adres)
        {
            try
            {
                // Veritabanı bağlantısını aç
                sqlconnection.checkconnection();

                // SQL sorgusu
                string query = "UPDATE hastanetablo SET ad = @ad, soyad = @soyad, dogumtarihi = @dogumtarihi, cinsiyet = @cinsiyet, telno = @telno, adres = @adres WHERE hastaid = @hastaid";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@dogumtarihi", dogumtarihi);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@telno", telno);
                cmd.Parameters.AddWithValue("@adres", adres);
                cmd.Parameters.AddWithValue("@hastaid", hastaID); // Hasta ID parametresi

                // Sorguyu çalıştır
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception("Bir hata oluştu: " + ex.Message);
            }
        }

        public void HastaEkle(string ad, string soyad, string dogumtarihi, string cinsiyet, string telno, string adres)
        {
            try
            {
                // Veritabanı bağlantısını aç
                sqlconnection.checkconnection();

                // SQL sorgusu
                string query = "INSERT INTO hastanetablo (ad, soyad, dogumtarihi, cinsiyet, telno, adres) VALUES (@ad, @soyad, @dogumtarihi, @cinsiyet, @telno, @adres)";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@dogumtarihi", dogumtarihi);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@telno", telno);
                cmd.Parameters.AddWithValue("@adres", adres);

                // Sorguyu çalıştır
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception("Bir hata oluştu: " + ex.Message);
            }
        }


    }
}