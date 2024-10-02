using Creating_API.DTOs;
using Creating_API.Models;
using Creating_API.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Creating_API.Services;
public class UserAllergyServices: IUserAllergyRepository
{
    public readonly ApplicationDbContext Context;

    public UserAllergyServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<UserAllergy>> GetAll()
    {
        if (Context.UserAllergies.Count()== 0)
        {
            throw new Exception("Ningun usuario tiene alergias");
        }
        else
        {
            try
            {
                return await Context.UserAllergies.ToListAsync();
            }
            catch (System.Exception)
            {
                
                throw new Exception("Un error ocurrio");
            }
        }
    }
    
    public async Task<UserAllergy> GetById(int id)
    {
        if (Context.UserAllergies.Count()== 0)
        {
            throw new Exception("No hay alergia en ningun usuario");
        }
        else if (Context.UserAllergies.LastOrDefaultAsync().Id< id)
        {
            throw new Exception("El Id esta fuera del rango");
        }
        else
        {
            try
            {
                return await Context.UserAllergies.FirstOrDefaultAsync(u=>u.Id==id);

            }
            catch (System.Exception)
            {
                
                throw new Exception("Un error ocurrio durante el proceso");
            }
        }
    }

    public async Task Add(UserAllergyDTO userAllergy,int userId,int AllergyId)
    {
        if (!await Context.Users.AnyAsync(u=>u.Id == userId) || !await Context.Allergies.AnyAsync(a=>a.Id== AllergyId))
        {
            throw new Exception("Debes de colocar valores dentro de los rangos");
        }
        else
        {
            try
            {
                await Context.UserAllergies.AddAsync(userAllergy);
                await Context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                
                throw new Exception("Un error ocurrio durante el proceso");
            }
        }
    }
    public async Task Update(UserAllergyDTO userAllergy,int userId,int AllergyId)
    {
        if (!await Context.Users.AnyAsync(u=>u.Id == userId) || !await Context.Allergies.AnyAsync(u=>u.Id == AllergyId))
        {
            throw new Exception("Los valores no existen");
        }
        else
        {
            try
            {
                Context.UserAllergies.Update(userAllergy);
                await Context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                
                throw new Exception("Un error ocurrio durante el proceso");
            }
        }
    }
    public async Task Delete(UserAllergy userAllergy)
    {
            try
            {
                Context.UserAllergies.Remove(userAllergy);
                await Context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                
                throw new Exception("Un error ocurrio durante el proceso");
            }
    }
    public async Task<int> CheckExistenceUserAllergy(int id)
    {
        if(await Context.UserAllergies.AnyAsync(u=>u.Id==id) == false)
        {return -1;}
        else
        {
            var user = await Context.UserAllergies.FirstOrDefaultAsync(u=>u.Id == id);
            return user.Id;
        }
    }
}
