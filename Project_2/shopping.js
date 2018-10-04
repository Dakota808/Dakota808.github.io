

function calculation(){
    var item1 = $("#item1").val();
    var itemOne = 3.50;
    var subtotal = item1 * itemOne;

   console.log("sub total = " + subtotal);
   $('#tableIn').append( "<tr><td>Item #1</td><td>$3.50</td><td>"+item1+"</td><td>$"+subtotal+"</td></tr>");
   console.log(subtotal);
}

function calculation2(){
    var item2 = $("#item2").val();
    var itemTwo = 7.99;
    var subtotal = item2 * itemTwo;
    console.log("sub total = " + subtotal);
    $('#tableIn').append( "<tr><td>Item #2</td><td>$7.99</td><td>"+item2+"</td><td>$"+subtotal+"</td></tr>");
    console.log(subtotal);

}

function calculation3(){
    var item3 = $("#item3").val();

    var itemThree = 8.99;

    var subtotal = item3 * itemThree;
    console.log("sub total = " + subtotal)
    $('#tableIn').append( "<tr><td>Item #3</td><td>$8.99</td><td>"+item3+"</td><td>$"+subtotal+"</td></tr>");
    console.log(subtotal);
}
