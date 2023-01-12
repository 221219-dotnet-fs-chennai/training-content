using System.Data.SqlClient;

namespace Data
{
    public class SqlRepo : IRepo
    {
        private static readonly string connectionString = "<your connection string >";
        public Restaurant Add(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            // establish the connection
            SqlConnection con=new SqlConnection(connectionString);
            con.Open();
            // fire the query
            string query = "select Id, Name, OpenTime, CloseTime, Zipcode from Restaurants";
            SqlCommand command = new SqlCommand(query, con);
            // execute it
            SqlDataReader reader=command.ExecuteReader();
            // process the output
            while (reader.Read())
            {
                restaurants.Add(new Restaurant()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    OpenTime = reader[2].ToString(),
                    CloseTime = reader[3].ToString(),
                    ZipCode = reader.GetString(4)
                }); ;
            }
            return restaurants;
        }
    }
}
