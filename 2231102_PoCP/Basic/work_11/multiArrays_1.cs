string[,] students =
{
    { "Win", "15", "12", "18", "27" },
    { "Mee", "20", "15", "20", "28" },
    { "Pan", "8", "7", "10", "15" },
    { "Nid", "18", "18", "15", "10" },
    { "Wai", "10", "15", "10", "18" }
};

Console.WriteLine("Output :");
Console.WriteLine("Name\tWork1\tWork2\tMidterm\tFinal\tTotal\tGrade");

for (int i = 0; i < students.GetLength(0); i++)
{
    char grade;
    int total = 0;

    for (int j = 0; j < students.GetLength(1); j++)
    {
        Console.Write(students[i, j] + "\t");
        if (j > 0) // j = 0 คือชื่อคน
            total += int.Parse(students[i, j]);
    }

    if (total >= 80)
        grade = 'A';
    else if (total >= 70)
        grade = 'B';
    else if (total >= 60)
        grade = 'C';
    else if (total >= 50)
        grade = 'D';
    else
        grade = 'F';

    Console.Write(total + "\t" + grade);
    Console.WriteLine(); // ขึ้นบรรทัดใหม่
}