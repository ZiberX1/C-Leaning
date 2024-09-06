Console.Write("Number for find factorial : ");
int num = int.Parse(Console.ReadLine());

string strNum = "";
int sum = 1;

for (int i = num; i >= 1; i--)
{
    sum *= i;
    if (i == 1)
        strNum += i;
    else
        strNum += i + " x ";
    
}

Console.WriteLine("Output :");
Console.WriteLine("\t{0}! = {1} = {2}", num, strNum, sum);