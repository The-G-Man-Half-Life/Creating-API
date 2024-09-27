using Creating_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Creating_API.Models;

public class ApplicationDbContext: DbContext
{
    public DbSet<Allergy> Allergies {get; set;}
    public DbSet<Event> Events {get; set;}
    public DbSet<EventUser> EventUsers {get; set;}
    public DbSet<Guest> Guests {get; set;}
    public DbSet<User> Users {get; set;}
    public DbSet<UserAllergy> UserAllergies {get; set;}


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}