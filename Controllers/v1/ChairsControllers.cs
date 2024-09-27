using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.Users;

[ApiController]
[Route("api/v1/[controller]")]
public class ChairsController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public ChairsController(ApplicationDbContext context)
    {
        Context = context;
    }
}