using Creating_API.Models;
using Creating_API.Repositories;

namespace Creating_API.Services;
public class TableServices:ITableRepository
{
    public readonly ApplicationDbContext Context;

    public TableServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<UserAllergy>> GetAll();
    {
        
    }
    public async Task<UserAllergy?> GetById(int id);
    {
        
    }

    public async Task Add(UserAllergy userAllergy);
    {
        
    }
    public async Task Update(UserAllergy userAllergy);
    {
        
    }
    public async Task Delete(int id);
    {
        
    }
    public async Task<bool> CheckExistence(int id);
    {
        
    }
}