using Microsoft.EntityFrameworkCore;
using WebMap.Models.Entities;
namespace WebMap.Data

{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options): base(options) 
        { }
        public DbSet<School> SchoolDetails { get; set; }
    }
}
