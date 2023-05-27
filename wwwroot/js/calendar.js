document.addEventListener('DOMContentLoaded', function () {
    var currentDate = new Date();

    var prevWeekBtn = document.getElementById('prevWeekBtn');
    var nextWeekBtn = document.getElementById('nextWeekBtn');
    var deliveries;
    var currentURL = window.location.href;
    var currentDirectory = currentURL.substring(0, currentURL.lastIndexOf('/'));
    $.ajax({
        url: currentDirectory + '/Deliveries/GetDeliveries',
        type: 'GET',
        dataType: 'json',
        success: function (response) {
            deliveries = response;
            console.log(response);

            updateCalendar(currentDate, deliveries);
        },
        error: function (error) {
            console.error("e : " + error);
        }
    });


    prevWeekBtn.addEventListener('click', function () {
        currentDate.setDate(currentDate.getDate() - 7);
        updateCalendar(currentDate, deliveries);
    });

    nextWeekBtn.addEventListener('click', function () {
        currentDate.setDate(currentDate.getDate() + 7);
        updateCalendar(currentDate, deliveries);
    });

    function updateCalendar(date, deliveries) {
        var startDate = new Date(date);
        startDate.setDate(startDate.getDate() - startDate.getDay() + 1);

        var calendarHeader = document.querySelector('.calendar-header h3');
        calendarHeader.textContent = startDate.toLocaleDateString('fr-FR', { year: 'numeric', month: 'long', day: 'numeric' });

        var dayCells = document.querySelectorAll('.day');
        for (var i = 0; i < dayCells.length; i++) {
            var cDate = new Date(startDate);
            cDate.setDate(cDate.getDate() + i);

            var dayCell = dayCells[i];
            var dayNumber = dayCell.querySelector('.day-number');
            var deliveryList = dayCell.querySelector('ul');

            dayNumber.textContent = cDate.toLocaleDateString('fr-FR', { month: 'long', day: 'numeric' });
            deliveryList.innerHTML = '';

            deliveries.forEach(function (delivery) {

                if (new Date(Date.parse(delivery.LoadDate)).toDateString() === cDate.toDateString()) {
                    var client = document.createElement('li');
                    client.textContent = "Client: " + delivery.Client.CompanyName;

                    var content = document.createElement('li');
                    content.textContent = "Contenu: " + delivery.Content;

                    var loadDate = document.createElement('li');
                    loadDate.textContent = "Date de chargement: \n" + new Date(delivery.LoadDate).toLocaleDateString('fr-FR', { year: 'numeric', month: 'long', day: 'numeric' });;

                    var unloadDate = document.createElement('li');
                    unloadDate.textContent = "Date de dechargement: \n" + new Date(delivery.UnloadingDate).toLocaleDateString('fr-FR', { year: 'numeric', month: 'long', day: 'numeric' });;

                    var detailsLink = document.createElement("a");
                    detailsLink.setAttribute("href", "/Deliveries/Details/" + delivery.Id);
                    detailsLink.textContent = "Details";

                    var terminateLink = document.createElement("a");
                    terminateLink.setAttribute("href", "/Deliveries/Finish/" + delivery.Id);
                    terminateLink.textContent = "Terminer";


                    deliveryList.appendChild(client);
                    deliveryList.appendChild(content);
                    deliveryList.appendChild(loadDate);
                    deliveryList.appendChild(unloadDate);
                    deliveryList.appendChild(detailsLink);
                    deliveryList.appendChild(terminateLink);
                    deliveryList.appendChild(document.createElement('hr'));
                }
            });
        }
    }

});