$(document).ready(function () {
    $('#col-companie-client').on('click', function () {
        if (document.getElementById("col-companie-client").classList.contains("sorted")) {
            document.getElementById("col-companie-client").classList.remove("sorted");  
            document.getElementById("col-companie-client").classList.add("sortedInverse");
            document.getElementById("col-companie-client").querySelector("span").innerHTML = `&#xe5db;`;
            OnClickStatClient("CompanyNameInverse");
        }
        else if (document.getElementById("col-companie-client").classList.contains("sortedInverse")) {
            document.getElementById("col-companie-client").classList.remove("sortedInverse");
            document.getElementById("col-companie-client").querySelector("span").innerHTML = `&#xe8d5;`;
            OnClickStatClient();
        }
        else {
            document.getElementById("col-companie-client").classList.add("sorted");
            document.getElementById("col-companie-client").querySelector("span").innerHTML = `&#xe5d8;`;
            OnClickStatClient("CompanyName");
        }
           
    });
    $('#col-livraison-tot-client').on('click', function () {
        OnClickStatClient("DeliveryCountTotal");
    });
});

function OnClickStatClient(col) {
    $.ajax({
        type: 'POST',
        url: '/Stats/GetClientStatsAjax',
        data: { "sortParam": col },
        success: function (data) {
            recreateStatCLient(data);
        },
        error: function () {
            alert('Une erreur est survenue');
        }
    });
}


/**
 * re fill the table with the new data
 * @param {any} data
 */
function recreateStatCLient(data) {
    document.getElementById("tboby-stat-client").innerHTML = "";

    for (var i = 0; i < data.length; i++) {
        var tr = document.createElement("tr");
        var td = document.createElement("td");
        td.innerHTML = data[i].companyName;
        tr.appendChild(td);
        td = document.createElement("td");
        td.innerHTML = data[i].deliveryCountTotal;
        tr.appendChild(td);
        td = document.createElement("td");
        td.innerHTML = data[i].deliveryWaitingCount;
        tr.appendChild(td);
        td = document.createElement("td");
        td.innerHTML = data[i].deliveryInProgressCount;
        tr.appendChild(td);
        td = document.createElement("td");
        td.innerHTML = data[i].deliveryTerminedCount;
        tr.appendChild(td);
        document.getElementById("tboby-stat-client").appendChild(tr);
    }

}