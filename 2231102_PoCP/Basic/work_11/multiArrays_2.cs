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
    Console.Write(people[i, 0] + "\t");

    int height = int.Parse(people[i, 1]);
    int weight = int.Parse(people[i, 2]);

    Console.Write(height + "\t");
    Console.Write(weight + "\t");

    int standard = height - 110;
    Console.Write("{0} - 110 = {1}\t\t", height, standard);

    int compare = weight - standard;
    Console.Write(compare + "\t\t");

    string message;
    if (compare < -5)
        message = "You're thin";
    else if (compare <= 5)
        message = "You're normal";
    else
        message = "You're fat";
    Console.Write(message);

    Console.WriteLine();
}