using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Student
{
    // Private Data Members
    private int studentId;
    private string studentName;
    private int age;
    private string course;
    private string email;
    private string phone;
    private static int admissionCounter = 1000;
    private int admissionNo;

    // Constructor
    public Student(int id, string name, int studentAge, string studentCourse, string studentEmail, string studentPhone)
    {
        studentId = id;
        studentName = name;
        age = studentAge;
        course = studentCourse;
        email = studentEmail;
        phone = studentPhone;
        admissionNo = ++admissionCounter;
    }

    // Method to Display Student Details
    public void DisplayDetails()
    {
        Console.WriteLine("\n====================================");
        Console.WriteLine("     STUDENT ADMISSION DETAILS");
        Console.WriteLine("====================================");
        Console.WriteLine("Admission No : " + admissionNo);
        Console.WriteLine("Student ID   : " + studentId);
        Console.WriteLine("Student Name : " + studentName);
        Console.WriteLine("Age          : " + age);
        Console.WriteLine("Course       : " + course);
        Console.WriteLine("Email        : " + email);
        Console.WriteLine("Phone No.    : " + phone);
        Console.WriteLine("====================================");
    }
}

class StudentAdmManagement
{
    static int ReadInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out value))
                return value;

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("====================================");
        Console.WriteLine(" STUDENT ADMISSION MANAGEMENT SYSTEM");
        Console.WriteLine("====================================");

        int id = ReadInt("Enter Student ID      : ");

        Console.Write("Enter Student Name    : ");
        string name = Console.ReadLine();

        int age = ReadInt("Enter Age             : ");

        Console.Write("Enter Course          : ");
        string course = Console.ReadLine();

        Console.Write("Enter Email           : ");
        string email = Console.ReadLine();

        Console.Write("Enter Phone Number    : ");
        string phone = Console.ReadLine();

        Student s1 = new Student(id, name, age, course, email, phone);

        s1.DisplayDetails();

        Console.WriteLine("\nAdmission Successful!");
        Console.WriteLine("Thank you for registering.");
    }
}