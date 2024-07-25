using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{//AppDbContext inherite this class from the class DbContext to get properties like options
    public class AppDbContext:DbContext
    {//AppDbContext constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //To add data in a table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                  new Currency() { Id = 1, Title = "INR", Description = "Indian INR" },
                  new Currency() { Id = 2, Title = "Dollar", Description = "Dollar" },
                  new Currency() { Id = 3, Title = "Euro", Description = "Euro" },
                  new Currency() { Id = 4, Title = "Dinar", Description = "Dinar" }
                  );
            modelBuilder.Entity<Language>().HasData(
              new Language() { Id = 1, Title = "Hindi", Description = "Hindi" },
              new Language() { Id = 2, Title = "Tamil", Description = "Tamil" },
              new Language() { Id = 3, Title = "Punjabi", Description = "Punjabi" },
              new Language() { Id = 4, Title = "Urdu", Description = "Urdu" }
              );

        }

        //dbset: from entity framework ,Boo.k:class name ,Books:table Name 
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
    }
}
