// Fill an array with positive 3-digits numbers. Display how many even numbers are in the array
Console.WriteLine("Start of the Programm");
Console.WriteLine("...");
Console.WriteLine("Your Array is:");

int[] MyArray = new int[5]; // Set new arrays with size of 5
int Index = 0;
int CountEven = 0;

while (Index < MyArray.Length)
{
    MyArray[Index] = new Random().Next(100, 500); // Random filling of the array with positive numbers from 100 to 500 
    if (MyArray[Index] % 2 ==0) // Checking for even numbers
    {
        CountEven++;
    }
    Console.Write($"{MyArray[Index]}, ");
    Index++; 
}
Console.WriteLine("\n");
Console.WriteLine($"Quantity of even numbers in the Array: {CountEven}");
