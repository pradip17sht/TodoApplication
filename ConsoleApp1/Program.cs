using RestSharp;

namespace ConsoleApp1
{
    public class Program
    {
        public static void  Main(string[] args)
        {
            GetNRBAPIs();
            GetMBLAPIs();

            PublicAPIs();
            GetCatFacts();
            GetPersons();
            GetNationality();
            GetIPAddress();
            GetUsers();

            Console.Read();
        }

        static void GetNRBAPIs()
        {
            var client = new RestClient("https://www.nrb.org.np/api/forex/v1/");
            var request = new RestRequest("rates?per_page=100&page=1&from=2022-05-17&to=2022-05-17");
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);

        }

        static void GetMBLAPIs()
        {
            var client = new RestClient("https://www.machbank.com/page/filter_branch/");
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);
        }

        static void PublicAPIs()
        {
            var client = new RestClient("https://api.publicapis.org/entries");
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);
        }

        static void GetCatFacts()
        {
            var client = new RestClient("https://catfact.ninja/fact");
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);
        }

        static void GetPersons()
        {
            var client = new RestClient("https://api.genderize.io");
            var request = new RestRequest("?name=pradip");
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);
        }

        static void GetNationality()
        {
            var client = new RestClient("https://api.nationalize.io/");
            var request = new RestRequest("?name=Nepali");
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);
        }

        static void GetIPAddress()
        {
            var client = new RestClient("https://api.ipify.org?format=json");
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);
        }

        static void GetUsers()
        {
            var client = new RestClient("https://randomuser.me/api/");
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            Console.WriteLine(response.Content);
        }
    }
}