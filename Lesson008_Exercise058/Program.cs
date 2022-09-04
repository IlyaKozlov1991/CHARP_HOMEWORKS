// Set-up two matrixes and multiply them

Console.WriteLine("Parameters of Matrixes are required");

Console.WriteLine("Enter number of strings");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Start of the Programm");
Console.WriteLine("...\n");

Console.WriteLine("Matrix A: \n");

int[,] MatrixA = new int[M, N];

    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixA.GetLength(1); j++)
        {
        MatrixA[i, j] = new Random().Next(1, 10);
        Console.Write($" {MatrixA[i, j]}  ");
        }
    Console.WriteLine();
    }

Console.WriteLine();
Console.WriteLine("Matrix B: \n");

int[,] MatrixB = new int[M, N];

    for (int i = 0; i < MatrixB.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
        MatrixB[i, j] = new Random().Next(1, 10);
        Console.Write($" {MatrixB[i, j]}  ");
        }
    Console.WriteLine();
    }

Console.WriteLine();

int[,] MatrixResult = new int[MatrixA.GetLength(0), MatrixA.GetLength(1)];

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            int TempSum = 0;
            for (int k = 0; k < matrix3.GetLength(1); k++)
            {
                TempSum += matrix1[i,k] * matrix2[k, j];
            }
            MatrixResult[i, j] = TempSum;
            Console.Write($" {matrix3[i, j]}");
        }
        Console.WriteLine();
    }
}

if (MatrixA.GetLength(0) == MatrixB.GetLength(0) && MatrixA.GetLength(1) == MatrixB.GetLength(1))
{
    Console.WriteLine("Result Matrix: \n");
    MultiplyMatrix(MatrixA, MatrixB, MatrixResult);
}
else
{
    Console.WriteLine("Dimensions of both matrix must be the same! Try again!");
}
Console.WriteLine();
