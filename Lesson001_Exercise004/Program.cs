// Receive two numbers and find max

Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
    Console.WriteLine("max = " + a);
    }
}
else
if (b > c)
{
Console.WriteLine("max = " + b);
}
else
Console.WriteLine("max = " + c);