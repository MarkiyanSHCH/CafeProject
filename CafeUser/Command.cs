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

        public void addEmployee()
        {
            Console.WriteLine("Enter first name: ");
            string firstNameTmp = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastNameTmp = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            short ageTmp = Convert.ToInt16(Console.ReadLine());
            short starsTmp = 0;
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



        
    }
}
