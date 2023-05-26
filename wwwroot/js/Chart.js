export { AddDriver };

function AddDriver(matricule, chart) {
    $.ajax({
        type: 'POST',
        url: '/Stats/GetDriverStatsAjax',
        data: { matricule: matricule },
        success: function (data) {
            console.log(data);
            AddToChart(chart, data);
            chart.data.datasets.push({
                label: "teste",
                fill: true,
                backgroundColor: "transparent",
                borderColor: window.theme.primary,
                data: [1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000]
            });
        },
        error: function () {
            alert('Une erreur est survenue lors de la récupération des statistiques du chauffeur');
        }
    });
}

function RemoveDriver(id, chart) {

}

function AddToChart(chart, data) {
    //console.log(data);
    var label = data.driverMatricul;
    
    var data = data.deliveryPerDayCount.value;


}


