using Creating_API.Models;
using Creating_API.Repositories;

namespace Creating_API.Services;
public class ChairServices:IChairRepository
{
    public readonly ApplicationDbContext Context;

    public ChairServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }
    public async Task<IEnumerable<Chair>> GetAll();
    {

    }
    public async Task<Chair?> GetById(int id);
    {

    }
    public async Task Add(Chair chair);
    {

    }
    public async Task Update(Chair chair);
    {

    }
    public async Task Delete(int id);
    {

    }
    public async Task<bool> CheckExistence(int id);
    {

    }
}
