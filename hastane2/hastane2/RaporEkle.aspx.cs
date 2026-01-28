using hastane2.classes;
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace hastane2
{
    public partial class RaporEkle : System.Web.UI.Page
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
                    string query = "SELECT * FROM TıbbiRaporlar";
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

                // Hücreleri indekslerine göre al
                string RaporID = selectedRow.Cells[0].Text;
                string Hastaid = selectedRow.Cells[1].Text;
                string DoktorID = selectedRow.Cells[2].Text;
                string RaporTarihi = selectedRow.Cells[3].Text;
                string RaporIcerigi = selectedRow.Cells[4].Text;

                // TemplateField içindeki HyperLink'i bul ve URL'yi al
                HyperLink hyperLinkRaporURL = (HyperLink)selectedRow.FindControl("HyperLinkRaporURL");
                string RaporURL = hyperLinkRaporURL != null ? hyperLinkRaporURL.NavigateUrl : string.Empty;

                string RaporJSON = selectedRow.Cells[6].Text;

                // TextBox'lara seçilen satırdaki verileri ata
                txtHastaid.Text = Hastaid;
                txtDoktorID.Text = DoktorID;
                txtRaporTarihi.Text = RaporTarihi;
                txtRaporIcerigi.Text = RaporIcerigi;
                txtRaporURL.Text = RaporURL;
                txtRaporJSON.Text = RaporJSON;
            }
        }



        protected void btnRaporSil_Click(object sender, EventArgs e)
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
                    // RaporlarSinifi nesnesi oluştur
                    TibbiRaporsinifi RaporlarSinifi = new TibbiRaporsinifi(sqlconnection.connection);

                    // Rapor silme metodu çağır
                    RaporlarSinifi.RaporSil(hastaid);

                    // Rapor silindikten sonra sayfayı yenile
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    Response.Write("Bir hata oluştu: " + ex.Message);
                }

            }
        }

        protected void btnRaporGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçilen satırın index'ini al
                int selectedIndex = GridView1.SelectedIndex;

                if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
                {
                    // Seçili satırın verilerini al
                    GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                    int RaporID = Convert.ToInt32(selectedRow.Cells[1].Text); // Rapor ID'si
                    string Hastaid = txtHastaid.Text;
                    string DoktorID = txtDoktorID.Text;
                    string RaporTarihi = txtRaporTarihi.Text;
                    string RaporIcerigi = txtRaporIcerigi.Text;
                    string RaporURL = txtRaporURL.Text;
                    string RaporJSON = txtRaporJSON.Text;

                    // RaporlarSinifi nesnesi oluştur
                    TibbiRaporsinifi RaporlarSinifi = new TibbiRaporsinifi(sqlconnection.connection);

                    // RaporGuncelle metodunu çağır
                    RaporlarSinifi.RaporGuncelle(RaporID, Hastaid, DoktorID, RaporTarihi, RaporIcerigi, RaporURL, RaporJSON);

                    // Rapor güncellendikten sonra sayfayı yenile
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
                else
                {
                    // Kullanıcı bir satır seçmemişse uyarı ver
                    Response.Write("<script>alert('Lütfen güncellenecek bir Rapor seçin.');</script>");
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Response.Write("Bir hata oluştu: " + ex.Message);
            }
        }

        protected void btnRaporKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Girdi verilerini al
                string Hastaid = txtHastaid.Text;
                string DoktorID = txtDoktorID.Text;
                string RaporTarihi = txtRaporTarihi.Text;
                string RaporIcerigi = txtRaporIcerigi.Text;
                string RaporURL = txtRaporURL.Text;
                string RaporJSON = txtRaporJSON.Text;

                // RaporlarSinifi nesnesi oluştur
                TibbiRaporsinifi RaporlarSinifi = new TibbiRaporsinifi(sqlconnection.connection);

                // Rapor Ekle metodunu çağır
                RaporlarSinifi.RaporEkle(Hastaid, DoktorID, RaporTarihi, RaporIcerigi, RaporURL, RaporJSON);

                // Rapor ekledikten sonra sayfayı yenile
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
            string query = "SELECT * FROM TıbbiRaporlar";
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