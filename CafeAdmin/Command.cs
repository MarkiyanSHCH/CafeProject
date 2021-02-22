using System;
using CafeLib.Models;
using CafeLib.Repository;
using CafeLib.Repository.TXT;

namespace CafeAdmin
{
    public class Command
    {
        public IRepository<Employee> employeeRepository = new EmployeeRep();
        public IRepository<Driver> driverRepository = new DriverRep();
        public IRepository<Customer> customerRepository = new CustomerRep();

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void addEmployee()
        {
            string firstNameTmp;
            string lastNameTmp;
            short ageTmp;
            short starsTmp = 0;

            Console.WriteLine("Enter first name: ");
            firstNameTmp = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            lastNameTmp = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            ageTmp = Convert.ToInt16(Console.ReadLine());
            var tmp = new Employee(firstNameTmp, lastNameTmp, ageTmp, starsTmp);

            employeeRepository.Add(tmp);
        }

        public void addCustomer()
        {
            string firstNameTmp;
            string lastNameTmp;
            short ageTmp;
            string addressTmp;
            short bonusTmp = 0;

            Console.WriteLine("Enter first name: ");
            firstNameTmp = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            lastNameTmp = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            ageTmp = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter address: ");
            addressTmp = Console.ReadLine();
            var tmp = new Customer(firstNameTmp, lastNameTmp, ageTmp, addressTmp, bonusTmp);

            customerRepository.Add(tmp);
        }

        public void addDriver()
        {
            string firstNameTmp;
            string lastNameTmp;
            short ageTmp;
            short starsTmp = 0;
            string car;

            Console.WriteLine("Enter first name: ");
            firstNameTmp = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            lastNameTmp = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            ageTmp = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter car: ");
            car = Console.ReadLine();
            var tmp = new Driver(firstNameTmp, lastNameTmp, ageTmp, starsTmp, car);

            driverRepository.Add(tmp);
        }

        public void deleteEmployee(short ind)
        {
            employeeRepository.Remove(ind);
        }

        public void deleteCustomer(short ind)
        {
            customerRepository.Remove(ind);
        }

        public void deleteDriver(short ind)
        {
            driverRepository.Remove(ind);
        }


        public void showEmployee()
        {
            Console.Clear();
            for (var i = 0; i < employeeRepository.Data.Count; i++)
            {
                Console.WriteLine($"{i + 1}.\n");
                Console.WriteLine(employeeRepository.Data[i].ToString());
            }
        }

        public void showCustomer()
        {
            Console.Clear();
            for (var i = 0; i < customerRepository.Data.Count; i++)
            {
                Console.WriteLine($"{i + 1}.\n");
                Console.WriteLine(customerRepository.Data[i].ToString());
                
            }
        }

        public void showDriver()
        {
            Console.Clear();
            for (var i = 0; i < driverRepository.Data.Count; i++)
            {
                Console.WriteLine($"{i + 1}.\n");
                Console.WriteLine(driverRepository.Data[i].ToString());
                
            }
        }

        public void analyse()
        {
            Console.Clear();
            int max = employeeRepository.Data[0].stars;
            int index = 0;
            for (int i = 0; i < employeeRepository.Data.Count; i++)
            {
                if (employeeRepository.Data[i].stars > max)
                {
                    max = employeeRepository.Data[i].stars;
                    index = i;
                }
            }

            Console.WriteLine("\t\t\tTop Employee : \n\n");
            Console.WriteLine(employeeRepository.Data[index].ToString());

            Console.WriteLine("\nEnter some button to continue.");
            Console.ReadLine();
        }



