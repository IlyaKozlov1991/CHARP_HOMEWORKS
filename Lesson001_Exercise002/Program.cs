// Receive two numbers and find max

Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a);
}
else
Console.WriteLine("max = " + b);