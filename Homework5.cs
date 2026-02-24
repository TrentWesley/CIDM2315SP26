namespace Homework5;
class Program
{
static void Main(string[ ] args)
    {
       // Call Q1_method()
       Q1_method();

       // Call Q2_method()
       Q2_method();
       
       // Call Q3_method()
       Q3_method();
    }
    // -----------------------------
    // Helper: Read an integer safely
    // -----------------------------
    static int ReadInt(string prompt)
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();
        return int.Parse(input ?? "0");
    }


 // Q1_method
static int LargestOfTwo(int x, int y)
    {
        return(x > y) ? x : y;
    }
static void Q1_method()
    {
        int a = ReadInt("Enter a:");
        int b = ReadInt("Enter b:");

        int max = LargestOfTwo(a, b);

        Console.WriteLine($"a = {a}; b={b}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine();
    }
 // Q2_method11
static void Q2_method()
    {
        int a = ReadInt("Enter a:");
        int b = ReadInt("Enter b:");
        int c = ReadInt("Enter c:");
        int d = ReadInt("Enter b:");

        int max1 = LargestOfTwo(a, b);
        int max2 = LargestOfTwo(c, d);
        int max = LargestOfTwo(max1, max2);

        Console.WriteLine($"a = {a}; b={b}; c = {c}; d={d};");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine();
    }

 // Q3_method
static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;

        if (age >= 18) return true;
        return false;
    }

static void createAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine() ?? "";

        Console.WriteLine("Enter Your Password:");
        string passward1 = Console.ReadLine() ?? "";

        Console.WriteLine("Enter Your Password Again:");
        string passward2 = Console.ReadLine() ?? "";

        int birthyear = ReadInt ("Enter you Birthyear:");
        
        if(checkAge(birthyear))
        {
            if (passward1 == passward2)
                Console.WriteLine("Account is created successfully");
            else
                Console.WriteLine("Wrong password");
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
        
        Console.WriteLine();
    }

    static void Q3_method()
    {
        createAccount();
    }
  }
