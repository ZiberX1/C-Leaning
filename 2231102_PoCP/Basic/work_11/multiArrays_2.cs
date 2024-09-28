string[,] people =
{
    { "Porn", "170", "55" },
    { "Koi", "165", "40" },
    { "Mai", "150", "38" },
    { "Nam", "155", "80" },
    { "Tue", "155", "49" },
    { "Yak", "180", "50" }
};

Console.WriteLine("Name\tHeight\tWeight\tStandard\t\tCompare\t\tMessage");

for (int i = 0; i < people.GetLength(0); i++)
{
    Console.Write(people[i, 0] + "\t"); // ชื่อ

    int height = int.Parse(people[i, 1]); // ส่วนสูง | แปลงเป็นค่า int
    int weight = int.Parse(people[i, 2]); // น้ำหนัก | แปลงเป็นค่า int

    Console.Write(height + "\t");
    Console.Write(weight + "\t");

    int standard = height - 110; // น้ำหนักมาตรฐาน (ส่วนสูง - 110)
    Console.Write("{0} - 110 = {1}\t\t", height, standard);

    int compare = weight - standard; // น้ำหนักที่ได้ (น้ำหนักตัว - น้ำหนักมาตรฐาน)
    Console.Write(compare + "\t\t");

    string message;
    if (compare < -5)
        message = "You're thin";
    else if (compare <= 5)
        message = "You're normal";
    else
        message = "You're fat";
    Console.Write(message);

    Console.WriteLine(); // ขึ้นบรรทัดใหม่
}