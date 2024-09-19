string[] names = { "TONSON", "CHIDAPA", "NARI", "CHOMPOO", "ARKOM", "NINA", "CARTOON" };

Console.Write("First character to find : ");
char fName = char.Parse(Console.ReadLine()); // รับค่าตัวอักษร '..' ex. 'c' , 'A'

string strNames = "";
string strfNames = "";
foreach (string name in names)
{
    strNames += name + " "; // เพิ่ม name (ex. "TONSON", "NARI") เข้าไปในตัวแปรและเว้นวรรค

    // name[0] -> ตัวอักษรตำแหน่งที่ 0 ของตัวแปร name (เป็น char ไม่ใช่ string) | ex. "TONSON" ตัวที่ 0 คือ 'T'
    // char.ToUpper(ตัวแปร) -> แปลงค่า ตัวอักษรเป็นตัวพิมพ์ใหญ่ ex. 'c' --> 'C'
    if (name[0] == char.ToUpper(fName))
    {
        strfNames += name + " "; // เพิ่ม name ที่ตรงกับเงื่อนไข เข้าไปในตัวแปรและเว้นวรรค
    }
}
Console.WriteLine("\nOutput :");
Console.WriteLine("\tName = {0}", strNames);
Console.WriteLine("\tFirst character as {0} = {1}", fName, strfNames);