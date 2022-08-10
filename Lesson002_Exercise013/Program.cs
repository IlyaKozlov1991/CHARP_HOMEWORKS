// Receive a 3-digit number and show its 2nd digit 

Console.WriteLine("Enter your number: ");

string InputStr = Console.ReadLine();
Char[] UserNumber = InputStr.ToCharArray();

if (UserNumber.Length == 3)
{
    Console.Write("third digit is: " + UserNumber[2]);
}
else
    Console.WriteLine("No 3rd digit");