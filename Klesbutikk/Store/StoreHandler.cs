﻿using System;
using Klesbutikk.Store;

namespace Klesbutikk.Store
{
    /* Handler for for products, brands, customers and 
    */
    public class StoreHandler
    {
        private PrintHandler printHandler = new PrintHandler();

        public StoreHandler()
        {
            printHandler.Run();
            Main_menu_selection();
        }

        public void Main_menu_selection()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            if(cki.Key == ConsoleKey.D1)
            {
                Search();
            }
            else if(cki.Key == ConsoleKey.D2)
            {
                Mens_products();
            }
            else if(cki.Key == ConsoleKey.D3)
            {
                Womens_products();
            }
            else if(cki.Key == ConsoleKey.D4)
            {
                Childrens_products();
            }
            else if(cki.Key == ConsoleKey.D5)
            {
                Display_shopping_cart();
            }
            else if(cki.Key == ConsoleKey.D6)
            {
                Display_wishlist();
            }
        }

        public void Search_menu_selection()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.D1)
            {
                Search_product_name();
            }
            else if (cki.Key == ConsoleKey.D2)
            {
                Search_brand();
            }
            else if (cki.Key == ConsoleKey.D3)
            {
                Search_article_number();
            }
            else if (cki.Key == ConsoleKey.D4)
            {
                Search_sale();
            }
        }

        private void Search_sale()
        {
            Console.WriteLine(" - Search_sale function was called");
            Search_menu_selection();
        }

        private void Search_article_number()
        {
            Console.WriteLine(" - Search_article_number function was called");
            Search_menu_selection();
        }

        private void Search_brand()
        {
            Console.WriteLine(" - Search_brand function was called");
            Search_menu_selection();
        }

        /* TODO
         * Create a function that searches for a product with the product name.
         * The function should iterate through the list.
         * Create an algorithm that sorts each product by name.
        */
        private void Search_product_name()
        {
            //string product_name = product.GetName();
            Console.WriteLine(" - Search_product_name function was called");
            Search_menu_selection();
        }

        // TODO create wishlist class
        private void Display_wishlist()
        {
            Console.WriteLine("Wishlist button pressed.");
        }

        // TODO create shopping cart
        private void Display_shopping_cart()
        {
            Console.WriteLine("Shopping cart button pressed.");
        }

        // TODO create childrens segmenting
        private void Childrens_products()
        {
            Console.WriteLine("Childrens products button pressed.");
        }

        // TODO create womens segmenting
        private void Womens_products()
        {
            Console.WriteLine("Womens products button pressed.");
        }

        // TODO create mens segmenting
        private void Mens_products()
        {
            Console.WriteLine("Mens products button pressed.");
        }

        // TODO create search function for products
        private void Search()
        {
            Console.WriteLine(" - Search products button pressed.\n");
            Console.WriteLine("Write product name: ");
            printHandler.SearchMenu();
            Search_menu_selection();
        }

        
        public void Add_product_inventory()
        {

        }

        // TODO update product in inventory
        public void Update_product_inventory()
        {

        }

        // TODO remove product from inventory
        public void Remove_product_inventory()
        {

        }
    }
}
