using System;
using Klesbutikk.Brand;
using Klesbutikk.Store;
using Klesbutikk.ProductFactory;
namespace Klesbutikk
{
    /*
     * Initialize the program
    */
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            // Start the program
            Brand brand = new Brand();
            client.Start();

            //client.Exit();
        }
    }
}
