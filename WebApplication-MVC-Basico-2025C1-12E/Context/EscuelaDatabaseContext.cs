using Microsoft.EntityFrameworkCore;
using WebApplication_MVC_Basico_2025C1_12E.Models;

namespace WebApplication_MVC_Basico_2025C1_12E.Context
{
    public class EscuelaDatabaseContext : DbContext
    {
        public EscuelaDatabaseContext(DbContextOptions<EscuelaDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
