using Creating_API.Models;

namespace Creating_API.Repositories;
public interface IChairRepository
{
    Task<IEnumerable<Chair>> GetAll();
    Task<Chair?> GetById(int id);
    Task Add(Chair chair);
    Task Update(Chair chair);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}