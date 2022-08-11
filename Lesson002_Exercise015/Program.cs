// Receive a number coresponding to a day and check if it is weekend day
// First day of a week is MONDAY 

Console.WriteLine("Enter your number: ");

int UserNumber = Convert.ToInt32(Console.ReadLine());

if (UserNumber >= 8) // Check for correct entered number
{
    Console.WriteLine("Wrong number!");
}
else
if (UserNumber == 6 | UserNumber == 7)
{
    Console.Write("Yes ");
}
else
    Console.WriteLine("No ");

if (UserNumber == 6 | UserNumber == 7)
{
    Console.WriteLine("Do you want to know what day is it today? 1-YES 0-NO"); // Ask User if he wants to know in case of weekend
    int UserAnswer = Convert.ToInt32(Console.ReadLine());
    if (UserAnswer ==1 )
    {
    if (UserNumber == 6)
    {
        Console.WriteLine("Today is Saturday");
    }
    else
    Console.WriteLine("Today is Sunday");
    }
}

