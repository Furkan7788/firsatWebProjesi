<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uyeol.aspx.cs" Inherits="webProjesi.html.uyeol" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link type="text/css" rel="stylesheet" href="../css/uyeol.css" />
    <script src="../JS/yeniUyeKayit.js"></script>
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
        <div class="form-style-3">
            <form runat ="server" method ="post" action ="uyeol.aspx">
                <fieldset>
                    <legend>Personal</legend>
                    <label for="field1"><span>TC Numarasi <span class="required">*</span></span><input id="tcNo" type="text" class="input-field" name="tcNo" value="" /></label>
                    <label for="field1"><span>Isim Soyisim <span class="required">*</span></span><input id="isimSoyisim" type="text" class="input-field" name="isimSoyisim" value="" /></label>
                    <label for="field2"><span>Email <span class="required">*</span></span><input id="email" type="email" class="input-field" name="email" value="" /></label>
                    <label for="field3"><span>Telefon Numarasi <span class="required">*</span></span><input id="telNo" type="text" class="input-field" name="telNo" value="" /></label>
                    

                </fieldset>

                <fieldset>
                    <legend>Sistem Girisi</legend>
                    <label for="field3"><span>Sifre <span class="required">*</span></span><input id="sifre" type="text" class="input-field" name="sifre" value="" /></label>
                    <label for="field3"><span>Sifreyi Tekrar giriniz <span class="required">*</span></span><input id="sifreTekrar" type="text" class="input-field" name="field3" value="" /></label>
                    <label><span> </span><asp:Button ID="BtnGonder" runat="Server" text="Gonder" OnClick="BtnGonder_Click"></asp:Button></label>
                   
                </fieldset>
            </form>
          
        </div>
    </div>
</body>
</html>
