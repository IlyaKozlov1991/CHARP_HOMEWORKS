// Set the value to N. Write a program that prints all natural numbers between N and 1 using recursion.

Console.WriteLine("\nEnter Your Number:\n");

int N = int.Parse(Console.ReadLine());

void RecursionN(int n)
{
    if (n == 1)
    {
        Console.Write("{0, -7}", n);
    }
    else
    {
        Console.Write("{0, -7}", n);
        n--;
        RecursionN(n);
    }
} 

Console.WriteLine("\nResult N->1:\n");
RecursionN(N);
Console.WriteLine("\n");