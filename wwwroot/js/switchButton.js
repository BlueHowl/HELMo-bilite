$(document).ready(function () {

    var commentField = document.getElementById('commentField');
    var reasonSelector = document.getElementById('reasonSelector');

    $('#switchButton').click(function () {
        if ($(this).hasClass('btn-success')) {
            $(this).removeClass('btn-success')
                .addClass('btn-danger')
                .text("Livraison Ratee");

            reasonSelector.classList.remove("d-none");
            commentField.text = "";
            commentField.disabled = true;
        } else {
            $(this).removeClass('btn-danger')
                .addClass('btn-success')
                .text("Livraison Effectuee");

            reasonSelector.classList.add("d-none");
            commentField.disabled = false;
            commentField.text = "";
        }
    });

});