// Receive indexes of an element and check if it is present in 2-dimensial array and its value

Console.WriteLine("Parameters of Array are required");

Console.WriteLine("Enter M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Start of the Programm");
Console.WriteLine("...");

Console.WriteLine("Your Array:");

int[,] MyArray = new int[M, N];

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
        MyArray[i, j] = new Random().Next(-100, 100);
        Console.Write($"{MyArray[i, j]} ");
        }
    Console.WriteLine();
    }

Console.WriteLine();
Console.WriteLine("Enter Index I:");
int IndexI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Index J:");
int IndexJ = Convert.ToInt32(Console.ReadLine());

if (IndexI < M & IndexJ < N)
{
    Console.WriteLine();
    Console.WriteLine($"Desired element is: {MyArray[IndexI, IndexJ]}");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Such element doesn't exist in the Array");
}
