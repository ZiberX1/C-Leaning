using System;

namespace EDU_work_ClassLibrary
{
    public class MyMethodClass // เปลี่ยนชื่อตามโจทย์
    {
        // #1 | void = ไม่คืนค่า
        public void CheckPassword(string password)
        {
            if (password.Length >= 8)
                Console.WriteLine("This password is OK");
            else
                Console.WriteLine("Password must be more than 8 characters");
        }

        // #2 | void = ไม่คืนค่า
        public void Welcome()
        {
            Console.WriteLine("Welcome !!! User");
            Console.WriteLine("This is Program for beginner player.");
            Console.WriteLine("Warning :");
            Console.WriteLine("\t\t\t1. Player should be over 12 years old.");
            Console.WriteLine("\t\t\t2. You should play no more than 2 hours");
        }

        // #3 | double = คืนค่าเป็น double (ค่าหลังจากคำว่า return)
        public double getFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        // #4 | string = คืนค่าเป็น string (ตัวแปร reverse)
        public string ConvertDigit(int toBase, int base10)
        {
            string first = "";
            do
            {
                int value = base10 % toBase;
                if (value == 10)
                    first += "A";
                else if (value == 11)
                    first += "B";
                else if (value == 12)
                    first += "C";
                else if (value == 13)
                    first += "D";
                else if (value == 14)
                    first += "E";
                else if (value == 15)
                    first += "F";
                else
                    first += value;
                base10 /= toBase;
            } while (base10 > 0);

            string reverse = ""; // สร้างตัวแปร
            for (int i = first.Length - 1; i >= 0; i--)
            {
                reverse += first[i];
            }
            return reverse; // คืนค่านี้ (reverse เป็น string ดังนั้นจึงต้องคืนค่าเป็น string)
        }

        // #5 | string = คืนค่าเป็น string (ตัวแปร grade)
        public string calGrade(int a, int b, int c, int d)
        {
            string grade; // สร้างตัวแปร
            int score = a + b + c + d;
            if (score >= 80)
                grade = "A";
            else if (score >= 75)
                grade = "B+";
            else if (score >= 70)
                grade = "B";
            else if (score >= 65)
                grade = "C+";
            else if (score >= 60)
                grade = "C";
            else if (score >= 55)
                grade = "D+";
            else if (score >= 50)
                grade = "D";
            else
                grade = "F";
            return grade; // คืนค่า grade (ตัวแปร grade เป็น string ดังนั้นจึงต้องคืนค่าเป็น string)
        }

        // #6 | void = ไม่คืนค่า
        public void outputNumber(int start, int end, int line)
        {
            int count = 0; // นับจำนวน
            for (int i = start; i <= end; i++)
            {
                count++;
                if (count % line == 0)
                    Console.WriteLine(i);
                else
                    Console.Write(i + "\t");
            }
        }

        // #7 | void = ไม่คืนค่า
        public void multiplication(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine("Multiplication Table " + i);
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
                Console.WriteLine("*******************");
            }
        }

        // #8 | long = คืนค่าเป็น long (ตัวแปร value)
        public long fac(int n)
        {
            long value = 1; // สร้างตัวแปร value
            for (int i = n; i > 0; i--)
            {
                value *= i;
            }
            return value; // value เป็น long ดังนั้นจึงเป็นการคืนค่า long
        }

        // #9 | void = ไม่คืนค่า
        public void christmasBush(int number)
        {
            if (number > 2)
            {
                int round = 0;
                // พุ่มไม้
                for (int i = 1; i <= number; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                    for (int j = 1; j <= number; j++)
                    {
                        Console.SetCursorPosition(Console.WindowWidth / 2 - i - j, Console.CursorTop);
                        for (int k = 1; k <= j + round; k++)
                        {
                            Console.Write(k + "  ");
                        }
                        Console.WriteLine();
                    }
                    round++;
                }
                // ลำต้น
                for (int i = 1; i <= number; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.CursorTop);
                    for (int j = 1; j <= number - 2; j++)
                    {
                        Console.Write(j + "  ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                Console.WriteLine("Error Christmas bush!!!");
            }
        }

        // #10 | string = คืนค่าเป็น string (ตัวแปร strOutput)
        public string method10(int start, int end, int div)
        {
            string strOutput = "";
            for (int i = start; i <= end; i++)
            {
                if (i % div == 0)
                {
                    if (strOutput == "")
                        strOutput += i;
                    else
                        strOutput += ", " + i;
                }
            }
            return strOutput; // คืนค่านี้ (strOutput เป็น string ดังนั้นจึงต้องคืนค่าเป็น string)
        }
    }
}
