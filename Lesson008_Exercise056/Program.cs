// See https://aka.ms/new-console-template for more information

Console.WriteLine("Parameters of Array are required");

Console.WriteLine("Enter number of strings");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nStart of the Programm");
Console.WriteLine("...\n");

Console.WriteLine("Your Array: \n");

int[,] MyArray = new int[M, N];

    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
        MyArray[i, j] = new Random().Next(1, 100);
        // Console.Write($" {MyArray[i, j]}  ");
        }
    // Console.WriteLine();
    }

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

WriteMyArray(MyArray);

    Console.WriteLine();
    int[] Sum = new int[MyArray.GetLength(0)];
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Sum[i] = Sum[i] + MyArray[i, j];
        }
        Console.WriteLine($"Sum of string {i}: {Sum[i]}");
    }

    int MinString = 0;
    int FindMin = Sum[0]; 
    for (int k = 1; k < Sum.GetLength(0) - 1; k++)
        {
            int TempVar = Sum[k];
            if (TempVar < FindMin)
            {
                FindMin = TempVar;
                MinString = k;
            }
        }
    Console.WriteLine();
    Console.WriteLine($"String #{MinString} has lowest Sum ofelements: {FindMin}");

