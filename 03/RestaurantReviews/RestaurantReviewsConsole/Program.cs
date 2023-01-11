using RestaurantReviewsData;
using RestaurantReviewsData.Common;
using System.Text.RegularExpressions;

int a= 10, b=0;
float c=0;
if(b==0){
    throw new ArithmeticException("You must be trying to have 0 as denominator");
}
Console.WriteLine($"{a}/{b}={c}");

/*Restaurant newRestaurant=new Restaurant();
newRestaurant.Id=2;
newRestaurant.Name="Uddipi";
newRestaurant.Email="contactus@uddipi.com";
try{
    newRestaurant.Phone="ghghj";
}

catch(ValidationException exception){
    Console.WriteLine(exception.Message);
    break;
}
string path = "../RestaurantReviewsData/FileStorage/Restaurant.txt";
IOperations opr= new Operations();
opr.Add(path);
//Console.WriteLine(opr.Get(path));
*/