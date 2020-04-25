<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminGiris.aspx.cs" Inherits="webProjesi.html.admin.adminGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Admin Giris</title>
    <link type="text/css" rel ="stylesheet" href ="../css/adminGiris.css" />

    <style type="text/css">
        #sifre {
            width: 273px;
        }
        #kullaniciAdi {
            width: 272px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div style ="text-align:center; margin-top:15%; height: 233px;">
           <span style ="margin-bottom:25%; color :bisque; font-size : 1.5vw">  ADMIN GIRIS PANELI</span>  <br />
            <hr />
             <input type="text" id="kullaniciAdi" name="kullaniciAdi" maxlength="11" runat ="server" placeholder="KULLANICI ADI" /> <p></p>
              <input type="password" id="sifre" name="sifre" maxlength="11" runat ="server" placeholder ="SIFRE" /> <br />
            <asp:Button runat ="server" class="listeleButton" Text ="Giris Yap" OnClick="Unnamed1_Click"  />
        </div>
    </form>
</body>
</html>
