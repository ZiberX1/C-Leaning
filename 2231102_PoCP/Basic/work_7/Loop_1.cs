// ตัวแปร
int sum = 0, max = 0, min = 0;
string strNum = "";

Console.WriteLine("Waring : If you don't to input number: you should key -999\n  ");

// input number ตัวแรก
Console.Write("Input your number (1-100)? : ");
int num = int.Parse(Console.ReadLine());

// เช็คว่า number ตัวแรก อยู่ในช่วง 1-100 ไหม
if (num > 0 && num <= 100)
{
    // เพิ่ม number ตัวแรก ลงในตัวแปร
    strNum += num + " ";
    sum = num;
    max = num;
    min = num;
}

// วนซ้ำ จนกว่าจะ input -999
while (num != -999)
{
    // input number ต่อไป
    Console.Write("Input your number? : ");
    num = int.Parse(Console.ReadLine());

    // เช็คว่าตัวเลขอยู่ในช่วง 1-100 ไหม
    if (num > 0 && num <= 100)
    {
        sum += num;
        strNum += num + " ";

        // อัปเดต ค่าต่ำสุด , ค่าสูงสุด
        if (min > num)
            min = num;

        if (max < num)
            max = num;
    }

}

// Output
Console.WriteLine("\nOutput:");
Console.WriteLine("\t Input number is : " + strNum);
Console.WriteLine("\t Sum = " + sum);
Console.WriteLine("\t Max number = " + max);
Console.WriteLine("\t Min number = " + min);