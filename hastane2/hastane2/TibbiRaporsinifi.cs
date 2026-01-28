using hastane2.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace hastane2
{
    public class TibbiRaporsinifi
    {
        // Veritabanı bağlantısı
        private SqlConnection connection;

        // Kurucu metod
        public TibbiRaporsinifi(SqlConnection conn)
        {
            connection = conn;
        }

        // Rapor silme metodu
        public void RaporSil(string RaporID)
        {
            // Bağlantının paylaşılmadığından ve doğru şekilde başlatıldığından emin olmak için using kullanılır
            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                try
                {
                    // Veritabanı bağlantısını aç
                    conn.Open();

                    // SQL sorgusu
                    string query = "DELETE FROM TıbbiRaporlar WHERE RaporID = @RaporID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parametre ekleyin
                    cmd.Parameters.AddWithValue("@RaporID", RaporID);

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    throw new Exception("Rapor silme işlemi sırasında hata oluştu: " + ex.Message);
                }
                // Using bloğu, bir istisna meydana gelse bile bağlantıyı otomatik olarak kapatır
            }
        }

        public void RaporGuncelle(int RaporID, string Hastaid, string DoktorID, string RaporTarihi, string RaporIcerigi, string RaporURL, string RaporJSON)
        {
            try
            {
                // Veritabanı bağlantısını aç
                sqlconnection.checkconnection();

                // SQL sorgusu
                string query = "UPDATE TıbbiRaporlar SET Hastaid = @Hastaid, DoktorID = @DoktorID, RaporTarihi = @RaporTarihi, RaporIcerigi = @RaporIcerigi, RaporURL = @RaporURL, RaporJSON = @RaporJSON WHERE RaporID = @RaporID";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@Hastaid", Hastaid);
                cmd.Parameters.AddWithValue("@DoktorID", DoktorID);
                cmd.Parameters.AddWithValue("@RaporTarihi", RaporTarihi);
                cmd.Parameters.AddWithValue("@RaporIcerigi", RaporIcerigi);
                cmd.Parameters.AddWithValue("@RaporURL", RaporURL);
                cmd.Parameters.AddWithValue("@RaporJSON", RaporJSON);
                cmd.Parameters.AddWithValue("@hastaid", RaporID); // Hasta ID parametresi

                // Sorguyu çalıştır
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception("Bir hata oluştu: " + ex.Message);
            }
        }

        public void RaporEkle(string Hastaid, string DoktorID, string RaporTarihi, string RaporIcerigi, string RaporURL, string RaporJSON)
        {
            try
            {
                // Veritabanı bağlantısını aç
                sqlconnection.checkconnection();

                // SQL sorgusu
                string query = "INSERT INTO TıbbiRaporlar (Hastaid, DoktorID, RaporTarihi, RaporIcerigi, RaporURL, RaporJSON) VALUES (@Hastaid, @DoktorID, @RaporTarihi, @RaporIcerigi, @RaporURL, @RaporJSON)";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@Hastaid", Hastaid);
                cmd.Parameters.AddWithValue("@DoktorID", DoktorID);
                cmd.Parameters.AddWithValue("@RaporTarihi", RaporTarihi);
                cmd.Parameters.AddWithValue("@RaporIcerigi", RaporIcerigi);
                cmd.Parameters.AddWithValue("@RaporURL", RaporURL);
                cmd.Parameters.AddWithValue("@RaporJSON", RaporJSON);

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