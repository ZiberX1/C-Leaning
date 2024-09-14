Console.Write("Christmas bush : ");
int number = int.Parse(Console.ReadLine());
int round = 0;
// พุ่มไม้
for (int i = 1; i <= number; i++)
{
    Console.SetCursorPosition(Console.WindowWidth / 2 - number + 1, Console.CursorTop);
    for (int j = 1; j <= number; j++)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - i - j, Console.CursorTop);
        for (int k = 1; k <= j + round; k++)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();
    }
    round++;
}
// ลำต้น
for (int i = 1; i <= number; i++)
{
    Console.SetCursorPosition(Console.WindowWidth / 2 - number + 1, Console.CursorTop);
    for (int j = 1; j <= number - 2; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}