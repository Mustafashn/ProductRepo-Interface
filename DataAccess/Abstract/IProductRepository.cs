using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Abstract {
    public interface IProductRepository:IRepository<Product> {
    Product[] getProductsByCategory(int categoryId);
    
}
}