using System;
namespace CafeAdmin
{
    public class Menu
    {
        public void showMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome to the MainMenu for Admin! \n" +
                              "\t\tSelect an option from the following: \n" +
                              "1.....Show Customers\n" +
                              "2.....Show Employee\n" +
                              "5.....Show Driver\n" +
                              "3.....Analyse\n" +
                              "4.....Setting\n" +
                              "0.....Close Program\n\n");
        }

        public void showFirstMenuSetting()
        {


            Console.Clear();
            Console.WriteLine("\t\t\t SETTING \n " +
                              "\t\tSelect an option from the following: \n" +
                              "1.....Customer\n" +
                              "2.....Employee\n" +
                              "3.....Driver\n" +
                              "0.....Exit\n\n");

        }

        public void showCustomerSetting()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t Customer \n " +
                              "\t\tSelect an option from the following: \n" +
                              "1.....Add Customer\n" +
                              "2.....Delete Customer\n" +
                              "3.....Edit Name\n" +
                              "4.....Edit Address\n" +
                              "5.....Add Bonus\n" +
                              "0.....Exit\n\n");

        }

        public void showEmployeeSetting()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t Employee \n " +
                              "\t\tSelect an option from the following: \n" +
                              "1.....Add Employee\n" +
                              "2.....Delete Employee\n" +
                              "3.....Edit Name\n" +
                              "4.....Set Rating\n" +
                              "0.....Exit\n\n");
        }

        public void showDriverSetting()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t Driver \n " +
                              "\t\tSelect an option from the following: \n" +
                              "1.....Add Driver\n" +
                              "2.....Delete Driver\n" +
                              "3.....Edit Name\n" +
                              "4.....Set Rating\n" +
                              "0.....Exit\n\n");

        }
    }
}
