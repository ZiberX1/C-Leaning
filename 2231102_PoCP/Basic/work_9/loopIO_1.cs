Console.Write("Start Number : ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Last Number : ");
int n2 = int.Parse(Console.ReadLine());

for (int i = n1; i <= n2; i++)
{
    Console.WriteLine("\t Multiply " + i);
    for (int j = 1; j <= 12; j++)
    {
        Console.WriteLine("\t{0} x {1} = {2}", i, j, i * j);
    }
    Console.WriteLine("------------------------------");
}