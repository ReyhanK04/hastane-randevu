<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hasta.aspx.cs" Inherits="hastane2.hasta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hasta Bilgileri</title>
    <style>
        /* Arka plan rengi */
        body {
         background-image: url('../images/foto.jpeg');
         background-size: cover; /* Arka plan resminin ekran boyutuna otomatik olarak uyum sağlamasını sağlar */
         background-position: center + 1; /* Arka plan resminin ortalanmasını sağlar */
         margin: 10;
         padding: 0;
        }

        /* GridView stilleri */
      /*  #GridView1 {
            width: 100%;
            border-collapse: collapse;
            margin-top: 10px;
            background-color: white;
        }
          */
        #GridView1 th {
            background-color: #000084;
            color: white;
            font-weight: bold;
            padding: 10px;
            text-align: left;
        } 

     /*  #GridView1 td, #GridView1 th {
            border: 1px solid #ddd;
            padding: 8px;
        }*/

        #GridView1 tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #GridView1 tr:hover {
            background-color: #808080;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Vertical">
                <Columns>
                    <asp:BoundField DataField="hastaid" HeaderText="Hasta ID" />
                    <asp:BoundField DataField="ad" HeaderText="Ad" />
                    <asp:BoundField DataField="soyad" HeaderText="Soyad" />
                    <asp:BoundField DataField="dogumtarihi" HeaderText="Doğum Tarihi" />
                    <asp:BoundField DataField="cinsiyet" HeaderText="Cinsiyet" />
                    <asp:BoundField DataField="telno" HeaderText="Telefon Numarası" />
                    <asp:BoundField DataField="adres" HeaderText="Adres" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>