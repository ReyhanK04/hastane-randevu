using hastane2.classes; // Import the namespace containing the sqlconnection class
using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;



namespace hastane2
{
    public partial class RandevuAl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadHastaList();
                LoadDoktorList();
                LoadKlinik();
                ShowRandevular(); // Randevuları göster
                GridView1_SelectedIndexChanged(sender, e);
            }
        }


        private void LoadHastaList()
        {
            sqlconnection.checkconnection();
            using (SqlCommand cmd = new SqlCommand("SELECT hastaid, ad + ' ' + soyad AS HastaAdSoyad FROM hastanetablo", sqlconnection.connection))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                ddlHasta.DataSource = reader;
                ddlHasta.DataTextField = "HastaAdSoyad";
                ddlHasta.DataValueField = "hastaid";
                ddlHasta.DataBind();
                reader.Close();
            }
        }

        private void LoadDoktorList()
        {
            sqlconnection.checkconnection();
            using (SqlCommand cmd = new SqlCommand("SELECT DoktorID, Ad + ' ' + Soyad AS DoktorAdSoyad FROM Doktorlar", sqlconnection.connection))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                ddlDoktor.DataSource = reader;
                ddlDoktor.DataTextField = "DoktorAdSoyad";
                ddlDoktor.DataValueField = "DoktorID";
                ddlDoktor.DataBind();
                reader.Close();
            }
        }

        private void LoadKlinik()
        {
            sqlconnection.checkconnection();
            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT UzmanlıkAlanı FROM Doktorlar", sqlconnection.connection))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                ddlKlinik.DataSource = reader;
                ddlKlinik.DataTextField = "UzmanlıkAlanı";
                ddlKlinik.DataValueField = "UzmanlıkAlanı";
                ddlKlinik.DataBind();
                reader.Close();
            }
        }

        protected void btnRandevuAl_Click(object sender, EventArgs e)
        {
            randevusinifi randevu = new randevusinifi();

            string hastaId = ddlHasta.SelectedValue;
            string doktorId = ddlDoktor.SelectedValue;
            string randevuTarihi = txtTarih.Text;
            string randevuSaati = txtSaat.Text;
            string klinik = ddlKlinik.SelectedValue;

            string mesaj;
            string result = randevu.RandevuAl(hastaId, doktorId, randevuTarihi, randevuSaati, klinik, out mesaj);
            lblSonuc.Text = mesaj;

            if (result == "success")
            {
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }

        //protected System.Web.UI.WebControls.GridView GridView1;


        private void ShowRandevular()
        {
            // Veritabanı bağlantısını kur

            string query = "SELECT * FROM Randevular";
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen satırın index'ini al
            int selectedIndex = GridView1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
            {
                // Seçili satırın verilerini al
                GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                string randevuID = selectedRow.Cells[0].Text;

                // Burada randevuID değerini kullanarak gerekli işlemleri yapabilirsiniz
            }
        }
        protected void btnSil_Click(object sender, EventArgs e)
        {
            randevusinifi randevu = new randevusinifi();

            int selectedIndex = GridView1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < GridView1.Rows.Count)
            {
                GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                string randevuID = selectedRow.Cells[0].Text;

                string mesaj;
                string result = randevu.SilRandevu(randevuID, out mesaj);
                lblSonuc.Text = mesaj;

                if (result == "success")
                {
                    ShowRandevular(); // GridView'ı güncelle
                }
            }
        }

    }
}