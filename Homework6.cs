namespace Homework6;

class Program
    {
        static void Main(string[ ] args)
    	    {
                Professor prof1 = new Professor("Alice", "Java",9000);
                Professor prof2 = new Professor("Bob", "Math",8000);

                Student student1 = new Student("Lisa", "Java", 90);
                Student student2 = new Student("Tom", "Math", 80);

                Console.WriteLine("Professor " + prof1.ProfName + " teaches " + prof1.ClassTeach + ", and the salary is: " + prof1.GetSalary());
                Console.WriteLine("Professor " + prof2.ProfName + " teaches " + prof2.ClassTeach + ", and the salary is: " + prof2.GetSalary());

                Console.WriteLine("Student " + student1.StudentName + " enrolls " + student1.ClassEnroll + ", and the grade is: " + student1.GetGrade());
                Console.WriteLine("Student " + student2.StudentName + " enrolls " + student2.ClassEnroll + ", and the grade is: " + student2.GetGrade());

                double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
                Console.WriteLine("The salary difference between Alice and Bob is: " + salaryDifference);

                double totalGrade = student1.GetGrade() + student2.GetGrade();
                Console.WriteLine("The total grade of Lisa and Tom is: " + totalGrade);
        
            }
    }


class Professor
{
// Code for Professor class
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string profName, string classTeach, double salary)
    {
        this.profName = profName;
        this.classTeach = classTeach;
        this.salary = salary;
    }
    
    public string ProfName
    {
        get { return profName; }
        set { profName = value; }
    }

    public string ClassTeach
    {
        get { return classTeach; }
        set { classTeach = value; }
    }

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }

}


class Student
{
// Code for Student class
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string studentName, string classEnroll, double studentGrade)
    {
        this.studentName = studentName;
        this.classEnroll = classEnroll;
        this.studentGrade = studentGrade;
    }

    public string StudentName
    {
        get { return studentName; }
        set { studentName = value; }
    }

    public string ClassEnroll
    {
        get { return classEnroll; }
        set { classEnroll = value; }
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}
