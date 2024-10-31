using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plantae.Models;

namespace Plantae.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Plantae.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Plantae.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<Plantae.Models.Planta> Planta { get; set; } = default!;
        public DbSet<Plantae.Models.Venda> Venda { get; set; } = default!;
    }
}
