using Application.Models;
using Application.Models.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class AuthDbContext : IdentityDbContext<Responsable_Entreprise, IdentityRole, string>
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Offre> offres { get; set; }
        public DbSet<Domaine> domaine { get; set; }
        public DbSet<Tâche> Tâche { get; set; }
        public DbSet<TypeTâche> TypeTâche { get; set; }

        public DbSet<Employe> employe { get; set; }
        
    }
}
