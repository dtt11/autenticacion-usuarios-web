using AutenticacionWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace AutenticacionWeb.Server
{
    public class ApplicationBDContext : IdentityDbContext <Usuario>
    {
        public ApplicationBDContext(DbContextOptions<ApplicationBDContext> options) : base(options)
        {
        }
    }
}
