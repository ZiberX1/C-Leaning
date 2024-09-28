string[,] str =
{
    { "Nong", "10" },
    { "Popeye", "5" },
    { "Olive", "4" },
    { "Nobita", "7" },
    { "Jiant", "9" },
    { "Oshin", "2" },
};

for (int i = 0; i < str.GetLength(0); i++)
{
    Console.Write(i + 1 + "\t"); // ตัวเลขหน้าสุด เริ่มที่ 1
    for (int j = 0; j < str.GetLength(1); j++)
    {
        Console.Write(str[i, j] + "\t");
    }

    int round = int.Parse(str[i, 1]); // แปลงเลขเป็น int
    for (int j = 1; j <= round; j++)
    {
        Console.Write("*");
    }
    
    Console.WriteLine(); // ขึ้นบรรทัดใหม่
}