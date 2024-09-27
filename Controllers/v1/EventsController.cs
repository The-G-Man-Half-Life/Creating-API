using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.Events;
[ApiController]
[Route("api/v1/[controller]")]
public class EventsController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public EventsController(ApplicationDbContext context)
    {
        Context = context;
    }
}
