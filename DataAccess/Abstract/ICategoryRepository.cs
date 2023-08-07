using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Abstract {
    public interface ICategoryRepository:IRepository<Category> {
    Category[] GetCategories();
}
}