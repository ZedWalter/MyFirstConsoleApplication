
// #2
var name = "Zed Walter";
var location = "Rexburg, ID";

// #3
Console.WriteLine($"My name is: {name}");
Console.WriteLine($"I'm from {location}");

// #4
var currentDate = DateTime.Now;
Console.WriteLine($"The date is: {currentDate.ToShortDateString()}");

// #5
var christmas = new DateTime(currentDate.Year, 12, 25);
var difference = christmas - currentDate;
Console.WriteLine($"Christmas is in {(int)difference.TotalDays} days");

// #6
double width, height, woodLength, glassArea;
string widthString, heightString;

// #7
Console.WriteLine("Please enter the width: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);

Console.WriteLine("Please enter the height: ");
heightString = Console.ReadLine();
height = double.Parse(heightString);

woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);
Console.WriteLine("The length of the wood is " + woodLength + " feet");
Console.WriteLine("The area of the glass is " + glassArea + " square metres" ) ;

Console.WriteLine("Press any key to exit");
Console.ReadKey();
