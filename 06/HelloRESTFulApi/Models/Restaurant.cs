namespace HelloRESTFulApi.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Cuisine { get; set; }
        public string Zipcode { get; set; }

        public override string ToString()
        {
            return $"Id - {Id}\nName - {Name}\nCuisine - {Cuisine}\nZipcode - {Zipcode}";
        }
    }
}
