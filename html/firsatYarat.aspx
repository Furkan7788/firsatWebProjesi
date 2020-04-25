<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firsatYarat.aspx.cs" Inherits="webProjesi.html.firsatYarat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Firsat Yarat</title>
    <link type="text/css" rel="stylesheet" href ="../css/firsatYarat.css"; />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
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
    
    <div class="form-style-5">
        <form runat="server">
            <p id="ikaz" style="color : yellowgreen " runat="server"> </p>
             <asp:HiddenField ID="hdnResultValue" Value="0" runat="server" />
             <asp:HiddenField ID="hdnResultValue2" Value="0" runat="server" />
             <asp:HiddenField ID="hdnResultValue3" Value="0" runat="server" />

            <fieldset>
                    <legend style ="color :yellowgreen"><span class="number" style ="color :white">1</span> Fırsat Bilgileri</legend>
                    <input type="text" name="firmaAdi" id="firmaAdi" placeholder="Firma Adı *" /> 
                    <select id="sektorTuru" name="sektorTuru" >
                        
                    <optgroup label="Fırsat Türü" style ="color :yellowgreen" id="Optgroup1" runat="server">
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
                    <textarea name="adres" id="adres" placeholder="Açık Adres *"></textarea>
                    
                    <select id="select1" name="mahalle" >
                    <optgroup label="Mahalle" style ="color :yellowgreen" id="mahalle" runat="server">
                        <option value="sec">Seciniz</option>
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
                         <option value="sec">Seciniz</option>
                        <option value="Ankara">Ankara</option>
                    </optgroup>
                    </select>  
       
            </fieldset>
            <fieldset>
                <legend style ="color :yellowgreen"><span class="number" style ="color :white">2</span>Kampanya Bilgileri</legend>
               <input type="text" name="urun" id="urun" placeholder="Urun Adı *" />
               <input type="text" name="normalFiyat" id="normalFiyat" placeholder="Normal Fiyat *" />
               <input type="text" name="indirimliFiyat" id="indirimliFiyat" placeholder="Indirimli Fiyat *" />
               <input type="text" name="kisiSayisi" id="kisiSayisi" placeholder="Kisi Sayisi *" />
               <input type="text" name="neZaman" id="neZaman" placeholder="Ne Zaman ? *" />
            </fieldset>
            <asp:Button ID="firsatGonder" runat="Server" text="Firsati Gonder" OnClick="firsatGonder_Click"  ></asp:Button>
            </form>
            
    </div>





<footer>
       
          © 2020 wintowin.com, Tüm Hakları Saklıdır.
          <a href="http://gazi.edu.tr">Gazi Universitesi</a>
            
        
    </footer>
     <script src="../JS/firsatYarat.js"></script>
        </div>
</body>
</html>
