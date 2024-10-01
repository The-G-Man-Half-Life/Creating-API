using Creating_API.Models;
using Creating_API.Repositories;

namespace Creating_API.Services;
public class AllergyServices: IAllergyRepository
{
    public readonly ApplicationDbContext Context;

    public AllergyServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    Task<IEnumerable<Allergy>> GetAll();
    {
        
    }
    Task<Allergy?> GetById(int id);
    {
        
    }
    Task Add(Allergy Allergy);
    {
        
    }
    Task Update(Allergy Allergy);
    {
        
    }
    Task Delete(int id);
    {
        
    }
    Task<bool> CheckExistence(int id);
    {
        
    }
}
