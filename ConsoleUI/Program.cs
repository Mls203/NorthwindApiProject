using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


Console.WriteLine("Hello, World!");

//ProductTest();

//CategoryTest();


ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
var result = productManager.GetProductDetail();
if (result.Success==true)
{
    foreach (var productDetail in result.Data)
    {
        Console.WriteLine(productDetail.ProductName);
        Console.WriteLine(productDetail.CategoryName);
    }
   
}
else
{
    Console.WriteLine(result.Message);
}



static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

    foreach (var product in productManager.GetByUnitPrice(50, 100).Data)
    {
        Console.WriteLine(product.ProductName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    Category category = categoryManager.GetById(8).Data;
    Console.WriteLine(category.CategoryName);
}