string[] names = { "TONSON", "CHIDAPA", "NARI", "CHOMPOO", "ARKOM", "NINA", "CARTOON" };

Console.Write("First character to find : ");
char fName = char.Parse(Console.ReadLine());

string strNames = "";
string strfNames = "";
foreach (string name in names)
{
    strNames += name + " ";
    if (name[0] == char.ToUpper(fName))
    {
        strfNames += name + " ";
    }
}
Console.WriteLine("\nOutput :");
Console.WriteLine("\tName = {0}", strNames);
Console.WriteLine("\tFirst character as {0} = {1}", fName, strfNames);