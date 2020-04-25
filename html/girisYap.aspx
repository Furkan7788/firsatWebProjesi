<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="girisYap.aspx.cs" Inherits="webProjesi.html.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sisteme Giris</title>
    <link type="text/css" rel="stylesheet" href="../css/giris.css" />
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

    <div class="icerik">
        <form class="form-style-7" runat="server">
            <ul>
                <li>
                    <label for="name">TC KIMLIK NUMARASI</label>
                    <input type="text" id="tcNo" name="tcNo" maxlength="11" runat ="server" />
                 
                    <span>11 HANELI TC NUMARANIZI GIRINIZ</span>
                </li>
                <li>
                    <label for="password">Sifre</label>
                    <input type="password" id="sifre" name="sifre" maxlength="100"  runat ="server" />
                    <span>Sifrenizi Giriniz</span>
                </li>

                <li>
                   <asp:Button ID="BtnGonder" runat="Server" text="GIRIS YAP" OnClick="BtnGonder_Click"></asp:Button>
                    <p id="ikaz" runat="server" style="color : red; text-align : center; "> </p>
                </li>
            </ul>

        </form>
    </div>
   </div>
</body>
</html>
