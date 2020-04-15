<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="webProjesi.html.anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Anasayfa</title>
    <link type="text/css" rel="stylesheet" href="/css/anasayfa.css" />
    <script src="../JS/slider.js" type="text/javascript"></script>
    <style>
        #slider {
            width: 700px;
            height: 306px;
        }
    </style>
</head>
<body class="body" >
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
    <div class="mainOpp">
        <marquee>FIRSAT YARATMAK VE FIRSATLARDAN YARARLANMAK ICIN HEMEN UYE OL KAZANIRKEN KAZANDIR..</marquee>
        <div id="slider">
            <a href="../html/firsatlar.html"><img src="../img/mainOpportunity .jpg" alt="WinToWin" /></a>
            <a href="../html/firsatlar.html"><img src="../sliderImg/fastfood.jpg"  alt="Yemek Firsatlari" /></a>
            <a href="../html/firsatlar.html"><img src="../sliderImg/sport.jpg"  alt="Spor Firsatlari" /></a>
            <a href="../html/firsatlar.html"><img src="../sliderImg/holiday.jpg"  alt="Tatil Firsatlari" /></a>
            <a href="../html/firsatlar.html"><img src="../sliderImg/cinema.jpg"  alt="Tiyatro Sinema Firsatlari" /></a>
        </div>
    </div>
   
    <footer>
       
          © 2020 wintowin.com, Tüm Hakları Saklıdır.
          <a href="http://gazi.edu.tr">Gazi Universitesi</a>
            
        
    </footer>
</body>
</html>
