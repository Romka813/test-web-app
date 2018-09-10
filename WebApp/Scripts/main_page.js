$(document).ready(function() {
    $("#btnCalculate").click(function () {
        if (!validate()) {
            showAlert("Values must be numberic");
            return;
        };
        var data = [];
        $(".argument").each(function () {
            data.push($(this).val());
        });
        hideAlert();
        $.post({
            type: "POST",
            url: "api/calculate",
            data: { '': data },
            success: function (data) {
                if (data.status == "success") {
                    showResult(data.result);
                } else {
                    hideResults();
                    showAlert(data.result);
                }
            },
            error: function (xhr, textStatus, errorThrown) {
                hideResults();
                showAlert(xhr.responseText);
            }
        });
    });
});

function validate() {
    var isValid = true;
    $(".argument").each(function () {
        var jqThis = $(this);
        if (!isNumeric(jqThis.val())) {
            isValid = false;
            jqThis.addClass("input-validation-error");
        } else {
            jqThis.removeClass("input-validation-error");
        }
    });
    return isValid;
}

function isNumeric(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function showResult(result) {
    $("#result").text("Result: " + result);
}

function hideResults() {
    $("#result").text("");
}

function showAlert(message) {
    $("#alert").html(
        "<div class=\"alert alert-danger alert-dismissable\">" +
            "<button type=\"button\" class=\"close\" " +
                    "data-dismiss=\"alert\" aria-hidden=\"true\">" +
                "&times;" +
            "</button>" +
            message +
        "</div>");
}

function hideAlert() {
    $("#alert").empty();
}
