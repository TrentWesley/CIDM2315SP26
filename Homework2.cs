namespace Homework2;
class Program
{
    static void Main(string[ ] args)
    {
        // Code for Q1
        Console.WriteLine("Please input a letter grade");
        string gradeInput = Console.ReadLine();
        
        if (gradeInput == "A")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (gradeInput == "B")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (gradeInput == "C")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (gradeInput == "D")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (gradeInput == "F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong letter Grade!");
        }


        // Code for Q2
        Console.WriteLine("Please input the first num:");
        int num1= Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the first num:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the first num:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
        }
        else
        {
             smallest = num3;
        }       
        Console.WriteLine("The smallest value is: " + smallest);
        
        // Code for Bonus question
    }
}

