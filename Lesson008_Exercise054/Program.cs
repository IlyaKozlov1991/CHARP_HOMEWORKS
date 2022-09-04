// Set-up a 2-dimensional array. Write a programm to put elements of each string in order: from bigger to lower 

Console.WriteLine("Parameters of Array are required");

Console.WriteLine("Enter number of strings");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nStart of the Programm");
Console.WriteLine("...\n");

Console.WriteLine("Your Array:\n");

int[,] MyArray = new int[M, N];
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

    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
        MyArray[i, j] = new Random().Next(1, 100);
        }
    }
WriteMyArray(MyArray);

Console.WriteLine("\nYour array after formating: ");
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
            }
        }
    }
WriteMyArray(MyArray);