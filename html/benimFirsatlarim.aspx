﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="benimFirsatlarim.aspx.cs" Inherits="webProjesi.html.benimFirsatlarim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Benim Fırsatları</title>
    <link type ="text/css" rel ="stylesheet" href="../css/benimFirsatlarim.css" />
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body>
   <div class="container">
     <div class="header">
        <div class="row"> 
         
                 <div class="col">
                     <div class="logo">
                     <img src="../img/logo.png" />
                    </div>
                </div>

                <div class="col">
                    <div class="nav">
                        <nav>
                             <a class="navi" href="uyeAnasayfa.aspx">Fırsatlar</a>&nbsp; &nbsp; &nbsp;
                             <a class="navi" href="benimFirsatlarim.aspx">Benim Firsatlarım </a>&nbsp; &nbsp; &nbsp;
                             <a class="navi" href="firsatYarat.aspx">Fırsat Yarat</a>&nbsp; &nbsp;&nbsp;
                             <a class="navi" href="profilGoruntule.aspx">Profilim </a>&nbsp;
                             <a class="navi" href="girisYap.aspx" style ="color : red; font-weight:bold;">Cikis Yap </a>
                      </nav>
                    </div>
                </div>
       </div>
    </div>

    <form runat ="server">
    <div id="onayIkaz1" class ="onayIkaz">
      
        <asp:HiddenField ID="hdnGidelecekFirsatId" Value="0" runat="server" />
        <p><span class ="ikaz" id="ikaz2">  </span> numaralı fırsata katılmaktan vazgeçmek istiyor musunuz ?
          <asp:Button ID="vazgec" runat="Server" text="ONAYLA" OnClick="vazgec_Click"  ></asp:Button>
        </p>
         
    </div>

            <span class="baslik" style=" margin-left : 20%; color : orangered">Gidecegim Firsatlar  <span class ="bilgilendirme">(Gidemeyeceğiniz fırsatı üzerine tıklayarak iptal edebilirsiniz.)</span></span>
     <asp:Table runat ="server" id="myTable">
              
            <asp:TableHeaderRow CssClass="tableHeader">
               
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

       <span class="baslik" style=" margin-left : 20%; color : orangered">Geçmiş Fırsatlarım</span>
       <asp:Table runat ="server" id="Table1">
              
            <asp:TableHeaderRow  CssClass="tableHeader">
               
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

    <div id="onayIkaz2" class ="onayIkaz">
        
        <asp:HiddenField ID="hdnBekleyenKampanyaNo" Value="0" runat="server" />
        <p><span class ="ikaz" id="ikaz1">  </span> numaralı onay bekleyen fırsatınızı iptal etmek istiyor musunuz?
          <asp:Button ID="bekleyenFirsat" runat="Server" text="ONAYLA" OnClick="bekleyenFirsat_Click" ></asp:Button>
        </p>
        
    </div>

      <span class="baslik" style=" margin-left : 20%; color : orangered">Onay Bekleyen Firsatlarim <span class ="bilgilendirme">(Fırsatınız onaylanana kadar iptal edebilirsiniz. İptal etmek istediğiniz fırsatı seçip onaylayın.)</span></span> 
       <asp:Table runat ="server" id="Table2">
              
            <asp:TableHeaderRow  CssClass="tableHeader">
               
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
     <span class="baslik" style=" margin-left : 20%; color : orangered">Reddedilen Firsatlarim</span>
       <asp:Table runat ="server" id="Table3">
              
            <asp:TableHeaderRow CssClass="tableHeader" >
               
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
               
          </form>
    <script src="../JS/benimFirsatlarim.js"></script>
       </div>
</body>
</html>
