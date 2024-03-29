﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
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

function ColorChanged(d, id) {
    var main = document.getElementById(id);
    var title = main.children[0].children[1];
    var color = main.children[0].children[2];
    if (d.id == "Aqua") {
        title.style.background = main.style.background = "#00FFFF";
        color.value = "#00FFFF";
        //i.classList.add("fa-solid");
        //i.classList.add("fa-check");
    }
    else if (d.id == "MediumSeaGreen") {
        title.style.background = main.style.background = "#3CB371";
        color.value = "#3CB371";
    }
    else if (d.id == "LightCoral") {
        title.style.background = main.style.background = "#F08080";
        color.value = "#F08080";
    }
    else if (d.id == "Lavender") {
        title.style.background = main.style.background = "#E6E6FA";
        color.value = "#E6E6FA";
    }
    else if (d.id == "Gold") {
        title.style.background = main.style.background = "#FFD700";
        color.value = "#FFD700";
    }
    d.closest(".card").children[0].style.height = "0";
}

function OnCheck(rad) {
    var title = document.getElementById("modeltitle");
    var color = document.getElementById("modelcontent").children[1];
    title.style.background = rad.value;
    color.value = rad.value;
}