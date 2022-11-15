using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;
using Microsoft.AspNetCore.Hosting;


namespace RazorPagesApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IWebHostEnvironment _environment;

    public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment environment)
    {
        _logger = logger;
        _environment = environment;
    }

    public List<Session> sessionList { get;set; } = default!;
    public void OnGet()
    {
        var wwwPath = _environment.WebRootPath;
        string sessionJsonPath = Path.Combine(_environment.WebRootPath, "data", "session.json");      
        var json = System.IO.File.ReadAllBytes(sessionJsonPath);
        sessionList = System.Text.Json.JsonSerializer.Deserialize<List<Session>>(json);
    }
}
