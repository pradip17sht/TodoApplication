using RestSharp;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.nrb.org.np/api/forex/v1/rates?per_page=100&page=1&from=2022-05-17&to=2022-05-17";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync(request);
            Console.WriteLine(response.ToString());
            Console.Read();
            Console.WriteLine("Hello World!");
        }
    }
}
