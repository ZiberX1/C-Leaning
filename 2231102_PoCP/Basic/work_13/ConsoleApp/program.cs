using EDU_work_ClassLibrary; // ชื่อ namespace ของ ClassLibrary
using System;

namespace EDU_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethodClass mc = new MyMethodClass(); // MyMethodClass : ชื่อ class ใน ClassLibrary | mc ตั้งชื่ออะไรก็ได้

            // #1
            Console.WriteLine("[ Method 1 ]");
            mc.CheckPassword("012345678");
            mc.CheckPassword("0123456");

            Console.WriteLine("\n====================");

            // #2
            Console.WriteLine("\n[ Method 2 ]");
            mc.Welcome();

            Console.WriteLine("\n====================");

            // #3
            Console.WriteLine("\n[ Method 3 ]");
            double fah = mc.getFahrenheit(30.5);
            Console.WriteLine(fah);

            Console.WriteLine("\n====================");

            // #4
            Console.WriteLine("\n[ Method 4 ]");
            string basenumber = mc.ConvertDigit(2, 25);
            Console.WriteLine(basenumber);
            basenumber = mc.ConvertDigit(8, 25);
            Console.WriteLine(basenumber);
            basenumber = mc.ConvertDigit(16, 25);
            Console.WriteLine(basenumber);

            Console.WriteLine("\n====================");

            // #5
            Console.WriteLine("\n[ Method 5 ]");
            string grade = mc.calGrade(20, 20, 20, 20); // 80
            Console.WriteLine(grade);
            grade = mc.calGrade(20, 20, 20, 16); // 76
            Console.WriteLine(grade);
            grade = mc.calGrade(20, 15, 20, 15); // 70
            Console.WriteLine(grade);
            grade = mc.calGrade(20, 10, 20, 15); // 65
            Console.WriteLine(grade);
            grade = mc.calGrade(20, 11, 20, 10); // 61
            Console.WriteLine(grade);
            grade = mc.calGrade(20, 16, 10, 10); // 56
            Console.WriteLine(grade);
            grade = mc.calGrade(20, 10, 10, 10); // 50
            Console.WriteLine(grade);
            grade = mc.calGrade(10, 10, 10, 10); // 40
            Console.WriteLine(grade);

            Console.WriteLine("\n====================");

            // #6
            Console.WriteLine("\n[ Method 6 ]");
            mc.outputNumber(10, 35, 10);
            Console.WriteLine("\n");
            mc.outputNumber(1, 12, 5);

            Console.WriteLine("\n\n====================");

            // #7
            Console.WriteLine("\n[ Method 7 ]");
            mc.multiplication(3, 4);

            Console.WriteLine("\n====================");

            // #8
            Console.WriteLine("\n[ Method 8 ]");
            long fac = mc.fac(5);
            Console.WriteLine(fac);

            Console.WriteLine("\n====================");

            // #9
            Console.WriteLine("\n[ Method 9 ]");
            mc.christmasBush(5);

            Console.WriteLine("\n====================");

            // #10
            Console.WriteLine("\n[ Method 10 ]");
            string text = mc.method10(1, 10, 3);
            Console.WriteLine(text);
            text = mc.method10(1, 100, 7);
            Console.WriteLine(text);

            Console.Write("\nPress any key to exit program");
            Console.ReadKey();
        }
    }
}
