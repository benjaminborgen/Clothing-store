using System;
namespace Klesbutikk.ProductFactory.Footwear
{
    public class OpenShoe : IProduct
    {
        public OpenShoe()
        {
        }

        public OpenShoe(string articleNumeber, string material, string name,
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
        private int _discount = 0;

        public int GetDiscount()
        {
            return _discount;
        }

        public void SetDiscount(int discount)
        {
            _discount = discount;
        }


        public void SetGender(bool gender)
        {
            _gender = gender;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public void SetArticleNumber(string articleNumeber)
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
