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
