using FrechettteZacharyTp4.Models;
using Microsoft.EntityFrameworkCore;

namespace FrechettteZacharyTp4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Abonnements> abonnements = new()
            {
            new(){ Id=1, Type="Regulier", PrixMensuel=0, RabaisPourcentage=0},
            new(){ Id=2, Type="Argent", PrixMensuel=50, RabaisPourcentage=10},
            new(){ Id=3, Type="Or", PrixMensuel=100, RabaisPourcentage=15}
            };
            modelBuilder.Entity<Abonnements>().HasData(abonnements);
        }

        public DbSet<Abonnements> Abonnements { get; set; }
        public DbSet<Clients> Clients { get; set; }
    }
}
