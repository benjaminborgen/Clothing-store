using System;
namespace Klesbutikk.Brand
{
    public class BrandHandler
    {


        Brand brand;
        Array values = Enum.GetValues(typeof(EBrand));
        Random random;

        public BrandHandler()
        {
            NewBrand();
            RandomBrand();
        }

        public void NewBrand()
        {
            brand = new Brand();
            brand.Name = "test";
            brand.Brand_number = "123456";
            brand.Country = "Norway";
        }

        public EBrand RandomBrand()
        {
            random = new Random();
            EBrand randomEnum = (EBrand)values.GetValue(random.Next(values.Length));
            Console.WriteLine(randomEnum);
            return randomEnum;
        }
    }
}
