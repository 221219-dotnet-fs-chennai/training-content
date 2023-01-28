using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Data
{
    public class SqlRepo : IRepo<Restaurant>, ISqlRepo //multiple inheritance
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
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                // fire the query
                // for associates - uncomment first
                //string query = "select Id, Name, OpenTime, CloseTime, Zipcode from Training.Restaurants";
                // for trainer
                string query = "select Id, Name, OpenTime, CloseTime, Zipcode from Restaurants";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                // process the output
                while (reader.Read())
                {
                    restaurants.Add(new Restaurant()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        OpenTime = (TimeSpan)reader[2],
                        CloseTime = (TimeSpan)reader[3],
                        ZipCode = reader.GetString(4)
                    }); ;
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return restaurants;
        }

        public async Task<List<Restaurant>> GetAllRestaurantsAsync()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            // establish the connection
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                // fire the query
                // for associates - uncomment first
                //string query = "select Id, Name, OpenTime, CloseTime, Zipcode from Training.Restaurants";
                // for trainer
                string query = "select Id, Name, OpenTime, CloseTime, Zipcode from Restaurants";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = await command.ExecuteReaderAsync();
                // process the output
                while (reader.Read())
                {
                    restaurants.Add(new Restaurant()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        OpenTime =  (TimeSpan)reader[2],
                        CloseTime = (TimeSpan)reader[3],
                        ZipCode = reader.GetString(4)
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return restaurants;
        }


        public List<Restaurant> GetAllRestaurantsDisconnected()
        {
            string query = "select Id, Name, Zipcode from Restaurants";
                using SqlConnection sqlConnection = new SqlConnection(connectionString);
                List<Restaurant> restaurants = new List<Restaurant>();
                using SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);// fill method will get data from the Db and fill into the dataset
               
                DataTable dtRestaurants = ds.Tables[0];// first table is indexed to 0
                foreach (DataRow row in dtRestaurants.Rows)
                {
                    restaurants.Add(new Restaurant()
                    {
                        // we can use the column number starting with 0 to represent which column value are we interested in
                        Id = (int)row[0],
                        //or we can also provide the column name because it is easier to remeber column name; since sql is case - insensitive the case isn't important while you mention te column name
                        Name = (string)row["name"],
                        ZipCode = (string)row["zipcode"]
                    });
                }
            return restaurants ;
        }
    }
}
