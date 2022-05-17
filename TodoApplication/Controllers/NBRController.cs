using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoApplication.Model;

namespace TodoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NBRController : ControllerBase
    {
        string BaseUrl = "https://www.nrb.org.np/api/forex/v1/";

        public async Task<IActionResult> Index()
        {
            NBR nbr = new NBR();

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BaseUrl);
                httpClient.DefaultRequestHeaders.Clear();
                HttpResponseMessage response = await httpClient.GetAsync("rates?per_page=100&page=1&from=2022-05-17&to=2022-05-17");
                if (response.IsSuccessStatusCode)
                {
                    var nbrResponse = await response.Content.ReadAsStringAsync();
                    nbr = JsonConvert.DeserializeObject<NBR>(nbrResponse);
                }
                return Ok(nbr);
            }
        }
    }
}
