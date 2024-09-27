using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.Tables;

[ApiController]
[Route("api/v1/[controller]")]
public class TablesController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public TablesController(ApplicationDbContext context)
    {
        Context = context;
    }
}