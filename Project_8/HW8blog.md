# Hoemwork #8

## Auction House Application

<p>
This assignment we are building an application that is using a relation database which holds multiple tables and each are calling each other to display bids of items. Then we will want to know what items are being sold right now and who is selling. The last part, like many online auction houses or shops we want to sell something as well so create a item for acution. We also use json to monitor bids and let you know what is going on.
</p>

Links to Assignment:<br>
[Repository](https://github.com/Dakota808/Dakota808.github.io/tree/master/Project_8/HW8/HW8)
[Demo](https://youtu.be/3D1ycL9ufZE)
[Main Page](https://dakota808.github.io/)

<p>This assignment we had to add some simple but yet different tricks that we learned from both homeworks 6 and 7. When working on this the main thing to take a further look into is the use of primary and foreign keys, as well as constraints for these keys. After that using different controllers comes in handy to handle different functions of a application such as in this case we handle bids of certain items. Tables to display current bids or rather the most recent bids. These were the main key take aways to get from this assignment. </p>

### Top 10 recent bids
<br>
When building the this table we needed to know the top ten recent bids for certain items and display them on a table. I did this on the front of the main page of the application which holds the list of ten recent bids on all of the different items.
```Html
<div class="row">
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Item1.ItemName)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Buyer.BuyersName)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Prices)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.TimeStamps)
            </th>
        </tr>
    @foreach (var bid in Model)
    {
        <tr>
            <th>
                @Html.DisplayFor(biditem => bid.Item1.ItemName)
            </th>
            <th>
                @Html.DisplayFor(biditem => bid.Buyer.BuyersName)
            </th>
            <th>
                @Html.DisplayFor(biditem => bid.Prices)
            </th>
            <th>
                @Html.DisplayFor(biditem => bid.TimeStamps)
            </th>
        </tr>


    }


    </table>
</div>
```
### Note:
<br>
This code is located inside of the Home view folder under the index page.

### Top 10 actionResult
```CS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW8.DAL;


namespace HW8.Controllers
{
    public class HomeController : Controller
    {
        private BidsContext db = new BidsContext();

        public ActionResult Index()
        {

            return View(db.Bids.OrderByDescending(x => x.TimeStamps).Take(10).ToList());
        }

    }
}
```

### Placing Bids
<br>
This is desgined to save the new bids that are created and then post it into the Items Details View. This will reference the items ID and return that value inside of the table that we created previously for the recent 10 bids. 
```CS
 // POST: Bids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BidID,Item,Bider,TimeStamps,Prices")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                bid.TimeStamps = System.DateTime.Now;
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Details", "Items", new {id = bid.Item });
            }

            ViewBag.Bider = new SelectList(db.Buyers, "BuyerID", "BuyersName", bid.Bider);
            ViewBag.Item = new SelectList(db.Items, "ItemID", "ItemName", bid.Item);
            return View(bid);
        }

```
### Note:
<br>
This was done in a different controller called bidController.<br>

<p>Most of the code we did was only for certain parts the rest were scaffoled which can be adjusted to meet certain needs such as Removing the functionality of creating your own ID for items. As well setting the timestamp by default instead of typing it.</p>

## SQL Database
<br>
This Database is using the both primary and foreign keys to run relation to different tables is sql file.<br>
```SQL
Create Table [dbo].[Buyers](
 BuyerID int identity (1,1) not null,
 BuyersName varchar(50) not  null,
 
 Constraint [PK_dbo.Buyers] Primary Key Clustered (BuyerID ASC),
);

Create Table [dbo].[Sellers](
 SellerID int identity (1,1) not null,
 SellersName varchar (50) not null,

 Constraint [PK_dbo.Sellers] Primary Key Clustered (SellerID ASC)
);

Create Table [dbo].[Items](
 ItemID int identity (1001,1) not null,
 Seller int					  not null,
 ItemName varchar (255)		  not null, 
 ItemDescription varchar(255) not null,

 Constraint [PK_dbo.Items] Primary Key Clustered (ItemID ASC),
 Constraint [FK_dbo.Items] Foreign Key  (Seller) References [dbo].[Sellers] (SellerID)
);

Create Table [dbo].[Bids](
 BidID int identity (1,1) not null, 
 Item int not null,
 Bider int not null,
 TimeStamps Datetime not null,
 Prices int not null

 Constraint [PK_dbo.Bids] Primary Key Clustered (BidID ASC),
 Constraint [FK_dbo.Bids] Foreign Key  (Item) References [dbo].[Items] (ItemID),
 Constraint [FK2_dbo.Bids] Foreign Key (Bider) References [dbo].[Buyers] (BuyerID)
);

Insert into Buyers(BuyersName)
 Values
  ('Jane Stone'),
  ('Tom McMaster'),
  ('Otto VanderWall');

Insert into Sellers(SellersName)
 Values
 ('Gayle Hardy'),
 ('Lyle Banks'),
 ('Pearl Greene');

 Insert into Items(ItemName, ItemDescription, Seller)
  Values
  ('Abraham Lincoln Hammer', 'A bench mallet from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln', 3),
  ('Albert Einstiens Telescope', 'A brass telescope owned by Albert Einstein in Germany, Circa 1927', 1),
  ('Bob Dylan Love Poems', 'Five versions of an original unpublished, handwritten, love poem by Bob Dylan', 2);

Insert into Bids(Item, Bider, Prices, TimeStamps)
 Values
 (1001,3, 250000, '12/02/2018 09:04:22'),
 (1003, 1, 95000, '11/24/2018 08:44:03'),
 (1002, 2, 100000, '11/18/2018 10:24:32');

```
<br>

## Ajax
<br>
The use of ajax is simple we want to know the people who bid on a patricular item. So set the javascript to run inside of the details page from items view and display that.<br>
```Javascript
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
```
<br>
```CS
public JsonResult DisplayBids(int? id)
        {
            var bidData = db.Bids.Where(i => i.Item1.ItemID == id)
                .Select(i => new { Buyer = i.Buyer.BuyersName, Price = i.Prices })
                .OrderByDescending(b => b.Price)
                .ToList();
 

            return Json(bidData, JsonRequestBehavior.AllowGet);

        }
```
<br>
```Html
@model HW8.Models.Item

@{
    ViewBag.Title = "Details";
}

<h2>Details</h2>

@* Done with out using Ajax *@
<div>
    <h4>Item</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            <input type="hidden" id="list" value="@Model.ItemID"/>
            @Html.DisplayNameFor(model => model.ItemID)
        </dt>
        <dd>
            @Html.DisplayFor(model => model.ItemID)
        </dd>
        <dt>
            @Html.DisplayNameFor(model => model.Seller1.SellersName)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Seller1.SellersName)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.ItemName)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.ItemName)
        </dd>

        <dt>
            @Html.DisplayNameFor(model => model.ItemDescription)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.ItemDescription)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", new { id = Model.ItemID }) |
    @Html.ActionLink("Back to List", "Index") |
</p>


@*Display a detail page for items using Ajax*@

<h2 class="text-center">Item Bids</h2>
<div id="Result">
    <table class="table">
        <thead>
            <tr>
                <th>
                    Buyer Name
                </th>
                <th>
                    Price
                </th>
            </tr>
        </thead>
        <tbody id="TableContent"></tbody>
    </table>
</div>

@section DetailScript{
    <script type="text/javascript" src="~/Scripts/MyBidScript.js"></script>
    
    }

<p
```
<br>
### _layout.cshtml
```Html
@RenderSection("DetailScript", required: false)
```
