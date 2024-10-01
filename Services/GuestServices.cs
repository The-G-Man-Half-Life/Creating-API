using Creating_API.Models;
using Creating_API.Repositories;

namespace Creating_API.Services;
public class GuestServices:IGuestRepository
{
    public readonly ApplicationDbContext Context;

    public GuestServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }
    public async Task<IEnumerable<Guest>> GetAll();
    {
        
    }
    public async Task<Guest?> GetById(int id);
    {
        
    }

    public async Task Add(Guest guest);
    {
        
    }
    public async Task Update(Guest guest);
    {
        
    }
    public async Task Delete(int id);
    {
        
    }
    public async Task<bool> CheckExistence(int id);
    {
        
    }
}