Console.Write("input size of array : ");
int size = int.Parse(Console.ReadLine()); // รับค่า ขนาด

int[] arrays = new int[size]; // สร้าง Array ตามขนาด

string strArrays = "";

for (int i = 0; i < arrays.Length; i++) // loop ตามจำนวนขนาด arrays
{
    Console.Write("Input value in array No. {0} : ", i);
    arrays[i] = int.Parse(Console.ReadLine()); // รับค่า ตัวเลข ไปใส่ใน arrays
    strArrays += arrays[i] + " "; // นำค่าที่ input มาไปใส่ไว้ใน ตัวแปรแล้วเว้นวรรค
}

Array.Sort(arrays); // เรียงจาก น้อย -> มาก
Array.Reverse(arrays); // ย้อนกลับ เป็น มาก -> น้อย

string decArrays = "";

foreach (int num in arrays)
{
    decArrays += num + " "; // นำค่าตัวเลขใน arrays มาใส่ไว้ใน ตัวแปรแล้วเว้นวรรค
}

Console.WriteLine("\nOutput :");
Console.WriteLine("  Value in array = {0}", strArrays);
Console.WriteLine("  Descending number => {0}", decArrays);