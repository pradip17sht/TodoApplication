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
            //List<NBR> nbr = new List<NBR>();

            /*using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BaseUrl);
                httpClient.DefaultRequestHeaders.Clear();
                HttpResponseMessage response = await httpClient.GetAsync("api/NBR/GetAll");
                if (response.IsSuccessStatusCode)
                {
                    var nbrResponse = await response.Content.ReadAsStringAsync();
                    nbr = JsonConvert.DeserializeObject<List<NBR>>(nbrResponse);
                }
                return Ok(nbr);
            }*/
            return Ok();
        }
    }
}
