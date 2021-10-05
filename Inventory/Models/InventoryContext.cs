using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Item> Records { get; set; }

    public InventoryContext(DbContextOptions options) : base(options) { }
  }
}