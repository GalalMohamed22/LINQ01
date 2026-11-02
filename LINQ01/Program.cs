using LINQ.Models;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using static LINQ.DataSources.Source;

namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Get all products from the "Seafood" category. Print each  product's name and price

            //var product = from p in ProductList
            //              where p.Category == "Seafood"
            //              select new { p.ProductName, p.UnitPrice };

            //foreach (var item in product)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region  Get a list of only the product names from ProductList. Print  each name. 

            //var product = ProductList.Select(p => p.ProductName);
            //foreach (var item in product)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Sort all products by UnitPrice (ascending). Print each  product's name and price.

            //var product = ProductList.OrderBy(p=>p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var item in product)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion



        }
    }
}
