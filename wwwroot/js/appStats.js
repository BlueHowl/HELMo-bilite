import { AddDriver } from './Chart.js';


document.addEventListener("DOMContentLoaded", function () {
    // Line chart

    var chart = new Chart(document.getElementById("chartjs-line"), {
        type: "line",
        data: {
            labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
            datasets: [{
                label: "Moyen",
                fill: true,
                backgroundColor: "transparent",
                borderColor: window.theme.primary,
                data: [2115, 1562, 1584, 1892, 1487, 2223, 2966, 2448, 2905, 3838, 2917, 3327]
            }]
        },
        options: {
            maintainAspectRatio: false,
            legend: {
                display: false
            },
            tooltips: {
                intersect: false
            },
            hover: {
                intersect: true
            },
            plugins: {
                filler: {
                    propagate: false
                }
            },
            scales: {
                xAxes: [{
                    reverse: true,
                    gridLines: {
                        color: "rgba(0,0,0,0.05)"
                    }
                }],
                yAxes: [{
                    ticks: {
                        stepSize: 500
                    },
                    display: true,
                    borderDash: [5, 5],
                    gridLines: {
                        color: "rgba(0,0,0,0)",
                        fontColor: "#fff"
                    }
                }]
            }
        }
    });

    AddDriver("DR885379", chart);



    console.log(chart.data);
    //chart.update();

});

function getCLient() {
    $.ajax({
        type: 'POST',
        url: '/Stats/GetClientStatsAjax',
        success: function (data) {
            recreateStatCLient(data);
        },
        error: function () {
            alert('Une erreur est survenue');
        }
    });
}
