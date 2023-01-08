// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".secondAlchMat").hide();
$(".hasTwoMats").click(function () {
    if ($(this).is(":checked")) {
        $(".secondAlchMat").show(300);
    } else {
        $(".secondAlchMat").hide(200);
    }
});