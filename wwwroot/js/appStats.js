
/**
 * load driver
 */
document.addEventListener("DOMContentLoaded", function () {



    recreateGraph();
    //doncument.getElementById("tboby-stat-driver").

    $(".chekbox-driver-stat").on("change", function (event) {
        recreateGraph();
    });
    $("#col-mat-stat-driver").on("click", function (event) {
        var children = $("#tboby-stat-driver").children();
        $("#tboby-stat-driver").children().remove();
        children = children.sort(function (a, b) {
            console.log(a);

           
        });


        $("#tboby-stat-driver").append(children);
        console.log();

    });


});
function onAddDriver(matricule) {
    getDeliveryDriver(2023, matricule)
        .then(function (data) {
            var chart = createChart(data);
        }).catch(function (error) { });

}


function getDeliveryDriver(year, matricules) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            type: 'POST',
            url: '/Stats/GetStatPerMonthDriver',
            data: { year: year, matricules: matricules },
            success: function (data) {
                resolve(data);
            },
            error: function () {
                reject('Une erreur est survenue lors de la récupération des statistiques du chauffeur');
            }
        });
    });
}



function recreateGraph() {
    let list = []
    $(".chekbox-driver-stat").each(function () {
        var isChecked = $(this).is(":checked");
        if (isChecked) {
            list.push($(this).data('mat'));
        }
    });
    getDeliveryDriver(2023, list)
        .then(function (data) {

            var chart = createChart(data);
        }).catch(function (error) { });



}




function createChart(data) {
    var dataSetChart = data.map(d => {
        return {
            label: d.matricule,
            fill: true,
            backgroundColor: "transparent",
            borderColor: "#" + Math.floor(Math.random() * 16777215).toString(16),
            data: d.statsPerMonth.map(d => d.count)

        };
    });
    return new Chart(document.getElementById("chartjs-line"), {
        type: "line",
        data: {
            labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
            datasets: dataSetChart
        },
        options: {
            scales: {
                xAxes: [{
                    reverse: true,
                    gridLines: {
                        color: "rgba(0,0,0,0.05)"
                    }
                }],
                yAxes: [{
                    borderDash: [5, 5],
                    gridLines: {
                        color: "rgba(0,0,0,0)",
                        fontColor: "#fff"
                    }
                }]
            }
        }
    });
}