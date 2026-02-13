namespace Homework4;
class Program
{
    static void Main(string[ ] args)
    {
       // Call Q1_method()
       Q1_method();

       // Call Q2_method()
       Q2_method();
    }


// Q1_method
static void Q1_method()
    {
        
    Console.Write("Enter the first number: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"a = {a}; b={b}");

    int largest = LargestNumber(a, b);

    Console.WriteLine($"The largest number is: {largest}");
    }

    static int LargestNumber(int num1, int num2)
        {
            if (num1 >= num2)
                return num1;
            else
                return num2;
        }





 //Q2_methods
 static void Q2_method()
    {
        Console.Write("Enter N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter shape (left or right): ");
        string shape = Console.ReadLine().ToLower();

        Console.WriteLine($"N is: {N}; shape is {shape}");

        if (shape == "left")
        {
        for (int i = 1; i <= N; i++)

            {
            for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");    
                }  
                Console.WriteLine();   
            }
        }
        else if (shape == "right")
        {
        for (int i = 1; i <= N; i++)
            {
            for (int s = 1; s <= N - i; s++)
            {
                Console.Write(" ");    
                }
            
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");        
                }

                Console.WriteLine();
            }  
        }
        else
        {
            Console.WriteLine("Invalid shape entered.");      
        }
    }
}


