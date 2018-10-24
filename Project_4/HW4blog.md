# Homework #4

## Building the web application

<p>
In this lab were designing the code to build two types of programs. First is the building a converter for miles, where we will convert miles into metric units such as: millimeters, centimeters, meters, kilometers. Then the second task is build a color maker which will create two colors and add the two colors together. However, the main thing to look at for these two fucntions is how we design the view for them as well the controllers for each of them. This is all done in visual studio.   
</p>

Here are the links to the this assignment:<br>
[Repository](https://github.com/Dakota808/Dakota808.github.io/tree/master/Project_4/HW4/HW4)<br>
[Main Page](https://dakota808.github.io/)<br>

### Metric unit Convertor

<p>First task is designing a metric unit converter for a string of integer. Which I did a switch case where each metric unit is running the code in that format. However, The main issuse came from the html page itself where I would get home twice which would crash the html page. So the way I fixed this was added the (/Home/Converter) Which will run the program correctly and this would not cause the double home. </p> 

```html

@{
    ViewBag.Title = "Home Page";
}

<div class="jumbotron">
    <h1>CS 460 Homework #4</h1>
    <p class="lead">Practice and better undertsanding  of basic MVC. For more information click the link to learn more about the project </p>
    <p><a href="http://www.wou.edu/~morses/classes/cs46x/assignments/HW4_1819.html" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-6">
        <h2>Metric Converter</h2>
        <p>
            Design of a converter which will convert the miles to metric measurements such as meters, millimeter, kilometers, etc..
        </p>
        <div class="col-md-6">
            
            <p><a class="btn btn-default" href="/Home/Converter">Try it out &raquo;</a></p>
        </div>
    </div>
    <div class="col-md-6">
        <h2>Color Maker</h2>
        <p>This is color maker</p>
        <p><a class="btn btn-default" href="/Color/Color_Maker">Try it out &raquo;</a></p>
    </div>

</div>
```
![Homepage](Homepage.jpg)<br>

<p>Then in convertor.cshtml file I desgined a text input for the distance you input, as well as the metric units that you will use to convert the distance such as millimeters, centimeters, etc.. The only thing to note is when I have user input the distances it will use a requried which makes the user have to put a value in the text field. Otherwise it will not continue. After that the code handles the input we use radio buttons which will connect to the controller that will execute the calculation/conversion of the input. It is a simple radio with a submit buttuon for this case. We also use the form to keep everything together in a groups.</p>

![convertor](ConverterHtml.jpg)<br>
![page](ConverterPage.jpg)<br>

<p>After the we setup the html page for this we are now working in the Controllers which will do all of the calculation. so we use the [Httpget] which will allow the code to recevie the inputs from the html page which I built a simple switch case similar to a if else statement that returns the values of doubles which can handle large decimals and whole numbers. I also add a viewbag which will be false until we return the results for the calculation. We also design a simlpe debuger to print the lines into the file to make sure the file is receiving and returning the right inputs.</p>

```CS
 [HttpGet]
        public ActionResult Converter()
        {
            ViewBag.result = false;
            double miles = Convert.ToDouble(Request.QueryString["mile"]);
            string mearsurement = Request.QueryString["metric-unit"];
            Debug.WriteLine(miles);
            Debug.WriteLine(mearsurement);

            double result;
            switch (mearsurement)
            {
                case "millimeters":
                    result = miles * 1609344;
                    ViewBag.result = true;
                    break;
                case "centimeters":
                    result = miles * 160934.4;
                    ViewBag.result = true;
                    break;
                case "meters":
                    result = miles * 1609.344;
                    ViewBag.result = true;
                    break;
                case "kilometers":
                    result = miles * 1.609344;
                    ViewBag.result = true;
                    break;
                default:
                    result = -1;
                    break;
            }

            string message = "Conversion: " + Convert.ToString(result) + " "+ mearsurement;
            ViewBag.Message = message;


            return View();
        }
```

### Color Maker
<p>The color maker is similar to the converter and that we will use a excpetion handling method that will be discussed later.  </p>