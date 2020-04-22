<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="benimFirsatlarim.aspx.cs" Inherits="webProjesi.html.benimFirsatlarim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Benim Fırsatları</title>
    <link type ="text/css" rel ="stylesheet" href="../css/benimFirsatlarim.css" />
</head>
<body>
   <div class="header">
        <div class="logo">
            <img src="../img/logo.png" />
        </div>
        <div class="nav">
            <nav>
                 <a class="navi" href="uyeAnasayfa.aspx">Fırsatlar</a>&nbsp; &nbsp; &nbsp;
                <a class="navi" href="benimFirsatlarim.aspx">Benim Fırsatlarım</a>&nbsp; &nbsp; &nbsp;
                <a class="navi" href="firsatYarat.aspx">Fırsat Yarat</a>&nbsp; &nbsp;&nbsp;
                <a class="navi" href="benimFirsatlarim.aspx">Profilim </a>&nbsp;
                <a class="navi" href="girisYap.aspx" style ="color : red; font-weight:bold;">Cikis Yap </a>
            </nav>
        </div>
    </div>
            <h2 style=" margin-left : 20%; color : orangered">Gidecegim Firsatlar</h2>
     <asp:Table runat ="server" id="myTable">
              
            <asp:TableHeaderRow>
               
                 <asp:TableHeaderCell>Kampanya Numarasi </asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Firma Adi </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Firma Sektoru </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Adres </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Mahalle</asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Sehir </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Ürün</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Normal Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Indirimli Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Kisi sayisi </asp:TableHeaderCell>
                 <asp:TableHeaderCell>Ne zaman ?</asp:TableHeaderCell>
                
           </asp:TableHeaderRow>
        </asp:Table>

       <h2 style=" margin-left : 20%; color : orangered">Geçmiş Fırsatlarım</h2>
       <asp:Table runat ="server" id="Table1">
              
            <asp:TableHeaderRow>
               
                 <asp:TableHeaderCell>Kampanya Numarasi </asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Firma Adi </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Firma Sektoru </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Adres </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Mahalle</asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Sehir </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Ürün</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Normal Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Indirimli Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Kisi sayisi </asp:TableHeaderCell>
                 <asp:TableHeaderCell>Ne zaman ?</asp:TableHeaderCell>
                
           </asp:TableHeaderRow>
        </asp:Table>

      <h2 style=" margin-left : 20%; color : orangered">Onay Bekleyen Firsatlarim</h2>
       <asp:Table runat ="server" id="Table2">
              
            <asp:TableHeaderRow>
               
                 <asp:TableHeaderCell>Kampanya Numarasi </asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Firma Adi </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Firma Sektoru </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Adres </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Mahalle</asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Sehir </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Ürün</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Normal Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Indirimli Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Kisi sayisi </asp:TableHeaderCell>
                 <asp:TableHeaderCell>Ne zaman ?</asp:TableHeaderCell>
                
           </asp:TableHeaderRow>
        </asp:Table>
     <h2 style=" margin-left : 20%; color : orangered">Reddedilen Firsatlarim</h2>
       <asp:Table runat ="server" id="Table3">
              
            <asp:TableHeaderRow>
               
                 <asp:TableHeaderCell>Kampanya Numarasi </asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Firma Adi </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Firma Sektoru </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Adres </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Mahalle</asp:TableHeaderCell>  
                 <asp:TableHeaderCell>Sehir </asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Ürün</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Normal Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Indirimli Fiyat</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Kisi sayisi </asp:TableHeaderCell>
                 <asp:TableHeaderCell>Ne zaman ?</asp:TableHeaderCell>
                
           </asp:TableHeaderRow>
        </asp:Table>
               
          

</body>
</html>
