<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="doktor.aspx.cs" Inherits="hastane2.doktor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Doktor Listesi</title>
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

       /* #GridView1 td, #GridView1 th {
            border: 1px solid #ddd;
            padding: 8px;
        }*/

        #GridView1 tr:nth-child(even) {
            background-color: #f2f2f2;
        }

    </style>
<script>
        window.onload = function () {
            var rows = document.querySelectorAll("#GridView1 tr");

            rows.forEach(function (row) {
                row.addEventListener("mouseover", function () {
                    this.style.backgroundColor = "#808080";
                });

                row.addEventListener("mouseout", function () {
                    this.style.backgroundColor = "";
                });
            });
        };
</script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Vertical">
                <Columns>
                    <asp:BoundField DataField="DoktorID" HeaderText="Doktor ID" />
                    <asp:BoundField DataField="Ad" HeaderText="Ad" />
                    <asp:BoundField DataField="Soyad" HeaderText="Soyad" />
                    <asp:BoundField DataField="UzmanlıkAlanı" HeaderText="Uzmanlık Alanı" />
                    <asp:BoundField DataField="CalistigiHastane" HeaderText="Çalıştığı Hastane" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>