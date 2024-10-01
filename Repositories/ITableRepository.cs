using Creating_API.Models;

namespace Creating_API.Repositories;
public interface ITableRepository
{
    Task<IEnumerable<Table>> GetAll();
    Task<Table?> GetById(int id);
    Task Add(Table table);
    Task Update(Table table);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
