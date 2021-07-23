using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{   //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
           // ProductTest();
            //CategoryTest();
        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

<<<<<<< HEAD
        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    var result = productManager.GetProductDetails();
        //    if (result.Success == true) { 
        //        foreach (var product in productManager.GetProductDetails().Data)
        //    {
        //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        //    }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Messsage);
        //    }
        //}
=======
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true) { 
                foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
            }
            else
            {
                Console.WriteLine(result.Messsage);
            }
        }
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
    }
}
