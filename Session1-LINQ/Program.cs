using static LINQ.DataSources.Source;

namespace Session1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            //1. Get all products from the "Seafood" category. Print each product's name and price.
            //var seafoodProducts = ProductList.Where(p=>p.Category == "Seafood");

            //foreach (var product in seafoodProducts)
            //{
            //    Console.WriteLine($"Name:{product.ProductName}, Price:{product.UnitPrice}");
            //}


            //Question 2
            //2. Get a list of only the product names from ProductList. Print each name.
            //var productNames = ProductList.Select(p=>p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

        }
    }
}
