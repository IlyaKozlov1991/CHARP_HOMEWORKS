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

for (int j = 0; j < MyArray.GetLength(1); j++) // GetLength(1) - returns number of columns in array
{
double Sum = 0; //Container to sum elements of a column

for (int i = 0; i < MyArray.GetLength(0); i++) // GetLength(0) - returns number of strings in array
{
    Sum = Sum + MyArray[i, j];
}
    double Average = 0; 
Average = Sum / MyArray.GetLength(0); //Average
System.Console.WriteLine($"Average sum of elements in column {j}: {Average}");
}


