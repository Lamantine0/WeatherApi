using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;


namespace WeatherApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetWeather(string city)
        {
           

            using (var httpClient = new HttpClient())
            {
                var irl = $"{baseUrl}?q={city}&appid={apiKey}&units=metric";

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if(response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                  
                }

               

            }

        }


    }
}
