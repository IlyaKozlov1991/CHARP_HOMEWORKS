// Receive a 3-digit number and show its 2nd digit 

Console.WriteLine("Enter your number: ");

string InputStr = Console.ReadLine();
Char[] UserNumber = InputStr.ToCharArray();

Console.Write("second digit is: " + UserNumber[2]);
