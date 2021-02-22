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
                            
                              "0.....Close Program\n\n");
        }
    }
}
