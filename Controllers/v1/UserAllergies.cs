using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.UserAllergies;

[ApiController]
[Route("api/v1/[controller]")]
public class UserAllergiesController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public UserAllergiesController(ApplicationDbContext context)
    {
        Context = context;
    }
}