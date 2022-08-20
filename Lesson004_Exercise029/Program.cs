// Set an array with 8 elements and print it
Console.WriteLine("Welcome to the Programming!!!");
Console.WriteLine("Your Array is:");

int[] MyArray = new int[8];

for (int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = new Random().Next(-9, 9);
    Console.Write($"{MyArray[i]}, ");
}
