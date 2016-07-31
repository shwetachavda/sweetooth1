/// <reference path="main.js" />
/**----------------------------------------------------------cakes img----------------------------------------------------*/
$(document).ready(function () {
    $('img').on('click', function () {
        $("#showImg").empty();
        var image = $(this).attr("src");
        $("#showImg").append("<img class='img-responsive' src='" + image + "' />")
    })
});

/*---------------------------------------------------------index pages img-----------------------------------------------------*/
function centerModal() {
    $(this).css('display', 'block');
    var $dialog = $(this).find(".modal-dialog");
    var offset = ($(window).height() - $dialog.height()) / 2;
    // Center modal vertically in window
    $dialog.css("margin-top", offset);
}

$('.modal').on('show.bs.modal', centerModal);
$(window).on("resize", function () {
    $('.modal:visible').each(centerModal);
});

