$(function () {

    var ajaxSubmitForm = function () {
        $form = $(this);

        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-osb-target"));
            var $html = $(data);
            $target.replaceWith($html);
            $html.effect("highlight")
        });

        return false;
    };

    var submitAutocompleteForm = function (event, ui) {
        var $input = $(this);

        $input.val(ui.item.label);

        var $form = $input.parents("form:first");
        $form.submit();
    };

    var createAutocomplete = function () {
        var $input = $(this);

        var options = {
            source: $input.attr("data-osb-autocomplete"),
            select: submitAutocompleteForm
        };

        $input.autocomplete(options);
    };

    $("form[data-osb-ajax='true']").submit(ajaxSubmitForm);
    $("input[data-osb-autocomplete]").each(createAutocomplete);

    $("#schoolList").css("display", "none");
    function closeDialog() {
        $(".row:first").fadeOut();

        return false;
    }
});