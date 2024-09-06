int sum = 0;
int num = 1;
string strNum = "";
for (int i = 1; i <= 13; i++)
{
    sum += num;

    if (i == 1)
        Console.WriteLine(num);
    else
        Console.WriteLine("{0}{1} = {2}", strNum, num, sum);

    strNum += num + " + ";
    num += 4;
}