using Creating_API.Models;

namespace Creating_API.Repositories;
public interface IUserAllergyRepository
{
    Task<IEnumerable<UserAllergy>> GetAll();
    Task<UserAllergy?> GetById(int id);
    Task Add(UserAllergy userAllergy);
    Task Update(UserAllergy userAllergy);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
