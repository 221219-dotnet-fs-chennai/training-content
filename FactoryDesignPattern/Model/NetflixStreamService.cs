namespace FactoryDesignPattern.Model
{
    public class NetflixStreamService : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
                "Avatar 2",
                "Inception"
            };
        }
    }
}
