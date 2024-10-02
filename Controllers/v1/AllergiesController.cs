using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Creating_API.Controllers.v1.Allergies;

[ApiController]
[Route("api/v1/[controller]")]
public class AllergiesController : ControllerBase
{
    private readonly ApplicationDbContext Context;

    public AllergiesController(ApplicationDbContext context)
    {
        Context = context;
    }

// [HttpPost]
// public async Task<IActionResult> CreateAllergies([FromBody]Allergy newAllergy)
// {

// }


// [HttpGet]
// public async Task<IActionResult> GetAllAllergies()
// {

// }


// [HttpPut("{id}")]
// public async Task<IActionResult> UpdateAllergy([FromRoute] int id, [FromBody] Allergy updatedAllergy)
// {



// [HttpDelete("{id}")]

// public async Task<IActionResult> DeleteAllergy([FromRoute] int id)
// {

// }

// private bool CheckExistence(int id)
// {

// }
}


