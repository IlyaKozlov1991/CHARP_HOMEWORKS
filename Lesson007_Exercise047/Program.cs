// Set-up 2-dimensional array [MxN] and fill it with random natural numbers

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