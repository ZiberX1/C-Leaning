static void Main(string[] args)
{
    string file = "C:\\shop.txt"; // ตำแหน่งไฟล์

    while (true) // วนซ้ำ
    {
        int choice; // ตัวแปร ช้อย

        do // วนซ้ำในนี้
        {
            Console.Clear();
            Console.Title = "Main Menu";
            Console.WriteLine("Selected File = {0}\n", file);

            Console.WriteLine("Menu:");
            Console.WriteLine("\t1) Write");
            Console.WriteLine("\t2) Read");
            Console.WriteLine("\t3) Search");
            Console.WriteLine("\t4) Exit");

            Console.Write("\nSelect > ");
            choice = int.Parse(Console.ReadLine());

            if (choice <= 0 || choice > 4)
            {
                Console.Clear();
                Console.WriteLine("Invalid choice. Please choose 1-4");
                Console.ReadKey();
            }

        } while (choice <= 0 || choice > 4); // วนซ้ำ จนกว่า ตัวแปร choice จะมีค่าเป็นค่าใดค่าหนึ่ง (1,2,3,4)
        // ออกจาก do while loop = choice มีค่าแล้ว

        switch (choice) // ไปตามค่า choice 1 - 3
        {
            case 1:
                printWriteMenu(file);
                break;
            case 2:
                printReadMenu(file);
                break;
            case 3:
                printSearchMenu(file);
                break;
        }

        // ถ้า choice เป็น 4 จะหยุดการทำงาน loop นี้
        if (choice == 4)
        {
            break;
        }
    }
}

static void printWriteMenu(string file)
{
    Console.Clear();
    Console.Title = "Write Menu";
    Console.WriteLine("Selected File = {0}\n", file);

    Console.WriteLine("Enter items you want to add to shop.\n");

    string[] item = new string[3]; // สร้าง Arrays ไว้รับค่า {id, name, price} (จะแยกเป็นตัวแปรปกติก็ได้ ไม่ต้องใช้ arrays)
    Console.Write("Enter ID: ");
    item[0] = Console.ReadLine(); // input id
    Console.Write("Enter Item Name: ");
    item[1] = Console.ReadLine(); // input name

    // เอา id กับ ชื่อ ไปเช็คว่ามีค่าซ้ำไหม
    if (checkExists(file, item[0], item[1]))
    {
        Console.WriteLine("\nItem already exists. Please enter a different ID or Name.");

        Console.Write("\nPress any key to continue");
        Console.ReadKey();
        return; // ถ้าซ้ำจะทำงานถึงแค่ตรงนี้ ด้านล่างไม่ทำแล้ว
    }

    // ถ้าไม่ซ้ำ จะทำงานด้านล่างนี้ต่อ
    Console.Write("Enter Price: ");
    item[2] = Console.ReadLine(); // input price

    StreamWriter streamWriter = new StreamWriter(file, true);
    streamWriter.Write(item[0] + ";");
    streamWriter.Write(item[1] + ";");
    streamWriter.WriteLine(item[2]);
    streamWriter.Close();

    Console.WriteLine("Saved");

    Console.Write("\nPress any key to continue");
    Console.ReadKey();
}

static void printReadMenu(string file)
{
    Console.Clear();
    Console.Title = "Read Menu";
    Console.WriteLine("Selected File = {0}\n", file);

    Console.WriteLine("ID\tName\t\tPrice");

    StreamReader streamReader = new StreamReader(file);
    string line = streamReader.ReadLine();
    while (line != null)
    {
        string[] str = line.Split(';');
        Console.WriteLine("{0}\t{1}\t\t{2} THB", str[0], str[1], str[2]); // Example > "1   Water      10 THB"
        line = streamReader.ReadLine();
    }
    streamReader.Close();

    Console.Write("\nPress any key to continue");
    Console.ReadKey();
}

static void printSearchMenu(string file)
{
    int choice; // ตัวแปร ช้อย

    do // วนซ้ำในนี้
    {
        Console.Clear();
        Console.Title = "Search Menu";
        Console.WriteLine("Selected File = {0}\n", file);

        Console.WriteLine("What do you want to search with?");
        Console.WriteLine("\t1) Search with ID");
        Console.WriteLine("\t2) Search with Name");
        Console.WriteLine("\t3) Back");

        Console.Write("\nSelect > ");
        choice = int.Parse(Console.ReadLine());

        if (choice <= 0 || choice > 3)
        {
            Console.Clear();
            Console.WriteLine("Invalid choice. Please choose 1-3");
            Console.ReadKey();
        }

    } while (choice <= 0 || choice > 3); // วนซ้ำ จนกว่า ตัวแปร choice จะมีค่าเป็นค่าใดค่าหนึ่ง (1,2,3)
    // ออกจาก do while loop = choice มีค่าแล้ว

    // ถ้า choice เป็น 3
    if (choice == 3)
        return; // จะทำงานถึงแค่บรรทัดนี้ ไม่ทำงานด้านล่าง

    // ถ้า choice ไม่ใช่ 3 จะมาทำงานตรงนี้ต่อ
    searchSystem(file, choice);
}

static void searchSystem(string file, int c)
{
    // สร้างตัวแปรไว้เก็บค่า
    int id;
    string txt;

    /*
        c = 1 ก็คือค้นหา id
        c = 2 ก็คือค้นหา ชื่อ
        เอาไว้ใช้ตรง str[0] , str[1]
    */
    if (c == 1)
    {
        id = 0;
        txt = "ID";
    }
    else
    {
        id = 1;
        txt = "Name";
    }

    Console.Clear();
    Console.Title = "Search Menu";
    Console.WriteLine("Selected File = {0}\n", file);

    Console.Write("Enter {0} to search: ", txt); // เอาตัวแปร txt มาแสดงแค่ตรงนี้
    string search = Console.ReadLine();

    StreamReader streamReader = new StreamReader(file);
    string line = streamReader.ReadLine();
    while (line != null)
    {
        string[] str = line.Split(';'); // แยก string เป็นส่วนๆ
        /*
            str[0] ก็คือค้นหา id
            str[1] ก็คือค้นหา ชื่อ
        */
        if (search == str[id])
        {
            Console.WriteLine("\nID : " + str[0]);
            Console.WriteLine("Name : " + str[1]);
            Console.WriteLine("Price : {0} Baht", str[2]);
        }
        line = streamReader.ReadLine();
    }
    streamReader.Close();

    Console.Write("\nPress any key to continue");
    Console.ReadKey();
}

static bool checkExists(string file, string id, string name)
{
    StreamReader sr = new StreamReader(file);
    string line = sr.ReadLine();
    while (line != null)
    {
        string[] str = line.Split(';'); // แยก string เป็นส่วนๆ

        // เช็คว่า (str[0] หรือ id ในไฟล์) ตรงกับ (id ที่รับมา) ไหม
        // หรือ OR ||
        // เช็คว่า (str[1] หรือ ชื่อ ในไฟล์) ตรงกับ (name ที่รับมา) ไหม
        if (str[0] == id || str[1] == name)
        {
            sr.Close();
            return true;
        }
        line = sr.ReadLine();
    }
    sr.Close();
    return false;
}