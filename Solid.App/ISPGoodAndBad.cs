using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.ISPGoodAndBad
{

    // Class Library  Read Impl
    // Class Library  Create/Update/Delete Impl

    public class Product{

        public int Id { get; set; }
        public string Name { get; set; }
    }
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);

        Product Create(Product p);
        Product Update(Product p);
        Product Delete(Product p);



    }


}
