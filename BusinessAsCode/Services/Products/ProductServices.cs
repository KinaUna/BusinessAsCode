using BusinessAsCode.People;
using BusinessAsCode.Products;

namespace BusinessAsCode.Services.Products
{
    public static class ProductServices
    {
        public static Product CreateProduct(Prototype prototype, Person productOwner)
        {
            Product newProduct = new Product();
            newProduct.ProductOwner = productOwner;
            newProduct.Requirements = prototype.Requirements;
            
            return newProduct;
        }
    }
}
