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