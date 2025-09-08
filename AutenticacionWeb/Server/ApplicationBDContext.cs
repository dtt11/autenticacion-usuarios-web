using AutenticacionWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace AutenticacionWeb.Server
{
    public class ApplicationBDContext : IdentityDbContext<Usuario>
    {
        public ApplicationBDContext(DbContextOptions<ApplicationBDContext> options) : base(options)
        {
        }
        /*
         Es un método especial en Entity Framework Core (EF Core) que se ejecuta cuando 
        el framework está construyendo el modelo de datos.
        El modelo de datos es la traducción de tus clases (DbContext y entidades) a 
        la estructura de la base de datos (tablas, relaciones, llaves primarias, etc.).
         
         */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1fcce683-9b14-4ff6-a4df-c0069ede227b",
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "a1" // puedes usar un string fijo cualquiera
                },
                new IdentityRole
                {
                    Id = "48b11774-156f-4f72-bdbe-d15c8ce77d5e",
                    Name = "vendedor",
                    NormalizedName = "VENDEDOR",
                    ConcurrencyStamp = "b1"
                },
                new IdentityRole
                {
                    Id = "916302fb-cbca-4f53-9944-2ca963126447",
                    Name = "cliente",
                    NormalizedName = "CLIENTE",
                    ConcurrencyStamp = "c1"
                }
            );
        }

    }
}
