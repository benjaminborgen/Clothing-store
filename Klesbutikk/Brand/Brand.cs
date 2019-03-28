using System;
namespace Klesbutikk.Brand
{
    public class Brand : IBrand
    {
        string _name;
        string _brand_number;
        string _country;



        public string Name { get => _name; set => _name = value; }
        public string Brand_number { get => _brand_number; set => _brand_number = value; }
        public string Country { get => _country; set => _country = value; }

        public Brand(string name, string brand_number, string country)
        {
            Name = name;
            Brand_number = brand_number;
            Country = country;
        }

        public Brand()
        {

        }

        /* Print a random brand from enumerated list.
        */


        public string GetBrandNumber()
        {
            return Brand_number;
        }

        public string GetCountry()
        {
            return Country;
        }

        public string GetName()
        {
            return Name;
        }




    }
}
