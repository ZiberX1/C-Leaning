int sum = 0;
string sumString = "";

for (int i = 1; i <= 49; i += 4)
{
    sum += i;

    if (i == 1)
    {
        sumString += i;
        Console.WriteLine(sum);
    }
    else
    {
        sumString += " + " + i;
        Console.WriteLine("{0} = {1}", sumString, sum);
    }
}