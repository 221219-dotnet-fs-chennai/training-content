using System.Data.SqlClient;

namespace Data
{
    public class SqlRepo : IRepo
    {
        private readonly string connectionString;
        public SqlRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Restaurant Add(Restaurant restaurant)
        {
            string query = @"insert into restaurants (Name, ZipCode)  values (@name, @zipcode)";
            using SqlConnection con=new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@name", restaurant.Name);
            sqlCommand.Parameters.AddWithValue("@zipcode",restaurant.ZipCode);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            return restaurant;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            // establish the connection
            using SqlConnection con=new SqlConnection(connectionString);
            con.Open();
            // fire the query
            // for associates - uncomment first
            //string query = "select Id, Name, OpenTime, CloseTime, Zipcode from Training.Restaurants";
            // for trainer
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
