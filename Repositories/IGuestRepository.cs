using Creating_API.Models;

namespace Creating_API.Repositories;
public interface IGuestRepository
{
    Task<IEnumerable<Guest>> GetAll();
    Task<Guest?> GetById(int id);
    Task Add(Guest guest);
    Task Update(Guest guest);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
