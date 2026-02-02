//storage 
//addition questions
string additionQuestions = new[]
{
    "35 + 67 = ?",
    "89 + 51 = ?",
    "48 + 90 = ?",
    "23 + 98 = ?",
    "12 + 77 = ?"
};
//subtraction questions
string subtractionQuestions = new[]
{
    "100 - 13 = ?",
    "56 - 8 = ?",
    "383 - 17 = ?",
    "34 - 9 = ?",
    "49 - 28 = ?"
};
//division questions
string divisionQuestions = new[]
{
    "35 / 7 = ?",
    "89 / 9 = ?",
    "49 / 7 = ?",
    "100 / 25 = ?",
    "77 / 11 = ?"
};
//multiplication questions
string multiplicationQuestions = new[]
{
    "35 * 80 = ?",
    "12 * 45 = ?",
    "7 * 3 = ?",
    "5 * 9 = ?",
    "78 * 2 = ?"
};
//surpise questions - this will be 5 randomly selected questions from any of the above.






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
