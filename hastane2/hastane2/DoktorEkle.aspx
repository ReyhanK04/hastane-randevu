<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorEkle.aspx.cs" Inherits="hastane2.DoktorEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
    /* Arka plan rengi */
    body {
     background-image: url('../images/foto.jpeg');
     background-size: cover; /* Arka plan resminin ekran boyutuna otomatik olarak uyum sağlamasını sağlar */
     background-position: center + 1; /* Arka plan resminin ortalanmasını sağlar */
     margin: 0;
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


        /* Form alanlarını düzenle */
    label {
        display: inline-block;
        width: 150px; /* Etiketlerin genişliğini ayarlayın */
        margin-right: 50px; /* Sağ boşluk ekleyin */
    }

    .textbox,
    .dropdown {
        width: 200px; /* Textbox ve dropdownların genişliğini ayarlayın */
        margin-bottom: 5px; /* Alt boşluk ekleyin */
    }

    #form1 {
        text-align: center; /* Formu yatayda ortala */
        margin-top: 50px; /* Üst boşluk ekleyin */
    }

    #form1 div {
        margin: 0 auto; /* Div'i yatayda ortala */
        width: 500px; /* Div'in genişliğini ayarlayın */
        background-color: #91d3ea; /* Arka plan rengini beyaz yapın */
        padding: 20px; /* Kenar boşlukları ekleyin */
        border-radius: 10px; /* Köşeleri yuvarlayın */
    }
        </style>
</head>
<body>
    <form id="form1" runat="server">
             <div style="overflow-y:auto; max-height: 300px;"> <!-- Tablonun dikey kaydırma cubugu ile kaydırılabilir olması için div içine alıyoruz -->
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999"
        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Vertical" AutoGenerateSelectButton="true"
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="DoktorID" HeaderText="Doktor ID" />
            <asp:BoundField DataField="Ad" HeaderText="Ad" />
            <asp:BoundField DataField="Soyad" HeaderText="Soyad" />
            <asp:BoundField DataField="UzmanlıkAlanı" HeaderText="Uzmanlik Alani" />
            <asp:BoundField DataField="CalistigiHastane" HeaderText="Calistigi Hastane" />
        </Columns>
    </asp:GridView>
         <asp:Button ID="btnDoktorSil" runat="server" Text="Sil" OnClick="btnDoktorSil_Click" />
           </div>

        <h2 style="color: white; font-weight: bold;">Doktor Ekle</h2>

       <div style="margin-bottom: 3px;"> <!-- Etiketlerin ve metin kutularının altına biraz boşluk ekler -->
    <div style="margin-bottom: 3px;"> <!-- Her etiket/metin kutusu çifti arasına biraz boşluk ekler -->
        <label>ad:</label>
        <asp:TextBox ID="txtDoktorad" runat="server"></asp:TextBox>
    </div>
    <div style="margin-bottom: 3px;">
        <label>soyad:</label>
        <asp:TextBox ID="txtDoktorsoyad" runat="server"></asp:TextBox>
    </div>
    <div style="margin-bottom: 3px;">
        <label>UzmanlıkAlanı:</label>
        <asp:TextBox ID="txtUzmanlıkAlanı" runat="server"></asp:TextBox>
    </div>
    <div style="margin-bottom: 3px;">
        <label>calistigihastane:</label>
        <asp:TextBox ID="txtcalistigihastane" runat="server"></asp:TextBox>
    </div>
   
    <div>
        <asp:Button ID="btnDoktorKaydet" runat="server" Text="Kaydet" OnClick="btnDoktorKaydet_Click" />
        <asp:Button ID="btnDoktorGuncelle" runat="server" Text="Guncelle" OnClick="btnDoktorGuncelle_Click" />
    </div>



        </div>
    </form>
</body>
</html>
