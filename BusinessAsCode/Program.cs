using BusinessAsCode;
using BusinessAsCode.People;
using BusinessAsCode.Products;
using BusinessAsCode.Services.BusinessServices;

Founder founder = new Founder();

Business myBusiness = BusinessServices.CreateBusiness(founder);


if (!myBusiness.Products.Any())
{
    Product? startupProduct = BusinessServices.CreateStartupProduct(myBusiness);
    if (startupProduct is not null)
    {
        myBusiness.Products.Add(startupProduct);
    }
}

BusinessServices.RunBusiness(myBusiness);