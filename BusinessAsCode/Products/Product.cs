using BusinessAsCode.People;

namespace BusinessAsCode.Products
{
    public class Product
    {
        public Person? ProductOwner { get; set; }

        public List<Requirement> Requirements { get; set; } = new List<Requirement>();

    }
}
