using Microsoft.EntityFrameworkCore;
using ClientesApp.Models;

namespace ClientesApp.Data
{
    public class AgendaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public AgendaContext(DbContextOptions<AgendaContext> options)
            : base(options)
        {
        }
    }
}