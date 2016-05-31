using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Chasoliveira.Core.Data.Contexts
{
    public class ChasoDBContext: DbContext, IDataContext
    {

        public ChasoDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
