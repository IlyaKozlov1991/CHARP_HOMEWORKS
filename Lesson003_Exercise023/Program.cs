// Receive a number (N) and show a table with with cubes from 1 to (N)

Console.WriteLine("Enter your number");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (userNumber > 0) // Possible to operate with both positive and negative numbers
{;
    while (count <= userNumber)
{
    double cube = Math.Pow(count, 3);
    count++;
    Console.Write(cube + ", ");
}
return;
}
else
count = -1;
while (count >= userNumber)
{
    double cube = Math.Pow(count, 3);
    count--;
    Console.Write(cube + ", ");   
}