/*Javascript*/

console.log("This is all in javascript");

// This sets the item ID for each of the different Items

var id = window.location.href.split("/").slice(-1)[0];

$(document).ready(function ()
{
    var source = "/Home/Index/" + id;

    var ajax_call = function () {
        $.ajax({
            type: "GET",
            datatype: "json",
            url: source,
            success: DataDisplay,
            error: AjaxError
        });
    };

    // Loads Ajax every 5 seconds
    var interval = 5000;
    window.setInterval(ajax_call, interval);

    /* shows the Data from the table of items */

    function DataDisplay(data)
    {
        consle.log("Data display");
        console.log("data: " + data);

        var update = "<table class = \"table\"><tbody>";
        $.each(data, function (num, item)
        {
            console.log("i: " + num);
            console.log("item: " + item);
            update += "<tr>" + "<td>" + item.Name +
                "</td>" + "<td> $" + item.Price + "</td>" + "</tr>";
        });

        $("#tableResp").htnl(update);
    }

});

function AjaxError()
{
    console.log("An error has occured");
}