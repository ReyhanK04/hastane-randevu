using hastane2.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hastane2
{
    public partial class DoktorEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    // Veritabanı bağlantısını aç
                    sqlconnection.checkconnection();

                    // SQL sorgusu
                    string query = "SELECT * FROM Doktorlar";
                    SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

                    // SqlDataAdapter ve DataSet oluştur
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    System.Data.DataSet ds = new System.Data.DataSet();

                    // DataSet'i doldur
                    adapter.Fill(ds);

                    // GridView kontrolüne verileri bağla
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    ListHastalar();
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    Response.Write("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen satırın index'ini al
            int selectedIndex = GridView1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
            {
                // Seçili satırın verilerini al
                GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                string ad = selectedRow.Cells[2].Text;
                string soyad = selectedRow.Cells[3].Text;
                string UzmanlıkAlanı = selectedRow.Cells[4].Text;
                string calistigihastane = selectedRow.Cells[5].Text;
 

                // TextBox'lara seçilen satırdaki verileri ata
                txtDoktorad.Text = ad;
                txtDoktorsoyad.Text = soyad;
                txtUzmanlıkAlanı.Text = UzmanlıkAlanı;
                txtcalistigihastane.Text = calistigihastane;

            }
        }

        //DOKTOR SIL
        protected void btnDoktorSil_Click(object sender, EventArgs e)
        {
            // Seçilen satırın index'ini al
            int selectedIndex = GridView1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
            {
                // Seçili satırın verilerini al
                GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                string doktorid = selectedRow.Cells[1].Text;

                try
                {
                    // doktorlarSinifi nesnesi oluştur
                    doktorsinifi doktorlarSinifi = new doktorsinifi(sqlconnection.connection);

                    // Doktor silme metodu çağır
                    doktorlarSinifi.DoktorSil(doktorid);

                    // Doktor silindikten sonra sayfayı yenile
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    Response.Write("Bir hata oluştu: " + ex.Message);
                }

            }
        }

        protected void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçilen satırın index'ini al
                int selectedIndex = GridView1.SelectedIndex;

                if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
                {
                    // Seçili satırın verilerini al
                    GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                    int doktorID = Convert.ToInt32(selectedRow.Cells[1].Text); // Hasta ID'si
                    string ad = txtDoktorad.Text;
                    string soyad = txtDoktorsoyad.Text;
                    string UzmanlıkAlanı = txtUzmanlıkAlanı.Text;
                    string calistigihastane = txtcalistigihastane.Text;
 

                    // doktorlarSinifi nesnesi oluştur
                    doktorsinifi doktorlarSinifi = new doktorsinifi(sqlconnection.connection);

                    // DoktorGuncelle metodunu çağır
                    doktorlarSinifi.DoktorGuncelle(doktorID, ad, soyad, UzmanlıkAlanı, calistigihastane);

                    // Doktor güncellendikten sonra sayfayı yenile
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
                else
                {
                    // Kullanıcı bir satır seçmemişse uyarı ver
                    Response.Write("<script>alert('Lütfen güncellenecek bir hasta seçin.');</script>");
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Response.Write("Bir hata oluştu: " + ex.Message);
            }
        }

        protected void btnDoktorKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Girdi verilerini al
                string ad = txtDoktorad.Text;
                string soyad = txtDoktorsoyad.Text;
                string UzmanlıkAlanı = txtUzmanlıkAlanı.Text;
                string calistigihastane = txtcalistigihastane.Text;


                // doktorlarSinifi nesnesi oluştur
                doktorsinifi doktorlarSinifi = new doktorsinifi(sqlconnection.connection);

                // DoktorEkle metodunu çağır
                doktorlarSinifi.DoktorEkle(ad, soyad, UzmanlıkAlanı, calistigihastane);

                // Doktor ekledikten sonra sayfayı yenile
                Response.Redirect(Request.Url.AbsoluteUri);
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Response.Write("Bir hata oluştu: " + ex.Message);
            }

            // İşlem tamamlandıktan sonra kullanıcıya bilgi vermek için bir mesaj gösterebilirsiniz
            Response.Write("<script>alert('Doktor başarıyla eklendi.');</script>");
        }

        private void ListHastalar()
        {
            // SQL sorgusu
            string query = "SELECT * FROM Doktorlar";
            SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);

            // SqlDataAdapter ve DataSet oluştur
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            System.Data.DataSet ds = new System.Data.DataSet();

            // DataSet'i doldur
            adapter.Fill(ds);

            // GridView kontrolüne verileri bağla
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}