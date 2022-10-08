using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIPGoodAndBad
{

    public class ProductService

    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();

            
        }







    }


    public class ProductRepositoryFromSqlServer:IRepository
    {


        public List<string> GetAll()
        {

            return new List<string>() { "SqlServer Kalem 1", "SqlServerKalem 2" };
        }



    }


    public class ProductRepositoryFromOracle : IRepository
    {


        public List<string> GetAll()
        {

            return new List<string>() { "Oracle Kalem 1", "Oracle Kalem 2" };
        }



    }


    public interface  IRepository
    {

        List<string> GetAll();
    }
}