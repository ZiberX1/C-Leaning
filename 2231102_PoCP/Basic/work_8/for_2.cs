Console.WriteLine("2 - Program for display number");

Console.Write("\nWhat is last number? : ");
int num = int.Parse(Console.ReadLine());

int count = 0;
Console.WriteLine("Output :");

for (int i = 1; i <= num; i++)
{
    count++;
    if (count % 5 == 0)
        Console.WriteLine(i);
    else
        Console.Write(i + "\t");
}