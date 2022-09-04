// Set-up 3D array filled with numbers which dont't repeat and print its elements with indexes

//Console.WriteLine("Parameters of Array are required");

Console.WriteLine("Enter first dimension");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second dimension");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third dimension");
int O = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Start of the Programm");
Console.WriteLine("...\n");

Console.WriteLine("Your Array: \n");

int[,,] MyArray = new int[M, N, O];

    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
        for (int k = 0; k < MyArray.GetLength(2); k++)
        {
        MyArray[i, j, k] = new Random().Next(1, 50);
        Console.WriteLine($" {MyArray[i, j, k]}({i}, {j}, {k})  ");
        }
        }
    // Console.WriteLine();
    }