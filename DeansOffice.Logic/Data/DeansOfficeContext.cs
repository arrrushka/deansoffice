using DeansOffice.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DeansOffice.Logic.Data
{
    public class DeansOfficeContext : DbContext
    {


        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentRequest> Requests { get; set; }
        public DbSet<DocumentRequestField> RequestFields { get; set; }
        public DeansOfficeContext(DbContextOptions<DeansOfficeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=deans_db;UserName=postgres;Password=0728");
        }

    }
}
