using BusinessAsCode.Concepts;

namespace BusinessAsCode.People
{
    public class Founder: Person
    {
        public bool CanCode { get; set; } = false;
        public string? Vision { get; set; }

        public Founder()
        {
            GetCodingSkills();
            GetVision();
        }

        private void GetCodingSkills()
        {
            Console.WriteLine("Can you write code? (Y/N)");
            var canYouCodeAnswer = Console.ReadLine();
            if (canYouCodeAnswer?.Trim().ToLower() == "y")
            {
                CanCode = true;
            }
        }

        private void GetVision()
        {
            Console.WriteLine("What is your vision?");
            Vision = Console.ReadLine();
        }

        public ProductIdea GetNextProductIdea()
        {
            ProductIdea nextProductIdea = new ProductIdea();
            Console.WriteLine("Describe your idea:");
            nextProductIdea.Description = Console.ReadLine();

            return nextProductIdea;
        }
    }
}
