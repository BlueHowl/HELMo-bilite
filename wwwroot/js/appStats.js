
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
            // Récupération du texte dans la deuxième colonne (matricule)
            var matA = $(a).find("td:eq(1)").text();
            var matB = $(b).find("td:eq(1)").text();

            // Comparaison des matricules
            if (matA < matB) return -1;
            if (matA > matB) return 1;
            return 0;
           
        });


        $("#tboby-stat-driver").append(children);

    });

    $("#col-name-stat-driver").on("click", function (event) {
        var children = $("#tboby-stat-driver").children();
        $("#tboby-stat-driver").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(2)").text();
            var elm2 = $(b).find("td:eq(2)").text();
            if (elm1 < elm2) return -1;
            if (elm2 > elm1) return 1;
            return 0;

        });


        $("#tboby-stat-driver").append(children);

    });

   


    $("#col-de-stat-driver").on("click", function (event) {
        var children = $("#tboby-stat-driver").children();
        $("#tboby-stat-driver").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(3)").text();
            var elm2 = $(b).find("td:eq(3)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });


        $("#tboby-stat-driver").append(children);

    });

    $("#col-de-start-stat-driver").on("click", function (event) {
        var children = $("#tboby-stat-driver").children();
        $("#tboby-stat-driver").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(4)").text();
            var elm2 = $(b).find("td:eq(4)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-driver").append(children);

    });

    $("#col-de-end-stat-driver").on("click", function (event) {
        var children = $("#tboby-stat-driver").children();
        $("#tboby-stat-driver").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(5)").text();
            var elm2 = $(b).find("td:eq(5)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-driver").append(children);

    });

    /**
     * Search driver
     */
    $("#driver-seacrh").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#tboby-stat-driver tr").each(function () {
            var mat = $(this).find("td:eq(1)").text();
            if (mat.toLowerCase().indexOf(value) > -1) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });


    $("#col-companie-client").on("click", function (event) {
        var children = $("#tboby-stat-client").children();
        $("#tboby-stat-client").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(0)").text();
            var elm2 = $(b).find("td:eq(0)").text();
            if (elm1 < elm2) return -1;
            if (elm2 > elm1) return 1;
            return 0;

        });

        $("#tboby-stat-client").append(children);

    });

    $("#col-livraison-tot-client").on("click", function (event) {
        var children = $("#tboby-stat-client").children();
        $("#tboby-stat-client").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(1)").text();
            var elm2 = $(b).find("td:eq(1)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-client").append(children);

    });

    $("#col-livraison-wait-client").on("click", function (event) {
        var children = $("#tboby-stat-client").children();
        $("#tboby-stat-client").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(2)").text();
            var elm2 = $(b).find("td:eq(2)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-client").append(children);

    });
    $("#col-livraison-pross-client").on("click", function (event) {
        var children = $("#tboby-stat-client").children();
        $("#tboby-stat-client").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(3)").text();
            var elm2 = $(b).find("td:eq(3)").text();

            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-client").append(children);

    });
    $("#col-livraison-end-client").on("click", function (event) {
        var children = $("#tboby-stat-client").children();
        $("#tboby-stat-client").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(4)").text();
            var elm2 = $(b).find("td:eq(4)").text();

            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-client").append(children);

    });


    /**
     * Search client
     */
    $("#cLient-seacrh").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#tboby-stat-client tr").each(function () {
            var mat = $(this).find("td:eq(0)").text();
            if (mat.toLowerCase().indexOf(value) > -1) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });



    $("#col-date").on("click", function (event) {
        var children = $("#tboby-stat-date").children();
        $("#tboby-stat-date").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(0)").text();
            var elm2 = $(b).find("td:eq(0)").text();
            if (elm1 < elm2) return -1;
            if (elm2 > elm1) return 1;
            return 0;

        });

        $("#tboby-stat-date").append(children);

    });

    $("#col-tot-date").on("click", function (event) {
        var children = $("#tboby-stat-date").children();
        $("#tboby-stat-date").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(1)").text();
            var elm2 = $(b).find("td:eq(1)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-date").append(children);

    });

    $("#col-start-date").on("click", function (event) {
        var children = $("#tboby-stat-date").children();
        $("#tboby-stat-date").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(2)").text();
            var elm2 = $(b).find("td:eq(2)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-date").append(children);

    });

    $("#col-livraison-pross-date").on("click", function (event) {
        var children = $("#tboby-stat-date").children();
        $("#tboby-stat-date").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(3)").text();
            var elm2 = $(b).find("td:eq(3)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-date").append(children);

    });

    $("#col-livraison-end-date").on("click", function (event) {
        var children = $("#tboby-stat-date").children();
        $("#tboby-stat-date").children().remove();
        children = children.sort(function (a, b) {
            var elm1 = $(a).find("td:eq(4)").text();
            var elm2 = $(b).find("td:eq(4)").text();
            if (parseInt(elm1) < parseInt(elm2)) return -1;
            if (parseInt(elm2) > parseInt(elm1)) return 1;
            return 0;

        });

        $("#tboby-stat-date").append(children);

    });



});



function onAddDriver(matricule) {
    getDeliveryDriver(2023, matricule)
        .then(function (data) {
            var chart = createChart(data);
        }).catch(function (error) { });

}


function getDeliveryDriver(year, matricules) {

    var currentURL = window.location.href;
    var currentDirectory = currentURL.substring(0, currentURL.lastIndexOf('/'));
    return new Promise(function (resolve, reject) {
        $.ajax({
            type: 'POST',
            url: currentDirectory+'/Stats/GetStatPerMonthDriver',
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