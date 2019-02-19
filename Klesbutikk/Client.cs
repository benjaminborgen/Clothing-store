using System;
using Klesbutikk.Store;
using Klesbutikk.ProductFactory;
namespace Klesbutikk
{
    public class Client
    {
        public Client()
        {
        }

        public void Start()
        {
            StoreHandler store = new StoreHandler();
        }

        public void Exit()
        {
            Console.WriteLine("Press escape to exit the clothing shop.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            Environment.Exit(0);
        }

    }
}
