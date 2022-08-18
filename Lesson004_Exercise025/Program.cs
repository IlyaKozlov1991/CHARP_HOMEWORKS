// Receive two numbers (A) and (B) and exponent (A) into (B)  

Console.WriteLine("Enter number A: ");
int NumbA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B: ");
int NumbB = Convert.ToInt32(Console.ReadLine());

double Result = Math.Pow(NumbA, Math.Abs(NumbB));

Console.WriteLine($"Your result is: {Result}");