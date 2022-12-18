using BusinessAsCode.Concepts;
using BusinessAsCode.People;
using BusinessAsCode.Products;

namespace BusinessAsCode
{
    public class Business
    {
        public Founder Founder { get; set; } = new Founder();
        public Vision? Vision { get; set; }
        public string? Values { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public List<Developer> Developers { get; set; } = new List<Developer>();
    }
}
