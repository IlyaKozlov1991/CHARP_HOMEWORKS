// See https://aka.ms/new-console-template for more information

Console.WriteLine("\nEnter Number M: ");
int m = int.Parse(Console.ReadLine());
            
Console.WriteLine("\nEnter Number N: ");
int n = int.Parse(Console.ReadLine());
            
static int Ackermann(int m, int n)
{           
if (m == 0) return n + 1;
if (m > 0 && n == 0) return Ackermann(m - 1, 1);
if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
return Ackermann(m, n);
}

Ackermann(m, n);
Console.WriteLine("\nResult: ");
Console.WriteLine(Ackermann(m, n));