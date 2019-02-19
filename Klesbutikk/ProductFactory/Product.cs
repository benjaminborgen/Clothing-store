using System;
using Klesbutikk.ProductFactory;
using Klesbutikk.ProductFactory.Footwear;
using Klesbutikk.ProductFactory.Jackets;
using Klesbutikk.ProductFactory.Miscellaneous;
using Klesbutikk.ProductFactory.Pants;
using Klesbutikk.ProductFactory.Shirts;
using Klesbutikk.ProductFactory.Sweaters;
using Klesbutikk.ProductFactory.Tshirts;
namespace Klesbutikk.ProductFactory
{
    public class Product
    {
        public static Random rnd;
        int category = 0;

        public Product()
        {

        }

        public void CreateProduct()
        {

        }

        public void CreateRandomProduct()
        {
            randomCategory();
        }

        public void randomCategory()
        {
            rnd = new Random();
            category = rnd.Next(1, 8);
            if (category == 1)
            {
                Console.WriteLine("Random footwear #{0}", category);
                RandomFootwear();
            } else if (category == 2)
            {
                Console.WriteLine("Random jacket #{0}", category);
                RandomJacket();
            }
            else if (category == 3)
            {
                Console.WriteLine("Random miscellaneous #{0}", category);
                RandomMiscellaneous();
            }
            else if (category == 4)
            {
                Console.WriteLine("Random pants #{0}", category);
                RandomPants();
            }
            else if (category == 5)
            {
                Console.WriteLine("Random shirt #{0}", category);
                RandomShirt();
            }
            else if (category == 6)
            {
                Console.WriteLine("Random sweater #{0}", category);
                RandomSweaters();
            }
            else if (category == 7)
            {
                Console.WriteLine("Random T-shirt #{0}", category);
                RandomTShirt();
            }
        }

        public void new_footwear_product(int _footwear_category)
        {
            _footwear_category = 0;
            _footwear_category = rnd.Next(1, 5);

            if (_footwear_category == 1)
            {
                DressShoe dressShoe = new DressShoe();
            }
            else if (_footwear_category == 2)
            {
                FlatShoe flatshoe = new FlatShoe();
            }
            else if (_footwear_category == 3)
            {
                OpenShoe openShoe = new OpenShoe();
            }
            else if (_footwear_category == 4)
            {
                Sneakers sneakers = new Sneakers();
            }
        }

        public void new_jacket_product(int _jacket_category)
        {
            _jacket_category = 0;
            _jacket_category = rnd.Next(1, 5);

            if (_jacket_category == 1)
            {
                Casual casual = new Casual();
            }
            else if (_jacket_category == 2)
            {
                DressJackets dressJackets = new DressJackets();
            }
            else if (_jacket_category == 3)
            {
                Leather leather = new Leather();
            }
            else if (_jacket_category == 4)
            {
                Winter winter = new Winter();
            }
        }

        public void new_miscellaneous_product(int _miscellaneous_category)
        {
            _miscellaneous_category = 0;
            _miscellaneous_category = rnd.Next(1, 5);

            if (_miscellaneous_category == 1)
            {
                Backpack backpack = new Backpack();
                if (backpack != null)
                {
                    Console.WriteLine("Backpack created.");
                }
            }
            else if (_miscellaneous_category == 2)
            {
                Bags bags = new Bags();
                if (bags != null)
                {
                    Console.WriteLine("Bag created.");
                }
            }
            else if (_miscellaneous_category == 3)
            {
                Clocks clocks = new Clocks();
                if (clocks != null)
                {
                    Console.WriteLine("Clock created.");
                }
            }
            else if (_miscellaneous_category == 4)
            {
                Jewelry jewelry = new Jewelry();
                if (jewelry != null)
                {
                    Console.WriteLine("Jewelry created.");
                }
            }
        }

        public void new_pants_product(int _pants_category)
        {
            _pants_category = 0;
            _pants_category = rnd.Next(1, 5);

            if (_pants_category == 1)
            {
                Cargo cargo = new Cargo();
            }
            else if (_pants_category == 2)
            {
                Chinos chinos = new Chinos();
            }
            else if (_pants_category == 3)
            {
                Denim denim = new Denim();
            }
            else if (_pants_category == 4)
            {
                Trousers trousers = new Trousers();
            }
        }

        public void new_shirt_product(int _shirts_category)
        {
            _shirts_category = 0;
            _shirts_category = rnd.Next(1, 3);

            if (_shirts_category == 1)
            {
                CasualShirts casualShirts = new CasualShirts();
            }
            else if (_shirts_category == 2)
            {
                FineShirts fineShirts = new FineShirts();
            }
        }

