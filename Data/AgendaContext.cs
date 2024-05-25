using Microsoft.EntityFrameworkCore;
using ClientesApp.Models;  // Asegúrate de que esta línea esté presente

namespace ClientesApp.Data
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}