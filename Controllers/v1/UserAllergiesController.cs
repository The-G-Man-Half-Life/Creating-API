using Creating_API.DTOs;
using Creating_API.Models;
using Creating_API.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Creating_API.Controllers.v1.UserAllergies;

[ApiController]
[Route("api/v1/[controller]")]
public class UserAllergiesController : ControllerBase
{
    private readonly UserAllergyServices UserAllergyServices;

    public UserAllergiesController(UserAllergyServices UserAllergyServices)
    {
        this.UserAllergyServices = UserAllergyServices;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewUserAllergy([FromBody] UserAllergyDTO userAllergy)
    {
        if (ModelState.IsValid == false)
        {
            return NotFound("Debes hacer un registro valido");
        }
        else
        {
            try
            {
                await UserAllergyServices.Add(userAllergy, userAllergy.UserId, userAllergy.AllergyId);
                return Ok("La alergia fue acoplada exitosament");
            }
            catch (System.Exception)
            {

                return NotFound("Un error ocurrio durante el proceso");
            }
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUserAllergy([FromBody] UserAllergyDTO userAllergy, [FromRoute] int id)
    {
        if (ModelState.IsValid == false)
        {
            return NotFound("Debes hacer un registro valido");
        }
        else if (await UserAllergyServices.CheckExistenceUserAllergy(id) == -1)
        {
            return NotFound("El id no existe en la base de datos");
        }
        else
        {
            try
            {
                await UserAllergyServices.Update(userAllergy, userAllergy.UserId, userAllergy.AllergyId);
                return Ok("El registro se creo exitosamente");
            }
            catch (System.Exception)
            {

                throw new Exception("Un error ocurrio durante el proceso");
            }
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUserAllergies()
    {
        try
        {
            await UserAllergyServices.GetAll();
            return Ok("Se trajo a todos los usuarios");
        }
        catch (System.Exception)
        {

            throw new Exception("Un error ocurrio");
        }
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUserAllergy([FromRoute] int id)
    {
        if (await UserAllergyServices.CheckExistenceUserAllergy(id) == -1)
        {
            return NotFound("No hay elementos con el id proporcionado");

        }
        else
        {
            try
            {
                var user = await UserAllergyServices.GetById(id);
                await UserAllergyServices.Delete(user);
                return Ok("se ha eliminado la alergia");
            }
            catch (System.Exception)
            {

                throw new Exception("hubo un error durante el proceso");
            }
        }

    }

}