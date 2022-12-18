using BusinessAsCode.Concepts;
using BusinessAsCode.People;

namespace BusinessAsCode.Products
{
    public class Prototype
    {
        public Person? Owner { get; set; }
        public ProductIdea? ProductIdea { get; set; }
        public List<Requirement> Requirements { get; set; } = new List<Requirement>();
    }
}
