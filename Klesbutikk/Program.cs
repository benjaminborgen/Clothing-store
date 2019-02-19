using System;
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
            client.Start();

            //client.Exit();
        }
    }
}
