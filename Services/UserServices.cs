using Creating_API.Models;
using Creating_API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Creating_API.Services;
public class UserServices : IUserRepository
{
    public readonly ApplicationDbContext Context;

    public UserServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        if (Context.Users.Count() == 0)
        {
            throw new Exception("no hay usuarios");
        }
        else
        {
            try
            {
                return await Context.Users.ToListAsync();
            }
            catch (System.Exception)
            {

                throw new Exception("un error ocurrio al traer los usuarios");
            }
        }

    }
    public async Task<User> GetById(int id)
    {
        try
        {
            return await Context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
        catch (System.Exception)
        {

            throw new Exception("Un error ocurrio");
        }
    }
    public async Task<User> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            throw new ArgumentNullException(nameof(keyword), "la palabra clave no puede ser nulo.");
        }
        else
        {
            try
            {
                return await Context.Users.FirstOrDefaultAsync(u => u.KeyWord == keyword);
            }
            catch (System.Exception)
            {

                throw new Exception("un error ocurrio vuelva a intentarlo");
            }
        }


    }
    public async Task Add(User user)
    {
        if (user == null)
        {
            throw new ArgumentNullException(nameof(user), "El usuario no puede ser nulo.");
        }

        try
        {
            await Context.Users.AddAsync(user);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Error al agregar el usuario a la base de datos.", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al agregar el usuario.", ex);
        }
    }
    public async Task Update(User user)
    {
        try
        {
            Context.Users.Update(user);
            await Context.SaveChangesAsync();
        }
        catch (System.Exception)
        {

            throw new Exception("Un error ocurrio durante el proceso");
        }
    }
    public async Task Delete(int id)
    {
        try
        {
            var userFound = await Context.Users.FirstOrDefaultAsync(u => u.Id == id);
            Context.Users.Remove(userFound);
            await Context.SaveChangesAsync();
        }
        catch (System.Exception)
        {

            throw new Exception("The user was not ");
        }
    }

}