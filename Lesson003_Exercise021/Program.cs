// Find destance between two points in 3D space

Console.WriteLine("Enter A(x): ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter A(y): ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter A(z): ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter B(x): ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("EnterB(y): ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B(z): ");
int zB = Convert.ToInt32(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine("Distance AB found: " + Math.Round(Distance, 2));
