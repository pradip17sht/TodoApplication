using RestSharp;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new RestClient("https://www.nrb.org.np/api/forex/v1/");
            //var client = new RestClient("https://www.machbank.com/page/filter_branch/");
            //var client = new RestClient("https://jsonplaceholder.typicode.com/posts/1");

            var request = new RestRequest("rates?per_page=100&page=1&from=2022-05-17&to=2022-05-17");
            //var request = new RestRequest();

            var response = client.GetAsync(request).Result; 
            
            Console.WriteLine(response.Content);

            Console.Read();
        }
    }
}