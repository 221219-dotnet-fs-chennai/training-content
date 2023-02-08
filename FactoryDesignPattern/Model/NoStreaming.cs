namespace FactoryDesignPattern.Model
{
    public class NoStreaming : IStreamService
    {
        public string[] ShowMovies()
        {

            return new string[]
            {
                "No new movies streaming",
                "Rent movies at Rs.150"
            };
        }
    }
}
