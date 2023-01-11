namespace RestaurantReviewsData.Common
{
    public class ValidationException:ApplicationException
    {
        public ValidationException()
        {
            
        }
        public ValidationException(string message):base(message)
        {
            message = "Phone should be only 10 digits";
        }
        public ValidationException(string? message, Exception? innerException):base(message,innerException)
        {}
    }
}