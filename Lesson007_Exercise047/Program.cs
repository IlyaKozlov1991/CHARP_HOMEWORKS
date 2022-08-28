// Set-up 2-dimensional array [MxN] and fill it with random natural numbers

Console.WriteLine("Enter M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter N");
int N = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = new int[M, N];
int IndexV = 0;
int IndexH = 0;

while (IndexH < MyArray.Length && IndexV < MyArray.Length)
{
for (int i = 0; i < M; i++)
{
    MyArray[i, 0] = new Random().Next(10, 10);
    Console.WriteLine();
    Console.WriteLine(MyArray[i, 0]);
    Console.WriteLine();
   
    for (int j = 0; j < N; j++)
{
    MyArray[j, 0] = new Random().Next();
    Console.WriteLine();
    Console.WriteLine(MyArray[j, 0]);
    Console.WriteLine();
}
}
}
IndexV++;
IndexH++;
