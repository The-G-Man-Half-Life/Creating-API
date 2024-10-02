using Creating_API.Models;
using Creating_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Creating_API.Controllers.v1.Users;

[ApiController]
[Route("api/v1/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserServices? userServices;

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody]User newUser)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest(ModelState);
        }
        else
        {
            var NewUser = new User{
                Name = newUser.Name,
                LastName = newUser.LastName,
                Email = newUser.Email,
                KeyWord = newUser.KeyWord,
                PhoneNumber = newUser.PhoneNumber,
                BirthDate = newUser.BirthDate,
                DrinksAlcohol = newUser.DrinksAlcohol,
                HasAllergy = newUser.HasAllergy
            };
            await userServices.Add(NewUser);
            return Ok("The user was created");
        }
    }

    [HttpGet]
    public async Task<IActionResult> BringAllUsers()
    {
        try
        {
            await userServices.GetAll();
            return Ok("Success");
        }
        catch (System.Exception)
        {
            
            throw new Exception("Un error ocurrio durante el proceso");
        }

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser([FromBody] User updatedUser,[FromRoute] int id)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest(ModelState);
        }
        else if(await userServices.CheckExistenceUser(id) == -1)
        {
            return BadRequest("El id no existe en la base de datos");
        }
        else 
        {
            await userServices.Update(updatedUser);
            return Ok("actualizado");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser([FromRoute] int id)
    {
        if (await userServices.CheckExistenceUser(id)==-1)
        {
            return BadRequest("El id no existe en la base de datos");
        }
        else
        {
            await userServices.Delete(id);
            return Ok("The user was deleted");
        }
            
    }
}