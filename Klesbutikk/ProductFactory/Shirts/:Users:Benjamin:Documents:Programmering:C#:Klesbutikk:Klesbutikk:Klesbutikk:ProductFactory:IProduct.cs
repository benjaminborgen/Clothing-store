using System;
namespace Klesbutikk.ProductFactory
{
    public interface EmptyInterface
    {
        string GetArticleNumber();
        string GetName();
        string GetMaterial();
        string GetColour();
        double GetPrice();
        bool GetGender(); // 0 = female / 1 = male
    }
}
