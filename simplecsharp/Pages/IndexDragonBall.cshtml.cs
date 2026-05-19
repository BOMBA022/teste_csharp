using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using simplecsharp.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace simplecsharp.Pages;

public class IndexDragonBall : PageModel

{
    private readonly IHttpClientFactory _httpClientFactory;

    public IndexDragonBall(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public List<DragonBall> DragonBalls { get; set; } = new();

    public async Task OnGetAsync()
    {
        var client = _httpClientFactory.CreateClient("RestDragonBall");
        var response = await client.GetAsync("/api/characters?race=Saiyan&affiliation=Zr");

        if (response.IsSuccessStatusCode)

        {
            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var dados = JsonSerializer.Deserialize<List<dragonballApiResponse>>(json, options);

            DragonBalls = dados.Select(d => new DragonBall
            {
                Id = d.id,
                Name = d.Name,
                ImageUrl = d.image?.png
            }).ToList();
        }
    }
    /*

private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
*/

}