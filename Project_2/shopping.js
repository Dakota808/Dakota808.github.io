var item1 = $("#item1").val();
var item2 = $("#item2").val();
var item3 = $("#item3").val();


var itemOne = 3.50
var itemTwo = 7.99
var itemThree = 8.99

function calculation(){
   var subtotal = item1 * itemOne;
   var subtotal = item2 * itemTwo;
   var subtotal = item3 * itemThree;
   console.log("sub total = " + subtotal);
}
calculation();
