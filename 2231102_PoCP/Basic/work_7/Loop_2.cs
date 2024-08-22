// ตัวแปร
int high, sum = 0;
double avg;
string ans;

int n = 0; // นับจำนวนนักเรียน

// วนซ้ำ จนกว่าจะเลือก ออก
do
{
    n++; // เพิ่มจำนวนนักเรียน

    // input ค่าความสูง
    Console.Write("Input high (Centimetre)? : ");
    high = int.Parse(Console.ReadLine());

    // เพิ่มค่าความสูงใน sum
    sum += high;

    // ถามว่าจะทำซ้ำต่อไหม
    Console.Write("Do you want to add data continue(Y/N)? ");
    ans = Console.ReadLine();

} while (ans.ToUpper() == "Y");

// คำนวณค่าเฉลี่ย
avg = (double)sum / n;

// Output
Console.WriteLine("\nOutput:");
Console.WriteLine("\t Sum of high = {0} cm.", sum);
Console.WriteLine("\t Total of student = {0} person.", n);
Console.WriteLine("\t Average high = {0:f2} cm.", avg);