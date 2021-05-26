using Microsoft.EntityFrameworkCore;
namespace CRMDemoApp.ORM
{
    public class CollectionContext:DbContext{

    public DbSet<Customer> Customers {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=localhost; database=ecommerce; user=root; password='Priya@2811'";
        optionsBuilder.UseMySQL(conString);

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Customer>(entity => 
        {
          entity.HasKey(e => e.Id);
          entity.Property(e => e.Name).IsRequired();
          entity.Property(e => e.Location).IsRequired();
          entity.Property(e => e.Age).IsRequired();
          entity.Property(e => e.ContactNumber).IsRequired();
          entity.Property(e => e.Email).IsRequired();
        });
    }
    }

}