var mahalle;
$('#select1').change(function () {
    var selected = $(':selected', this);
    debugger;
    document.getElementById("hdnResultValue").value  = selected.closest('option').attr('value');
});
$('#select2').change(function () {
    var selected = $(':selected', this);
    debugger;
    document.getElementById("hdnResultValue2").value = selected.closest('option').attr('value');
});

$('#sektorTuru').change(function () {
    var selected = $(':selected', this);
    debugger;
    document.getElementById("hdnResultValue3").value = selected.closest('option').attr('value');
});