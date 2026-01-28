using hastane2.classes;
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace hastane2
{
    public class randevusinifi
    {
        public string RandevuAl(string hastaId, string doktorId, string randevuTarihi, string randevuSaati, string klinik, out string mesaj)
        {
            sqlconnection.checkconnection();

            string queryHasta = "SELECT ad, soyad FROM hastanetablo WHERE hastaid = @Hastaid";
            SqlCommand cmdHasta = new SqlCommand(queryHasta, sqlconnection.connection);
            cmdHasta.Parameters.AddWithValue("@Hastaid", hastaId);
            SqlDataReader reader = cmdHasta.ExecuteReader();
            string hastaAd = "", hastaSoyad = "";
            if (reader.Read())
            {
                hastaAd = reader["ad"].ToString();
                hastaSoyad = reader["soyad"].ToString();
            }
            reader.Close();

            string query = "INSERT INTO Randevular (Hastaid, DoktorID, RandevuTarihi, RandevuSaati, Klinik, HastaAdi, HastaSoyadi) VALUES (@Hastaid, @DoktorID, @RandevuTarihi, @RandevuSaati, @Klinik, @HastaAdi, @HastaSoyadi)";
            SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);
            cmd.Parameters.AddWithValue("@Hastaid", hastaId);
            cmd.Parameters.AddWithValue("@DoktorID", doktorId);
            cmd.Parameters.AddWithValue("@RandevuTarihi", randevuTarihi);
            cmd.Parameters.AddWithValue("@RandevuSaati", randevuSaati);
            cmd.Parameters.AddWithValue("@Klinik", klinik);
            cmd.Parameters.AddWithValue("@HastaAdi", hastaAd);
            cmd.Parameters.AddWithValue("@HastaSoyadi", hastaSoyad);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                mesaj = "Randevu başarıyla alındı.";
                return "success";
            }
            else
            {
                mesaj = "Randevu alınırken bir hata oluştu.";
                return "error";
            }
        }

        public string SilRandevu(string randevuID, out string mesaj)
        {
            sqlconnection.checkconnection();

            try
            {
                string query = "DELETE FROM Randevular WHERE RandevuID = @RandevuID";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);
                cmd.Parameters.AddWithValue("@RandevuID", randevuID);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    mesaj = "Randevu başarıyla silindi.";
                    return "success";
                }
                else
                {
                    mesaj = "Randevu silinirken bir hata oluştu.";
                    return "error";
                }
            }
            catch (Exception ex)
            {
                mesaj = "Bir hata oluştu: " + ex.Message;
                return "error";
            }
        }
    }
}