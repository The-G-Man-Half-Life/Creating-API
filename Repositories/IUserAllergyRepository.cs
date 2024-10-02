using Creating_API.DTOs;
using Creating_API.Models;

namespace Creating_API.Repositories;
public interface IUserAllergyRepository
{
    Task<IEnumerable<UserAllergy>> GetAll();
    Task<UserAllergy?> GetById(int id);
    Task Add(UserAllergyDTO userAllergy,int userId,int AllergyId);
    Task Update(UserAllergyDTO userAllergy,int userId,int AllergyId);
    Task Delete(UserAllergy userAllergy);
}
