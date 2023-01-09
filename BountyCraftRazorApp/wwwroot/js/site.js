// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".secondAlchMat").hide();
var alchmat = $("select[name=secondAlchSelect]:hidden");
var alchqty = $("input[name=secondAlchQty]:hidden");
alchmat.val(null);
alchqty.val(null);

$(".hasTwoMats").click(function () {
    if ($(this).is(":checked")) {
        $(".secondAlchMat").show(300);
    } else {
        $(".secondAlchMat").hide(200);
        alchmat.val(null);
        alchqty.val(null);
    }
});