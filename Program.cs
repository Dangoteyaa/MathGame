//storage 
//addition questions
//subtraction questions
//division questions
//multiplication questions
//surpise questions





Console.WriteLine("Welcome to the MathGame!/nPlease enter your name:");
string? name = Console.ReadLine();
Console.WriteLine($"Hi {name}! Nice to meet you");
Console.WriteLine("Below is a list of Math Games. Please enter which one you would like to play:");

//menu of games
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Division");
Console.WriteLine("4 - Multiplication");
Console.WriteLine("5 - Suprise me!");

var userInput = Console.ReadLine();

//branching based off input
switch (userInput){
    case null:
        Console.WriteLine("Please enter an option:");
        break;
    case "1":
        Console.WriteLine("Please enter an option:");
        break;
    case "2":
        Console.WriteLine("Please enter an option:");
        break;
    case "3":
        Console.WriteLine("Please enter an option:");
        break;
    case "4":
        Console.WriteLine("Please enter an option:");
        break;
    case "5":
        Console.WriteLine("Please enter an option:");
        break;

}
