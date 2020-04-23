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

$('#sektorTuru').change(function () {
    var selected = $(':selected', this);
    debugger;
    document.getElementById("hdnFirsatTuru").value = selected.closest('option').attr('value');
});
$('#mahalleTuru').change(function () {
    var selected = $(':selected', this);
    debugger;
    document.getElementById("hdnMahalle").value = selected.closest('option').attr('value');
});

$('#select2').change(function () {
    var selected = $(':selected', this);
    debugger;
    document.getElementById("hdnSehir").value = selected.closest('option').attr('value');
});