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
