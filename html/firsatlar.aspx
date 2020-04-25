<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firsatlar.aspx.cs" Inherits="webProjesi.html.firsatlar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Firsatlar</title>
    <link type="text/css"  rel="stylesheet" href="../css/firsatlar.css" />
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
                        <a class="navi" href="anasayfa.aspx">Anasayfa</a> &nbsp; &nbsp; &nbsp;
                        <a class="navi" href="wtwnedir.aspx">WTW NEDIR?</a>&nbsp; &nbsp; &nbsp;
                        <a class="navi" href="firsatlar.aspx">Fırsatlar</a>&nbsp; &nbsp; &nbsp;
                        <a class="navi" href="kazananlar.aspx">Kimlere Kazandırdık ?</a>&nbsp; &nbsp;&nbsp;
                        <a class="navi" href="uyeol.aspx">Uye Ol </a>&nbsp;
                        <a class="navi" href="girisYap.aspx">Giris Yap </a>
                    </nav>
                    </div>
                </div>
       </div>
    </div>

     <span class="ikaz1" > Aktif Firsatlardan Yararlanmak Icin Hemen Uye Olun</span> 

    <div class ="aramaMotoru">
        <form runat ="server">
             <asp:HiddenField ID="hdnFirsatTuru" Value = "null" runat="server" />
             <asp:HiddenField ID="hdnMahalle" Value= "null" runat="server" />
             <asp:HiddenField ID="hdnSehir" Value= "null" runat="server" />
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
                 
         <select id="mahalleTuru" name="mahalle" >
                        
                    <optgroup label="Mahalle" style ="color :yellowgreen" id="mahalle" runat="server">
                        <option value="sec">MAHALLE SECINIZ</option>
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
        </form>
    </div>



    <div class="icerik">
        
         
        
        <asp:Table runat ="server" id="myTable">
              
           
           
               
          
        </asp:Table>

    </div>
    </div>
   <script src="../JS/firsatlar.js"></script>
</body>
</html>
