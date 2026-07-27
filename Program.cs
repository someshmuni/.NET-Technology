using System;
namespace practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display menu for selecting employee type
            Console.WriteLine("===== Employee Payroll System =====");
            Console.WriteLine("Select Employee Type");
            Console.WriteLine("1. Full-Time Employee");
            Console.WriteLine("2. Part-Time Employee");
            Console.Write("Enter your choice: ");

            int ch = Convert.ToInt32(Console.ReadLine());

            employee e = null;
            Ipayroll p = null;

            //creating object based on employee choice
            if (ch == 1)
            {
                e = new fulltimeemp();
                p = (Ipayroll)e;
            }
            else if (ch == 2)
            {
                e = new parttimeemp();
                p = (Ipayroll)e;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            e.accdet();
            e.display();
            p.calsal();

            Console.ReadLine();
        }


        //interface for payroll calculation
        interface Ipayroll
        {
            void calsal();
        }
        class employee // parent class
        {
            //public data members
            public int empid;
            public string ename;
            public double bsal;

            //constructor
            public employee()
            {

            }

            //method1 to accept details
            public void accdet()
            {
                Console.Write("Enter Employee ID: ");
                empid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                ename = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                bsal = Convert.ToDouble(Console.ReadLine());
            }

            //method2 to display details
            public void display()
            {
                Console.WriteLine("\n===== Employee Details =====");
                Console.WriteLine("Employee ID     : " + empid);
                Console.WriteLine("Employee Name   : " + ename);
                Console.WriteLine("Basic Salary    : " + bsal);
            }
        }
        class fulltimeemp : employee, Ipayroll //derived class1, interface
        {
            //method to calculate full time employee salary
            public void calsal()
            {
                double da = bsal * 0.10;
                double hra = bsal * 0.15;
                double sa = bsal * 0.05;
                double pf = bsal * 0.20;

                //calculating net salary
                double netsal = (bsal + da + hra + sa) - pf;

                Console.WriteLine("\nEmployee Type   : Full-Time");
                Console.WriteLine("Net Salary      : " + netsal);
            }
        }
        class parttimeemp : employee, Ipayroll //derived class2, interface
        {
            //method to calculate part time employee salary
            public void calsal()
            {
                double netsal = bsal;
                Console.WriteLine("\nEmployee Type   : Part-Time");
                Console.WriteLine("Net Salary      : " + netsal);
            }
        }
    }
}