using Backend_intro;
using Microsoft.EntityFrameworkCore;

namespace API;

public class BackendContext : DbContext
{
    public BackendContext(DbContextOptions<BackendContext> options) : base(options) {}

    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Addresses { get; set; }
}