namespace EntityFramework.Data.EntitiesConfiguration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(e => e.Url)
                   .IsRequired()
                   .HasMaxLength(500);
        }
    }
}
