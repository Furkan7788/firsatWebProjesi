<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profilGoruntule.aspx.cs" Inherits="webProjesi.html.profilGoruntule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hesap Bilgileri</title>
    <link type="text/css" rel="stylesheet" href="../css/profilGoruntule.css" />
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
                <a class="navi" href="#">Benim Fırsatlarım</a>&nbsp; &nbsp; &nbsp;
                <a class="navi" href="firsatYarat.aspx">Fırsat Yarat</a>&nbsp; &nbsp;&nbsp;
                <a class="navi" href="#">Profilim </a>&nbsp;
                <a class="navi" href="girisYap.aspx" style ="color : red; font-weight:bold;">Cikis Yap </a>
         
            </nav>
        </div>
        
        <div class ="icerik">
           <div>
            <img id="uyepp" src="../img/uyePP.PNG" /></div>
           </div>
            
            <div id="uyeBilgileri">
                <form runat="server" >
                
                 <asp:HiddenField id="hprofilTcNo" Value="0" runat="server" />
                 <asp:HiddenField id="hprofilAdiSoyadi" Value="0" runat="server" />
                 <asp:HiddenField id="hprofilEmail" Value="0" runat="server" />
                 <asp:HiddenField id="hprofilTelNo" Value="0" runat="server" />
                 <asp:HiddenField id="hprofilSifre" Value="0" runat="server" />
                 
                 <table>
                        
                  <tr><td> Tc Kimlik Numarasi     </td> <td>  <input type="text" value="null" id="profilTcNo" name="profilTcNo"  /> </td></tr> 
                  <tr><td> Adi Soyadi             </td> <td> <input type="text" value="null"  id="profilAdiSoyadi" name="profilAdiSoyadi" /></td></tr> 
                  <tr><td> Email                  </td> <td> <input type="text" value="null"  id="profilEmail" name="profilEmail" /></td></tr> 
                  <tr><td> Telefon Numarasi       </td> <td> <input type="text" value="null"  id="profilTelNo" name="profilTelNo" /></td></tr> 
                  <tr><td> Sifre                  </td> <td> <input type="password" value="null"  id="profilSifre" name="profilSifre" /></td></tr> 
                  <tr><td> Sifreyi Tekrar giriniz </td> <td> <input type="password" value="null"  id="profilSifreTekrar" name="profilSifreTekrar" /></td></tr> 
                   </table>
                  <div class="buttons">
                    <asp:Button ID="uyeKaydiGuncelle" runat="Server" text="Guncelle" BackColor ="#99cc00" Font-Size ="X-Large" BorderColor ="#990000" ForeColor="#ccccff" OnClick="uyeKaydiGuncelle_Click"></asp:Button>
                    <asp:Button ID="uyeKaydiSil" runat="Server" text="Hesabı Sil" BackColor ="#cc3300"  Font-Size ="X-Large"  BorderColor ="#990000" ForeColor="#c0c0c0" OnClick="uyeKaydiSil_Click" OnClientClick="return confirmation();"></asp:Button>
                      <p id="profilIkaz" runat="server" style="color:teal"></p>
                  </div>
                </form>
            </div>
        </div>
    <script src="../JS/uyeProfil.js" ></script>
</body>
</html>
