Console.WriteLine("Please enter your name");
string lionName = Console.ReadLine();

Console.WriteLine("Hello " + lionName + ", Welcome to Loropio Fitness App. ");

int feeling;

Console.WriteLine("How did you feel after the activity? Enter a number (1=BAD, 2=OK, 3=GOOD, 4=VERY GOOD, 5=STRONG): ");
string feelingInput = Console.ReadLine();

if (int.TryParse(feelingInput, out feeling))
{
    string feelingMessage;

    switch (feeling)
    {
        case 1:
            feelingMessage = "Bad";
            break;
        case 2:
            feelingMessage = "OK";
            break;
        case 3:
            feelingMessage = "Good";
            break;
        case 4:
            feelingMessage = "Very Good";
            break;
        case 5:
            feelingMessage = "Strong";
            break;
        default:
            Console.WriteLine("Invalid feeling input.");
            return;
    }

    Console.WriteLine("How You Felt After the Activity: " + feelingMessage);
}
else
{
    Console.WriteLine("Invalid feeling input. Please enter a valid number.");
}