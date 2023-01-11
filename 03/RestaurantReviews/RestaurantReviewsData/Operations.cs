using System.IO;
using System.Text;
namespace RestaurantReviewsData
{
    public class Operations : IOperations
    {
        public void Add(string path)
        {
            StreamWriter sw;
            // This will cxreate a file as per in the path if its not there
            try
            {
                // any statement that can cause exceptions should be put under try block
                sw = new StreamWriter(path, true);
                Restaurant restaurant = new Restaurant();
                sw.WriteLine($"{restaurant.Id} {restaurant.Name} {restaurant.OpenTime}-{restaurant.CloseTime} {restaurant.Phone}");
                sw.Flush();
                sw.Close();
                Console.WriteLine("Restaurant Added");
            }            
            //most specific exception            
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }    
            //least specific exception
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally{
                Console.WriteLine("Finally block");
            }
        }
        public string Get(string path)
        {
            string restaurants=null;
            
            try
            {
                StreamReader reader = new StreamReader(path);
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                restaurants= reader.ReadLine();
                while (restaurants != null)
                {
                    Console.WriteLine(restaurants);
                    restaurants = reader.ReadLine();
                }
                reader.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally{
                Console.WriteLine("Finally block");
            }
            return restaurants;
        }
    }
}