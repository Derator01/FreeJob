using FreeJob.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FreeJob.Server.Controllers;


[ApiController]
[Route("[controller]")]
public class JobOffersController : ControllerBase
{
    private static readonly List<Job> Jobs = new();

    private readonly ILogger<JobOffersController> _logger;

    public JobOffersController(ILogger<JobOffersController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Job> Get()
    {
        return new Job[] { new Job("hello", "smth", 100, 1, false) };
    }

    [HttpPost]
    public bool Post()
    {
        return true;
    }
}