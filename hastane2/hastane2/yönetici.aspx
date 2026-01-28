<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yönetici.aspx.cs" Inherits="hastane2.yönetici" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Yönetici</title>
    <style>
        /* Arka plan rengi */
        body {
            background-color: rgb(69, 100, 110);
            margin: 0;
            padding: 0;
        }

        /* Butonların ortada olması ve biraz daha büyük olması için CSS stil tanımları */
        .button-container {
            text-align: center; /* Butonların yatay ortalanması */
            margin-top: 200px; /* Butonların üstteki boşluk */
        }

        .custom-button {
            font-size: 35px; /* Butonların metin boyutu */
            width: 380px; /* Butonların genişliği */
            height: 40px; /* Butonların yüksekliği */
            margin: 30px; /* Butonlar arasındaki boşluk */
            border: none; /* Kenarlık yok */
            border-radius: 5px; /* Kenar yumuşatma */
            cursor: pointer; /* Fare imleci el işareti */
        }

        /* Hasta ekle Butonu */
        #btnHastaEkle {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
        }

        #btnHastaEkle:hover {
            background-color: #254176; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnHastaEkle:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }

        /* Doktor ekle Butonu */
        #btnDoktorEkle {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
        }

        #btnDoktorEkle:hover {
            background-color: #254176; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnDoktorEkle:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }

        /* Rapor ekle Butonu */
        #btnRaporEkle {
            background-color: #40a2e5; /* Butonun arkaplan rengi */
            color: white; /* Buton metin rengi */
        }

        #btnRaporEkle:hover {
            background-color: #254176; /* Butona fare ile gelindiğindeki arkaplan rengi */
        }

        #btnRaporEkle:active {
            background-color: #40a2e5; /* Butona tıklandığında arkaplan rengi */
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="button-container">

            <!-- Hasta Ekle Butonu -->
            <asp:Button ID="btnHastaEkle" runat="server" Text="Hasta Ekle/Sil/Güncelle" OnClick="btnHastaEkle_Click" CssClass="custom-button" />
            <!-- Doktor Ekle Butonu -->
            <asp:Button ID="btnDoktorEkle" runat="server" Text="Doktor Ekle/Sil/Güncelle" OnClick="btnDoktorEkle_Click" CssClass="custom-button" />
            <!-- Rapor Ekle Butonu -->
            <asp:Button ID="btnRaporEkle" runat="server" Text="Rapor Ekle/Sil/Güncelle" OnClick="btnRaporEkle_Click" CssClass="custom-button" />
            
            

          
        </div>
    </form>
</body>
</html>