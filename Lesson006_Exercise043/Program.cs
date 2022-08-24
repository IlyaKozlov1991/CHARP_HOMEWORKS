// Receive functions of two lines and find their cross point

Console.WriteLine("Start of the Programm");
Console.WriteLine("...");
Console.WriteLine("Coefficients are required");
Console.WriteLine();
double Y1 = new int();
double Y2 = new int();

Console.WriteLine("Enter B1:"); // Request for coefficients
double B1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter K1:");
double K1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter B2:");
double B2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter K2:");
double K2 = double.Parse(Console.ReadLine());

double X = 0;
Y1 = K1 * X + B1;
Y2 = K2 * X + B2;

if (Y1 - Y2 == 0)
{
    Console.WriteLine("Parallel lines!!!");
}
else
{
    X = Math.Round(((B2 - B1) / (K1 - K2)), 1);
    Y1 = K1 * X + B2;
    Y2 = K2 * X + B2;
    Console.WriteLine();
    Console.WriteLine($"Coordinates of cross point are: ({X}, {Math.Round(Y2, 1)})");
}
