using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;
namespace WebApplication2.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext>options) : base(options)
        { }  

        public DbSet<Contato> Contatos { get; set; }
    }
}
