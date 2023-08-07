using ConsoleApp.DataAccess.Abstract;
using ConsoleApp.Entity;

namespace ConsoleApp.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public void create(Category entity)
        {
            Console.WriteLine("Category created");
        }

        public void delete(int id)
        {
            Console.WriteLine("Category Delete");
        }

        public Category getById(int id)

        {
            Console.WriteLine("Category getById");

            return new Category();
        }

        public Category[] GetCategories()
        {
            Console.WriteLine("Categories get");

            return new Category[3];
        }

        public void update(Category entity)
        {
            Console.WriteLine("Category Update");
        }
    }
}