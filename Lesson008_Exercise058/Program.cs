// Set-up two matrixes and multiply them

Console.WriteLine("Parameters of Matrixes are required");

Console.WriteLine("Enter number of strings for Matrix A");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of strings for Matrix B");
int R = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns");
int S = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Start of the Programm");
Console.WriteLine("...\n");

void WriteMyArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,-7}", array[i, j])); // For good look of output array
        }
        Console.WriteLine("\n");
    }
}

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
            matrix3[i, j] = TempSum;
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Matrix A:\n");

int[,] MatrixA = new int[M, N];

    for (int i = 0; i < MatrixA.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixA.GetLength(1); j++)
        {
        MatrixA[i, j] = new Random().Next(1, 10);
        }

    }
WriteMyArray(MatrixA);

Console.WriteLine();
Console.WriteLine("Matrix B:\n");

int[,] MatrixB = new int[R, S];

    for (int i = 0; i < MatrixB.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
        MatrixB[i, j] = new Random().Next(1, 10);
        }
    }
WriteMyArray(MatrixB);

int[,] MatrixResult = new int[MatrixA.GetLength(0), MatrixA.GetLength(1)];


if (MatrixA.GetLength(0) == MatrixB.GetLength(0) && MatrixA.GetLength(1) == MatrixB.GetLength(1))
{
    MultiplyMatrix(MatrixA, MatrixB, MatrixResult);
    Console.WriteLine("Result Matrix:\n");
    WriteMyArray(MatrixResult);
}
else
{
    Console.WriteLine("Impossible to multiply. Dimensions of both matrix must be equal. Try again!");
}
Console.WriteLine();
