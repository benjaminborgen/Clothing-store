using System;
namespace Klesbutikk.Store
{
    public class PrintHandler
    {
        public PrintHandler()
        {
            
        }

        public void Run()
        {
            Introduction();
            Menu();
        }

        public void Introduction()
        {
            Console.Clear();
            Console.WriteLine("Welcome a to fictional command based clothing shop.");
            Print_spacing();
        }

        public void Menu()
        {
            Console.WriteLine("Press the key of the action you'd like to explore:");
            Console.WriteLine("1 - Search");
            Console.WriteLine("2 - Men");
            Console.WriteLine("3 - Women");
            Console.WriteLine("4 - Children");
            Console.WriteLine("5 - Shopping cart");
            Console.WriteLine("6 - Wish list\n");
        }

        public void SearchMenu()
        {
            Console.WriteLine("Press the number key of the command:");
            Console.WriteLine("1 - Search product name");
            Console.WriteLine("2 - Search brand");
            Console.WriteLine("3 - Search Article number");
            Console.WriteLine("4 - Search sale\n");
        }


        public void Print_spacing()
        {
            Console.WriteLine("\n/*******************************/\n");
        }
    }
}
