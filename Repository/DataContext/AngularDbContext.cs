using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.DataContext
{
    public class AngularDataContext(DbContextOptions<AngularDataContext> options) : DbContext(options)
    {
        public DbSet<AngularUsers> AngularUsers { get; set; }

    }
}
