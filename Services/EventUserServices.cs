using Creating_API.Models;
using Creating_API.Repositories;

namespace Creating_API.Services;
public class EventUserServices:IEventUserRepository
{
        public readonly ApplicationDbContext Context;

    public EventUserServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }
    
    public async Task<IEnumerable<EventUser>> GetAll();
    {

    }
    
    public async Task<EventUser?> GetById(int id);
    {

    }
    
    public async Task Add(EventUser eventUser);
    {

    }
    
    public async Task Update(EventUser eventUser);
    {

    }
    
    public async Task Delete(int id);
    {

    }
    
    public async Task<bool> CheckExistence(int id);
    {

    }
}
