using System;
namespace Klesbutikk.ProductFactory.Miscellaneous
{
    public class Clocks : IProduct
    {
        public Clocks()
        {
        }

        public Clocks(string articleNumeber, string material, string name,
                            double price, bool gender)
        {
            SetArticleNumber(articleNumeber);
            SetMaterial(material);
            SetName(name);
            SetPrice(price);
            SetGender(gender);
        }

        private string _article_number = "";
        private string _material = "";
        private string _name = "";
        private double _price = 0;
        private bool _gender = false;

        private void SetGender(bool gender)
        {
            _gender = gender;
        }

        private void SetPrice(double price)
        {
            _price = price;
        }

        private void SetName(string name)
        {
            _name = name;
        }

        private void SetMaterial(string material)
        {
            _material = material;
        }

        private void SetArticleNumber(string articleNumeber)
        {
            _article_number = articleNumeber;
        }

        public string GetArticleNumber()
        {
            return _article_number;
        }

        public bool GetGender()
        {
            return _gender;
        }

        public string GetMaterial()
        {
            return _material;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
