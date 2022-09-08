// Set the values of M and N. Write a program that will find the sum of positive integers between M and N using recursion

Console.WriteLine("Enter Number M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Number N: ");
int n = int.Parse(Console.ReadLine());

void SumMN(int m)
{
    if (m < n)
    {
        int count = 0;
        count = count + m;
        m++;
        Console.Write(count);
        SumMN(m, n);
    }
    else
    {
        SumMN(m, n);
    }
}

SumMN(m, n);
Console.WriteLine(SumMN(m, n));