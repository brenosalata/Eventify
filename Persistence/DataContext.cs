using System.Data;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Event> Events { get; set; }
}
