using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.Guests;

[ApiController]
[Route("api/v1/[controller]")]
public class GuestsController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public GuestsController(ApplicationDbContext context)
    {
        Context = context;
    }
}