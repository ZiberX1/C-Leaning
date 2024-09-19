int[] numbers = new int[10];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("input number index {0} : ", i);
    numbers[i] = int.Parse(Console.ReadLine());

    if (i % 2 == 1)
    {
        sum += numbers[i];
    }
}

double avg = sum / 5.0;
string strNumber = "";

foreach (int num in numbers)
{
    if (num > avg)
        strNumber += num + " ";
}
Console.WriteLine("sum of odd index array = {0}", sum);
Console.WriteLine("average of odd index array = {0}", avg);
Console.WriteLine("array is greater than average : {0}", strNumber);