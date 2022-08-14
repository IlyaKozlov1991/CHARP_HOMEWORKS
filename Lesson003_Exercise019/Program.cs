// Receive 5-digits number and check if it is palindrome
Console.WriteLine("Enter your number: ");

for (int Attempt = 0; Attempt < 5;) // User has ony 5 attempts
{
 string InputNumberStr = Console.ReadLine();
 Char[] InputNumberChar = InputNumberStr.ToCharArray();   
 if (InputNumberChar.Length == 5) // Check that 5-digits number has been entered
{
    if (InputNumberChar[0] == InputNumberChar[4] && InputNumberChar[1] == InputNumberChar[3])
    {
        Console.WriteLine("Yes, " + InputNumberStr + " is palindrome");
    }
    else Console.WriteLine("No, " + InputNumberStr + " is not palindrome");
    return;
}
else
Console.WriteLine("Wrong Number");
Attempt++;
}
Console.WriteLine("Number must have FIVE digits");