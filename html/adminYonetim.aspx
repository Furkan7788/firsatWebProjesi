<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminYonetim.aspx.cs" Inherits="webProjesi.html.adminYonetim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Yonetim</title>
    <link type="text/css" rel="stylesheet" href="../css/adminYonetim.css" />
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</head>
<body>
    <a style="color:red; float:right" href="anasayfa.aspx"> Cikis Yap</a>
    <form id="form1" runat="server">
            <asp:HiddenField ID="hdnGoruntulenenFirsatTuru" Value = "null" runat="server" />
            <asp:HiddenField ID="hdnKampanyaNo" Value = "null" runat="server" />
        <div class="buttons">
              <asp:Button runat ="server"  class="listeleButton" Text ="Guncel Firsatlari Goruntule" OnClick="Unnamed1_Click"  />
              <asp:Button runat ="server"  class="listeleButton" Text ="Firsat Yayinlama Istekleri" OnClick="Unnamed2_Click" />
            
        </div> 
        <div class="onay">

            <p id="ikaz1" runat ="server" style="visibility:hidden;">
                <span id ="span1"></span>
           
            <asp:Button runat ="server" class="listeleButton" Text ="Firsati Sonlandir" OnClick="Unnamed4_Click" />
            </p>
            <p id="ikaz2" runat ="server" style="visibility:hidden;">
                   <span id ="span2"></span>
            <asp:Button runat ="server" class="listeleButton" Text ="Onayla" OnClick="Unnamed5_Click" />
            <asp:Button runat ="server" class="listeleButton" Text ="Reddet" OnClick="Unnamed7_Click" />
            </p>
        </div>
        <div id="guncellePanel" runat="server" class="guncellePanel" style="visibility:hidden; margin-bottom:1%;">
            <table>
             <tr>
             <td><input runat="server" type="text" value="null" id="ifirmaAdi" name="ifirmaAdi"  /> </td>
             <td><input runat="server" type="text" value="null" id="ifirmaSektoru" name="ifirmaSektoru"  /> </td>
             <td><input runat="server" type="text" value="null" id="iadres" name="iadres"  /> </td>
             <td><input runat="server" type="text" value="null" id="imahalle" name="imahalle"  /></td> 
             <td><input runat="server" type="text" value="null" id="iurun" name="iurun"  /> </td>
             </tr>
             <tr>
             
             <td><input runat="server" type="text" value="null" id="inormalFiyat" name="inormalFiyat"  /> </td>
             <td><input runat="server" type="text" value="null" id="iindirimliFiyat" name="iindirimliFiyat"  /></td> 
             <td><input runat="server" type="text" value="null" id="ikisiSayisi" name="ikisiSayisi"  /> </td>
             <td><input runat="server" type="text" value="null" id="ineZaman" name="ineZaman"  /> </td> 
             <td> <asp:Button runat ="server" class="ilisteleButton" Text ="Guncelle Ve Yayinla" OnClick="Unnamed8_Click" CssClass="btn-warning" /></td>
            </tr>

            </table>
        </div>
        <div class="icerik">
 
            <asp:Table runat ="server" id="myTable">
            </asp:Table>

        </div>
    </form>
    <script src="../JS/adminYonetim.js"></script>
</body>
</html>
