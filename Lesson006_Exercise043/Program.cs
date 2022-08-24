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

double X = 1;

static double FindY1(double K1, double B1, double X)
{
    double NewY1 = K1 * X + B1;
    return NewY1; 
}
static double FindY2(double K2, double B2, double X)
{
    double NewY2 = K2 * X + B2;
    return NewY2; 
}

Y1 = FindY1(K1, B1, X);
Y2 = FindY2(K2, B2, X);

if (Y1 - Y2 == 0)
{
    Console.WriteLine("Parallel lines!!!");
}
else
{
    X = Math.Round(((B2 - B1) / (K1 - K2)), 2);
    Y1 = FindY1(K1, B1, X);
    Y2 = FindY2(K2, B2, X);
    Console.WriteLine();
    Console.WriteLine($"Coordinates of cross point are: ({X}, {Math.Round(Y2, 2)})");
}
