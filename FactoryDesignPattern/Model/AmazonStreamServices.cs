namespace FactoryDesignPattern.Model
{
    public class AmazonStreamServices : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "Wakanda forever",
                "Veera simha reddy",
                "Master"
            };
        }
    }
}
