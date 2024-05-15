using System;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("John Doe", "123 Main St", "Computer Science", 2, 5000.0);
        Student student2 = new Student("Jane Smith", "456 Elm St", "Biology", 3, 6000.0);
        Student student3 = new Student("My Name", "My Address", "My Program", 1, 4000.0);

        Staff staff1 = new Staff("Dr. Johnson", "789 Oak St", "University of ABC", 80000.0);
        Staff staff2 = new Staff("Dr. Thompson", "321 Pine St", "University of DEF", 90000.0);

        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());
        Console.WriteLine(student3.ToString());
        Console.WriteLine(staff1.ToString());
        Console.WriteLine(staff2.ToString());
    }
}