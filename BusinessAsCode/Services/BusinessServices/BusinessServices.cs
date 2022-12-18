using BusinessAsCode.Concepts;
using BusinessAsCode.People;
using BusinessAsCode.Products;
using BusinessAsCode.Services.Products;
using BusinessAsCode.Services.Prototypes;

namespace BusinessAsCode.Services.BusinessServices
{
    public static class BusinessServices
    {
        public static Business CreateBusiness(Founder founder)
        {
            Business newBusiness = new Business();
            newBusiness.Founder = founder;
            newBusiness.Vision = new Vision(founder.Vision);
            Console.WriteLine("What is your business' values?");
            newBusiness.Values = Console.ReadLine();
            return newBusiness;
        }

        public static Product? CreateStartupProduct(Business business)
        {
            Prototype? startupProtoType = null;
            Product? startupProduct = null;

            // Get an idea.
            ProductIdea startupProductIdea = business.Founder.GetNextProductIdea();

            // Validate idea.
            if (startupProductIdea.Validate())
            {
                // Create a prototype.
                Prototype nextPrototype = PrototypeServices.CreatePrototype(startupProductIdea, business.Founder);

                // Todo: Test prototype.
                startupProtoType = nextPrototype;
            }


            //  Create a new product from the prototype.
            if (startupProtoType is not null)
            {
                Product nextProduct = ProductServices.CreateProduct(startupProtoType, business.Founder);

                // Todo: Add product management/planning.
                startupProduct = nextProduct;
            }

            return startupProduct;
        }

        public static void RunBusiness(Business business)
        {
            // Todo: Daily operations.
            throw new NotImplementedException();
        }
    }
}
