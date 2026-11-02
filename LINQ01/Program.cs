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



            #region  . Get all products where UnitPrice is between 10 and 30

            //var product = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var item in product)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region  Get all products that are in stock (UnitsInStock > 0) and  belong to the "Condiments" category


            //var product =ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var item in product)
            //{
            //    Console.WriteLine(item);


            #endregion


            #region   Create a new anonymous type with three properties:

            //var product = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock: {item.StockStatus}");

            //}


            #endregion


            #region Print each product's name along with its position (1-based)  in the list. Expected format: 1.Chai, 2.Chang, etc.

            //var ProductName = ProductList.Select((p, i) => $"{i+1}.{p.ProductName}");
            //foreach (var item in ProductName)
            //{
            //    Console.WriteLine(item+", ");
            //}


            #endregion



            #region  Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var product = ProductList.OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var item in product)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


            #region  Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

            //var products = ProductList.Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .Select(p => new { p.ProductName, p.UnitsInStock });

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductName},{item.UnitsInStock}");
            //}


            #endregion


            #region Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.

            //var orders = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new { c.CustomerID, o.OrderDate };

            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"{item.CustomerID}, {item.OrderDate}");
            //}


            #endregion


            #region  Show position number alongside ProductName

            //var ProductName = ProductList.Select((p, i) => new {index = i,name = p.ProductName });
            //foreach (var item in ProductName)
            //{
            //    Console.WriteLine($"{item.index}- {item.name}");
            //}

            #endregion





        }
    }
}
