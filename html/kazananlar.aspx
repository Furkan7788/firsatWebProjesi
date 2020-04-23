<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kazananlar.aspx.cs" Inherits="webProjesi.html.kazananlar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kazananlar!</title>
    <link type="text/css" rel="stylesheet" href="../css/kazananlar.css" />
</head>
<body>
  <div class="header">
        <div class="logo">
            <img src="../img/logo.png" />
        </div>
        <div class="nav">
            <nav>
                  <a class="navi" href="anasayfa.aspx">Anasayfa</a> &nbsp; &nbsp; &nbsp;
                <a class="navi" href="wtwnedir.aspx">WTW NEDIR?</a>&nbsp; &nbsp; &nbsp;
                <a class="navi" href="firsatlar.aspx">Fırsatlar</a>&nbsp; &nbsp; &nbsp;
                <a class="navi" href="kazananlar.aspx">Kimlere Kazandırdık ?</a>&nbsp; &nbsp;&nbsp;
                <a class="navi" href="uyeol.aspx">Uye Ol </a>&nbsp;
                <a class="navi" href="girisYap.aspx">Giris Yap </a>
            </nav>
        </div>
    </div>

    <div class="icerik">
       
            <caption>Asağıda Geçmişteki Fırsatlardan Kimler Nekadar Kazandı Görebilirsiniz.  Kazanalardan Olmak İçin Hemen Üye Olunuz.</caption>
          
        <asp:Table runat ="server" id="myTable">
              
            <asp:TableHeaderRow CssClass ="tableHeader">
               
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

    </div>

</body>
</html>
