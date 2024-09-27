using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.Users;

[ApiController]
[Route("api/v1/[controller]")]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public UsersController(ApplicationDbContext context)
    {
        Context = context;
    }
}