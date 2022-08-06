// Receive a number (N) and and show all even numbers from 1 to N

Console.WriteLine("Enter your number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) // Only positive numbers will be processed
{
int temp_n = 1;

while (temp_n <= n)
{
    if (temp_n % 2 == 0)
    {
        Console.WriteLine(temp_n);
        temp_n = temp_n + 1;
    }
    else
    temp_n = temp_n + 1;
}
}
else
Console.WriteLine("Wrong number! Try again!");