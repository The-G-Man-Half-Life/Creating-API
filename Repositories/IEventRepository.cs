using Creating_API.Models;

namespace Creating_API.Repositories;
public interface IEventRepository
{
    Task<IEnumerable<Event>> GetAll();
    Task<Event?> GetById(int id);
    Task Add(Event Event);
    Task Update(Event Event);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
