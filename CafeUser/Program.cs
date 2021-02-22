using System;
using CafeLib.Models;
using CafeLib.Repository.TXT;

namespace CafeAdmin
{
    class Program
    {
        static void Main(string[] args)
        {

            menu();
            void menu()
            {
                Menu prog = new Menu();
                Command com = new Command();

                short userInput = 0;
                while (true)
                {
                    prog.showMenu();
                    userInput = Convert.ToInt16(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            {
                                if (com.customerRepository.Data.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("No Customer\n\nEnter some button to continue.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    com.showCustomer();
                                    Console.WriteLine("\nEnter some button to continue.");
                                    Console.ReadLine();
                                }
                                break;

                            }
                        case 2:
                            {
                                if (com.employeeRepository.Data.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("No Employee\n\nEnter some button to continue.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    com.showEmployee();
                                    Console.WriteLine("\nEnter some button to continue.");
                                    Console.ReadLine();
                                }
                                break;
                            }
                        
                        case 0:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        case 3:
                            {
                                com.analyse();
                                break;
                            }
                        case 5:
                            {
                                if (com.driverRepository.Data.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("No Driver\n\nEnter some button to continue.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    com.showDriver();
                                    Console.WriteLine("\nEnter some button to continue.");
                                    Console.ReadLine();
                                }
                                break;
                            }
                        default:
                            Console.Error.WriteLine("Error: wrong operation");
                            Console.WriteLine("\nEnter some button to continue.");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
