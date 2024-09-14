Console.Write("Row : ");
int row = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
for (int i = 1; i <= row; i++)
{
    if (i % 5 == 0)
        Console.Write("C o m p u t e r  S c i e n c e");
    else
    {
        for (int j = 1; j <= i; j++)
        {
            if (j % 3 == 1)
                Console.Write("& ");
            else if (j % 3 == 2)
                Console.Write("# ");
            else if ((j % 3) == 0)
                Console.Write("@ ");
        }
    }
    Console.WriteLine();
}