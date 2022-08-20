// Set an array. Find difference between Max and Min numbers
Console.WriteLine("Start of the Programm");
Console.WriteLine("...");
Console.WriteLine("Your Array is:");

int[] MyArray = new int[5]; // Set new array with size of 5
int Index = 0;

while (Index < MyArray.Length)
{
    MyArray[Index] = new Random().Next(100, 200); // Random filling of the array with positive numbers from 100 to 500
    Console.Write($"{MyArray[Index]}, ");
    Index++;
}

Console.WriteLine("\n");

int FindMax = MyArray[0];
int FindMin = MyArray[0];
    for (int NewIndex = 1; NewIndex < MyArray.Length; NewIndex++) // Check for minimum number
    {
       if (MyArray[NewIndex] < FindMin)
       {
        FindMin = MyArray[NewIndex];
       }
       else
       if (FindMax < MyArray[NewIndex]) // Check for maximum number
       {
        FindMax = MyArray[NewIndex];
       }
    }
Console.WriteLine($"Maximum is - {FindMax}");
Console.WriteLine($"Minimum is - {FindMin}");
Console.WriteLine($"Difference between Max and Min is - {(FindMax - FindMin)}");
Console.WriteLine();