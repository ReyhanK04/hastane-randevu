<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RandevuAl.aspx.cs" Inherits="hastane2.RandevuAl" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Randevu Al</title>
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
        #GridView1 {
            width: 50%; /* Önceki değerin yarısı */
            border-collapse: collapse;
            margin-top: 20px;
            background-color: white;
        }

        #GridView1 th {
            background-color: #000084;
            color: white;
            font-weight: bold;
            padding: 2px; /* Önceki değerden daha az padding */
            text-align: left;
        }

        #GridView1 td, #GridView1 th {
            border: 1px solid #ddd;
            padding: 2px; /* Önceki değerden daha az padding */
        }

        #GridView1 tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #GridView1 tr:hover {
            background-color: #ddd;
        }


        .form-container {
            width: 50%;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #69a0af;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input, .form-group select {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-group button {
            padding: 10px 15px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .form-group button:hover {
            background-color: #0056b3;
        }
        .result-message {
            margin-top: 20px;
            font-size: 1.2em;
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Randevu Al</h2>
            <div class="form-group">
                <label for="ddlHasta">Hasta:</label>
                <asp:DropDownList ID="ddlHasta" runat="server" />
            </div>
            <div class="form-group">
                <label for="ddlDoktor">Doktor:</label>
                <asp:DropDownList ID="ddlDoktor" runat="server" />
            </div>
            <div class="form-group">
                <label for="txtTarih">Randevu Tarihi:</label>
                <asp:TextBox ID="txtTarih" runat="server" TextMode="Date" />
            </div>
            <div class="form-group">
                <label for="txtSaat">Randevu Saati:</label>
                <asp:TextBox ID="txtSaat" runat="server" TextMode="Time" />
            </div>
            <div class="form-group">
                <label for="ddlKlinik">Klinik:</label>
                <asp:DropDownList ID="ddlKlinik" runat="server" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnRandevuAl" runat="server" Text="Randevu Al" OnClick="btnRandevuAl_Click" />
            </div>
            <div class="result-message">
                <asp:Label ID="lblSonuc" runat="server" Text="" />
            </div>
           <div>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Vertical" AutoGenerateSelectButton="true"
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="RandevuID" HeaderText="RandevuID" />
        <asp:BoundField DataField="Hastaid" HeaderText="Hastaid" />
        <asp:BoundField DataField="DoktorID" HeaderText="DoktorID" />
        <asp:BoundField DataField="RandevuTarihi" HeaderText="RandevuTarihi " />
        <asp:BoundField DataField="RandevuSaati" HeaderText="RandevuSaati" />
        <asp:BoundField DataField="Klinik" HeaderText=" Klinik" />
        <asp:BoundField DataField="HastaAdi" HeaderText="HastaAdi" />
        <asp:BoundField DataField="HastaSoyadi" HeaderText="HastaSoyadi" />
        <asp:CommandField ShowSelectButton="True" SelectText="Sil" />
    </Columns>
    </asp:GridView>
        </div>
          
        </div>
    </form>
</body>
</html>