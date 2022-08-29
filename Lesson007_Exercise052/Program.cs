// Set-up 2-dimensional array and find AVG of its elements

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
        MyArray[i, j] = new Random().Next(1, 10);
        Console.Write($"{MyArray[i, j]} ");
        }
    Console.WriteLine();
    }

int NewI = 0;
int NewJ = 0;
decimal Result = 0;
decimal Sum = MyArray[NewI, NewJ];
 
while (NewI < M && NewJ < N)
{
    if (NewJ == 0)
    {
    while (NewI != M - 1 && NewJ != N - 1)
        {
            for (int i = 0; i < M - 1; i++)
            {
            Result = Sum;
            Sum = Result + MyArray[NewI + 1, NewJ];
            NewI++;
            }
        Console.Write("Average sum of each column:" + " " + Math.Round(Sum/M, 1) + " ");
        }
        NewJ++;
    }
    else
    {
        NewI = 0;
        Result = 0;
        Sum = MyArray[NewI, NewJ];
        while (NewI != M - 1 && NewJ != N- - 1)
        {
            for (int k = 0; k < M - 1; k++)
                {
                Result = Sum;
                Sum = Result + MyArray[NewI + 1, NewJ];
                NewI++;
                } 
            Console.Write(Math.Round(Sum/M, 1) + " ");
            NewJ++;
    }
    }
}


