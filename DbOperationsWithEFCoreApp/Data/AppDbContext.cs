using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{//AppDbContext inherite this class from the class DbContext to get properties like options
    public class AppDbContext:DbContext
    {//AppDbContext constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}
