//storage 
//ADDITION
//questions
string[] additionQuestions = new[]
{
    "35 + 67 = ?",
    "89 + 51 = ?",
    "48 + 90 = ?",
    "23 + 98 = ?",
    "12 + 77 = ?"
};
//answers
string[] additionAnswers = new[]
{
    "102",
    "140",
    "138",
    "121",
    "89"
};

//subtraction questions
string[] subtractionQuestions = new[]
{
    "100 - 13 = ?",
    "56 - 8 = ?",
    "383 - 17 = ?",
    "34 - 9 = ?",
    "49 - 28 = ?"
};
//division questions
string[] divisionQuestions = new[]
{
    "35 / 7 = ?",
    "89 / 9 = ?",
    "49 / 7 = ?",
    "100 / 25 = ?",
    "77 / 11 = ?"
};
//multiplication questions
string[] multiplicationQuestions = new[]
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

        //addition logic
        //note: remember user tests and validation/error handling
    case "1":
        // think I may need a loop within a loop
        foreach (string question in additionQuestions)
        {
            Console.WriteLine(question.ToString());
            int counter = 0;
            string? userAnswer = Console.ReadLine();
            int number;

            if ( userAnswer == null)
            {
                Console.WriteLine("Please enter an answer:");
            } //this might needing extending ? add Console.ReadLine(); here. 

            //confirm they have entered a number
            while (int.TryParse(userAnswer, out number ))
            {
                if(userAnswer == additionAnswers[counter])
                {
                    Console.WriteLine("Correct!");
                    ++counter;


                }
            }
        }
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
