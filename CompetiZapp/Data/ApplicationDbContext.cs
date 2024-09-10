using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompetiZapp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Competidor> Competidor { get; set;}
        public DbSet<Esporte> Esporte { get; set;}
        public DbSet<Campeonato> Campeonato { get; set;}
    }
}
