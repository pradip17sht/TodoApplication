using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoApplication.Model;

namespace TodoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MBLController : ControllerBase
    {
        public async Task<IActionResult> Index()
        {
            MBL mbl = new MBL();

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://www.machbank.com/page/filter_branch/");
                httpClient.DefaultRequestHeaders.Clear();
                HttpResponseMessage response = await httpClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var mblResponse = await response.Content.ReadAsStringAsync();
                    mbl = JsonConvert.DeserializeObject<MBL>(mblResponse);
                }
                return Ok(mbl);
            }
        }
    }
}
