using System;
using ConsoleApp.Entity;
using ConsoleApp.DataAccess.Concrete;
namespace ConsoleApp{
class Program{
    static void Main(string [] args) {
        var productDal = new EfProductDal();
        productDal.create(new Product());
    }
}
}



