// Set-up 2D array with size of 4x4 and fill it with numbers helix 

Console.WriteLine("Start of the Programm");
Console.WriteLine("...\n");

int[,] MyArray = new int[4, 4];
int TempVar = 1;
int IndexI = 0;
int IndexJ = 0;

while (TempVar <= MyArray.GetLength(0) * MyArray.GetLength(1))
{
    MyArray[IndexI, IndexJ] = TempVar;
    TempVar++;
    if (IndexI <= IndexJ + 1 && IndexI + IndexJ < MyArray.GetLength(1) - 1)
        IndexJ++;
    else if (IndexI < IndexJ && IndexI + IndexJ >= MyArray.GetLength(0) - 1)
        IndexI++;
    else if (IndexI >= IndexJ && IndexI + IndexJ > MyArray.GetLength(1) - 1)
        IndexJ--;
    else
        IndexI--;
}
Console.WriteLine();

void WriteMyArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,-7}", array[i, j])); // For good look of output array
        }
        Console.WriteLine("\n");
    }
}

WriteMyArray(MyArray);
Console.WriteLine();
