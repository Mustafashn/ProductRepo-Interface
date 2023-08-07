
using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        public void create(Product entity)
        {
            Console.WriteLine("Product create");
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product getById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] getProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}