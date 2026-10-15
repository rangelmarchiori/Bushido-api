using Bushido_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Bushido_api.Data;

public class BushidoDbContext : DbContext
{
    public BushidoDbContext(DbContextOptions<BushidoDbContext> options)
        : base(options) { }

    public DbSet<Aula> Aulas => Set<Aula>();   // cada DbSet = uma tabela
}
