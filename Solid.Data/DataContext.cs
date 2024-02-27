using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using System.Formats.Asn1;
using System.Globalization;

namespace ManagingANewspaper
{
    public class DataContext:DbContext
    {
        public DbSet<Designer> Designers { get; set; }
        public  DbSet<Editor> Editors { get; set; }
        public  DbSet<Writer> Writers { get; set; }
        public DbSet<Article> Articles { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("server=(localdb)\\sqlServer;name=sample_db;");
             optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db"
);
            
        }

    }
}
