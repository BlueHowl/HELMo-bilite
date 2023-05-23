$(document).ready(function () {
    setInterval(refreshTable, 30000); // Refresh 30sec
});

function refreshTable() {

    if ($('#activeRefresh').length == 0) {
        return;
    }

    var refreshIcon = document.getElementById('activeRefresh'); //document.getElementById("#activeRefresh");

    refreshIcon.classList.add('rotate-icon');

    $.ajax({
        url: '/Deliveries/Index',
        type: 'GET',
        success: function (data) {
            $('#deliveryTable').html(data.find('#deliveryTable')); // Update avec le contenu de /Deliveries/Index
        },
        error: function (error) {
            console.log('Error:', error);
        }
    });

    setTimeout(function () {
        refreshIcon.classList.remove('rotate-icon');
    }, 2000); // Delay 
}