﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//Making the selected drop-down item visible
$(".dropdown-menu a").click(function () {
    $(this).parents(".dropdown").find('.btn').html($(this).text() + ' <span class="caret"></span>');
    $(this).parents(".dropdown").find('.btn').val($(this).data('value'));

    var linkClicked = this;
    var chartType = linkClicked.innerText.toLowerCase();
    // Trying to get rid of the old chart before creating a new one 
    //(I think.destroy is what we want https://www.chartjs.org/docs/latest/developers/api.html#destroy)
    chart.destroy(); 
    drawChart(chartType);
});

