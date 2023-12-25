using Microsoft.EntityFrameworkCore;
using Stocknet.Entities;

namespace Stocknet.Data;

public class StoreContext :DbContext
{
    public StoreContext(DbContextOptions options) :base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
}