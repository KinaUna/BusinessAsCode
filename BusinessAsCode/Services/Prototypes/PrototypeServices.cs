using BusinessAsCode.Concepts;
using BusinessAsCode.People;
using BusinessAsCode.Products;

namespace BusinessAsCode.Services.Prototypes
{
    public static class PrototypeServices
    {
        public static Prototype CreatePrototype(ProductIdea idea, Person productOwner)
        {
            Prototype newPrototype = new Prototype();
            newPrototype.ProductIdea = idea;
            newPrototype.Owner = productOwner;
            
            // Todo: Assign developer(s).
            // Todo: Add requirements.
            // Todo: Create product plan.
            return newPrototype;
        }

    }
}
