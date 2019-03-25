using System;
namespace Klesbutikk.Brand
{
    public class Brand : IBrand
    {
        string _name { 
            get { return _name; }
            set { _name = ""; 
            }
        }

        string _brand_number = "";
        string _country = "";

        Array values = Enum.GetValues(typeof(EBrand));
        Random random = new Random();

        public Brand()
        {

        }

        public void RandomBrand()
        {
            EBrand randomEnum = (EBrand)values.GetValue(random.Next(0, values.Length));
            Console.WriteLine(randomEnum);
        }

        public string GetBrandNumber()
        {
            throw new NotImplementedException();
        }

        public string GetCountry()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }




    }
}
