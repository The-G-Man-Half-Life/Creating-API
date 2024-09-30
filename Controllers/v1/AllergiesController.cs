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

[HttpPost]
public async Task<IActionResult> CreateAllergies([FromBody]Allergy newAllergy)
{
    if(ModelState.IsValid == false)
    {
        return BadRequest(ModelState);
    }
    var newAllergy1 = new Allergy{
        Name = newAllergy.Name
    };
    Context.Allergies.Add(newAllergy1);
    await Context.SaveChangesAsync();
    return Ok("The Allergy was cretated");
}


[HttpGet]
public async Task<IActionResult> GetAllAllergies()
{
    var Allergies = await Context.Allergies.ToListAsync();

    if(Allergies.Count() == 0)
    {
        return NoContent();
    }
    else
    {
        return Ok(Allergies);
    }
}


[HttpPut("{id}")]
public async Task<IActionResult> UpdateAllergy([FromRoute] int id, [FromBody] Allergy updatedAllergy)
{
    var Existence = CheckExistence(id);

    if(Existence == false)
    {
        return NoContent();
    }
    updatedAllergy.Id = id;
    if(ModelState.IsValid == false)
    {
        return BadRequest(ModelState);
    }
    Context.Entry(updatedAllergy).State = EntityState.Modified;
    await Context.SaveChangesAsync();
    return Ok("updated");
}


[HttpDelete("{id}")]

public async Task<IActionResult> DeleteAllergy([FromRoute] int id)
{
    var Existence = CheckExistence(id);
    if (Existence == false)
    {
        return NoContent();
    }
    var allergyUbication = await Context.Allergies.FirstOrDefaultAsync(at => at.Id == id);
    Context.Allergies.Remove(allergyUbication);
    await Context.SaveChangesAsync();

    return Ok("The Allergy was erased succesfully");
}

private bool CheckExistence(int id)
{
    return Context.Allergies.Any(A=>A.Id == id);
}
}


