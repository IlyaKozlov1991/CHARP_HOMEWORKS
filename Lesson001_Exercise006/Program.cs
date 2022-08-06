// Receive a number and check if it is even or odd

Console.WriteLine("Enter your number");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 2;

if (b > 0)
{
    Console.WriteLine("No! Number is odd!");
}
else
Console.WriteLine("Yes! Number is even!");
