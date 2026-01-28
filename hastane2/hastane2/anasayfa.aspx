
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="hastane2.anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Anasayfa</title>
    <style>
        /* Arka plan rengi */
        body {
         background-image: url('../images/foto2.jpeg');
         background-size: cover; /* Arka plan resminin ekran boyutuna otomatik olarak uyum sağlamasını sağlar */
         background-position: center; /* Arka plan resminin ortalanmasını sağlar */
         margin: 0;
         padding: 0;
        }

        /* Butonların ortada olması ve biraz daha büyük olması için CSS stil tanımları */
        .button-container {
            text-align: center; /* Butonların yatay ortalanması */
            margin-top: 5px; /* Butonların üstteki boşluk */
        }

        .custom-button {
            font-size: 30px; /* Butonların metin boyutu */
            width: 200px; /* Butonların genişliği */
            height: 70px; /* Butonların yüksekliği */
            margin: 30px; /* Butonlar arasındaki boşluk */
            border: none; /* Kenarlık yok */
            border-radius: 5px; /* Kenar yumuşatma */
            cursor: pointer; /* Fare imleci el işareti */
        }

        /* Hasta Butonu */
        #btnHasta {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
        }

        #btnHasta:hover {
            background-color: #326077; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnHasta:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }

        /* Doktor Butonu */
        #btnDoktor {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
}

        #btnDoktor:hover {
            background-color: #326077; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnDoktor:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }

        /* Yönetici Butonu */
        #btnYonetici {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
}

        #btnYonetici:hover {
            background-color: #326077; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnYonetici:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }

        /* Randevu Alma Butonu */
        #btnRandevuAl {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
}

        #btnRandevuAl:hover {
            background-color: #326077; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnRandevuAl:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }

        /* Tibbi Raporlar Butonu */
        #btnTibbiRaporlar {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
}

        #btnTibbiRaporlar:hover {
            background-color: #326077; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnTibbiRaporlar:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Resim konteyneri -->
        <div class="image-container">
            <img src="images/Digital - AH – STUDIO Blog.jpeg"  />
        </div>

        <div class="button-container">
            <!-- Hasta Butonu -->
            <asp:Button ID="btnHasta" runat="server" Text="Hasta" OnClick="btnHasta_Click" CssClass="custom-button" />
            <!-- Doktor Butonu -->
            <asp:Button ID="btnDoktor" runat="server" Text="Doktor" OnClick="btnDoktor_Click" CssClass="custom-button" />
            <!-- Yonetici Butonu -->
            <asp:Button ID="btnYonetici" runat="server" Text="Yönetici" OnClick="btnYonetici_Click" CssClass="custom-button" />
            <!-- Randevu Al Butonu -->
            <asp:Button ID="btnRandevuAl" runat="server" Text="Randevu Al" OnClick="btnRandevuAl_Click" CssClass="custom-button" />
            <!-- Tibbi Rapor Butonu -->
            <asp:Button ID="btnTibbiRaporlar" runat="server" Text="Tibbi Raporlar" OnClick="btnTibbiRaporlar_Click" CssClass="custom-button" />
           
        </div>
    </form>
</body>
</html>