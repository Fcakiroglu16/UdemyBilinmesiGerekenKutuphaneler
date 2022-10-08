using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.ISPGoodAndBad
{

    //1. Class Library  Read Impl
    //1. Class Library  Create/Update/Delete Impl


    // 1. Class Library
    public class ReadPRoductRepository : IReadRepository
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }

    // 2. Class Library
    public class WritePoductRepository : IWriteRepository
    {
        public Product Create(Product p)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product p)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product p)
        {
            throw new NotImplementedException();
        }
    }


    public class Product{

        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Bad way
    //public interface IProductRepository
    //{
    //    List<Product> GetList();
    //    Product GetById(int id);

    //    Product Create(Product p);
    //    Product Update(Product p);
    //    Product Delete(Product p);



    //}

    public interface IReadRepository
    {
        List<Product> GetList();
        Product GetById(int id);
    }
    public interface IWriteRepository
    {
        Product Create(Product p);
        Product Update(Product p);
        Product Delete(Product p);
    }

}