        public void new_sweaters_product(int _sweater_category)
        {
            _sweater_category = 0;
            _sweater_category = rnd.Next(1, 4);

            if (_sweater_category == 1)
            {
                Cardigan cardigan = new Cardigan();
            }
            else if (_sweater_category == 2)
            {
                Knitted knitted = new Knitted();
            }
            else if (_sweater_category == 3)
            {
                Sweatshirt sweatshirt = new Sweatshirt();
            }
        }

        public void new_TShirt_product(int _tShirt_category)
        {
            _tShirt_category = 0;
            _tShirt_category = rnd.Next(1, 4);

            if (_tShirt_category == 1)
            {
                BasicT basicT = new BasicT();
            }
            else if (_tShirt_category == 2)
            {
                Longsleeve longsleeve = new Longsleeve();
            }
            else if (_tShirt_category == 3)
            {
                PrintedT printedT = new PrintedT();
            }
        }

        public void RandomFootwear()
        {
            int _footwear_category = 0;
            _footwear_category = rnd.Next(1, 5);

            if(_footwear_category == 1)
            {
                DressShoe dressShoe = new DressShoe();
            } else if(_footwear_category == 2)
            {
                FlatShoe flatshoe = new FlatShoe();
            } else if(_footwear_category == 3)
            {
                OpenShoe openShoe = new OpenShoe();
            } else if(_footwear_category == 4)
            {
                Sneakers sneakers = new Sneakers();
            }
        }

        public void RandomJacket()
        {
            int _jacket_category = 0;
            _jacket_category = rnd.Next(1, 5);

            if (_jacket_category == 1)
            {
                Casual casual = new Casual();
            }
            else if (_jacket_category == 2)
            {
                DressJackets dressJackets = new DressJackets();
            }
            else if (_jacket_category == 3)
            {
                Leather leather = new Leather();
            }
            else if (_jacket_category == 4)
            {
                Winter winter = new Winter();
            }
        }

        public void RandomMiscellaneous()
        {
            int _miscellaneous_category = 0;
            _miscellaneous_category = rnd.Next(1, 5);

            if (_miscellaneous_category == 1)
            {
                Backpack backpack = new Backpack();
                if (backpack != null)
                {
                    Console.WriteLine("Backpack created.");
                }
            }
            else if (_miscellaneous_category == 2)
            {
                Bags bags = new Bags();
                if (bags != null)
                {
                    Console.WriteLine("Bag created.");
                }
            }
            else if (_miscellaneous_category == 3)
            {
                Clocks clocks = new Clocks();
                if (clocks != null)
                {
                    Console.WriteLine("Clock created.");
                }
            }
            else if (_miscellaneous_category == 4)
            {
                Jewelry jewelry = new Jewelry();
                if (jewelry != null)
                {
                    Console.WriteLine("Jewelry created.");
                }
            }
        }

        public void RandomPants()
        {
            int _pants_category = 0;
            _pants_category = rnd.Next(1, 5);

            if (_pants_category == 1)
            {
                Cargo cargo = new Cargo();
            }
            else if (_pants_category == 2)
            {
                Chinos chinos = new Chinos();
            }
            else if (_pants_category == 3)
            {
                Denim denim = new Denim();
            }
            else if (_pants_category == 4)
            {
                Trousers trousers = new Trousers();
            }
        }

        public void RandomShirt()
        {
            int _shirts_category = 0;
            _shirts_category = rnd.Next(1, 3);

            if (_shirts_category == 1)
            {
                CasualShirts casualShirts = new CasualShirts();
            }
            else if (_shirts_category == 2)
            {
                FineShirts fineShirts = new FineShirts();
            }
        }

        public void RandomSweaters()
        {
            int _sweater_category = 0;
            _sweater_category = rnd.Next(1, 4);

            if (_sweater_category == 1)
            {
                Cardigan cardigan = new Cardigan();
            }
            else if (_sweater_category == 2)
            {
                Knitted knitted = new Knitted();
            }
            else if (_sweater_category == 3)
            {
                Sweatshirt sweatshirt = new Sweatshirt();
            }
        }

        public void RandomTShirt()
        {
            int _tShirt_category = 0;
            _tShirt_category = rnd.Next(1, 4);

            if (_tShirt_category == 1)
            {
                BasicT basicT = new BasicT();
            }
            else if (_tShirt_category == 2)
            {
                Longsleeve longsleeve = new Longsleeve();
            }
            else if (_tShirt_category == 3)
            {
                PrintedT printedT = new PrintedT();
            }
        }
    }
}
