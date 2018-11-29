/*Javascript*/

console.log("This is all in javascript");

// This sets the item ID for each of the different Items
function data()
{
    var input = document.getElementById("list").value;
    var id = parseInt(input);
    var source = "/Item/DisplayBids" + id;

    $.ajax({
        type: "GET",
        datatype: "json",
        url: source,
        success: DisplayBids,
        error: AjaxError
    });
}

function DisplayBids(BidTable)
{
    if (BidTable.length === 0)
    {
        $("#message").empty();
        $("#message").append("There are no bids currently made to this item");

    }
    else
    {
        $("#message").empty();
        $(".bids").remove();

        for (var i = 0; i < BidTable.length; i++)
        {
            $("#table").append("<tr class\"bids\"><td>" + BidTable[i].Buyer + "</td><td>$" + Number(BidTable[i].Price).toLocaleString('en-US', { minimumFractionDigits: 2 }) + "</td></tr>");
        }
    }

}

function AjaxError()
{
    console.log("An error has occured");
}

function main()
{
    data();
    var interval = 1000 * 5;
    window.setInterval(data, interval);
}

$(document).ready(main());
/*var id = window.location.href.split("/").slice(-1)[0];*/

/*$(document).ready(function ()
{
    var source = "/Items/DisplayBids/" + id;

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

    /*function DataDisplay(data)
    {
        console.log("Data display");
        console.log("data: " + data);

        var update = "<table class = \"table\"><tbody>";

        $.each(data, function (num, item)
        {
            console.log("i: " + num);
            console.log("item: " + item);
            update += "<tr>" + "<td>" + item.Buyer +
                "</td>" + "<td> $" + item.Prices + "</td>" + "</tr>";
        });

        $("#tableResp").html(update);
    }

});*/

