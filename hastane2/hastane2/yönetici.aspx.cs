
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hastane2
{
    public partial class yönetici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnHastaEkle_Click(object sender, EventArgs e)
        {
            // Yönlendirme işlemi - Hasta Ekle sayfasına
            Response.Redirect("HastaEkle.aspx");
        }

        protected void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            // Yönlendirme işlemi - Doktor Ekle sayfasına
            Response.Redirect("DoktorEkle.aspx");
        }

        protected void btnRaporEkle_Click(object sender, EventArgs e)
        {
            // Yönlendirme işlemi - Rapor Ekle sayfasına
            Response.Redirect("RaporEkle.aspx");


        }


    }
}