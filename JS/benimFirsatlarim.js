$(document).ready(function () {
    $("#Table2 tr").click(function () {
        $("#onayIkaz2").css("visibility", "visible");
        $(this).find("#kNo").each(function () {
            $("#ikaz1").text($(this).text());
            $("#hdnBekleyenKampanyaNo").val($(this).text());
        });
       

    });
});

$(document).ready(function () {
    $("#myTable tr").click(function () {
        $("#onayIkaz1").css("visibility", "visible");
        $(this).find("#kNo").each(function () {
            $("#ikaz2").text($(this).text());
            $("#hdnGidelecekFirsatId").val($(this).text());
        });


    });
});