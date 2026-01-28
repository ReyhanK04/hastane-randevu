using hastane2.classes;
using hastane2.classes;
using System;
using System.Data.SqlClient;

namespace hastane2
{
    public partial class doktor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Veritabanı bağlantısını aç
                sqlconnection.checkconnection();

                // SQL sorgusu
                string query = "SELECT * FROM Doktorlar";
                SqlCommand cmd = new SqlCommand(query, sqlconnection.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                // GridView kontrolüne verileri bağla
                GridView1.DataSource = reader;
                GridView1.DataBind();

                // SqlDataReader nesnesini kapat
                reader.Close();

            }
        }
    }
}