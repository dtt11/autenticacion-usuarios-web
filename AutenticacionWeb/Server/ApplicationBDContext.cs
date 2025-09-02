using Microsoft.EntityFrameworkCore;
namespace AutenticacionWeb.Server
{
    public class ApplicationBDContext : IdentityDbContext 
    {
        public ApplicationBDContext(DbContextOptions<ApplicationBDContext> options) : base(options)
        {
        }
    }
}
