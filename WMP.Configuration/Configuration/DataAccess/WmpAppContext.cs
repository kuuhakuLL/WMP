using Microsoft.EntityFrameworkCore;

namespace WMP.Configuration.Configuration.DataAccess; 

public class WmpAppContext : DbContext {
    protected WmpAppContext(!!!!!) {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseNpgsql();
    }
}