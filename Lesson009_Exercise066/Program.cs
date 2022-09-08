// Set the values of M and N. Write a program that will find the sum of positive integers between M and N using recursion

Console.WriteLine("Enter Number M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Number N: ");
int N = int.Parse(Console.ReadLine());

void SumMN(int m, int n)
{
    if (m < n)
    {
        int i = 0;
        i = i + m;
        Console.Write($"{i}");
        // i = i + m;
        m++;
        SumMN(m, n);
    }
    else
    {
        
    }
}

SumMN(M, N);