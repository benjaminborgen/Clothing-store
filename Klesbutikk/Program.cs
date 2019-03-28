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
            var client = new Client();
            // Start the program
            BrandHandler brandHandler = new BrandHandler();
            
            client.Start();

            //client.Exit();
        }
    }
}
