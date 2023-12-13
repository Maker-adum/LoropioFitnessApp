
Console.WriteLine("Please enter your name");
string lionName = Console.ReadLine();

Console.WriteLine("Hello " + lionName + ", Welcome to Loropio Fitness App. ");


Console.WriteLine("Please enter your name");
string lionName = Console.ReadLine();

Console.WriteLine($"Hello {lionName}, Welcome to Loropio Fitness App.");

Console.WriteLine("Activity Details");

Console.WriteLine("Activity Name");
string activityName = Console.ReadLine();

Console.WriteLine("Distance Covered (in meters)");
double distanceInMeters = double.Parse(Console.ReadLine());

Console.WriteLine("Time Taken (in Minutes)");
double timeMinutes = double.Parse(Console.ReadLine());

Console.WriteLine("Date of Activity (YYY-MM-DD)");
string dateOfActivity = Console.ReadLine();

double distanceInKilometers = distanceInMeters / 1000;
double averageSpeed = distanceInKilometers / timeMinutes;

Console.WriteLine();
Console.WriteLine("Activity Details");
Console.WriteLine($"Activity Name: {activityName}");
Console.WriteLine($"Distance Covered: {distanceInKilometers} kilometers");
Console.WriteLine($"Time Taken: {timeMinutes} minutes");
Console.WriteLine($"Date of Activity: {dateOfActivity}");
Console.WriteLine($"Average Speed: {averageSpeed} kilometers per minute");
Console.WriteLine($"You feel{feelingInput}");

Console.ReadLine();

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

            Console.WriteLine($"How You Felt After the Activity: {feelingMessage}");
        }
        else
        {
            Console.WriteLine("Invalid feeling input. Please enter a valid number.");
            return;
        }




