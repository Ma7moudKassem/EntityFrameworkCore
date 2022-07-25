namespace EntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)=> 
            options.UseSqlServer(@"Data Source=DESKTOP-FSH1TEE;database=EntityFrameworkDb;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BlogConfiguration());

            builder.Ignore<Post>();
            //builder.Entity<Post>().ToTable("Posts", e => e.ExcludeFromMigrations());
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
