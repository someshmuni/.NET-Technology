using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expensetracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            List<expense> expenses = new List<expense>();

            do
            {
                // Console.Clear();   // Removed so previous output remains visible

                Console.WriteLine("=================================================");
                Console.WriteLine("             EXPENSE TRACKER MODULE              ");
                Console.WriteLine("=================================================");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View All Expenses");
                Console.WriteLine("3. View Total Expense");
                Console.WriteLine("4. Exit");
                Console.WriteLine("=================================================");

                try
                {
                    Console.Write("Enter your choice : ");
                    ch = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    switch (ch)
                    {
                        case 1:
                            {
                                try
                                {
                                    expense e = new expense();

                                    Console.WriteLine("----------- ADD NEW EXPENSE -----------");
                                    e.accDetails();
                                    expenses.Add(e);

                                    Console.WriteLine();
                                    Console.WriteLine("Expense added successfully.");
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error : Please enter the valid numeric value.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error : " + ex.Message);
                                }
                                finally
                                {
                                    Console.WriteLine("Expense processing completed.");
                                }
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("============== ALL EXPENSES ==============");

                                if (expenses.Count == 0)
                                    Console.WriteLine("No expenses found.");
                                else
                                {
                                    foreach (expense e in expenses)
                                        e.disDet();
                                }
                                break;
                            }

                        case 3:
                            {
                                double t = 0;

                                foreach (expense e in expenses)
                                    t = t + e.amt;

                                Console.WriteLine("=========================================");
                                Console.WriteLine("Total Expense = Rs. " + t);
                                Console.WriteLine("=========================================");
                                break;
                            }

                        case 4:
                            {
                                Console.WriteLine("=========================================");
                                Console.WriteLine("Thank You For Using This Expense Tracker");
                                Console.WriteLine("=========================================");
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Invalid Choice.");
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error : Please enter a valid menu choice.");
                    ch = 0;
                }

                if (ch != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (ch != 4);
        }

        class expense
        {
            public int expId;
            public string category;
            public double amt;
            public string paymentmode;
            public DateTime expDate;

            //Method-1 To accept expense details
            public void accDetails()
            {
                Console.Write("Enter Expense ID            : ");
                expId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Expense Category      : ");
                category = Console.ReadLine();

                Console.Write("Enter Expense Amount        : ");
                amt = Convert.ToDouble(Console.ReadLine());

                if (amt <= 0)
                {
                    throw new Exception("Expense must be more than Zero");
                }

                Console.Write("Enter Payment Mode (Cash/UPI/Card) : ");
                paymentmode = Console.ReadLine();

                expDate = DateTime.Now;
            }

            //Method-2 To display expense details
            public void disDet()
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Expense ID       : " + expId);
                Console.WriteLine("Category         : " + category);
                Console.WriteLine("Amount           : Rs. " + amt);
                Console.WriteLine("Payment Mode     : " + paymentmode);
                Console.WriteLine("Date             : " + expDate);
                Console.WriteLine("=========================================");
                Console.WriteLine();
            }
        }
    }
}