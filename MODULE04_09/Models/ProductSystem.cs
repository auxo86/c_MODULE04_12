using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODULE04_09.DAL;
using MODULE04_09.ViewModels;

namespace MODULE04_09.Models
{
    public class ProductSystem
    {
        //public Product GetProductByID(int id)
        //{
        //    NorthwindEntities db = new NorthwindEntities();
        //    var query = from p in db.Products
        //                where p.ProductID == id
        //                select p;

        //    //只列第一筆
        //    var result = query.First();

        //    return result;

        //}

        public ProductViewModel GetProductByID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.ProductID == id
                        select new ProductViewModel
                        {
                            ProductID=p.ProductID,
                            ProductName=p.ProductName,
                            UnitPrice=p.UnitPrice
                        };

            //只列第一筆
            var result = query.First();

            return result;
        }

        //public IEnumerable<Product> GetProductsByCategoryID(int id)
        //{
        //    NorthwindEntities db = new NorthwindEntities();
        //    var query = from p in db.Products
        //                where p.CategoryID == id
        //                select p;

        //    var result = query.ToList();
        //    return result;
        //}

        public CategoryProductsViewModel GetProductsByCategoryID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id
                        select new ProductViewModel
                        {
                            ProductID=p.ProductID,
                            ProductName=p.ProductName,
                            UnitPrice=p.UnitPrice
                        };
            CategoryProductsViewModel result = new CategoryProductsViewModel();
            result.CategoryID = id;
            result.CategoryName = db.Categories.Find(id).CategoryName;
            result.Products = query.ToList();

            return result;
        }

    }
}
