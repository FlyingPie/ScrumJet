$(function () {

    $('input[type=checkbox]').click(function (c) {
        var card = $(c.target).closest('.card');

        if (c.target.checked) {
            card.removeClass('exclude');
        } else {
            card.addClass('exclude');
        }
    })

    $('#btn-include-all').click(function () {
        $('input[type=checkbox]').prop('checked', true);
        $('.card').removeClass('exclude');
    })

    $('#btn-exclude-all').click(function () {
        $('input[type=checkbox]').prop('checked', false);
        $('.card').addClass('exclude');
    })

    $('#btn-print').click(function () {
        window.print();
    })

    $('.card').click(function () {
        $('input[type=checkbox]', this).trigger('click');
    })

})