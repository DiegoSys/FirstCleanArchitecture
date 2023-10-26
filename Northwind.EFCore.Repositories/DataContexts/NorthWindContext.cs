namespace NorthWind.EFCore.Repositories.DataContexts
{

    //Add-Migration InitialCreate -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -c NorthWindContext
    //Update-Database -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -context NorthWindContext
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local); Database=NorthWind; User Id=sa; Password=sa; Encrypt=False; TrustServerCertificate=True");
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
