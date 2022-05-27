// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//$(document).ready(function () {
//    $('[data-toggle="popover"]').popover();
//});


$(document).ready(function () {
    $('[data-bs-toggle="popover"]').popover({
        placement: 'right'
    });
});

$(function () {
    $('[data-toggle="tooltip"]').tooltip()
});

function newNote() {
    var tt = document.getElementById("total");
    var rowCount = parseInt(tt.value);
    rowCount++;
    tt.value = rowCount;
    var html = '';
    html += '<div id="inputRow">';
    html += '<input type="text" name="[' + (rowCount - 1) + '].Name"  />';
    html += '</div>';

    $('#newRow').append(html);
}

function openNav(btn) {
    btn.blur();
    var elm = btn.closest(".card");
    elm.children[0].style.height = "auto"
    elm.focus();
}

function closeNav(nav) {
    nav.closest(".card").children[0].style.height = "0";
}

