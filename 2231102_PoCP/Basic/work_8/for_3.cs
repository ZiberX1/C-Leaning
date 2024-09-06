int num;
int n1 = 0; // มากกว่าหรือเท่ากับ 50
int n2 = 0; // น้อยกว่า 50
string strNum = "";

for (int i = 1; i <= 6; i++)
{
    Console.Write("Input your number? : ");
    num = int.Parse(Console.ReadLine());
    strNum += num + " ";
    if (num >= 50)
        n1++;
    else
        n2++;
}

Console.WriteLine("Output :");
Console.WriteLine("You input number is {0}", strNum);
Console.WriteLine("Count of number is grater or equal than 50 = {0}", n1);
Console.WriteLine("Count of number is less than 50 = {0}", n2);