using Creating_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody]User newUser)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest(ModelState);
        }
        else
        {
            var newUser_ = new User{
                Name = newUser.Name,
                LastName = newUser.LastName,
                Email = newUser.Email,
                KeyWord = newUser.KeyWord,
                PhoneNumber = newUser.PhoneNumber,
                BirthDate = newUser.BirthDate,
                DrinksAlcohol = newUser.DrinksAlcohol,
                HasAllergy = newUser.HasAllergy
            };

            Context.Users.Add(newUser_);
            await Context.SaveChangesAsync();
            return Ok("The user was created");
        }
    }

    [HttpGet]
    public async Task<IActionResult> BringAllUsers()
    {
        var users =await Context.Users.ToListAsync();

        if(users.Count() ==0)
        {
            return NoContent();
        }
        else
        {
            return Ok(users);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser([FromRoute] int id, [FromBody] User updatedUser)
    {
        if(CheckExistence(id) == false)
        {
            return NoContent();
        }
        else if(ModelState.IsValid == false)
        {
            return BadRequest(ModelState);
        }
        else 
        {
            Context.Entry(updatedUser).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return Ok("updated");
        }
    }

    private bool CheckExistence(int id)
    {
        return Context.Users.Any(u=>u.Id == id);
    }
}