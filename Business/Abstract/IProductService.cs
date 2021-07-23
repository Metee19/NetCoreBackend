using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
<<<<<<< HEAD
        IResult Update(Product product);
        IDataResult<Product> GetById(int productId);
        IResult AddTransactionalTest(Product product);

=======
        IDataResult<Product> GetById(int productId);
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
    }
}
