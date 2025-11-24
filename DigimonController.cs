using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CharactersController : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var http = new HttpClient();
        var url = $"https://digi-api.com/api/v1/digimon/{id}";

        var response = await http.GetAsync(url);
        if (!response.IsSuccessStatusCode)
            return BadRequest("Error obteniendo datos");

        var json = await response.Content.ReadAsStringAsync();
        return Content(json, "application/json");
    }
}