using hastane2.classes;
using System;
using System.Data.SqlClient;

namespace hastane2
{
    public partial class TibbiRaporlar : System.Web.UI.Page
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
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    Response.Write("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}