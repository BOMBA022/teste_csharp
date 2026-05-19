using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class InfoDragonBallModel : PageModel

    {
        private readonly IHttpClientFactory _httpClientFactory;

        public InfoDragonBallModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    }
}