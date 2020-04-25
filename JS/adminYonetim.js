$("#myTable tr").click(function () {
    if ($("#hdnGoruntulenenFirsatTuru").val() == "onaylandi") {

        $("#ikaz1").css("visibility", "visible");
        $("#guncellePanel").css("visibility", "visible");
        $(this).find("#kNo").each(function () {
            $("#span1").text( $(this).text() + "Numarali Firsat Icin =>  ");
            $("#hdnKampanyaNo").val($(this).text());
            
        });
        $(this).find("#firmaAdi").each(function () {
          
            $("#ifirmaAdi").val($(this).text());

        });
        $(this).find("#firmaSektoru").each(function () {

            $("#ifirmaSektoru").val($(this).text());

        });
        $(this).find("#adres").each(function () {

            $("#iadres").val($(this).text());

        });
        $(this).find("#mahalle").each(function () {

            $("#imahalle").val($(this).text());

        });
        $(this).find("#urun").each(function () {

            $("#iurun").val($(this).text());

        });
        $(this).find("#normalFiyat").each(function () {

            $("#inormalFiyat").val($(this).text());

        });
        $(this).find("#indirimliFiyat").each(function () {

            $("#iindirimliFiyat").val($(this).text());

        });

        $(this).find("#firmaSektoru").each(function () {

            $("#firmaSektoru").val($(this).text());

        });
        $(this).find("#kisiSayisi").each(function () {

            $("#ikisiSayisi").val($(this).text());

        });
        $(this).find("#neZaman").each(function () {

            $("#ineZaman").val($(this).text());

        });


    }
    else if ($("#hdnGoruntulenenFirsatTuru").val() == "Onay Bekliyor") {
        $("#ikaz2").css("visibility", "visible");
        $("#guncellePanel").css("visibility", "visible");
        $(this).find("#kNo").each(function () {
            $("#span1").text($(this).text() + "Numarali Firsat Icin =>  ");
            $("#hdnKampanyaNo").val($(this).text());

        });
        $(this).find("#firmaAdi").each(function () {

            $("#ifirmaAdi").val($(this).text());

        });
        $(this).find("#firmaSektoru").each(function () {

            $("#ifirmaSektoru").val($(this).text());

        });
        $(this).find("#adres").each(function () {

            $("#iadres").val($(this).text());

        });
        $(this).find("#mahalle").each(function () {

            $("#imahalle").val($(this).text());

        });
        $(this).find("#urun").each(function () {

            $("#iurun").val($(this).text());

        });
        $(this).find("#normalFiyat").each(function () {

            $("#inormalFiyat").val($(this).text());

        });
        $(this).find("#indirimliFiyat").each(function () {

            $("#iindirimliFiyat").val($(this).text());

        });

        $(this).find("#firmaSektoru").each(function () {

            $("#firmaSektoru").val($(this).text());

        });
        $(this).find("#kisiSayisi").each(function () {

            $("#ikisiSayisi").val($(this).text());

        });
        $(this).find("#neZaman").each(function () {

            $("#ineZaman").val($(this).text());

        });
    }



});