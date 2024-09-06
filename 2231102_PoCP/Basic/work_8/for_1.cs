Console.WriteLine("1 - Program for display number");

Console.Write("\nWhat is last number? : ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Output :");

for (int i = 1; i <= num; i++)
{
    Console.Write(i + " ");
}