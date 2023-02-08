namespace FactoryDesignPattern.Model
{
    public class StreamFactory
    {
        public IStreamService GetStreamService(string userchoice)
        {
            if(userchoice=="netflix")
            {
                return new NetflixStreamService();
            }
            else if(userchoice=="amazon")
            {
                return new AmazonStreamServices();
            }
            else
            {
                return new NoStreaming();
            }
        }
    }
}
