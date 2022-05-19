using RestSharp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://www.nrb.org.np/api/forex/v1/");
            var request = new RestRequest("rates?per_page=100&page=1&from=2022-05-17&to=2022-05-17");
            var response = client.GetAsync(request).Result;       
            Console.WriteLine(response.Content);

            Console.Read();
        }
    }
}