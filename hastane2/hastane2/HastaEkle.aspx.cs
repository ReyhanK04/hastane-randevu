using hastane2.classes;
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace hastane2
{
    public partial class HastaEkle : System.Web.UI.Page
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
                    string query = "SELECT * FROM hastanetablo";
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
                string dogumtarihi = selectedRow.Cells[4].Text;
                string cinsiyet = selectedRow.Cells[5].Text;
                string telno = selectedRow.Cells[6].Text;
                string adres = selectedRow.Cells[7].Text;

                // TextBox'lara seçilen satırdaki verileri ata
                txtad.Text = ad;
                txtsoyad.Text = soyad;
                txtdogumtarihi.Text = dogumtarihi;
                txtcinsiyet.Text = cinsiyet;
                txttelno.Text = telno;
                txtadres.Text = adres;
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            // Seçilen satırın index'ini al
            int selectedIndex = GridView1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
            {
                // Seçili satırın verilerini al
                GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                string hastaid = selectedRow.Cells[1].Text;

                try
                {
                    // HastaneSinifi nesnesi oluştur
                    hastasinifi hastaneSinifi = new hastasinifi(sqlconnection.connection);

                    // Hasta silme metodu çağır
                    hastaneSinifi.HastaSil(hastaid);

                    // Hasta silindikten sonra sayfayı yenile
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    Response.Write("Bir hata oluştu: " + ex.Message);
                }

            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçilen satırın index'ini al
                int selectedIndex = GridView1.SelectedIndex;

                if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
                {
                    // Seçili satırın verilerini al
                    GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                    int hastaID = Convert.ToInt32(selectedRow.Cells[1].Text); // Hasta ID'si
                    string ad = txtad.Text;
                    string soyad = txtsoyad.Text;
                    string dogumtarihi = txtdogumtarihi.Text;
                    string cinsiyet = txtcinsiyet.Text;
                    string telno = txttelno.Text;
                    string adres = txtadres.Text;

                    // HastaneSinifi nesnesi oluştur
                    hastasinifi hastaneSinifi = new hastasinifi(sqlconnection.connection);

                    // HastaGuncelle metodunu çağır
                    hastaneSinifi.HastaGuncelle(hastaID, ad, soyad, dogumtarihi, cinsiyet, telno, adres);

                    // Hasta güncellendikten sonra sayfayı yenile
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


        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Girdi verilerini al
                string ad = txtad.Text;
                string soyad = txtsoyad.Text;
                string dogumtarihi = txtdogumtarihi.Text;
                string cinsiyet = txtcinsiyet.Text;
                string telno = txttelno.Text;
                string adres = txtadres.Text;

                // HastaneSinifi nesnesi oluştur
                hastasinifi hastaneSinifi = new hastasinifi(sqlconnection.connection);

                // HastaEkle metodunu çağır
                hastaneSinifi.HastaEkle(ad, soyad, dogumtarihi, cinsiyet, telno, adres);

                // Hasta ekledikten sonra sayfayı yenile
                Response.Redirect(Request.Url.AbsoluteUri);
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Response.Write("Bir hata oluştu: " + ex.Message);
            }

            // İşlem tamamlandıktan sonra kullanıcıya bilgi vermek için bir mesaj gösterebilirsiniz
            Response.Write("<script>alert('Hasta başarıyla eklendi.');</script>");
        }

        private void ListHastalar()
        {
            // SQL sorgusu
            string query = "SELECT * FROM hastanetablo";
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