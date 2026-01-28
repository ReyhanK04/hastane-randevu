using System;
using System.Web.UI;
using System.Data.SqlClient;
namespace hastane2
{
    public partial class anasayfa : Page
    {

        // Hasta Butonu Tıklama Olayı
        protected void btnHasta_Click(object sender, EventArgs e)
        {
            // Yönlendirme işlemi - Hasta sayfasına
            Response.Redirect("hasta.aspx");
        }

        // Doktor Butonu Tıklama Olayı
        protected void btnDoktor_Click(object sender, EventArgs e)
        {
            // Yönlendirme işlemi - Doktor sayfasına
            Response.Redirect("doktor.aspx");

        }

        //Yönetici Butonu Ekleme Olayı
        protected void btnYonetici_Click(object sender, EventArgs e)
        {
            // Yönlendirme işlemi - Doktor sayfasına
            Response.Redirect("yönetici.aspx");
        }

        //Randevu Al Butonu Ekleme Olayı
        protected void btnRandevuAl_Click(object sender, EventArgs e)
        {
            //Yönlendirme işlemi  - Randevu Alma Sayfası
            Response.Redirect("RandevuAl.aspx");
        }

        //Tibbi Raporlar Butonu Ekleme Olayı
        protected void btnTibbiRaporlar_Click(object sender, EventArgs e)
        {
            //Yönlendirme işlemi  - Randevu Alma Sayfası
            Response.Redirect("TibbiRaporlar.aspx");
        }
    }
}