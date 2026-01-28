using hastane2.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace hastane2
{
    public class doktorsinifi
    {
        // Veritabanı bağlantısı
        private SqlConnection connection;

        // Kurucu metod
        public doktorsinifi(SqlConnection conn)
        {
            connection = conn;
        }

        // Doktor silme metodu
        public void DoktorSil(string doktorid)
        {
            // Bağlantının paylaşılmadığından ve doğru şekilde başlatıldığından emin olmak için using kullanılır
            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                try
                {
                    // Veritabanı bağlantısını aç
                    conn.Open();

                    // SQL sorgusu
                    string query = "DELETE FROM Doktorlar WHERE DoktorID = @DoktorID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parametre ekleyin
                    cmd.Parameters.AddWithValue("@DoktorID", doktorid);

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    throw new Exception("Doktor silme işlemi sırasında hata oluştu: " + ex.Message);
                }
                // Using bloğu, bir istisna meydana gelse bile bağlantıyı otomatik olarak kapatır
            }
        }

        public void DoktorGuncelle(int doktorID, string ad, string soyad, string UzmanlıkAlanı, string calistigihastane)
        {
            try
            {
                // Veritabanı bağlantısını aç
                sqlconnection.checkconnection();

                // SQL sorgusu
                string query = "UPDATE Doktorlar SET Ad = @Ad, Soyad = @Soyad, UzmanlıkAlanı = @UzmanlıkAlanı, CalistigiHastane = @CalistigiHastane  WHERE DoktorID = @DoktorID";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@UzmanlıkAlanı", UzmanlıkAlanı);
                cmd.Parameters.AddWithValue("@CalistigiHastane", calistigihastane);
                cmd.Parameters.AddWithValue("@DoktorID", doktorID); // Doktor ID parametresi

                // Sorguyu çalıştır
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                throw new Exception("Bir hata oluştu: " + ex.Message);
            }
        }

        public void DoktorEkle(string ad, string soyad, string UzmanlıkAlanı, string calistigihastane)
        {
            try
            {
                // Veritabanı bağlantısını aç
                sqlconnection.checkconnection();

                // SQL sorgusu
                string query = "INSERT INTO Doktorlar (Ad, Soyad, UzmanlıkAlanı, CalistigiHastane) VALUES (@Ad, @Soyad, @UzmanlıkAlanı, @CalistigiHastane)";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@UzmanlıkAlanı", UzmanlıkAlanı);
                cmd.Parameters.AddWithValue("@CalistigiHastane", calistigihastane);
      

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