        public void settingEmp(int i)
        {
            char op;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"1. Change first name;\t({employeeRepository.Data[i].firstName})\n" +
                                  $"2. Change last name;\t({employeeRepository.Data[i].lastName})\n" +
                                  $"3. Change age.\t({employeeRepository.Data[i].age})\n" +
                                  $"4. Exit");
                op = Convert.ToChar(Console.ReadLine());
                if (op == '4')
                {
                    break;
                }
                switch (op)
                {
                    case '1':
                        {
                            Console.WriteLine($"First name : {employeeRepository.Data[i].firstName}\n");
                            string tmp;
                            Console.WriteLine("Enter new first name : ");
                            tmp = Console.ReadLine();
                            employeeRepository.Data[i].firstName = tmp;
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine($"Last name : {employeeRepository.Data[i].lastName}\n");
                            string tmp;
                            Console.WriteLine("Enter new Last name : ");
                            tmp = Console.ReadLine();
                            employeeRepository.Data[i].lastName = tmp;
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine($"Age : {employeeRepository.Data[i].age}\n");
                            short tmp;
                            while (true)
                            {
                                Console.WriteLine("Enter new age : ");
                                tmp = Convert.ToInt16(Console.ReadLine());
                                if (tmp > 0)
                                {
                                    break;
                                }
                                Console.Error.WriteLine("Error: Wrong age\n");
                            }
                            employeeRepository.Data[i].age = tmp;
                            break;
                        }
                    default:
                        {
                            Console.Error.WriteLine("Error: wrong operation\n");

                            Console.ReadKey();//write "Enter to continue
                            break;
                        }
                }
            }
        }

        public void settingCust(int i)
        {
            char op;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"1. Change first name;\t({customerRepository.Data[i].firstName})\n" +
                                  $"2. Change last name;\t({customerRepository.Data[i].lastName})\n" +
                                  $"3. Change age.\t({customerRepository.Data[i].age})\n" +
                                  $"4. Exit");
                op = Convert.ToChar(Console.ReadLine());
                if (op == '4')
                {
                    break;
                }
                switch (op)
                {
                    case '1':
                        {
                            Console.WriteLine($"First name : {customerRepository.Data[i].firstName}\n");
                            string tmp;
                            Console.WriteLine("Enter new first name : ");
                            tmp = Console.ReadLine();
                            customerRepository.Data[i].firstName = tmp;
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine($"Last name : {customerRepository.Data[i].lastName}\n");
                            string tmp;
                            Console.WriteLine("Enter new Last name : ");
                            tmp = Console.ReadLine();
                            customerRepository.Data[i].lastName = tmp;
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine($"Age : {customerRepository.Data[i].age}\n");
                            short tmp;
                            while (true)
                            {
                                Console.WriteLine("Enter new age : ");
                                tmp = Convert.ToInt16(Console.ReadLine());
                                if (tmp > 0)
                                {
                                    break;
                                }
                                Console.Error.WriteLine("Error: Wrong age\n");
                            }
                            customerRepository.Data[i].age = tmp;
                            break;
                        }
                    default:
                        {
                            Console.Error.WriteLine("Error: wrong operation\n");

                            Console.ReadKey();//write "Enter to continue
                            break;
                        }
                }
            }
        }

        public void settingDriv(int i)
        {
            char op;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"1. Change first name;\t({driverRepository.Data[i].firstName})\n" +
                                  $"2. Change last name;\t({driverRepository.Data[i].lastName})\n" +
                                  $"3. Change age.\t({driverRepository.Data[i].age})\n" +
                                  $"4. Exit");
                op = Convert.ToChar(Console.ReadLine());
                if (op == '4')
                {
                    break;
                }
                switch (op)
                {
                    case '1':
                        {
                            Console.WriteLine($"First name : {driverRepository.Data[i].firstName}\n");
                            string tmp;
                            Console.WriteLine("Enter new first name : ");
                            tmp = Console.ReadLine();
                            driverRepository.Data[i].firstName = tmp;
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine($"Last name : {driverRepository.Data[i].lastName}\n");
                            string tmp;
                            Console.WriteLine("Enter new Last name : ");
                            tmp = Console.ReadLine();
                            driverRepository.Data[i].lastName = tmp;
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine($"Age : {driverRepository.Data[i].age}\n");
                            short tmp;
                            while (true)
                            {
                                Console.WriteLine("Enter new age : ");
                                tmp = Convert.ToInt16(Console.ReadLine());
                                if (tmp > 0)
                                {
                                    break;
                                }
                                Console.Error.WriteLine("Error: Wrong age\n");
                            }
                            driverRepository.Data[i].age = tmp;
                            break;
                        }
                    default:
                        {
                            Console.Error.WriteLine("Error: wrong operation\n");

                            Console.ReadKey();//write "Enter to continue
                            break;
                        }
                }
            }
        }

        public void setRating(int i)
        {
            Console.WriteLine("You can set from 1 to 5\n");
            employeeRepository.Data[i].stars = Convert.ToInt16(Console.ReadLine());
            if (employeeRepository.Data[i].stars < 0 || employeeRepository.Data[i].stars > 5)
            {
                throw new Exception("Error: Enter wrong rating");
            }
        }

        public void setRating1(int i)
        {
            Console.WriteLine("You can set from 1 to 5\n");
            driverRepository.Data[i].stars = Convert.ToInt16(Console.ReadLine());
            if (driverRepository.Data[i].stars < 0 || driverRepository.Data[i].stars > 5)
            {
                throw new Exception("Error: Enter wrong rating");
            }
        }

        public void changeAddress(int i)
        {
            Console.Clear();
            Console.WriteLine($"Address : {customerRepository.Data[i].address}\n");
            string tmp;
            Console.WriteLine("Enter new address : ");
            tmp = Console.ReadLine();
            customerRepository.Data[i].address = tmp;
            Console.WriteLine($"New address : {customerRepository.Data[i].address}\n");
        }
    }
}
