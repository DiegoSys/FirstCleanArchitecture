namespace NorthWind.EFCore.Repositories.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.ProductId }).IsClustered(false);

            builder.Property(x => x.UnitPrice).HasPrecision(8, 2);

        }
    }
}
