using Microsoft.EntityFrameworkCore;
using stajProje.DAL.Entities;

namespace stajProje.DAL.Context
{
    public class stajProjeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C95HC1U\\SQLEXPRESS;initial Catalog=stajProjeDb;integrated Security=true;");
        }
        public DbSet<NoteInfo> NoteInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NoteInfo>()
                .HasKey(n => n.NoteID); // NoteID'yi birincil anahtar olarak tanımlıyoruz
        }

        
        public DbSet<user> users { get; set; }       
    }
}
