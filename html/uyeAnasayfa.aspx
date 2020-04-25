<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uyeAnasayfa.aspx.cs" Inherits="webProjesi.html.uyeAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WinToWin</title>
    <link type ="text/css" rel ="stylesheet" href="../css/uyeAnasayfa.css" />
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
    
    <div class ="onayIkaz">
    
               <asp:HiddenField ID="hdnKampanyaNo" Value="0" runat="server" />
        <p><span class ="ikaz" id="ikaz1"> </span> Numaralı Kampanya -> <span  class ="ikaz"  id ="ikaz2"></span> daki fırsat için <span  class ="ikaz"  id="ikaz3"></span>
            tarihinde <span  class ="ikaz"  id="ikaz4"></span> /<span  class ="ikaz"  id="ikaz5"></span> adresinde olmayı onaylıyor musun ?
          <asp:Button ID="firsatiOnayla" runat="Server" text="ONAYLA" OnClick="firsatiOnayla_Click" ></asp:Button>
        </p>
   
    </div>
    <p class ="bilgilendirme" >Bilgilendirme: Fırsata kayıt yaptırmak için fırsatın üzerine tıkladıktan sonra onay veriniz. Kişi sayısının ekside olması 
        gerekli kişi sayısı sağlanmış olmasi demektir fakat bu sizin firsattan yararlanamayacağınız anlamına gelmez. Fırsatı onayladıktan sonra sayfayı yenileyiniz
        sonra kişi sayısının düştüğünü ve benim fırsatlarım da kayıt olduğunuzu göreceksiniz.
    </p>

     <div class ="aramaMotoru">
       
             <asp:HiddenField ID="hdnFirsatTuru" Value = "null" runat="server" />
             <asp:HiddenField ID="hdnMahalle" Value= "null" runat="server" />
             <asp:HiddenField ID="hdnSehir" Value= "null" runat="server" />
             <select id="sektorTuru" name="sektorTuru" >
                        
                    <optgroup label="Fırsat Türü" style ="color :yellowgreen" id="Optgroup2" runat="server">
                        <option value="sec">FIRSAT TÜRÜ</option>
                        <option value="Yemek">Yeme-İçme</option>
                        <option value="Market">Market</option>
                        <option value="Saglik-Guzellik">Saglık-Guzellik</option>
                        <option value="Oto-Bakim">Oto Bakim</option>
                        <option value="Sinema-Tiyatro">Sinema - Tiyatro</option>
                        <option value="Spor-Salonu">Spor Salonu</option>
                        <option value="Tatil">Tatil</option>
                        <option value="Etkinlik">Etkinlik</option>
                        <option value="Diger">Diger</option>
                    </optgroup>
                    </select>      
                 
         <select id="mahalleTuru" name="mahalle" >
                        
                    <optgroup label="Mahalle" style ="color :yellowgreen" id="Optgroup3" runat="server">
                        <option value="sec">MAHALLE</option>
                        <option value="Altindag">Altindag</option>
                        <option value="Cankaya">Cankaya</option>
                        <option value="Etimesgut">Etimesgut</option>
                        <option value="Golbasi">Golbasi</option>
                        <option value="Kecioren">Kecioren</option>
                        <option value="Mamak">Mamak</option>
                        <option value="Sincan">Sincan</option>
                        <option value="Yenimahalle">Yenimahalle</option>
                    </optgroup>
                    </select>      
                 
                   <select id="select2" name="field4">
                    <optgroup label="Sehir" style ="color :yellowgreen">
                         <option value="sec">SEHIR SECINIZ</option>
                        <option value="Ankara">Ankara</option>
                    </optgroup>
                    </select>  
            <asp:Button runat ="server" class="listeleButton" Text ="Listele" OnClick="Unnamed1_Click" />
            <asp:Button runat ="server" class="listeleButton" Text ="Tümü Fırsatları Listele" OnClick="Unnamed2_Click"  />
       
    </div>



    <div class="icerik">
        
         
        
        <asp:Table runat ="server" id="myTable">
              
           
           
               
          
        </asp:Table>

    </div>
    </form>
   </div>
    <script src="../JS/uyeAnasayfa.js"></script>
</body>
</html>
