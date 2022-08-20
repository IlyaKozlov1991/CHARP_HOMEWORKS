// Set an array filled with random numbers. Find sum of odd elements
Console.WriteLine("Start of the Programm");
Console.WriteLine("...");
Console.WriteLine("Your Array is:");

int[] MyArray = new int[5]; // Set new arrays with size of 5
int Index = 0;
int SumOdd = 0;

while (Index < MyArray.Length)
{
    MyArray[Index] = new Random().Next(100, 500); // Random filling of the array with positive numbers from 100 to 500 
    if (Index % 2 != 0) // Checking for odd numbers
    {
        SumOdd += MyArray[Index];
    }
    Console.Write($"{MyArray[Index]}, ");
    Index++; 
}
Console.WriteLine("\n");
Console.WriteLine($"Sum of odd elements is: {SumOdd}");
