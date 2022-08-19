// Receive a number and show sum of all its numbers

Console.WriteLine("Entre Your number");

string NumbStr = Console.ReadLine();
string[] TempStr = new string[NumbStr.Length];

int[] NumbArr = new int[NumbStr.Length];
int counter = 0;

for (int i = 0; i < NumbStr.Length; i++)
{
    TempArr[i] = NumbStr.Substring(counter, 1);
    counter++;
}
Console.WriteLine()