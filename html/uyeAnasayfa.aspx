<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uyeAnasayfa.aspx.cs" Inherits="webProjesi.html.uyeAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WinToWin</title>
    <link type ="text/css" rel ="stylesheet" href="../css/uyeAnasayfa.css" />
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
</head>
<body>
     <div class="header">
        <div class="logo">
            <img src="../img/logo.png" />
        </div>
       
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
    
        BURAYADA TURE SEHIR MAHALLE GORE ARAMA MOTORU KOYCAN
    <div class ="onayIkaz">
        <form runat ="server">
               <asp:HiddenField ID="hdnKampanyaNo" Value="0" runat="server" />
        <p><span class ="ikaz" id="ikaz1"> </span> Numaralı Kampanya -> <span  class ="ikaz"  id ="ikaz2"></span> daki fırsat için <span  class ="ikaz"  id="ikaz3"></span>
            tarihinde <span  class ="ikaz"  id="ikaz4"></span> /<span  class ="ikaz"  id="ikaz5"></span> adresinde olmayı onaylıyor musun ?
          <asp:Button ID="firsatiOnayla" runat="Server" text="ONAYLA" OnClick="firsatiOnayla_Click" ></asp:Button>
        </p>
         </form>
    </div>
    <p class ="bilgilendirme" >Bilgilendirme: Fırsata kayıt yaptırmak için fırsatın üzerine tıkladıktan sonra onay veriniz. Kişi sayısının ekside olması 
        gerekli kişi sayısı sağlanmış olmasi demektir fakat bu sizin firsattan yararlanamayacağınız anlamına gelmez. Fırsatı onayladıktan sonra sayfayı yenileyiniz
        sonra kişi sayısının düştüğünü ve benim fırsatlarım da kayıt olduğunuzu göreceksiniz.
    </p>

    <div class="icerik">
         <asp:Table runat ="server" id="myTable">
              
            <asp:TableHeaderRow  Runat="server" id="myRow" >
               
                 <asp:TableHeaderCell >Kampanya Numarasi </asp:TableHeaderCell>  
                 <asp:TableHeaderCell >Firma Adi </asp:TableHeaderCell> 
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
    
   
    <script src="../JS/uyeAnasayfa.js"></script>
</body>
</html>
