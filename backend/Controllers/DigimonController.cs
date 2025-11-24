using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DigimonController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("https://digimon-api.vercel.app/api/digimon");

            return Content(json, "application/json");
        }
    }
}
