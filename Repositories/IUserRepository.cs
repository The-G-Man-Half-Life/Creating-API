using Creating_API.Models;

namespace Creating_API.Repositories;
public interface IUserRepository
{
    Task<IEnumerable<User>> GetAll();
    Task<User?> GetById(int id);
    Task<User> GetByKeyword(string keyword);
    Task Add(User user);
    Task Update(User user );
    Task Delete(int id);
}