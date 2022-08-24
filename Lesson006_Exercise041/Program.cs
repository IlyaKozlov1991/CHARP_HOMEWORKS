// Receive (M) numbers from User and find how many of them are > 0

Console.WriteLine("Start of the Programm");
Console.WriteLine("...");
Console.WriteLine();
Console.WriteLine("Enter Your Numbers using SAPCE");

string NumberStr = Console.ReadLine();
string[] SecondStr = NumberStr.Split(' ');
 
int[] NumberArray = new int[SecondStr.Length];
int Index = 0;
int Count =0;

Console.WriteLine();
Console.WriteLine("Your numbers: ");

foreach (var i in SecondStr)
{
    NumberArray[Index] = Convert.ToInt32(i);
    Console.Write($"{NumberArray[Index]} ");
    if (NumberArray[Index] > 0)
    {
        Count++;
        Index++;
    }
    else
    {
        Index++;
    }
}
Console.WriteLine("\n");
Console.WriteLine($"You entered {Count} numbers bigger than 0");
Console.WriteLine();