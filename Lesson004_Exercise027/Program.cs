// Receive a number and show sum of all its numbers

Console.WriteLine("Enter Your number"); // Number request

string NumbStr = Console.ReadLine(); // Number is received from user

Char[] NumbAr = new Char[NumbStr.Length]; // Line 7-8 Number is moved to Char format
NumbAr = NumbStr.ToArray(); 
int MyNumb = 0; // Temporary variable for further convertation
int Result = 0;
Array[] TempArr = new Array[NumbAr.Length]; // Temporary array for further convertation

for (int i = 0; i < NumbAr.Length; i++)
{
    MyNumb = NumbAr[i] - '0'; // Convertation from ASCII to int has been implemented because Char is used
    Result += MyNumb;
}

Console.WriteLine($"Your Sum is: {Result}");
