using System;
namespace Klesbutikk
{
    public interface IProduct
    {
        string GetArticleNumber();
        string GetName();
        string GetMaterial();
        double GetPrice(); 
        bool GetGender(); // 0 = female / 1 = male
    }
}
