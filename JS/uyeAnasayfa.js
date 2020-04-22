$(document).ready(function () {
    $("#myTable tr").click(function () {
        $(".onayIkaz").css("visibility","visible");
        $(this).find("#kNo").each(function () {
            $("#ikaz1").text($(this).text());
            $("#hdnKampanyaNo").val($(this).text());
        });
        $(this).find("#fAdi").each(function () {
            $("#ikaz2").text($(this).text());
        });
        
        $(this).find("#fAdres").each(function () {
            $("#ikaz4").text($(this).text());
        });
        $(this).find("#fMahalle").each(function () {
            $("#ikaz5").text($(this).text());
        });
        $(this).find("#neZmn").each(function () {
            $("#ikaz3").text($(this).text());
        });
       

    });
});