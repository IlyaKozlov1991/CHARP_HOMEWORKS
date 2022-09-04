// Set-up a 2-dimensional array. Write a programm to put elements of each string in order: from bigger to lower 

Console.WriteLine("Parameters of Array are required");

Console.WriteLine("Enter number of strings");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Start of the Programm");
Console.WriteLine("...");

Console.WriteLine("Your Array:");

int[,] MyArray = new int[M, N];

    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
        MyArray[i, j] = new Random().Next(1, 100);
        Console.Write($" {MyArray[i, j]}  ");
        }
    Console.WriteLine();
    }

Console.WriteLine("Your array after formating: ");
Console.WriteLine();

for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            for (int k = 0; k < MyArray.GetLength(1) - 1; k++)
            {
                if (MyArray[i, k] < MyArray[i, k + 1])
                {
                    int TempVar = MyArray[i, k + 1];
                    MyArray[i, k + 1] = MyArray[i, k];
                    MyArray[i, k] = TempVar;
                }
                Console.Write($"{MyArray[i, k]} ");
            }
        }
        Console.WriteLine();
    }
    return;
