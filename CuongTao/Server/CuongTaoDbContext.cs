using Microsoft.EntityFrameworkCore;
using CuongTao.Shared;

namespace CuongTao.Server
{
    public class CuongTaoDbContext : DbContext  
    {
        public CuongTaoDbContext(DbContextOptions<CuongTaoDbContext> options)
          : base(options) { }

        public DbSet<Phone> Phones { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var phoneEntity = modelBuilder.Entity<Phone>();
            phoneEntity.HasKey(phone => phone.Id);
            phoneEntity.Property(phone => phone.Name)
            .HasMaxLength(80);
            phoneEntity.Property(phone => phone.Price)
            .HasColumnType("money");
            phoneEntity.Property(phone => phone.Phonemodel)
            .HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Phones)
            .WithMany(phone => phone.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.Id);
            customerEntity.Property(customer => customer.Name)
            .HasMaxLength(100);
            customerEntity.Property(customer => customer.Street)
            .HasMaxLength(50);
            customerEntity.Property(customer => customer.City)
            .HasMaxLength(50);
        }
    }
}
