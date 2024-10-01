using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creating_API.Models;

namespace Creating_API.Repositories;
public interface IEventUserRepository
{
    Task<IEnumerable<EventUser>> GetAll();
    Task<EventUser?> GetById(int id);
    Task Add(EventUser eventUser);
    Task Update(EventUser eventUser);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
