<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uyeol.aspx.cs" Inherits="webProjesi.html.uyeol" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link type="text/css" rel="stylesheet" href="../css/uyeol.css" />
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
     <script src="../JS/yeniUyeKayit.js"></script>
    <title>Uye Ol</title>
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
    
    <div class="icerik">
        <div class="form-style-3">
            <form runat ="server" method ="post" action ="uyeol.aspx">
                <p runat="server" id="yeniUyeOlIkaz" style ="background-color:aquamarine; color:red;"></p>
                <fieldset>
                    <legend>Personal</legend>
                    <label for="field1"><span>TC Numarasi <span class="required">*</span></span><input id="tcNo" type="text" class="input-field" name="tcNo" value="" maxlength="11" required minlength="5"  /></label>
                    <label for="field1"><span>Isim Soyisim <span class="required">*</span></span><input id="isimSoyisim" type="text" class="input-field" name="isimSoyisim" value="" /></label>
                    <label for="field2"><span>Email <span class="required">*</span></span><input id="email" type="email" class="input-field" name="email" value="" /></label>
                    <label for="field3"><span>Telefon Numarasi <span class="required">*</span></span><input id="telNo" type="text" class="input-field" name="telNo" value="" /></label>
                    

                </fieldset>

                <fieldset>
                    <legend>Sistem Girisi</legend>
                    <label for="field3"><span>Sifre <span class="required">*</span></span><input id="sifre" type="password" class="input-field" name="sifre" value="" /></label>
                    <label for="field3"><span>Sifreyi Tekrar giriniz <span class="required">*</span></span><input id="sifreTekrar" type="password" class="input-field" name="field3" value="" /></label>
                    <label><span> </span><asp:Button ID="BtnGonder" runat="Server" text="Gonder" OnClick="BtnGonder_Click"></asp:Button></label>
                   
                </fieldset>
            </form>
          
        </div>
    </div>
</div>
</body>
</html>
