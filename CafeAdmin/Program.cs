using System;
using System.Xml;
using CafeLib.Models;
using CafeLib.Repository.TXT;

namespace CafeAdmin
{
    class Program
    {
        static Menu prog = new Menu();
        static Command com = new Command();

        static void menu()
        {
           
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
                    case 4:
                        {
                            prog.showFirstMenuSetting();
                            short i = 0;
                            while (true)
                            {
                                i = Convert.ToInt16(Console.ReadLine());
                                if (i == 0)
                                {
                                    menu();
                                    break;
                                }
                                switch (i)
                                {
                                    case 1:
                                        {
                                            short tmp = 0;
                                            while (true)
                                            {
                                                prog.showCustomerSetting();
                                                tmp = Convert.ToInt16(Console.ReadLine());
                                                if (tmp == 0)
                                                {
                                                    prog.showFirstMenuSetting();
                                                    break;
                                                }
                                                switch (tmp)
                                                {
                                                    case 1:
                                                        {
                                                            Console.Clear();
                                                            com.addCustomer();
                                                            Console.WriteLine("Customer Added Successfully\n\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            com.showCustomer();
                                                            Console.WriteLine("Select Customer you want delete : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.deleteCustomer(Convert.ToInt16(selCustomer - 1));
                                                            Console.WriteLine("Customer Deleted Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            com.showCustomer();
                                                            Console.WriteLine("Select Customer you want edit : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.settingCust(selCustomer - 1);
                                                           //com.customerRepository.WriteToStorage();
                                                            Console.WriteLine("Customer Edited Successfully"); ;
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;

                                                        }
                                                    case 4:
                                                        {
                                                            com.showCustomer();
                                                            Console.WriteLine("Select Customer you want edit address : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.changeAddress(selCustomer - 1);
                                                            //com.customerRepository.WriteToStorage();
                                                            Console.WriteLine("Customer Edited Successfully"); ;
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            com.showCustomer();
                                                            Console.WriteLine("Select Customer you want add bonus : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.customerRepository.Data[selCustomer - 1].addBonus();
                                                            //com.customerRepository.WriteToStorage();
                                                            Console.WriteLine("Bonus Added Successfully"); ;
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    default:
                                                        Console.Error.WriteLine("Error: wrong operation");
                                                        Console.WriteLine("\nEnter some button to continue.");
                                                        Console.ReadLine();
                                                        break;
                                                }
                                            }
                                            break;
                                        }
                                    case 2:
                                        {

                                            short tmp = 0;
                                            while (true)
                                            {
                                                prog.showEmployeeSetting();
                                                tmp = Convert.ToInt16(Console.ReadLine());
                                                if (tmp == 0)
                                                {
                                                    prog.showFirstMenuSetting();
                                                    break;
                                                }
                                                switch (tmp)
                                                {
                                                    case 1:
                                                        {
                                                            Console.Clear();
                                                            com.addEmployee();
                                                            Console.WriteLine("Employee Added Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            com.showEmployee();
                                                            Console.WriteLine("Select Employee you want delete : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.deleteEmployee(Convert.ToInt16(selCustomer - 1));
                                                            Console.WriteLine("Employee Edited Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            com.showEmployee();
                                                            Console.WriteLine("Select Employee you want edit : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.settingEmp(selCustomer - 1);
                                                            //com.employeeRepository.WriteToStorage();
                                                            Console.WriteLine("Employee Edited Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;

                                                        }
                                                    case 4:
                                                        {
                                                            com.showEmployee();
                                                            Console.WriteLine("Select Employee you want edit Rating : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.setRating(selCustomer - 1);
                                                            //com.employeeRepository.WriteToStorage();
                                                            Console.WriteLine("Rating Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    default:
                                                        Console.Error.WriteLine("Error: wrong operation");
                                                        Console.WriteLine("\nEnter some button to continue.");
                                                        Console.ReadLine();
                                                        break;
                                                }
                                            }

                                            break;
                                        }
                                    case 3:
                                        {

                                            short tmp = 0;
                                            while (true)
                                            {
                                                prog.showDriverSetting();
                                                tmp = Convert.ToInt16(Console.ReadLine());
                                                if (tmp == 0)
                                                {
                                                    prog.showFirstMenuSetting();
                                                    break;
                                                }
                                                switch (tmp)
                                                {
                                                    case 1:
                                                        {
                                                            Console.Clear();
                                                            com.addDriver();
                                                            Console.WriteLine("Driver Added Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            com.showDriver();
                                                            Console.WriteLine("Select Driver you want delete : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.deleteDriver(Convert.ToInt16(selCustomer - 1));
                                                            Console.WriteLine("Driver Deleted Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            com.showDriver();
                                                            Console.WriteLine("Select Driver you want edit : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.settingDriv(selCustomer - 1);
                                                           // com.driverRepository.WriteToStorage();
                                                            Console.WriteLine("Driver Edited Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;

                                                        }
                                                    case 4:
                                                        {
                                                            com.showDriver();
                                                            Console.WriteLine("Select Driver you want edit Rating : ");
                                                            short selCustomer;
                                                            selCustomer = Convert.ToInt16(Console.ReadLine());
                                                            com.setRating1(selCustomer - 1);
                                                           // com.driverRepository.WriteToStorage();
                                                            Console.WriteLine("Rating Successfully");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    default:
                                                        Console.Error.WriteLine("Error: wrong operation");
                                                        Console.WriteLine("\nEnter some button to continue.");
                                                        Console.ReadLine();
                                                        break;
                                                }
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



        static void Main(string[] args)
        {
            try
            {
               
                menu();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex);
                Console.ReadKey();
            }

            
        }
    }
}
