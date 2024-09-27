using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.EventUsers;

[ApiController]
[Route("api/v1/[controller]")]
public class EventUsersController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public EventUsersController(ApplicationDbContext context)
    {
        Context = context;
    }
}
