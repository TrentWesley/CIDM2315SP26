namespace Homework3;
class Program
{
    static void Main(string[ ] args)
    {
        // Code for Q1 Prime number check

        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt32(Console.ReadLine());
        
        bool isPrime = true;

        if (N <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
           }
        }

        if (isPrime)
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is non-prime");
        }

        // Code for Q2 Square pattern

        Console.WriteLine("Assign an int value to N:");
        int N2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N2; i++)
        {
            for (int j = 1; j <= N2; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }


        // Code for Q3 Triagnle pattern

        Console.WriteLine("Assign an int value to N:");
        int N3 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        // Code for Bonus question
    }
}

