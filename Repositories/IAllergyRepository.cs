using Creating_API.Models;

namespace Creating_API.Repositories;

public interface IAllergyRepository
{
    Task<IEnumerable<Allergy>> GetAll();
    Task<Allergy?> GetById(int id);
    Task Add(Allergy Allergy);
    Task Update(Allergy Allergy);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}